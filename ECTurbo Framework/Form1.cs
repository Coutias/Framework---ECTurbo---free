using ECTurbo_Framework.Codigos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ECTurbo_Framework
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false)
            {

                Funcoes.CriarLabel(checkBox1, "Por favor, marque essa opção", "info");
                Funcoes.CriarLabel(ecTurbo_Datas1, "xxx");

            }

        }
    }

}
