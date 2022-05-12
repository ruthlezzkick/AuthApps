using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieApp
{
    public partial class AdminPanel : System.Web.UI.Page
    {
        public IList<UserStat> UserStats { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var cookie = this.Request.Cookies["user"];
            if (cookie == null)
            {
                this.Response.Redirect("Login.aspx?baseUrl=AdminPanel.aspx");
            }

            else
            {
                var userCookie = cookie.Value;
                var dataProvider = new DataProvider();
                var user = dataProvider.GetUserByUserName(userCookie);
                if(!user.Roles.Contains("Admin"))
                {
                    this.Response.Redirect("Login.aspx?baseUrl=AdminPanel.aspx");
                }
                UserStats = dataProvider.GetAllUserStats().ToList();
            }
        }
    }
}