using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabViewSample
{
    public class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private string? image;
        public string? ImageName
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged("ImageName");
            }
        }
        private Color? selectedColor;
        public Color? SelectedColor
        {
            get => selectedColor;
            set
            {
                selectedColor = value;
                OnPropertyChanged(nameof(SelectedColor));
            }
        }
    }
}
