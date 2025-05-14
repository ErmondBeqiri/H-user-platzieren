using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace UML_Haus_Vererbenn
{
    internal class Hochhaus : Haus
    {
        public Hochhaus()
        {

            rectangle.Height = 70;
            rectangle.Fill = new SolidColorBrush(Color.FromRgb(111, 0, 111));


        }

        }
    }
