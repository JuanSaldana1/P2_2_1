﻿using System.ComponentModel;


namespace P2_2_1 {
    class Producto : INotifyPropertyChanged {
        private string nombreProducto;
        private int codigoProducto;
        private int codigoVendedor;
        private double precioVenta;
        private string imagen;

        public string NombreProducto {
            get {
                return nombreProducto;
            }
            set {
                nombreProducto = value;
                OnPropertyChanged("NombreProducto");
            }
        }

        public int CodigoProducto {
            get {
                return codigoProducto;
            }
            set {
                codigoProducto = value;
                OnPropertyChanged("CodigoProducto");
            }
        }

        public int CodigoVendedor {
            get {
                return codigoVendedor;
            }
            set {
                codigoVendedor = value;
                OnPropertyChanged("CodigoVendedor");
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