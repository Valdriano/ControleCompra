using ControleCompra.Model.Entities;
using ControleCompra.Util;
using System.Collections.ObjectModel;

namespace ControleCompra.Model.Directory
{
    public class SupermercadoDirectory : ObservableBaseObject
    {
        private ObservableCollection<Supermercado> supermercados = new ObservableCollection<Supermercado>();

        public ObservableCollection<Supermercado> Supermercados { get => supermercados; set { supermercados = value; OnPropertyChanged(); } }
    }
}
