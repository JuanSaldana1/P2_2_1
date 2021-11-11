using P2_2_1.VistaModelo;
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

namespace P2_2_1 {
    /// <summary>
    /// Lógica de interacción para VentasUserControl.xaml
    /// </summary>
    public partial class VentasUserControl : UserControl {
        public VentasUserControl() {
            InitializeComponent();
            DataContext = new VentaVistaModelo();
            VentaVistaModelo venta = new VentaVistaModelo();
            venta.Hola();
        }

        private void MyListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            MyListView.DataContext = new VentaVistaModelo();
        }
    }
}