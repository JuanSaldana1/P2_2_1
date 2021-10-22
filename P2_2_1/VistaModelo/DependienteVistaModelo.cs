using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace P2_2_1 {
    internal class DependienteVistaModelo {
        public DependienteVistaModelo() {
            Dependientes = new List<Dependiente> {
                new Dependiente{NombreDependiente = "Pepe", CodigoDependiente = 0001, FechaNacimiento = "1995/25/3", Edad = 22, Imagen = "https://images-eu.ssl-images-amazon.com/images/I/81VK4xavo6L._AC_UL450_SR450,320_.jpg"},
                new Dependiente{NombreDependiente = "Pepe", CodigoDependiente = 0002, FechaNacimiento = "1989/25/3", Edad = 22, Imagen = "https://images-eu.ssl-images-amazon.com/images/I/81VK4xavo6L._AC_UL450_SR450,320_.jpg"},
                new Dependiente{NombreDependiente = "Pepe", CodigoDependiente = 0003, FechaNacimiento = "1991/25/3", Edad = 22, Imagen = "https://images-eu.ssl-images-amazon.com/images/I/81VK4xavo6L._AC_UL450_SR450,320_.jpg"},
                new Dependiente{NombreDependiente = "Pepe", CodigoDependiente = 0004, FechaNacimiento = "2000/25/3", Edad = 22, Imagen = "https://www.redaccionmedica.com/images/destacados/-buscamos-la-recuperacion-completa-de-la-persona-con-depresion--7353.jpg"},
                new Dependiente{NombreDependiente = "Chica", CodigoDependiente = 0005, FechaNacimiento = "2009/25/3", Edad = 20, Imagen = "https://xavierferras.com/wp-content/uploads/2019/02/266-Persona.jpg"}
            };
        }

        public IList<Dependiente> Dependientes { get; set; }

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