using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace P2_2_1 {
    class ProductoVistaModelo {
        private IList<Producto> _listaProductos;
        public ProductoVistaModelo() {
            _listaProductos = new List<Producto> {
                new Producto{CodigoProducto = 0001, NombreProducto = "Skechers Ultra Flex-Free Spirits, Zapatillas Mujer", PrecioVenta = 61.27, Imagen = "E:/DESARROLLO DE INTERFACES/2. GENERACIÓN DE INTERFACES DE ESCRITORIO A PARTIR DE DOCUMENTO XML/P2_2_1/P2_2_1/P2_2_1/IMG/81VK4xavo6L._AC_UL450_SR450,320_.jpg"},
                new Producto{CodigoProducto = 0002, NombreProducto = "Skechers Ultra Flex-Free Spirits, Zapatillas Mujer", PrecioVenta = 61.27, Imagen = "E:/DESARROLLO DE INTERFACES/2. GENERACIÓN DE INTERFACES DE ESCRITORIO A PARTIR DE DOCUMENTO XML/P2_2_1/P2_2_1/P2_2_1/IMG/81VK4xavo6L._AC_UL450_SR450,320_.jpg"},
                new Producto{CodigoProducto = 0003, NombreProducto = "Skechers Ultra Flex-Free Spirits, Zapatillas Mujer", PrecioVenta = 61.27, Imagen = "E:/DESARROLLO DE INTERFACES/2. GENERACIÓN DE INTERFACES DE ESCRITORIO A PARTIR DE DOCUMENTO XML/P2_2_1/P2_2_1/P2_2_1/IMG/81VK4xavo6L._AC_UL450_SR450,320_.jpg"},
                new Producto{CodigoProducto = 0004, NombreProducto = "Skechers Ultra Flex-Free Spirits, Zapatillas Mujer", PrecioVenta = 61.27, Imagen = "E:/DESARROLLO DE INTERFACES/2. GENERACIÓN DE INTERFACES DE ESCRITORIO A PARTIR DE DOCUMENTO XML/P2_2_1/P2_2_1/P2_2_1/IMG/81VK4xavo6L._AC_UL450_SR450,320_.jpg"},
                new Producto{CodigoProducto = 0005, NombreProducto = "Skechers Ultra Flex-Free Spirits, Zapatillas Mujer", PrecioVenta = 61.27, Imagen = "E:/DESARROLLO DE INTERFACES/2. GENERACIÓN DE INTERFACES DE ESCRITORIO A PARTIR DE DOCUMENTO XML/P2_2_1/P2_2_1/P2_2_1/IMG/81VK4xavo6L._AC_UL450_SR450,320_.jpg"}
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
    }
}