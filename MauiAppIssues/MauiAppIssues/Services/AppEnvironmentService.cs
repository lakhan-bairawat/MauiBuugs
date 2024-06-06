using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppIssues.Services
{
    public class AppEnvironmentService : IAppEnvironmentService
    {
        public IChangeIconService ChangeIconService { get; private set; }

        public AppEnvironmentService(IChangeIconService changeIconService)
        {
            ChangeIconService = changeIconService;
        }
    }
}
