using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BattleShip
{
    class Plateau
    {
        int tailleX;
        int tailleY;
        bool ordinateur;
        int tailleCaseX;
        int tailleCaseY;
        Bitmap dessiner;

        public int TailleCaseX { get => tailleCaseX; set => tailleCaseX = value; }
        public int TailleCaseY { get => tailleCaseY; set => tailleCaseY = value; }
    }
}
