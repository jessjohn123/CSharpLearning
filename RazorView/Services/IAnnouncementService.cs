using RazorView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorView.Services
{
    public interface IAnnouncementService
    {
        Task<IEnumerable<Announcements>> GetAnnouncementsAsync();
    }
}
