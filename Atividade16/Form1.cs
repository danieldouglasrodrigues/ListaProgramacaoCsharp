using System;
using System.Windows.Forms;
using Microsoft.VisualBasic; 

namespace Atividade16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SimularCaixaEletronico();

            MessageBox.Show("Sessão do Caixa Eletrônico Encerrada.", "Fim da Simulação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SimularCaixaEletronico()
        {
            double saldo = 1000.00;
            bool rodando = true;

            string menu = "## Caixa Eletrônico (ATM) ##\n\n" +
                          "Selecione uma opção:\n" +
                          "1. Sacar\n" +
                          "2. Depositar\n" +
                          "3. Consultar Saldo\n" +
                          "4. Sair";

            while (rodando)
            {
                string entradaOpcao = Interaction.InputBox(
                    menu,
                    "Menu Principal",
                    "3" 
                );

                int opcao;

                if (string.IsNullOrEmpty(entradaOpcao))
                {
                    opcao = 4;
                }
                else if (!int.TryParse(entradaOpcao, out opcao))
                {
                    MessageBox.Show("Opção inválida. Por favor, digite um número de 1 a 4.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue; 
                }

                switch (opcao)
                {
                    case 1: 
                        ProcessarSaque(ref saldo);
                        break;

                    case 2: 
                        ProcessarDeposito(ref saldo);
                        break;

                    case 3: 
                        MessageBox.Show($"Seu saldo atual é de R$ {saldo:F2}", "Consulta de Saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case 4: 
                        rodando = false;
                        break;

                    default:
                        MessageBox.Show("Opção não reconhecida. Por favor, escolha 1, 2, 3 ou 4.", "Opção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }

        private void ProcessarSaque(ref double saldo)
        {
            string entradaValor = Interaction.InputBox(
                "Digite o valor para saque:",
                "Operação de Saque",
                "0.00"
            );

            if (string.IsNullOrEmpty(entradaValor)) return;

            if (double.TryParse(entradaValor.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double valorSaque) && valorSaque > 0)
            {
                if (valorSaque > saldo)
                {
                    MessageBox.Show($"Saldo insuficiente. Saldo atual: R$ {saldo:F2}", "Erro no Saque", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    saldo -= valorSaque;
                    MessageBox.Show($"Saque de R$ {valorSaque:F2} realizado com sucesso.\nNovo saldo: R$ {saldo:F2}", "Saque Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Valor de saque inválido. Digite um valor numérico positivo.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessarDeposito(ref double saldo)
        {
            string entradaValor = Interaction.InputBox(
                "Digite o valor para depósito:",
                "Operação de Depósito",
                "0.00"
            );

            if (string.IsNullOrEmpty(entradaValor)) return;

            if (double.TryParse(entradaValor.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double valorDeposito) && valorDeposito > 0)
            {
                saldo += valorDeposito;
                MessageBox.Show($"Depósito de R$ {valorDeposito:F2} realizado com sucesso.\nNovo saldo: R$ {saldo:F2}", "Depósito Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Valor de depósito inválido. Digite um valor numérico positivo.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}