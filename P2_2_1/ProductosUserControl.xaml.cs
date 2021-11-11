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
    /// Lógica de interacción para ProductosUserControl.xaml
    /// </summary>
    public partial class ProductosUserControl : UserControl {
        public ProductosUserControl() {
            InitializeComponent();
            DataContext = new ProductoVistaModelo();
        }
    }
}