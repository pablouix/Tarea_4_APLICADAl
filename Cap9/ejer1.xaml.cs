using System;
using System.Windows;
using System.Linq;

namespace todosEjercicios.Cap9
{
    public partial class ejer1 : Window
    {
        public ejer1()
        {
            InitializeComponent();
        }

        /*
            
            1 Crear una estructura para guardar 
            los productos de una tienda.

        */
        public struct Producto
        {
            public int productoId;
            public string nombreProducto;
            public float precioProducto;

            public Producto(int id, string nombre, float precio)
            {
                productoId = id;
                nombreProducto = nombre;
                precioProducto = precio;
            }
        }

        private void Click_btnGuardar(object sender, RoutedEventArgs e)
        {

            if(!Validar())
               return;

            Producto producto;
            producto = new Producto(Convert.ToInt32(TextBoxProductoID.Text), TextBoxNombreProducto.Text, float.Parse(TextBoxPrecioProducto.Text));
            MessageBox.Show("Producto guardado..");
            Limpiar();

            ListBoxProductos.Items.Add(producto.productoId.ToString()+"    "+producto.nombreProducto.ToString()+"  "+"$"+producto.precioProducto.ToString());
        }

        public bool Validar()
        {
            bool paso = false;
            if(string.IsNullOrWhiteSpace(TextBoxProductoID.Text))
                MessageBox.Show("Digita el id del producto");
            else if(string.IsNullOrWhiteSpace(TextBoxNombreProducto.Text))
                MessageBox.Show("Digita el nombre del producto");
            else if(string.IsNullOrWhiteSpace(TextBoxPrecioProducto.Text))
                MessageBox.Show("Digita el precio del producto");
            else
                paso = true;
            return paso;
        }

        private void Click_btnLimpiar(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            TextBoxProductoID.Text = "";
            TextBoxNombreProducto.Text = "";
            TextBoxPrecioProducto.Text = "";
        }
    }
}