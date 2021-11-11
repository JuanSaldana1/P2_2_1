
using System.Windows;

namespace P2_2_1 {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            userControlProductos.Content = new ProductosUserControl();
            userControlDependientes.Content = new DependientesUserControl();
            userControlVentas.Content = new VentasUserControl();
        }
    }
}