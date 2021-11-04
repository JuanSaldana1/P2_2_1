using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1.Modelo {
    class Venta {
        private string codigoVenta;
        private DateTime fechaPedido;
        private double costePedido;
        private bool pagoPorTarjeta;
        private bool pagoPorEfectivo;
        private string formaPago;
        private int numeroTarjeta;

        public string CodigoVenta {
            get => codigoVenta;
            set {
                codigoVenta = value;
                OnPropertyChanged("CodigoVenta");
            }
        }

        public DateTime FechaPedido {
            get => fechaPedido;
            set {
                fechaPedido = value;
                OnPropertyChanged("FechaPedido");
            }
        }

        public double CostePedido {
            get => costePedido;
            set {
                costePedido = value;
                OnPropertyChanged("CostePedido");
            }
        }

        public bool PagoPorTarjeta {
            get => pagoPorTarjeta;
            set {
                pagoPorTarjeta = value;
                OnPropertyChanged("PagoPorTarjeta");
            }
        }

        public bool PagoPorEfectivo {
            get => pagoPorEfectivo;
            set {
                pagoPorEfectivo = value;
                OnPropertyChanged("PagoPorEfectivo");
            }
        }

        //GETTERS Y SETTERS DEL ATRIBUTO TIPOIVA
        public string FormaPago {
            get => formaPago;
            set {
                // El atributo va a recoger el valor que devuelve la función DevuelveFormaPago()
                formaPago = DevuelveFormaPago();
                OnPropertyChanged("FormaPago");
            }
        }

        public int NumeroTarjeta {
            get => numeroTarjeta;
            set {
                numeroTarjeta = value;
                OnPropertyChanged("NumeroTarjeta");
            }
        }

        public List<Producto> ListaProductos { get; internal set; }

        public string DevuelveFormaPago() {
            if (pagoPorEfectivo) {
                formaPago = "Efectivo";
            } else {
                formaPago = "Tarjeta";
            }
            return formaPago;
        }


        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}