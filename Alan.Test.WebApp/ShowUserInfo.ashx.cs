using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alan.Test.WebApp
{
    /// <summary>
    /// ShowUserInfo 的摘要说明
    /// </summary>
    public class ShowUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}