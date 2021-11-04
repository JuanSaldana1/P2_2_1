using System.Windows.Controls;

namespace P2_2_1 {
    /// <summary>
    /// Lógica de interacción para Productos.xaml
    /// </summary>
    public partial class Productos : Page {
        public Productos() {
            InitializeComponent();
            DataContext = new ProductoVistaModelo();
        }
    }
}