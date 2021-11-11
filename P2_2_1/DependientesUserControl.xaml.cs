using MVVM.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace P2_2_1 {
    /// <summary>
    /// Lógica de interacción para DependientesUserControl.xaml
    /// </summary>
    public partial class DependientesUserControl : UserControl {
        public DependientesUserControl() {
            InitializeComponent();
            DataContext = new DependienteVistaModelo();
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e) {
            editTextNumeroSeguridadSocial.Text = null;
            editTextFecha.Text = "";
            editTextNombreDependiente.Text = "";
            editTextApellidoDependiente.Text = null;
        }
    }
}