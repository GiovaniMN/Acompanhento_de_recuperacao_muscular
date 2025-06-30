using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using Xcel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms.DataVisualization.Charting;

namespace PjtSENSOR
{
    public partial class Form1 : Form
    {
        string RxString;
        int data;
        int x = 1;
        int tempo = 0;
        string porcen;
        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;
            chart1.Legends.Clear();
            //chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
        }

        #region Fecha form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar?", "Fechando o programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Atualiza portas
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;//flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (toolStripComboBox2.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (toolStripComboBox2.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;//retorna
            }
            //limpa comboBox
            toolStripComboBox2.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                toolStripComboBox2.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            toolStripComboBox2.SelectedIndex = 0;
        }
        #endregion

        #region Limpar btn
        private void limparBtn_Click(object sender, EventArgs e)
        {
            textBoxReceber.Text = "";
            dataGV.Enabled = true;
            for (int i = dataS.Tables[0].Rows.Count - 1; i >= 0; i--)
            {
                DataRow rmv = dataS.Tables["Dados"].Rows[i];//teste
                dataS.Tables[0].Rows.Remove(rmv);//teste
            }

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            x = 0;

            dataGV.Enabled = false;
        }
        #endregion

        #region Trata dados
        private void trataDadoRecebido(object sender, EventArgs e)
        {
            textBoxReceber.AppendText(RxString);
        }
        #endregion

        #region Botão conectar
        private void conectarBtn_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen == false)
            {
                try
                {
                    SerialPort.PortName = toolStripComboBox2.Items[toolStripComboBox2.SelectedIndex].ToString();
                    SerialPort.Open();
                }
                catch
                {
                    return;

                }
                if (SerialPort.IsOpen)
                {
                    conectarBtn.Text = "Desconectar";
                    toolStripComboBox2.Enabled = false;
                }
            }
            else
            {
                try
                {
                    SerialPort.Close();
                    toolStripComboBox2.Enabled = true;
                    conectarBtn.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }
        #endregion

        #region Dados Recebidos
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = SerialPort.ReadExisting();
            data = Convert.ToInt16(RxString);
            this.Invoke(new EventHandler(trataDadoRecebido));
        }
        #endregion

        #region Timer/grafico
        private void timerCOM_Tick(object sender, EventArgs e)
        {
            //textBoxReceber.AppendText(Convert.ToString(rnd.Next(1, 100)));
            atualizaListaCOMs();
            if (textBoxReceber.Text.Length > 0)
            {
                tempo = tempo + 1;
                dataGV.Enabled = true;
                DataRow novalinha = dataS.Tables["Dados"].NewRow();
                novalinha["Forc"] = textBoxReceber.Text.ToString();
                dataS.Tables[0].Rows.Add(novalinha);
                textBoxReceber.Clear();
                dataGV.Enabled = false;
            }
            else

            {
                textBoxReceber.Clear();
            }

            chart1.Update();
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 600;

            chart1.ChartAreas[0].AxisX.Title = "Tempo(m/s)";
            chart1.ChartAreas[0].AxisY.Title = "Força(%)";


            x = x + 1;
            //Convert.ToString(rnd.Next(1, 100))

                chart1.Series[0].Points.AddXY(x, data);


            //chart1.Series[0].Points.AddXY(x, Convert.ToString(rnd.Next(1, 100)));

            if (x > 600)
            {
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                x = 0;
            }
        }
        #endregion

        #region Fecha porta
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SerialPort.IsOpen == true)  // se porta aberta
                SerialPort.Close();            //fecha a porta
        }

        #endregion

        #region 3D
        private void Cb3d_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb3d.Checked)
            {
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }
        #endregion

        #region Exportar Excel
        private void excelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGV.Rows.Count > 0)
            {
                try
                {
                    Xcel.Application app = new Xcel.Application();
                    Xcel.Workbook pasta = app.Workbooks.Add();
                    Xcel.Worksheet plan;
                    plan = pasta.Worksheets.Add();
                    dataGV.Enabled = true;
                    plan.Name = "Exame";
                    int l = 4;
                    int l2 = 4;
                    plan.Range["C3"].Value = "Força do sensor";
                    plan.Range["B3"].Value = "Tempos(m/s)";
                    plan.Range["A1"].Value = "Nome do paciente: " + textBox_paciente.Text;
                    for (int i = 0; i < dataS.Tables["Dados"].Rows.Count; i++)
                    {
                        plan.Range["C" + Convert.ToString(l++)].Value = dataS.Tables["Dados"].Rows[i]["Forc"];
                        plan.Range["B" + Convert.ToString(l2++)].Value = Convert.ToString(x++);
                    }

                    dataGV.Enabled = false;
                    saveFileDialog.Filter = "Tabela Excel|*.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pasta.SaveAs(saveFileDialog.FileName);
                        pasta.Close();
                        app.Quit();
                    }
                }
                catch
                {
                    return;
                }
            }

        }
        #endregion

        #region Exportar grafico
        private void gráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Printing.PrintDocument.Print();
        }
        #endregion

        #region Creditos
        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<b>{ACOMPANHAMENTO DE RECUPERAÇÃO MUSCULAR}</b>\n\nProjeto desenvolvido na matéria 'Gestão da inovação'\n\nDocentes:\nRaquel Galhardo de Carvalho Lopes Araujo\nKelly Cristina Abou Arabi de Mendonça\n\nIntegrantes do grupo:\nCaue Silva Porto Rodrigues\nGiovani Martinho do Nascimento\nKauã Santos Silva\nKevin Bulgarelli Dossantos\nPedro Henrique Santos Silva\nRafael Luiz Forssell Ferrara Fomin");
        }
        #endregion
    }

}