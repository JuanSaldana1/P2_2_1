using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace P2_2_1 {
    class ProductoVistaModelo {
        readonly Producto producto = new Producto();
        private IList<Producto> _listaProductos;
        public ProductoVistaModelo() {
            _listaProductos = new List<Producto> {
                new Producto{NombreProducto = "Skechers Ultra Flex-Free Spirits, Zapatillas Mujer", CodigoProducto = 0001, Descripcion="These Free Spirits sneakers from Skechers feature smooth sleek athletic mesh nearly one piece fabric upper. Lace up sporty comfort walking and training sneakers with air cooled memory foam insole, highly flexible comfort midsole. These sneakers also feature smooth synthetic overlays at heel and laces for added stability along with solid color design with knit-in mesh texture detailing. Ultra Flex midsole with superior impact cushioning protection and remarkable energy return. Highly flexible articulated midsole and outsole design for freedom of movement. Keep your feet feeling free and looking sleekly sporty with these SKECHERS Ultra Flex - Free Spirits shoes. ", CodigoVendedor = 01, PrecioVenta = 61.27, IvaGeneral = true, IvaReducido = false, IvaSuperreducido = false, TipoIVA = producto.DevuelveIVA(), Imagen = "https://images-eu.ssl-images-amazon.com/images/I/81VK4xavo6L._AC_UL450_SR450,320_.jpg"},
                new Producto{NombreProducto = "Kingston Canvas Select Plus Tarjeta microSD, SDCS2/128GB Class 10 con Adaptador SD ", Descripcion="· Velocidades de UHS-I Clase 10 de hasta 100 MB/s · Optimizada para uso con dispositivos Android · Capacidad de la memoria: 128 GB ·Tipo de memoria flash: Micro SD", CodigoProducto = 0002, PrecioVenta = 10.99, IvaGeneral = true, IvaReducido = false, IvaSuperreducido = false, TipoIVA = producto.DevuelveIVA(), Imagen = "https://images-eu.ssl-images-amazon.com/images/I/61B6AVhR5zS._AC_UL450_SR450,320_.jpg"},
                new Producto{NombreProducto = "Tarjeta Regalo Amazon.es - €50 (Estuche plateado)", CodigoProducto = 0003, Descripcion="Las tarjetas regalo de Amazon pueden canjearse por millones de productos de Amazon.es. Son el regalo ideal y con ellas acertarás de lleno ya que permiten que sea el destinatario el que elija lo que quiere y necesita.", CodigoVendedor = 01, PrecioVenta = 50.00, IvaGeneral = false, IvaReducido = true, IvaSuperreducido = false, TipoIVA = producto.DevuelveIVA(), Imagen = "https://m.media-amazon.com/images/I/71maiy6A5xL._AC_SL1500_.jpg"},
                new Producto{NombreProducto = "TP-Link TAPO P100 - Mini Enchufe Inteligente Wi-Fi", CodigoProducto = 0004, Descripcion="Control remoto: enciende y apaga instantáneamente los dispositivos conectados donde sea que estés a través de la aplicación tapo ", CodigoVendedor = 01, PrecioVenta = 9.90, IvaGeneral = false, IvaReducido = false, IvaSuperreducido = true, TipoIVA = producto.DevuelveIVA(), Imagen = "https://m.media-amazon.com/images/I/61wb-kgqcLL._AC_SL1500_.jpg"},
                new Producto{NombreProducto = "Logitech G432 Auriculares Gaming con Cable, Sonido 7.1 Surround", CodigoProducto = 0005, Descripcion="DTS Headphone:X 2.0, Transductores 50mm, USB y Jack Audio 3,5mm, Microfóno Volteable, Peso Ligero, PC/Mac/Xbox One/PS4/Switch - Negro ", CodigoVendedor = 01, PrecioVenta = 41.45, IvaGeneral = true, IvaReducido = false, IvaSuperreducido = false, TipoIVA = producto.DevuelveIVA(), Imagen = "https://m.media-amazon.com/images/I/61us2rqFJOS._AC_SL1500_.jpg"}
            };
        }

        public IList<Producto> Articulos {
            get => _listaProductos;
            set { _listaProductos = value; }
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

#pragma warning disable CS0067 // El evento 'ProductoVistaModelo.Updater.CanExecuteChanged' nunca se usa
            public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067 // El evento 'ProductoVistaModelo.Updater.CanExecuteChanged' nunca se usa

            public void Execute(object parameter) {

            }
            #endregion
        }

        private class Deleter : ICommand {
            #region ICommand Members  

            public bool CanExecute(object parameter) {
                return true;
            }

#pragma warning disable CS0067 // El evento 'ProductoVistaModelo.Deleter.CanExecuteChanged' nunca se usa
            public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067 // El evento 'ProductoVistaModelo.Deleter.CanExecuteChanged' nunca se usa

            public void Execute(object parameter) {

            }
            #endregion
        }
    }
}