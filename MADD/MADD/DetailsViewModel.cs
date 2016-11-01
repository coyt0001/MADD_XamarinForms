using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MADD
{
    class DetailsViewModel : INotifyPropertyChanged
    {
        string Todoitem;
        public string Todo
        {
            get
            {
                return Todoitem;
            }
            set
            {
                if (Todoitem != value)
                {
                    Todoitem = value;
                    OnPropertyChanged("Todoitem");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
