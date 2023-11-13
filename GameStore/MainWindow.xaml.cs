using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace GameStore
{
    public partial class MainWindow : Window
    {
        private AppList appList = new AppList();

        public MainWindow()
        {
            InitializeComponent();
            appList.AddApp(new Entities.App("https://cdn.icon-icons.com/icons2/1099/PNG/512/1485482352-whatsapp_78680.png", "WhatsApp",3.1f,"Социальные сети","Бесплатно"));
            appList.AddApp(new Entities.App("https://cdn.icon-icons.com/icons2/294/PNG/256/iTunes_Store_31097.png", "iTunes",2.7f,"Музыка","2.50$"));
            appList.AddApp(new Entities.App("https://cdn.icon-icons.com/icons2/2108/PNG/512/telegram_icon_130816.png", "Telegram Desktop",4.4f,"Социальные сети","Бесплатно"));
            appList.AddApp(new Entities.App("https://cdn.icon-icons.com/icons2/2621/PNG/512/device_scanner_icon_157277.png", "Сканер Windows",3.4f,"Служебные программы","Бесплатно"));
            appList.AddApp(new Entities.App("https://i.imgur.com/3Bu7NEn.png", "Microsoft Clipschamp",3.4f,"Фотографии и видео","Бесплатно"));
            appList.AddApp(new Entities.App("https://cdn.icon-icons.com/icons2/2108/PNG/512/spotify_icon_130826.png", "Spotify",4.3f,"Музыка","Бесплатно"));
            appList.AddApp(new Entities.App("https://cdn.icon-icons.com/icons2/2699/PNG/512/viber_tile_logo_icon_170260.png", "Viber",3.4f,"Социальные сети","Бесплатно"));
            appList.AddApp(new Entities.App("https://cdn.icon-icons.com/icons2/1211/PNG/512/1491580658-yumminkysocialmedia06_83104.png", "Instagram",3.4f, "Социальные сети", "Бесплатно"));

            LVMain.ItemsSource = appList.Apps;
        }
    }
}
