using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppIssues.Services
{
    public interface IChangeIconService
    {
        void ChangeIcon(int clubId);
        string GetClubIcon(int ClubId);
    }
}
