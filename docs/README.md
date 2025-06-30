# Projeto Sensor com Gráfico em C#

Este projeto consiste em um sistema que lê dados de um sensor utilizando um Arduino e exibe esses dados em um gráfico em tempo real através de uma aplicação C#.

## Visão Geral

O sistema é composto por duas partes principais:

1.  **Código Arduino (`arduino_code`):** Responsável por ler o valor de um sensor analógico (conectado à porta A0), converter esse valor para uma escala de 0 a 100 e enviá-lo pela porta serial.
2.  **Aplicação C# (`csharp_project`):** Uma aplicação Windows Forms que se conecta à porta serial para receber os dados enviados pelo Arduino e exibe esses dados em um gráfico.

## Estrutura de Arquivos

```
.
├── arduino_code/
│   └── codigo_arduino.ino       # Código fonte para o Arduino
├── csharp_project/
│   └── Grafico_Integrado_CS/    # Contém o projeto C# (solução e arquivos)
│       ├── PjtSENSOR/           # Diretório principal do projeto C#
│       │   ├── PjtSENSOR.sln    # Arquivo da solução Visual Studio
│       │   ├── PjtSENSOR/       # Arquivos do projeto (formulários, código C#)
│       │   └── ...              # Outros arquivos e pastas do projeto C#
│       └── ...
├── docs/
│   └── README.md                # Esta documentação
└── Grafico_Integrado.rar        # Arquivo .rar original (mantido para referência)
```

## Código Arduino

O arquivo `arduino_code/codigo_arduino.ino` contém o sketch para o Arduino.

**Funcionalidade:**

*   Inicializa a comunicação serial a 9600 bps.
*   No loop principal:
    *   Lê o valor analógico da porta A0 (espera-se um sensor conectado aqui).
    *   Converte o valor lido (que varia de 0 a 1023) para uma porcentagem (0 a 100).
    *   Garante que o valor não seja menor que 0.
    *   Envia o valor percentual pela porta serial.
    *   Aguarda 100 milissegundos antes da próxima leitura.

**Como Compilar e Carregar:**

1.  Abra o arquivo `codigo_arduino.ino` na IDE do Arduino.
2.  Conecte o seu Arduino ao computador.
3.  Selecione a placa e a porta corretas no menu "Ferramentas" da IDE.
4.  Clique no botão "Carregar" (Upload) para compilar e enviar o código para o Arduino.

## Aplicação C#

O projeto C# está localizado em `csharp_project/Grafico_Integrado_CS/`. A solução principal é `PjtSENSOR.sln`.

**Funcionalidade:**

*   A aplicação Windows Forms (provavelmente `Form1.cs` dentro da pasta `PjtSENSOR/PjtSENSOR/`) é responsável por:
    *   Estabelecer a comunicação com a porta serial à qual o Arduino está conectado.
    *   Ler os dados numéricos enviados pelo Arduino.
    *   Atualizar um componente de gráfico em tempo real para visualizar os dados do sensor.

**Como Executar (Ambiente de Desenvolvimento):**

1.  Abra o arquivo `PjtSENSOR.sln` com o Visual Studio.
2.  Certifique-se de que o Arduino esteja conectado e enviando dados pela porta serial.
3.  Na aplicação C#, provavelmente haverá uma opção para selecionar a porta COM correta e iniciar a conexão.
4.  Compile e execute o projeto a partir do Visual Studio (geralmente pressionando F5).
5.  O gráfico deverá começar a exibir os dados recebidos do sensor.

**Observações:**

*   O projeto C# parece ter sido desenvolvido em uma versão mais antiga do Visual Studio (referências a `.v12.suo`). Pode ser necessário atualizar o projeto se estiver usando uma versão mais recente do Visual Studio.
*   O código Arduino possui seções comentadas (`/*#include <MySQL_Connection.h> ... */`) que sugerem uma intenção anterior de integrar com um banco de dados MySQL. Esta funcionalidade não está ativa no código fornecido.
*   O arquivo `.rar` original (`Grafico_Integrado.rar`) foi mantido na raiz do projeto para referência, mas o seu conteúdo já foi extraído e organizado.

## Hardware Necessário

*   Placa Arduino (Uno, Nano, etc.)
*   Sensor analógico (ex: potenciômetro, sensor de luz LDR, sensor de temperatura LM35, etc.) conectado à porta A0 do Arduino.
*   Cabos de conexão.

## Fluxo de Dados

1.  O sensor analógico envia um sinal de tensão para a porta A0 do Arduino.
2.  O Arduino lê este sinal, converte-o para um valor entre 0-1023.
3.  O Arduino mapeia este valor para uma escala de 0-100.
4.  O valor processado (0-100) é enviado via comunicação serial para o computador.
5.  A aplicação C# no computador lê os dados da porta serial.
6.  A aplicação C# atualiza o gráfico com os novos dados recebidos.
```
