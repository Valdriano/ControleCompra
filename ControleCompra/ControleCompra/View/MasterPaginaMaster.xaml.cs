using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleCompra.View
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class MasterPaginaMaster : ContentPage
    {
        public ListView ListView;

        public MasterPaginaMaster()
        {
            InitializeComponent();

            BindingContext = new MasterPaginaMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterPaginaMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterPaginaMenuItem> MenuItems { get; set; }

            public MasterPaginaMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterPaginaMenuItem>( new[]
                {
                    new MasterPaginaMenuItem { Id = 0, Title = "Supermercados"  , TargetType = typeof(PageSupermercado)},
                    new MasterPaginaMenuItem { Id = 1, Title = "Produtos" },
                    new MasterPaginaMenuItem { Id = 2, Title = "Marcas" },
                    new MasterPaginaMenuItem { Id = 3, Title = "Lista de Compras" },
                    new MasterPaginaMenuItem { Id = 4, Title = "Relatório" },
                } );
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged( [CallerMemberName] string propertyName = "" )
            {
                if( PropertyChanged == null )
                    return;

                PropertyChanged.Invoke( this , new PropertyChangedEventArgs( propertyName ) );
            }
            #endregion
        }
    }
}