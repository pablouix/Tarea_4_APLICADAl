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
using todosEjercicios.Cap8;
using todosEjercicios.Cap9;

namespace todosEjercicios
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejer3MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var ejer3 = new ejer3();
            ejer3.Show();

        }

        private void Ejer5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var ejer5 = new ejer5();
            ejer5.Show();
        }

        private void Ejer3Cap9MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var ejer3C9 = new ejer3C9();
            ejer3C9.Show();
        }

        private void Ejer4Cap9MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var ejer4 = new ejer4();
            ejer4.Show();
        }
        
        private void Ejer1Cap9MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var ejer1 = new ejer1();
            ejer1.Show();
        }

    
    }
}
