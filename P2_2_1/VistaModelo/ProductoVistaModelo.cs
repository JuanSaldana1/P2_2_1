using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace P2_2_1 {
    class ProductoVistaModelo {
        private IList<Producto> _listaProductos;
        public ProductoVistaModelo() {
            _listaProductos = new List<Producto> {
                new Producto{NombreProducto = "Skechers Ultra Flex-Free Spirits, Zapatillas Mujer", CodigoProducto = 0001, CodigoVendedor= 01, PrecioVenta = 61.27, Imagen = "https://images-eu.ssl-images-amazon.com/images/I/81VK4xavo6L._AC_UL450_SR450,320_.jpg"},
                new Producto{NombreProducto = "Kingston Canvas Select Plus Tarjeta microSD, SDCS2/128GB Class 10 con Adaptador SD ", CodigoProducto = 0002, PrecioVenta = 10.99, Imagen = "https://images-eu.ssl-images-amazon.com/images/I/61B6AVhR5zS._AC_UL450_SR450,320_.jpg"},
                new Producto{NombreProducto = "Tarjeta Regalo Amazon.es - €50 (Estuche plateado)", CodigoProducto = 0003, CodigoVendedor= 01, PrecioVenta = 50.00, Imagen = "https://m.media-amazon.com/images/I/61Ste4rDEtL._AC_SL1500_.jpg"},
                new Producto{NombreProducto = "Skechers Ultra Flex-Free Spirits, Zapatillas Mujer", CodigoProducto = 0004, CodigoVendedor= 01, PrecioVenta = 61.27, Imagen = "E:/DESARROLLO DE INTERFACES/2. GENERACIÓN DE INTERFACES DE ESCRITORIO A PARTIR DE DOCUMENTO XML/P2_2_1/P2_2_1/P2_2_1/IMG/81VK4xavo6L._AC_UL450_SR450,320_.jpg"},
                new Producto{NombreProducto = "Skechers Ultra Flex-Free Spirits, Zapatillas Mujer", CodigoProducto = 0005, CodigoVendedor= 01, PrecioVenta = 61.27, Imagen = "E:/DESARROLLO DE INTERFACES/2. GENERACIÓN DE INTERFACES DE ESCRITORIO A PARTIR DE DOCUMENTO XML/P2_2_1/P2_2_1/P2_2_1/IMG/81VK4xavo6L._AC_UL450_SR450,320_.jpg"}
            };
        }

        public IList<Producto> Articulos {
            get { return _listaProductos; }
            set { _listaProductos = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand {
            get {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set {
                mUpdater = value;
            }
        }

        private ICommand mDeleter;
        public ICommand DeleteCommand {
            get {
                if (mDeleter == null)
                    mDeleter = new Deleter();
                return mDeleter;
            }
            set {
                mDeleter = value;
            }
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