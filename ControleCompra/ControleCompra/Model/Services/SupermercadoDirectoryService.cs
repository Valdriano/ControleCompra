using ControleCompra.Model.Directory;
using ControleCompra.Model.Entities;
using ControleCompra.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCompra.Model.Services
{
    public class SupermercadoDirectoryService
    {
        private DataBaseManager<Supermercado> database;
        private SupermercadoDirectory supermercadoDirectory;
        private ObservableCollection<Supermercado> supermercados;

        public SupermercadoDirectoryService()
        {
            database = new DataBaseManager<Supermercado>();
            supermercadoDirectory = new SupermercadoDirectory();

        }

        public SupermercadoDirectory LoadSupermercadoDirectory()
        {
            supermercados = new ObservableCollection<Supermercado>( database.GetAllItems<Supermercado>() );

            supermercadoDirectory.Supermercados = supermercados;

            return supermercadoDirectory;

        }
    }
}
