using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SP_Lab5_Priority_Planning
{
    internal class NotifyObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
