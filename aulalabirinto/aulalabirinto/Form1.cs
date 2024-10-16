using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace aulalabirinto
{
    public partial class labirinto : Form
    {
        public labirinto()
        {
            InitializeComponent();
        }
        #region variaveis globais
        static string[,] llabirinto = new string[24, 32] 
        {
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","0","0","1","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","0","0","1","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","0","1","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"0","0","0","1","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","0","1","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","0","1","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","0","1","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","0","1","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
        };
        int posLinha=0, posColuna=12 ;
        string controle;
        #endregion

        private void labirinto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja sair?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void labirinto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString().ToUpper()=="W" || e.KeyChar.ToString().ToUpper() == "A" || e.KeyChar.ToString().ToUpper() == "S" || e.KeyChar.ToString().ToUpper() == "D")
            {
                controle = e.KeyChar.ToString().ToUpper();
            }
            else
            {
                e.KeyChar=Convert.ToChar(0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x=pbx_avatar.Location.X;
            int y=pbx_avatar.Location.Y;

            if((x==700) && (y == 472))
            {
                MessageBox.Show("Chegou na saida");
            }
            else if (controle == "W")
            {
                pbx_avatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\sobe.png");
                pbx_avatar.Size = new Size(40, 49);

                if (posLinha == 0) return;

                if (llabirinto[posLinha - 1, posColuna] == "1")
                {
                    pbx_avatar.Location = new Point(x, y - 15);
                    posLinha--;
                }
            }

            else if (controle == "A")
            {
                pbx_avatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\esquerda.png");
                pbx_avatar.Size = new Size(40, 49);

                if (posColuna == 0) return;

                if (llabirinto[posLinha, posColuna - 1] == "1")
                {
                    pbx_avatar.Location = new Point(x - 15, y);
                    posColuna--;
                }
            }

            else if(controle == "S")
            {
                pbx_avatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\desce.png");
                pbx_avatar.Size = new Size(40, 49);

                if(posLinha == 23) return;

                if(llabirinto[posLinha +1, posColuna] == "1")
                {
                    pbx_avatar.Location = new Point(x, y + 15);
                    posLinha++;
                }
            }

            else if(controle == "D")
            {
                pbx_avatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\direita.png");
                pbx_avatar.Size = new Size(40, 49);

                if(posColuna == 31) return;

                if (llabirinto[posLinha, posColuna + 1] == "1")
                {
                    pbx_avatar.Location = new Point(x + 15, y);
                    posColuna++;
                }
            }
        }

        private void labirinto_Load(object sender, EventArgs e)
        {
            
        }
    }
}
