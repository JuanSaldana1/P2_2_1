﻿using System.Windows;

namespace P2_2_1 {
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            MainWindow window = new MainWindow();
            ProductoVistaModelo productoVistaModelo = new ProductoVistaModelo();
            window.DataContext = productoVistaModelo;
            window.Show();
        }
    }
}