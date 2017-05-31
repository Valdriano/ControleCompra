using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ControleCompra.Util
{
    public class ObservableBaseObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged( [CallerMemberName] string name = "" )
        {
            PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( name ) );
        }
    }
}
