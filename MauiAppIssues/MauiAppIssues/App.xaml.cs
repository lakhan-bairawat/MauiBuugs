using MauiAppIssues.Services;

namespace MauiAppIssues
{
    public partial class App : Application
    {
        public static IAppEnvironmentService _appEnvironmentService;

        public App(IAppEnvironmentService appEnvironmentService)
        {
            InitializeComponent();
            _appEnvironmentService = appEnvironmentService;
            MainPage = new NavigationPage(new MainPage());

        }
    }
}
