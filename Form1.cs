using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ini, fim;

            ini = int.Parse(txtNumIni.Text);
            fim = int.Parse(txtNumFim.Text);
            
            // No C# tem-se a classe Random que é uma classe que trabalha com números aleatórios.
            // Contudo, precisa-se criar um objeto "váriavel" do tipo Random.
            Random rd = new Random();

            //Criado o objeto do tipo Random, eu tenho acesso aos métodos ou funções para
            // trabalhar com números aletórios.
            int aleatorio = rd.Next(ini, fim);

            MessageBox.Show("Sorteado o nº " + aleatorio);
          

        }
    }
}
