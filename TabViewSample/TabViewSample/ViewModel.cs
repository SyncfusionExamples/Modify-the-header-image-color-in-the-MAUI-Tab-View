using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabViewSample
{
    public class TabItemsSourceViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Model>? tabItems;
        public ObservableCollection<Model>? TabItems
        {
            get { return tabItems; }
            set
            {
                tabItems = value;
                OnPropertyChanged("TabItems");
            }
        }
        public TabItemsSourceViewModel()
        {
            TabItems = new ObservableCollection<Model>();
            TabItems.Add(new Model() { ImageName = "call.png", SelectedColor = Colors.Red });
            TabItems.Add(new Model() { ImageName = "contacts.png", SelectedColor = Colors.Gray });
            TabItems.Add(new Model() { ImageName = "favorite.png", SelectedColor = Colors.Gray });
        }
    }
}
