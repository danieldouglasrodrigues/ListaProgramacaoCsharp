using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic; 

namespace Atividade14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double peso = 0;
            double altura = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                string entradaPeso = Interaction.InputBox(
                    "Digite o seu peso (em quilogramas, ex: 75.5):",
                    "Entrada de Peso",
                    "70.0"
                );

                if (string.IsNullOrEmpty(entradaPeso))
                {
                    MessageBox.Show("Operação cancelada. Não é possível calcular o IMC sem o peso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (double.TryParse(entradaPeso.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out peso) && peso > 0)
                {
                    entradaValida = true;
                }
                else
                {
                    MessageBox.Show("Peso inválido. Digite um valor numérico positivo.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            entradaValida = false; 

            while (!entradaValida)
            {
                string entradaAltura = Interaction.InputBox(
                    "Digite a sua altura (em metros, ex: 1.75):",
                    "Entrada de Altura",
                    "1.70"
                );

                if (string.IsNullOrEmpty(entradaAltura))
                {
                    MessageBox.Show("Operação cancelada. Não é possível calcular o IMC sem a altura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (double.TryParse(entradaAltura.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out altura) && altura > 0 && altura <= 3.0)
                {
                    entradaValida = true;
                }
                else
                {
                    MessageBox.Show("Altura inválida. Digite um valor numérico positivo em metros.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            double imc = peso / (altura * altura);

            string classificacao;

            if (imc < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 24.9) 
            {
                classificacao = "Peso normal";
            }
            else if (imc >= 25.0 && imc <= 29.9) 
            {
                classificacao = "Sobrepeso";
            }
            else 
            {
                classificacao = "Obesidade";
            }

            string mensagem = "## Cálculo do Índice de Massa Corporal (IMC) ##\n\n";
            mensagem += $"Peso Informado: {peso:F2} kg\n";
            mensagem += $"Altura Informada: {altura:F2} m\n\n";
            mensagem += "-----------------------------------------\n";
            mensagem += $"Valor do IMC: {imc:F2}\n"; 
            mensagem += $"Classificação: {classificacao}";
            mensagem += "\n-----------------------------------------";

            MessageBox.Show(mensagem, "Resultado do IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}