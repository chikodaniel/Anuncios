using Anuncios.Connectors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Anuncios
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static dbconector _dbconnector = new dbconector();

        public static dbconector dbconector
        {
            get { return App._dbconnector; }
        }
    }
}
