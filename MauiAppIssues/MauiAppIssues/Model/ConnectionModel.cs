using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppIssues.Model
{
    public class ConnectionModel
    {
        public int ClubId { get; set; }
        public string Connection { get; set; }
        public string ShortName { get; set; }
        public string MapName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int ThemeColorType { get; set; }
        private string _ThemeColor = string.Empty;
        public string ThemeColor
        {
            get
            {
                return _ThemeColor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = "#0A92D6";
                _ThemeColor = value;
                OnPopertyChanged("ThemeColor");
            }
        }
        private bool _Selected = false;
        public bool Selected
        {
            get { return _Selected; }
            set { _Selected = value; OnPopertyChanged("Selected"); OnPopertyChanged("CheckboxColor"); }
        }
        public ImageSource ClubIcon => ImageSource.FromFile(App._appEnvironmentService?.ChangeIconService?.GetClubIcon(ClubId));

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPopertyChanged(string ImageName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(ImageName));
        }

        public double calculatedistace { get; set; }
    }

}
