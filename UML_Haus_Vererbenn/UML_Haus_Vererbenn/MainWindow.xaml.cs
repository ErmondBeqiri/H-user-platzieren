using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UML_Haus_Vererbenn
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Flachdach flachdach;
        private Hochhaus hochHaus;
        private int x = 1;

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (x == 1)
            {
                flachdach = new Flachdach();
                Point point = new Point();
                point = Mouse.GetPosition(MainCanvas);
                flachdach.Posx = point.X;
                flachdach.Posy = point.Y;
                flachdach.Zeichnen();
                MainCanvas.Children.Add(flachdach.Rectangle);
                x = 0;



            }
            else if (x == 0)
            {
                hochHaus = new Hochhaus();
                Point point = new Point();
                point = Mouse.GetPosition(MainCanvas);
                hochHaus.Posx = point.X;
                hochHaus.Posy = point.Y;
                hochHaus.Zeichnen();
                MainCanvas.Children.Add(hochHaus.Rectangle);
                x = 1;



            }
        }
    }
}