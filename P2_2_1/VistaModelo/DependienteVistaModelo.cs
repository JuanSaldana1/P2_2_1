using MVVM.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace MVVM.ViewModel {
    class DependienteVistaModelo {
        private IList<Dependiente> _DependientesList;
        public DependienteVistaModelo() {
            _DependientesList = new List<Dependiente> {
                new Dependiente{Id = 1, Ss = 243651287645, Nombre="Javier", Apellido="González", Fecha = new DateTime(2010, 02, 01)},
                new Dependiente{Id = 2, Ss = 756343578689, Nombre="Andrea", Apellido="Mata", Fecha = new DateTime(2013, 04, 23)},
                new Dependiente{Id = 3, Ss = 293874153141, Nombre="Antonio", Apellido="García", Fecha = new DateTime(2000, 08, 12)},
                new Dependiente{Id = 4, Ss = 243526245234, Nombre="Alberto", Apellido="Salinas", Fecha = new DateTime(1994, 11, 05)},
                new Dependiente{Id = 5, Ss = 856345637335, Nombre="Laura", Apellido="Mendoza", Fecha = new DateTime(2018, 06, 30)}
            };
        }

        public IList<Dependiente> Dependientes {
            get { return _DependientesList; }
            set { _DependientesList = value; }
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