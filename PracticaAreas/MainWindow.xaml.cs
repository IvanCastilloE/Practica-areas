using System;
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

namespace PracticaAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void botonRectangulo_Click(object sender, RoutedEventArgs e)
        {
            /*float area = float.Parse(alturaRectangulo.Text) * float.Parse(baseRectangulo.Text);
            areaRectangulo.Text = area.ToString() + " m";*/
        }

        private void botonTriangulo_Click(object sender, RoutedEventArgs e)
        {
            /*float area = float.Parse(alturaTriangulo.Text) * float.Parse(baseTriangulo.Text) / 2;
            areaTriangulo.Text = area.ToString() + " m";*/
        }

        private void botonCirculo_Click(object sender, RoutedEventArgs e)
        {
            /*float pi = Convert.ToSingle(Math.PI);
            float area = float.Parse(radio.Text) * float.Parse(radio.Text) * pi;
            areaCirculo.Text = area.ToString() + " m";*/
        }

        private void botonTrapecio_Click(object sender, RoutedEventArgs e)
        {
            /*
            float area = (float.Parse(baseMayor.Text) + float.Parse(BaseMenor.Text)) 
                * float.Parse(alturaTrapecio.Text) / 2;
            areaTrapecio.Text = area.ToString()+" m";*/
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelConfiguracion.Children.Clear();
            switch (cbTipoFigura.SelectedIndex)
            {
                //rectangulo
                case 0:
                    panelConfiguracion.Children.Add(new ControlAreaRectangulo());
                    break;
                //triangulo
                case 1:
                    panelConfiguracion.Children.Add(new ControlAreaTriangulo());
                    break;
                //circulo
                case 2:
                    panelConfiguracion.Children.Add(new ControlAreaCirculo());
                    break;
                //trapecio
                case 3:
                    panelConfiguracion.Children.Add(new ControlAreaTrapecio());
                    break;
                //nada
                default:
                    break;

            }
        }
        private void botonClick_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            switch (cbTipoFigura.SelectedIndex)
            {
                //rectangulo
                case 0:
                    break;
                //triangulo
                case 1:
                    break;
                //circulo
                case 2:
                    break;
                //trapecio
                case 3:
                    break;
                //nada
                default:
                    break;
            }
            lblResultadoArea.Text = area.ToString();
        }
    }
}
