using System;
using System.Windows;
using System.Linq;

namespace todosEjercicios.Cap8
{
    public partial class ejer5 : Window
    {
        public ejer5()
        {
            InitializeComponent();
        }

        /*
            5 Hacer un programa que le solicite al usuario dos
            cadenas y luego las muestre en orden alfabético.
        */
        public bool Validar()
        {
            bool paso = false;
            if(string.IsNullOrWhiteSpace(TextBoxPrimeraCadena.Text))
                MessageBox.Show("Digita la primera cadena");
            else if(string.IsNullOrWhiteSpace(TextBoxSegundaCadena.Text))
                MessageBox.Show("Digita la segunda cadena");
            else 
                paso = true;
            return paso;
        }

        public void Limpiar()
        {
            TextBoxPrimeraCadena.Text = "";
            TextBoxSegundaCadena.Text = "";
            TextBoxPrimeraCadenaResultado.Text = "";
            TextBoxSegundaCadenaResultado.Text = "";
        }

        public void Click_btnOrdenar(object sender, RoutedEventArgs e)
        {
            if(!Validar())
               return;

            TextBoxPrimeraCadenaResultado.Text = new String(TextBoxPrimeraCadena.Text.OrderBy(p => p).ToArray());
            TextBoxSegundaCadenaResultado.Text = new String(TextBoxSegundaCadena.Text.OrderBy(s => s).ToArray());
        }

        public void Click_btnLimpiar(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
    }
}