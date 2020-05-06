using Alan.Test.Web.DAL;
using Alan.Test.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.Test.Web.BLL
{
    public class UserInfoBLL
    {
        UserInfoDal userInfoDal = new UserInfoDal();
        public List<UserInfo> GetUserInfo()
        {
            return userInfoDal.GetUserInfo();
        }
    }
}
