using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWPLDataService.Model
{
    public class User : Entity
    {
        public User()
        {
            UserAccessPageses=new List<UserAccessPage>();
        }

        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<UserAccessPage> UserAccessPageses { get; set; } 
    }

    public class UserAccessPage : Entity
    {
        public string PageName { get; set; }

        public bool View { get; set; }

        public bool Add { get; set; }

        public bool Edit { get; set; }

        public bool Delete { get; set; }

        public User User { get; set; }
    }
}
