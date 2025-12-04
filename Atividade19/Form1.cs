using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade19
{
    // A classe Form1 foi mantida como a primeira no namespace.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método refatorado para demonstrar o Polimorfismo
        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("## Demonstração de Polimorfismo (Vetores) ##");
            sb.AppendLine("--------------------------------------------------");

            // 1. Criação das instâncias
            Cachorro rex = new Cachorro { Nome = "Rex" };
            Gato mia = new Gato { Nome = "Mia" };
            Animal desconhecido = new Animal { Nome = "Pássaro" }; // Animal base

            // 2. Criação do vetor (Array) de Animal
            // Este vetor pode armazenar qualquer objeto que herde de Animal.
            Animal[] fazenda = new Animal[] { rex, mia, desconhecido };

            sb.AppendLine("Iterando sobre o vetor de animais:");
            sb.AppendLine("");

            // 3. Percorre o vetor e chama EmitirSom()
            // Em cada iteração, mesmo que o tipo da variável seja Animal,
            // o C# (em tempo de execução) chama a implementação (override) correta.
            foreach (Animal animal in fazenda)
            {
                // Polimorfismo em Ação:
                // O método EmitirSom() correto é determinado pelo tipo real do objeto
                // (Cachorro, Gato ou Animal) e não pelo tipo da referência (Animal).
                string acao = animal.EmitirSom();

                sb.AppendLine($"Animal: {animal.Nome}");
                sb.AppendLine($"Ação: {acao}");
                sb.AppendLine($"Tipo Real: {animal.GetType().Name}");
                sb.AppendLine("---");
            }

            sb.AppendLine("--------------------------------------------------");

            // Exibe a mensagem de forma amigável
            MessageBox.Show(sb.ToString(), "Polimorfismo (Herança e Sobrescrita)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // --- CLASSE BASE: Animal (virtual) ---
    public class Animal
    {
        public string Nome { get; set; }

        public virtual string EmitirSom()
        {
            return "Fazendo algum som genérico...";
        }
    }

    // --- CLASSE DERIVADA: Cachorro (override) ---
    public class Cachorro : Animal
    {
        public override string EmitirSom()
        {
            return "Latindo...";
        }
    }

    // --- CLASSE DERIVADA: Gato (override) ---
    public class Gato : Animal
    {
        public override string EmitirSom()
        {
            return "Miando...";
        }
    }
}