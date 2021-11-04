using P2_2_1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P2_2_1.VistaModelo {
    class VentaVistaModelo {
        readonly Venta ventas = new Venta();
        private IList<Venta> ListaPedidos;
        private readonly List<Producto> listaProductos1;
        private readonly List<Producto> listaProductos2;
        private readonly List<Producto> listaProductos3;
        private readonly List<Producto> listaProductos4;
        private readonly List<Producto> listaProductos5;
        private readonly List<Producto> listaProductos6;
        private readonly List<Producto> listaProductos7;
        private readonly List<Producto> listaProductos8;
        public VentaVistaModelo() {
            ListaPedidos = new List<Venta> {
                new Venta{CodigoVenta = "0001", FechaPedido = new DateTime(1992, 8, 1, 17, 59, 44),  CostePedido=335.00, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta= 1561645123, ListaProductos= listaProductos1},
                new Venta{CodigoVenta = "0002", FechaPedido = new DateTime(1993, 9, 21, 11, 30, 44),  CostePedido=33.00, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta= 1561641234, ListaProductos= listaProductos5},
                new Venta{CodigoVenta = "0003", FechaPedido = new DateTime(1995, 11, 8, 09, 47, 44),  CostePedido=3386.00, PagoPorEfectivo = true, PagoPorTarjeta = false, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta= 1561124123, ListaProductos= listaProductos3},
                new Venta{CodigoVenta = "0004", FechaPedido = new DateTime(1996, 2, 16, 01, 24, 44),  CostePedido=56.00, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta= 1561134246, ListaProductos= listaProductos7},
                new Venta{CodigoVenta = "0005", FechaPedido = new DateTime(1996, 4, 17, 23, 03, 44),  CostePedido=36.00, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta= 1561453664, ListaProductos= listaProductos2},
                new Venta{CodigoVenta = "0006", FechaPedido = new DateTime(1993, 1, 9, 19, 49, 44),  CostePedido=396.00, PagoPorEfectivo = true, PagoPorTarjeta = false, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta= 1561234121, ListaProductos= listaProductos6},
                new Venta{CodigoVenta = "0007", FechaPedido = new DateTime(2000, 6, 14, 03, 03, 44),  CostePedido=356.00, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta= 1545123456, ListaProductos= listaProductos4},
                new Venta{CodigoVenta = "0008", FechaPedido = new DateTime(2021, 7, 24, 08, 21, 44),  CostePedido=306.00, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta= 1512344616, ListaProductos= listaProductos8},

            };
        }

        public IList<Venta> Ventas {
            get => ListaPedidos;
            set => ListaPedidos = value;
        }



        private ICommand mUpdater;
        public ICommand UpdateCommand {
            get {
                if (mUpdater == null) {
                    mUpdater = new Updater();
                }
                return mUpdater;
            }
            set => mUpdater = value;
        }

        private ICommand mDeleter;
        public ICommand DeleteCommand {
            get {
                if (mDeleter == null) {
                    mDeleter = new Deleter();
                }
                return mDeleter;
            }
            set => mDeleter = value;
        }

        private class Updater : ICommand {
            #region ICommand Members  

            public bool CanExecute(object parameter) {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter) {

            }
            #endregion
        }

        private class Deleter : ICommand {
            #region ICommand Members  

            public bool CanExecute(object parameter) {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter) {

            }
            #endregion
        }
    }
}