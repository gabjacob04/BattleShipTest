using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class Form1 : Form
    {//Équipe Gabriel Jacob, Thomas Toulouse et Jean-Nicolas Paquet
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ptbTirsJoueur_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptbTirsAdverses_Paint(object sender, PaintEventArgs e)
        {
            int tailleX = 50;
            int tailleY = 50;
            int positionX = 0;
            int positionY = 0;
            int nbCase = 8;
            Pen pen = new Pen(Color.Black);

            Bitmap exempleBitmap = new Bitmap(tailleX, tailleY);
            using (Graphics graphic = Graphics.FromImage(exempleBitmap))
            {
                for (int DimensionX = 0; DimensionX < nbCase; DimensionX++)
                {
                    for (int DImensionY = 0; DImensionY < nbCase; DImensionY++)
                    {
                        if (positionX== 400)
                        {
                            positionY = positionY + 50;
                            if (positionX == 400)
                            {
                                positionX = 0;
                            }
                        }
                        e.Graphics.FillRectangle(Brushes.Blue, new Rectangle(positionX, positionY, tailleX, tailleY));
                        positionX = positionX + 50;



                    }
                }
            }
        }
    }
}
