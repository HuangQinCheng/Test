using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow dr=null;
            int temp = 1;
            for (int i = 1; i < 5; i++)
            {
                dt.Columns.Add("SN" + i, Type.GetType("System.String"));              
            }
            for (int j = 1; j < 4; j++)
            {
                dr = dt.NewRow();
                for (int i = 1; i < 5; i++)
                {
                   
                    dr["SN" + i] = temp;
                    temp = temp + 1;
                }
                dt.Rows.Add(dr);
            }
            GridView1.ShowHeader = false;

            GridView1.DataSource = dt;
            GridView1.DataBind();
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                GridView1.Rows[i].CssClass = "selectedTr";
            }

        }
    }
}