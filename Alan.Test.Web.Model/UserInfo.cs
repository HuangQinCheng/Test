using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.Test.Web.Model
{
    public class UserInfo
    {
        public UserInfo()
        {
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { this.id = value; }
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public DateTime RegTime { get; set; }
        public string MailAddress { get; set; }
    }
}
