using System;
using System.Windows;
using System.Linq;

namespace todosEjercicios.Cap9
{
    public partial class ejer4 : Window
    {
        public ejer4()
        {
            InitializeComponent();
            verNeumaticos();
        }

         /*
         4 Crear una enumeración para 
         los diferentes tipos de neumáticos
        */

        public enum TiposNeumaticos
        {
            Verano, Deportivos, Invierno, Pista, TodoTerreno, Antipinchazo, Remolques, Repuesto, SinAire
        };

        public void verNeumaticos()
        {

            foreach(var i in Enum.GetValues(typeof(TiposNeumaticos)))
            {
                ListBoxEnum.Items.Add(i);
            }
        }
       
    }
}