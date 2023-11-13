using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Entities
{
    public class AppList : INotifyPropertyChanged
    {
        public List<App> Apps = null;

        public App selectedApp
        {
            get { return selectedApp; }
            set
            {
                selectedApp = value;
                OnPropertyChanged("SelectedApp");
            }
        }

        public AppList()
        {
            Apps = new List<App>();
        }

        public void AddApp(App app)
        {
            Apps.Add(app);
        }

        public void RemoveApp(App app)
        {
            Apps.Remove(app);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propetyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }
    }
}
