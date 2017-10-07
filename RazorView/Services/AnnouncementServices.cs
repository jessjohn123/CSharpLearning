using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorView.Models;

namespace RazorView.Services
{
    public class AnnouncementServices : IAnnouncementService
    {
        public async Task<IEnumerable<Announcements>> GetAnnouncementsAsync()
        {
            List<Announcements> announcement = new List<Announcements>() {
            new Announcements() { Title = "Announcement 1", Content = "Today is a Pizza day. Order unlimited margaritta and coke!!!" },
            new Announcements() {Title="Announcement 2", Content = "Get ready for SmackDown Live tonight!!!"},
            };
            return announcement;
        }

    }
}
