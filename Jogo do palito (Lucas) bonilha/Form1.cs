using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_do_palito__Lucas__bonilha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            quantidadedepalitos++;
            InitializeComponent();
            CenterToScreen();

        }

        int quantidadedepalitos = 0;
        
        private void visibles()
        {
            quantidadedepalitos = 0;
            labelretirar.Visible = true;
            mskdretirar.Visible = true;
            btnretirar.Visible = true;
        }
        private void enable()
        {
            labelquantidade.Enabled = false;
            nudquantidade.Enabled = false;
            btnjogar.Enabled = false;
        }
        private void jogadadobot()
        {

            quantidadedepalitos = (int)nudquantidade.Value;

            mskdretirar.Focus();
            int palitosbot = new Random().Next(1 , 3);
           //(lógica - parte1)
           
            if (quantidadedepalitos % 2 == 0)
            {
                palitosbot = 1;
                //quantidadedepalitos -= palitosbot;
            }
            if (quantidadedepalitos == 20)
            {
                palitosbot = 3;
            }
            if(quantidadedepalitos == 24)
            {
                palitosbot = 3;
            }
            if(quantidadedepalitos == 25)
            {
                palitosbot = 1;
            }
            if(quantidadedepalitos == 28)
            {
                palitosbot = 3;
            }
            if(quantidadedepalitos == 29)
            {
                palitosbot = 3;
            }
            quantidadedepalitos -= palitosbot;
                richTextBoxjogo.AppendText("Eu começo !" + Environment.NewLine);
                richTextBoxjogo.AppendText("Retirei " + palitosbot + " palito(s)" + Environment.NewLine);
                richTextBoxjogo.AppendText("Sobraram " + quantidadedepalitos + " palito(s)" + Environment.NewLine + Environment.NewLine);
                richTextBoxjogo.AppendText("Sua vez..." + Environment.NewLine + Environment.NewLine);
                mskdretirar.Focus();
        }
        private void fimmdejogo()
        {
            labelretirar.Visible = false;
            mskdretirar.Visible = false;
            btnretirar.Visible = false;
            ////
            labelquantidade.Enabled = true;
            nudquantidade.Enabled = true;
            btnjogar.Enabled = true;
            richTextBoxjogo.Clear();
        }
        private void Jogo()
        {
            if (string.IsNullOrEmpty(mskdretirar.Text))
            {
                MessageBox.Show("Preencha o campo", "Atenção");
                return;
            }

            int palitosplayer1 = int.Parse(mskdretirar.Text);

            if (palitosplayer1 < 1 || palitosplayer1 > 3)
            {
                MessageBox.Show("Só e possivel retirar de 1 a 3 palitos ", "Atenção");
                return;
            }
            else if (palitosplayer1 > quantidadedepalitos)
            {
                MessageBox.Show("Digite um valor válido", "Atenção");
                return;
            }
            else
            {

                quantidadedepalitos = quantidadedepalitos - palitosplayer1;

                richTextBoxjogo.AppendText("Você retirou " + palitosplayer1 + " palito(s)" + Environment.NewLine);
                richTextBoxjogo.AppendText("Sobraram " + quantidadedepalitos + " palito(s)" + Environment.NewLine + Environment.NewLine);
                mskdretirar.Focus();
                richTextBoxjogo.Focus();
            }
           

            if (quantidadedepalitos == 0)
            {
                MessageBox.Show("Você perdeu", "Muito fácil");

                if (MessageBox.Show("Gostaria de Jogar Novamente ?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    quantidadedepalitos = 0;
                    fimmdejogo();
                }
                else
                {
                    Close();
                }

                return;
            }

            //(lógica - parte 2)
            int jogadabot = 3;

            int resto = quantidadedepalitos % 4;

            if (resto != 0 && resto != 1)
            {
                jogadabot = resto - 1;
            }
            if(quantidadedepalitos == 25 || palitosplayer1 == 3)
            {
                jogadabot = 2;
            }
            //

            quantidadedepalitos = quantidadedepalitos - jogadabot;

            richTextBoxjogo.AppendText("Minha vez..." + Environment.NewLine);
            richTextBoxjogo.AppendText("Retirei " + jogadabot + " palito(s)" + Environment.NewLine);
            richTextBoxjogo.AppendText("Sobraram " + quantidadedepalitos + " palito(s)" + Environment.NewLine + Environment.NewLine);
            richTextBoxjogo.AppendText("Sua vez..." + Environment.NewLine);
            mskdretirar.Focus();

           


            if (quantidadedepalitos <= 0)
            {
                MessageBox.Show(" Como você conseguiu ganhar?", "Meu Deus");


                if (MessageBox.Show("Gostaria de Jogar Novamente ?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    quantidadedepalitos = 0;
                    fimmdejogo();
                }
                else
                {
                    Close();
                }

                return;
            }
            mskdretirar.Clear();

        
        }
     
    
        private void btnjogar_Click(object sender, EventArgs e)
        {
            try
            {
                visibles();
                enable();
                jogadadobot();
            }

            catch
            {
                MessageBox.Show("Digite um valor válido", "Atenção");
            }
        }

        private void btnretirar_Click(object sender, EventArgs e)
        {
            try
            {
                Jogo();
            }
            catch
            {
            MessageBox.Show("Informe um valor válido", "Atenção");
            }
        }
        

        private void richTextBoxjogo_TextChanged(object sender, EventArgs e)
        {
            richTextBoxjogo.ScrollToCaret();
        }

       
    }
    
}



    

