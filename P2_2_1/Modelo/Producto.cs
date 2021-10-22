using System.ComponentModel;


namespace P2_2_1 {
    class Producto : INotifyPropertyChanged {
        private string nombreProducto;
        private int codigoProducto;
        private string descripcion;
        private int codigoVendedor;
        private double precioVenta;
        private bool ivaGeneral;
        private bool ivaReducido;
        private bool ivaSuperreducido;
        private string tipoIVA;
        private string imagen;

        public string NombreProducto {
            get => nombreProducto;
            set {
                nombreProducto = value;
                OnPropertyChanged("NombreProducto");
            }
        }

        public int CodigoProducto {
            get => codigoProducto;
            set {
                codigoProducto = value;
                OnPropertyChanged("CodigoProducto");
            }
        }

        public string Descripcion {
            get => descripcion;
            set {
                descripcion = value;
                OnPropertyChanged("Descripcion");
            }
        }

        public int CodigoVendedor {
            get => codigoVendedor;
            set {
                codigoVendedor = value;
                OnPropertyChanged("CodigoVendedor");
            }
        }

        public double PrecioVenta {
            get => precioVenta;
            set {
                precioVenta = value;
                OnPropertyChanged("PrecioVenta");
            }
        }

        public bool IvaGeneral {
            get => ivaGeneral;
            set {
                ivaGeneral = value;
                OnPropertyChanged("IvaGeneral");
            }
        }

        public bool IvaReducido {
            get => ivaReducido;
            set {
                ivaReducido = value;
                OnPropertyChanged("IvaReducido");
            }
        }

        public bool IvaSuperreducido {
            get => ivaSuperreducido;
            set {
                ivaSuperreducido = value;
                OnPropertyChanged("IvaSuperreducido");
            }
        }

        //GETTERS Y SETTERS DEL ATRIBUTO TIPOIVA
        public string TipoIVA {
            get => tipoIVA;
            set {
                // El atributo va a recoger el valor que devuelve la función DevuelveTipoIVA()
                tipoIVA = DevuelveIVA();
                OnPropertyChanged("TipoIVA");
            }
        }

        public string Imagen {
            get => imagen;
            set {
                imagen = value;
                OnPropertyChanged("Imagen");
            }
        }

        public string DevuelveIVA() {
            if (ivaGeneral && ivaReducido == false && ivaSuperreducido == false) {
                tipoIVA = "General";
            }
            else if (ivaReducido) {
                tipoIVA = "Reducido";
            }
            else if (ivaSuperreducido) {
                tipoIVA = "Super reducido";
            }
            return tipoIVA;
        }


        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}