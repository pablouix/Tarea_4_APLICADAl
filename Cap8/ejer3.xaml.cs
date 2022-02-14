


using System;
using System.Windows;

namespace todosEjercicios.Cap8
{
    public partial class ejer3 : Window
    {
        public ejer3()
        {
            InitializeComponent();
        }

        /*
            3 Hacer un programa que muestre la hora del día en 
            formato AM/PM seguida del año, el día y el mes actual.  
        */

        public void Click_btnMostrar(object sender, RoutedEventArgs e)
        {
            TextBoxFechaAcual.Text = DateTime.Now.ToString("hh:mm tt yyyy/dd/MM ").ToUpper();
        }
    }
}