using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alan.Test.Web.DAL;
using Oracle.ManagedDataAccess.Client;

namespace TicketProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string strSQL = string.Empty;
            try
            {
                strSQL = "SELECT * FROM TICKETINFO WHERE FROM=:FROM AND DESTINATION=:DESTINATION AND ";
                OracleParameter[] paras = 
                {
                    new OracleParameter(":DESTINATION", OracleDbType.Varchar2, 32),
                    new OracleParameter(":FROM",OracleDbType.Varchar2,32)
                };
                SqlHelper.GetTable(strSQL, CommandType.Text, paras);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
