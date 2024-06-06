using MauiAppIssues.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace MauiAppIssues.Platforms.iOS
{
    public class ChangeIconService : IChangeIconService
    {
        private static string AlternateIconName = string.Empty;

        public async void ChangeIcon(int ClubId)
        {
            if (UIApplication.SharedApplication.SupportsAlternateIcons)
            {
                switch (ClubId)
                {                   
                    case 1:
                        AlternateIconName = "demo";
                        UIApplication.SharedApplication.SetAlternateIconName(AlternateIconName, HandleError);
                        await System.Threading.Tasks.Task.Delay(3000);
                        break;
                    case 2:
                        AlternateIconName = "fitness";
                        UIApplication.SharedApplication.SetAlternateIconName(AlternateIconName, HandleError);
                        await System.Threading.Tasks.Task.Delay(3000);
                        break;
                    case 3:
                        AlternateIconName = "design";
                        UIApplication.SharedApplication.SetAlternateIconName(AlternateIconName, HandleError);
                        await System.Threading.Tasks.Task.Delay(3000);
                        break;
                    case 4:
                        AlternateIconName = "gym";
                        UIApplication.SharedApplication.SetAlternateIconName(AlternateIconName, HandleError);
                        await System.Threading.Tasks.Task.Delay(3000);
                        break;

                    default:
                        AlternateIconName = "demo";
                        UIApplication.SharedApplication.SetAlternateIconName(AlternateIconName, HandleError);
                        break;
                }

            }
        }
        private void HandleError(Foundation.NSError error)
        {
           
        }

        public string GetClubIcon(int ClubId)
        {
            string clubIcon = "demo";
            if (UIApplication.SharedApplication.SupportsAlternateIcons)
            {
                switch (ClubId)
                {                   
                    case 1:
                        return "demo";
                    case 2:
                        return "fitness";
                    case 3:
                        return "design";
                    case 4:
                        return "gym";

                    default:
                        return "demo";
                }
            }
            return clubIcon;
        }
    }

}
