using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Entities
{
    public class App : INotifyPropertyChanged
    {
        public string? _image;
        public string? _name;
        public float? _rating;
        public string? _type;
        public string? _price;

        public App(string image,string name,float rating,string type, string price)
        {
            Image = image;
            Name = name;
            Rating = rating;
            Type = type;
            Price = price;
        }



        public string? Image { get { return _image; } set { _image = value; OnPropertyChanged("Image"); } }
        public string? Name { get { return _name; } set { _name = value; OnPropertyChanged("Name"); } }
        public float? Rating { get { return _rating; } set { _rating = value; OnPropertyChanged("Rating"); } }
        public string? Type { get { return _type; } set { _type = value; OnPropertyChanged("Type"); } }
        public string? Price { get { return _price; } set { _price = value; OnPropertyChanged("Price"); } }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propetyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }
    }
}
