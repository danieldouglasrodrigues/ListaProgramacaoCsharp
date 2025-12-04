using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("## Demonstração de Herança (Animal) ##");
            sb.AppendLine("--------------------------------------------------");

            Cachorro cachorro = new Cachorro { Nome = "Rex" };
            Gato gato = new Gato { Nome = "Mia" };

            sb.AppendLine($"Animal: {cachorro.Nome}");
            sb.AppendLine($"Tipo: Cachorro");
            sb.AppendLine($"Ação: {cachorro.EmitirSom()}"); 
            sb.AppendLine("");

            sb.AppendLine($"Animal: {gato.Nome}");
            sb.AppendLine($"Tipo: Gato");
            sb.AppendLine($"Ação: {gato.EmitirSom()}"); 
            sb.AppendLine("");

            Animal animalDesconhecido = new Animal { Nome = "Desconhecido" };
            sb.AppendLine($"Animal: {animalDesconhecido.Nome}");
            sb.AppendLine($"Tipo: Base Animal");
            sb.AppendLine($"Ação: {animalDesconhecido.EmitirSom()}"); 

            sb.AppendLine("--------------------------------------------------");

            MessageBox.Show(sb.ToString(), "Herança de Classes (Cachorro e Gato)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class Animal
    {
        public string Nome { get; set; }

        public virtual string EmitirSom()
        {
            return "Fazendo algum som genérico...";
        }
    }

    public class Cachorro : Animal
    {
        public override string EmitirSom()
        {
            return "Latindo...";
        }
    }

    public class Gato : Animal
    {
        public override string EmitirSom()
        {
            return "Miando...";
        }
    }
}