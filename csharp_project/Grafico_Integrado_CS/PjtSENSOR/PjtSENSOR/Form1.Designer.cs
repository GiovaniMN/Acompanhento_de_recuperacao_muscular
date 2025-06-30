namespace PjtSENSOR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.limparBtn = new System.Windows.Forms.Button();
            this.conectarBtn = new System.Windows.Forms.Button();
            this.textBoxReceber = new System.Windows.Forms.TextBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.dadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSRC = new System.Windows.Forms.BindingSource(this.components);
            this.dataS = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.lbltxt = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStrp = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Cb3d = new System.Windows.Forms.CheckBox();
            this.forcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.textBox_paciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            //
            // SerialPort
            //
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            //
            // limparBtn
            //
            this.limparBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.limparBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.Location = new System.Drawing.Point(446, 577);
            this.limparBtn.Margin = new System.Windows.Forms.Padding(4);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(136, 43);
            this.limparBtn.TabIndex = 1;
            this.limparBtn.Text = "Limpar gráfico";
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            //
            // conectarBtn
            //
            this.conectarBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.conectarBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conectarBtn.Location = new System.Drawing.Point(605, 91);
            this.conectarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.conectarBtn.Name = "conectarBtn";
            this.conectarBtn.Size = new System.Drawing.Size(136, 43);
            this.conectarBtn.TabIndex = 0;
            this.conectarBtn.Text = "Conectar";
            this.conectarBtn.UseVisualStyleBackColor = true;
            this.conectarBtn.Click += new System.EventHandler(this.conectarBtn_Click);
            //
            // textBoxReceber
            //
            this.textBoxReceber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReceber.Enabled = false;
            this.textBoxReceber.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReceber.Location = new System.Drawing.Point(679, 370);
            this.textBoxReceber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReceber.Multiline = true;
            this.textBoxReceber.Name = "textBoxReceber";
            this.textBoxReceber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceber.Size = new System.Drawing.Size(94, 38);
            this.textBoxReceber.TabIndex = 2;
            //
            // timerCOM
            //
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            //
            // dadosBindingSource
            //
            this.dadosBindingSource.DataMember = "Dados";
            this.dadosBindingSource.DataSource = this.bindingSRC;
            //
            // bindingSRC
            //
            this.bindingSRC.DataSource = this.dataS;
            this.bindingSRC.Position = 0;
            //
            // dataS
            //
            this.dataS.DataSetName = "NewDataSet";
            this.dataS.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            //
            // dataTable1
            //
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.dataTable1.TableName = "Dados";
            //
            // dataColumn1
            //
            this.dataColumn1.ColumnName = "Forc";
            //
            // lbltxt
            //
            this.lbltxt.AutoSize = true;
            this.lbltxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt.ForeColor = System.Drawing.Color.Black;
            this.lbltxt.Location = new System.Drawing.Point(647, 335);
            this.lbltxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(151, 20);
            this.lbltxt.TabIndex = 6;
            this.lbltxt.Text = "Dados da força";
            //
            // menuStrip1
            //
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStrp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(888, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            //
            // mnuStrp
            //
            this.mnuStrp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.textoToolStripMenuItem,
            this.créditosToolStripMenuItem});
            this.mnuStrp.Name = "mnuStrp";
            this.mnuStrp.Size = new System.Drawing.Size(73, 24);
            this.mnuStrp.Text = "Opções";
            //
            // excelToolStripMenuItem
            //
            this.excelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem1,
            this.gráficoToolStripMenuItem});
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.excelToolStripMenuItem.Text = "Exportar";
            //
            // excelToolStripMenuItem1
            //
            this.excelToolStripMenuItem1.Name = "excelToolStripMenuItem1";
            this.excelToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.excelToolStripMenuItem1.Text = "Excel";
            this.excelToolStripMenuItem1.Click += new System.EventHandler(this.excelToolStripMenuItem1_Click);
            //
            // gráficoToolStripMenuItem
            //
            this.gráficoToolStripMenuItem.Name = "gráficoToolStripMenuItem";
            this.gráficoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gráficoToolStripMenuItem.Text = "Gráfico";
            this.gráficoToolStripMenuItem.Click += new System.EventHandler(this.gráficoToolStripMenuItem_Click);
            //
            // textoToolStripMenuItem
            //
            this.textoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.textoToolStripMenuItem.Text = "Porta";
            //
            // chart1
            //
            this.chart1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F);
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Verdana", 8.25F);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F);
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Verdana", 8.25F);
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Gráfico de força";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(119, 188);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(502, 391);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Gráfico de força";
            this.chart1.Titles.Add(title1);
            //
            // Cb3d
            //
            this.Cb3d.AutoSize = true;
            this.Cb3d.Location = new System.Drawing.Point(158, 577);
            this.Cb3d.Margin = new System.Windows.Forms.Padding(4);
            this.Cb3d.Name = "Cb3d";
            this.Cb3d.Size = new System.Drawing.Size(121, 20);
            this.Cb3d.TabIndex = 9;
            this.Cb3d.Text = "Abrir gráfico 3D";
            this.Cb3d.UseVisualStyleBackColor = true;
            this.Cb3d.CheckedChanged += new System.EventHandler(this.Cb3d_CheckedChanged);
            //
            // forcDataGridViewTextBoxColumn
            //
            this.forcDataGridViewTextBoxColumn.DataPropertyName = "Forc";
            this.forcDataGridViewTextBoxColumn.HeaderText = "Forc";
            this.forcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.forcDataGridViewTextBoxColumn.Name = "forcDataGridViewTextBoxColumn";
            this.forcDataGridViewTextBoxColumn.Width = 125;
            //
            // dataGV
            //
            this.dataGV.AutoGenerateColumns = false;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.forcDataGridViewTextBoxColumn});
            this.dataGV.DataSource = this.dadosBindingSource;
            this.dataGV.Location = new System.Drawing.Point(421, 867);
            this.dataGV.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV.Name = "dataGV";
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGV.Size = new System.Drawing.Size(182, 47);
            this.dataGV.TabIndex = 4;
            //
            // textBox_paciente
            //
            this.textBox_paciente.Location = new System.Drawing.Point(294, 103);
            this.textBox_paciente.Name = "textBox_paciente";
            this.textBox_paciente.Size = new System.Drawing.Size(277, 22);
            this.textBox_paciente.TabIndex = 10;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome do paciente:";
            //
            // toolStripComboBox2
            //
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            //
            // créditosToolStripMenuItem
            //
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.créditosToolStripMenuItem.Text = "Créditos";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(888, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_paciente);
            this.Controls.Add(this.Cb3d);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.textBoxReceber);
            this.Controls.Add(this.conectarBtn);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicação do sensor de força";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button conectarBtn;
        private System.Windows.Forms.TextBox textBoxReceber;
        private System.Windows.Forms.Timer timerCOM;
        private System.Windows.Forms.BindingSource dadosBindingSource;
        private System.Windows.Forms.BindingSource bindingSRC;
        private System.Data.DataSet dataS;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStrp;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox Cb3d;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn forcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.TextBox textBox_paciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gráficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
    }
}
