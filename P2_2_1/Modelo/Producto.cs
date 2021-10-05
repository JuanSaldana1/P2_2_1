using System.ComponentModel;


namespace P2_2_1 {
    class Producto : INotifyPropertyChanged {
        private int codigoProducto;
        private string nombreProducto;
        private double precioVenta;
        private string imagen;

        public int CodigoProducto {
            get {
                return codigoProducto;
            }
            set {
                codigoProducto = value;
                OnPropertyChanged("CodigoProducto");
            }
        }

        public string NombreProducto {
            get {
                return nombreProducto;
            }
            set {
                nombreProducto = value;
                OnPropertyChanged("NombreProducto");
            }
        }

        public double PrecioVenta {
            get {
                return precioVenta;
            }
            set {
                precioVenta = value;
                OnPropertyChanged("PrecioVenta");
            }
        }

        public string Imagen {
            get {
                return imagen;
            }
            set {
                imagen = value;
                OnPropertyChanged("Imagen");
            }
        }




        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}