using System;
using System.ComponentModel;

namespace MVVM.Modelo {

    public class Dependiente : INotifyPropertyChanged {
        private int id;
        private string nombre;
        private string apellido;
        private DateTime fecha;
        private long ss;

        public int Id {
            get => id;
            set {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Nombre {
            get => nombre;
            set {
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }
        public string Apellido {
            get => apellido;
            set {
                apellido = value;
                OnPropertyChanged("Apellido");
            }
        }
        public DateTime Fecha {
            get => fecha;
            set {
                fecha = value;
                OnPropertyChanged("Fecha");
            }
        }
        public long Ss {
            get => ss;
            set {
                ss = value;
                OnPropertyChanged("Ss");
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