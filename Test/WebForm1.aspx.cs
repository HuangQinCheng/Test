using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            using (OracleConnection conn = new OracleConnection("Data Source=106.12.91.167:1521/ORCL;User ID=Alan;Password=18855971690hqcx"))
            {
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM STUDENT";
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (OracleDataAdapter oda = new OracleDataAdapter(cmd))
                    {
                        dt = new DataTable();
                        oda.Fill(dt);
                    }
                }
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}