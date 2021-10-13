using System.ComponentModel;

namespace P2_2_1 {
    class Dependiente : INotifyPropertyChanged {
        private string nombreDependiente;
        private int codigoDependiente;
        private string fechaNacimiento;
        private int edad;
        private string imagen;

        public string NombreDependiente {
            get {
                return nombreDependiente;
            }
            set {
                nombreDependiente = value;
                OnPropertyChanged("NombreDependiente");
            }
        }

        public int CodigoDependiente {
            get {
                return codigoDependiente;
            }
            set {
                codigoDependiente = value;
                OnPropertyChanged("CodigoDependiente");
            }
        }

        public string FechaNacimiento {
            get {
                return fechaNacimiento;
            }
            set {
                fechaNacimiento = value;
                OnPropertyChanged("FechaNacimiento");
            }
        }

        public int Edad {
            get {
                return edad;
            }
            set {
                edad = value;
                OnPropertyChanged("Edad");
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
