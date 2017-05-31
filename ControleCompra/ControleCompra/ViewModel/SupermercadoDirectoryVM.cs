using ControleCompra.Model.Entities;
using ControleCompra.Model.Services;
using ControleCompra.Util;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ControleCompra.ViewModel
{
    public class SupermercadoDirectoryVM : ObservableBaseObject
    {
        private bool isBusy;
        public bool IsBusy { get => isBusy; set { isBusy = value; OnPropertyChanged(); } }
        public ObservableCollection<Supermercado> Supermercados { get; set; }
        public Command RefleshCommand { get; set; }

        public SupermercadoDirectoryVM()
        {
            IsBusy = false;
            Supermercados = new ObservableCollection<Supermercado>();
            RefleshCommand = new Command( () => Reflesh() );
        }

        private async void Reflesh()
        {
            if( !IsBusy )
            {
                IsBusy = true;

                Supermercados.Clear();

                await Task.Run( () =>
                 {
                     var directory = new SupermercadoDirectoryService().LoadSupermercadoDirectory();

                     foreach( var item in directory.Supermercados )
                     {
                         Supermercados.Add( item );
                     }
                 }
                    );

                IsBusy = false;

            }
        }
    }
}
