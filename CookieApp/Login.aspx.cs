using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cookie = this.Request.Cookies["user"];
            var baseUrl = this.Request.QueryString["baseUrl"];
      
            if (cookie!=null && !string.IsNullOrEmpty(baseUrl))
            {
                this.loginMessage.Text = "Brak dostępu do strony";
                this.loginMessage.Visible = true;
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            var dataProvider = new DataProvider();

            if (string.IsNullOrEmpty(this.userTxt.Text))
            {
                this.loginMessage.Text = "Nie podano loginu";
                this.loginMessage.Visible = true;
            }
            else
            {
                var user = dataProvider.GetUserByUserName(this.userTxt.Text);
                if (user == null || user.Password != this.passwordTxt.Text)
                {
                    this.loginMessage.Text = "Błędny login lub hasło";
                    this.loginMessage.Visible = true;
                }
                else
                {
                    var cookie = new HttpCookie("user");
                    cookie.Value = this.userTxt.Text;
                    this.Response.SetCookie(cookie);

                    var baseUrl = this.Request.QueryString["baseUrl"];
                    if (!string.IsNullOrEmpty(baseUrl))
                    {
                        this.Response.Redirect(baseUrl);
                    }
                    else
                    {
                        this.Response.Redirect("/");
                    }
                }
            }
        }
    }
}