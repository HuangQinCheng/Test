using Alan.Test.Web.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.Test.Web.DAL
{
    public class UserInfoDal
    {
        public List<UserInfo> GetUserInfo()
        {
            string sql = "SELECT * FROM USERINFO";
            DataTable dt = new DataTable();
            dt = SqlHelper.GetTable(sql, CommandType.Text);
            List<UserInfo> list = null;
            if (dt.Rows.Count > 0)
            {
                list = new List<UserInfo>();
                foreach (DataRow dr in dt.Rows)
                {
                    UserInfo userInfo = new UserInfo();
                    LoadEntity(dr,userInfo);
                    list.Add(userInfo);
                }
            }
            return list;
        }
        private void LoadEntity(DataRow row, UserInfo userInfo)
        {
            userInfo.id = Convert.ToInt32(row["ID"]);
            userInfo.UserName = row["UserName"] != DBNull.Value ? row["UserName"].ToString() : string.Empty;
            userInfo.Password = row["PASSWORD"] != DBNull.Value ? row["PASSWORD"].ToString() : string.Empty;
            userInfo.Sex = row["SEX"] != DBNull.Value ? row["SEX"].ToString() : string.Empty;
            userInfo.RegTime = Convert.ToDateTime(row["REGTIME"]);
            userInfo.MailAddress = row["MAILADDRESS"] != DBNull.Value ? row["MAILADDRESS"].ToString() : string.Empty;
        }
    }
}
