using Android.App;
using Android.Content.PM;
using Android.Content;
using MauiAppIssues.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Provider.Settings;
using Application = Android.App.Application;

namespace MauiAppIssues.Platforms.Android
{
    [Service(Exported = true)]
    public class ChangeIconService : IChangeIconService
    {
        private static string AlternateIconName = string.Empty;
        public List<string> alise = new List<string>()
        {
            "com.mauiappissues.app.icon",
            "com.mauiappissues.app.demo",
            "com.mauiappissues.app.fitness",
            "com.mauiappissues.app.design",
            "com.mauiappissues.app.gym",
            "com.mauiappissues.app.SplashScreen"
        };
        [Obsolete]
        public void ChangeIcon(int ClubId)
        {
            try
            {                
                var activity = Platform.CurrentActivity as MainActivity;
                string ComponentName = GetActiveComponent(ClubId);
                activity.PackageManager.SetComponentEnabledSetting(new ComponentName(Application.Context.PackageName, ComponentName), ComponentEnabledState.Enabled, ComponentEnableOption.DontKillApp);
                for (int i = 0; i < alise.Count; i++)
                {
                    try
                    {
                        if (alise[i] != ComponentName)
                        {
                            activity.PackageManager.SetComponentEnabledSetting(new ComponentName(Application.Context.PackageName, alise[i]), ComponentEnabledState.Disabled, ComponentEnableOption.DontKillApp);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                var intent = new Intent(activity, typeof(MainActivity));
                intent.AddFlags(ActivityFlags.ClearTop);
                intent.SetFlags(ActivityFlags.NewTask | ActivityFlags.ClearTask);
                activity.Finish();
                activity.StartActivity(intent);
            }
            catch (Exception ex)
            {
            }           
        }

        public string GetActiveComponent(int ClubId)
        {
            switch (ClubId)
            {               
                case 1:
                    AlternateIconName = "com.mauiappissues.app.demo";
                    return AlternateIconName;
                case 2:
                    AlternateIconName = "com.mauiappissues.app.fitness";
                    return AlternateIconName;
                case 3:
                    AlternateIconName = "com.mauiappissues.app.design";
                    return AlternateIconName;
                case 4:
                    AlternateIconName = "com.mauiappissues.app.gym";
                    return AlternateIconName;
                default:
                    AlternateIconName = "com.mauiappissues.app.icon";
                    return AlternateIconName;
            }

        }

        public string GetClubIcon(int ClubId)
        {
            string clubIcon = "demo";
            switch (ClubId)
            {               
                case 1:
                    clubIcon = "demo";
                    return clubIcon;
                case 2:
                    clubIcon = "fitness";
                    return clubIcon;
                case 3:
                    clubIcon = "design";
                    return clubIcon;
                case 4:
                    clubIcon = "gym";
                    return clubIcon;

                default:
                    clubIcon = "icon";
                    return clubIcon;

            }

        }

    }
}
