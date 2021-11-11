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

        private void buttonCrear_Click(object sender, System.Windows.RoutedEventArgs e) {
            ProductoVistaModelo nuevoProducto = new ProductoVistaModelo();
            nuevoProducto.Articulos.Add(new Producto() {NombreProducto = editTextNombreProducto.Text,  CodigoVendedor = int.Parse(editTextCodigoVendedor.Text), PrecioVenta = int.Parse(editTextPrecio.Text), CodigoProducto = int.Parse(editTextCodigoProducto.Text), Descripcion = editTextDescripcion.Text });

        }
    }
}