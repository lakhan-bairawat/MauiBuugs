using MauiAppIssues.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppIssues.ViewModel
{
    public class ChangeAppIconViewModel
    {
        public ChangeAppIconViewModel()
        {
            source = new List<ConnectionModel>();
            CreateMonkeyCollection();
        }
        readonly IList<ConnectionModel> source;
        public ObservableCollection<ConnectionModel> Clubs { get; private set; }

        void CreateMonkeyCollection()
        {
            source.Add(new ConnectionModel
            {
                ShortName = "Demo",
                MapName="Demo_Point",
                Latitude = "19.075983",
                Longitude = "72.877655",
                ClubId = 1
            });  
            source.Add(new ConnectionModel
            {
                ShortName = "fitness",
                MapName="Fit_Point",
                Latitude = "19.075983",
                Longitude = "72.877655",
                ClubId = 2
            }); 
            source.Add(new ConnectionModel
            {
                ShortName = "design",
                MapName= "design_Point",
                Latitude = "19.075983",
                Longitude = "72.877655",
                ClubId = 3
            }); 
            source.Add(new ConnectionModel
            {
                ShortName = "gym",
                MapName= "gym_Point",
                Latitude = "19.075983",
                Longitude = "72.877655",
                ClubId = 4
            });


            Clubs = new ObservableCollection<ConnectionModel>(source);
        }
    }
}
