using P2_2_1.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace P2_2_1.VistaModelo {
    class VentaVistaModelo {
        readonly Venta ventas = new Venta();
        private IList<Venta> ListaPedidos;
        private readonly Producto producto = new Producto();
        private readonly List<Producto> listaProductos1 = new List<Producto>();
        private readonly List<Producto> listaProductos2 = new List<Producto>();
        private readonly List<Producto> listaProductos3 = new List<Producto>();
        private readonly List<Producto> listaProductos4 = new List<Producto>();
        private readonly List<Producto> listaProductos5 = new List<Producto>();
        private readonly List<Producto> listaProductos6 = new List<Producto>();
        private readonly List<Producto> listaProductos7 = new List<Producto>();
        private readonly List<Producto> listaProductos8 = new List<Producto>();
        public VentaVistaModelo() {
            List<Producto> lista = new List<Producto>();
#pragma warning disable CS0168 // La variable 'lista2' se ha declarado pero nunca se usa
            List<Producto> lista2;
#pragma warning restore CS0168 // La variable 'lista2' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'lista3' se ha declarado pero nunca se usa
            List<Producto> lista3;
#pragma warning restore CS0168 // La variable 'lista3' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'lista4' se ha declarado pero nunca se usa
            List<Producto> lista4;
#pragma warning restore CS0168 // La variable 'lista4' se ha declarado pero nunca se usa
            Producto item = new Producto() { NombreProducto = "TP-Link TAPO P100 - Mini Enchufe Inteligente Wi-Fi", CodigoProducto = 0004, Descripcion = "Control remoto: enciende y apaga instantáneamente los dispositivos conectados donde sea que estés a través de la aplicación tapo ", CodigoVendedor = 01, PrecioVenta = 9.90, IvaGeneral = false, IvaReducido = false, IvaSuperreducido = true, TipoIVA = producto.DevuelveIVA(), Imagen = "https://m.media-amazon.com/images/I/61wb-kgqcLL._AC_SL1500_.jpg" };
            Producto item2 = new Producto() { NombreProducto = "TP-Link TAPO P100 - Mini Enchufe Inteligente Wi-Fi", CodigoProducto = 0004, Descripcion = "Control remoto: enciende y apaga instantáneamente los dispositivos conectados donde sea que estés a través de la aplicación tapo ", CodigoVendedor = 01, PrecioVenta = 9.90, IvaGeneral = false, IvaReducido = false, IvaSuperreducido = true, TipoIVA = producto.DevuelveIVA(), Imagen = "https://m.media-amazon.com/images/I/61wb-kgqcLL._AC_SL1500_.jpg" };
            Producto item3 = new Producto() { NombreProducto = "TP-Link TAPO P100 - Mini Enchufe Inteligente Wi-Fi", CodigoProducto = 0004, Descripcion = "Control remoto: enciende y apaga instantáneamente los dispositivos conectados donde sea que estés a través de la aplicación tapo ", CodigoVendedor = 01, PrecioVenta = 9.90, IvaGeneral = false, IvaReducido = false, IvaSuperreducido = true, TipoIVA = producto.DevuelveIVA(), Imagen = "https://m.media-amazon.com/images/I/61wb-kgqcLL._AC_SL1500_.jpg" };
            Producto item4 = new Producto() { NombreProducto = "TP-Link TAPO P100 - Mini Enchufe Inteligente Wi-Fi", CodigoProducto = 0004, Descripcion = "Control remoto: enciende y apaga instantáneamente los dispositivos conectados donde sea que estés a través de la aplicación tapo ", CodigoVendedor = 01, PrecioVenta = 9.90, IvaGeneral = false, IvaReducido = false, IvaSuperreducido = true, TipoIVA = producto.DevuelveIVA(), Imagen = "https://m.media-amazon.com/images/I/61wb-kgqcLL._AC_SL1500_.jpg" };
            Producto item5 = new Producto() { NombreProducto = "TP-Link TAPO P100 - Mini Enchufe Inteligente Wi-Fi", CodigoProducto = 0004, Descripcion = "Control remoto: enciende y apaga instantáneamente los dispositivos conectados donde sea que estés a través de la aplicación tapo ", CodigoVendedor = 01, PrecioVenta = 9.90, IvaGeneral = false, IvaReducido = false, IvaSuperreducido = true, TipoIVA = producto.DevuelveIVA(), Imagen = "https://m.media-amazon.com/images/I/61wb-kgqcLL._AC_SL1500_.jpg" };
            Producto item6 = new Producto() { NombreProducto = "TP-Link TAPO P100 - Mini Enchufe Inteligente Wi-Fi", CodigoProducto = 0004, Descripcion = "Control remoto: enciende y apaga instantáneamente los dispositivos conectados donde sea que estés a través de la aplicación tapo ", CodigoVendedor = 01, PrecioVenta = 9.90, IvaGeneral = false, IvaReducido = false, IvaSuperreducido = true, TipoIVA = producto.DevuelveIVA(), Imagen = "https://m.media-amazon.com/images/I/61wb-kgqcLL._AC_SL1500_.jpg" };
            Producto item7 = new Producto() { NombreProducto = "TP-Link TAPO P100 - Mini Enchufe Inteligente Wi-Fi", CodigoProducto = 0004, Descripcion = "Control remoto: enciende y apaga instantáneamente los dispositivos conectados donde sea que estés a través de la aplicación tapo ", CodigoVendedor = 01, PrecioVenta = 9.90, IvaGeneral = false, IvaReducido = false, IvaSuperreducido = true, TipoIVA = producto.DevuelveIVA(), Imagen = "https://m.media-amazon.com/images/I/61wb-kgqcLL._AC_SL1500_.jpg" };
            lista.Add(item);
            lista.Add(item3);
            lista.Add(item4);
            lista.Add(item2);
            ListaPedidos = new List<Venta> {
                new Venta{ CodigoVenta = "0001", FechaPedido = new DateTime(1992, 8, 1, 17, 59, 44), CostePedido=335.78, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta= 1561645123, ListaProductos = lista},
                new Venta{ CodigoVenta = "0002", FechaPedido = new DateTime(1993, 9, 21, 11, 30, 44), CostePedido=33.54, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta= 1561641234, ListaProductos = listaProductos2},
                new Venta{ CodigoVenta = "0003", FechaPedido = new DateTime(1995, 11, 8, 09, 47, 44), CostePedido=3386.29, PagoPorEfectivo = true, PagoPorTarjeta = false, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta= 1561124123, ListaProductos = listaProductos3},
                new Venta{ CodigoVenta = "0004", FechaPedido = new DateTime(1996, 2, 16, 01, 24, 44), CostePedido =56.11, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta = 1561134246, ListaProductos = listaProductos7},
                new Venta{ CodigoVenta = "0005", FechaPedido = new DateTime(1996, 4, 17, 23, 03, 44), CostePedido =36.64, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta = 1561453664, ListaProductos = listaProductos2},
                new Venta{ CodigoVenta = "0006", FechaPedido = new DateTime(1993, 1, 9, 19, 49, 44), CostePedido= 396.00, PagoPorEfectivo = true, PagoPorTarjeta = false, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta = 1561234121, ListaProductos = listaProductos6},
                new Venta{ CodigoVenta = "0007", FechaPedido = new DateTime(2000, 6, 14, 03, 03, 44), CostePedido= 356.00, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta = 1545123456, ListaProductos = listaProductos4},
                new Venta{ CodigoVenta = "0008", FechaPedido = new DateTime(2021, 7, 24, 08, 21, 44), CostePedido= 306.00, PagoPorEfectivo = false, PagoPorTarjeta = true, FormaPago = ventas.DevuelveFormaPago(), NumeroTarjeta = 1512344616, ListaProductos = listaProductos8},
            };
        }

        public IList<Venta> Ventas {
            get => ListaPedidos;
            set => ListaPedidos = value;
        }

        public void Hola() {
            foreach (Venta venta in Ventas) {
                Console.WriteLine(venta.ListaProductos.ToString());
            }
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

#pragma warning disable CS0067 // El evento 'VentaVistaModelo.Updater.CanExecuteChanged' nunca se usa
            public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067 // El evento 'VentaVistaModelo.Updater.CanExecuteChanged' nunca se usa

            public void Execute(object parameter) {

            }
            #endregion
        }

        private class Deleter : ICommand {
            #region ICommand Members  

            public bool CanExecute(object parameter) {
                return true;
            }

#pragma warning disable CS0067 // El evento 'VentaVistaModelo.Deleter.CanExecuteChanged' nunca se usa
            public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067 // El evento 'VentaVistaModelo.Deleter.CanExecuteChanged' nunca se usa

            public void Execute(object parameter) {

            }
            #endregion
        }
    }


}



