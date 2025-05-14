using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace UML_Haus_Vererbenn
{

    public class Haus
    {
        protected double posx = 200;
        protected double posy = 100;
        protected Rectangle rectangle;

        public Haus()
        {
            rectangle = new Rectangle(); // Initialisiere das shape-Objekt

            rectangle.Height = 20;
            rectangle.Width = 20;
            rectangle.Fill = Brushes.Black;
        }

        public double Posx  // Immer Pascal case
        {
            get { return posx; }  // immer camel case
            set { posx = value; }


        }

        public double Posy
        {
            get { return posy; }
            set { posy = value; }
        }
        public Rectangle Rectangle
        {
            get { return rectangle;}
            set { rectangle = value; }
        }

        public void Zeichnen()
        {
            Canvas.SetLeft(rectangle, Posx);
            Canvas.SetTop(rectangle, Posy);
        }
    }
}