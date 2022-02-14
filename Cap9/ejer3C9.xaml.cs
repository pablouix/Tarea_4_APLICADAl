using System;
using System.Windows;
using System.Linq;

namespace todosEjercicios.Cap9
{
    public partial class ejer3C9 : Window
    {
        public ejer3C9()
        {
            InitializeComponent();
        }

        /*
            3 Crear estructuras enlazadas para 
            guardar la información de una mascota y su dueño
        */
       public struct Dueno
       {
           public string nombreDueno;
           public string telefonoDueno;

           public Dueno(String nombre, string telefono)
           {
               nombreDueno = nombre;
               telefonoDueno = telefono;
           }
       }

       public struct Mascota
       {
           public string nombreMascota;
           public string edadMascota;
           public Dueno dueno;

           public Mascota(string nombre, string edad, string nombre_dueno, string telefono)
           {
               nombreMascota = nombre;
               edadMascota = edad;

               dueno = new Dueno(nombre_dueno, telefono);
           }
        }

        private void Click_btnGuardar(object sender, RoutedEventArgs e)
        {

            if(!Validar())
               return;

            Mascota mascota;
            mascota = new Mascota(TextBoxNombreDueno.Text, TextBoxTelefonoDueno.Text, TextBoxNombreMascota.Text, TextBoxEdadMascota.Text);
            MessageBox.Show("Datos guardado..");
            Limpiar();

            ListBoxDatos.Items.Add(mascota.dueno.nombreDueno.ToString()+"  "+mascota.dueno.telefonoDueno.ToString()+"    "+mascota.nombreMascota.ToString()+"    "+mascota.edadMascota.ToString());

        }

        private void Click_btnLimpiar(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

         public bool Validar()
        {
            bool paso = false;
            if(string.IsNullOrWhiteSpace(TextBoxNombreDueno.Text))
                MessageBox.Show("Digita el nombre del dueno");
            else if(string.IsNullOrWhiteSpace(TextBoxTelefonoDueno.Text))
                MessageBox.Show("Digita el telefono del dueno");
            else if(string.IsNullOrWhiteSpace(TextBoxNombreMascota.Text))
                MessageBox.Show("Digita el nombre de la mascota");
            else if(string.IsNullOrWhiteSpace(TextBoxEdadMascota.Text))
                MessageBox.Show("Digita el edad de la mascota");
            else
                paso = true;
            return paso;
        }

        public void Limpiar()
        {
            TextBoxNombreDueno.Text = "";
            TextBoxTelefonoDueno.Text = "";
            TextBoxNombreMascota.Text = "";
            TextBoxEdadMascota.Text = "";
        }
    }
}