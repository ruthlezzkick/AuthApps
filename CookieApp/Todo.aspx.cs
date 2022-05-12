using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieApp
{
    public partial class Todo : System.Web.UI.Page
    {
        public IList<ToDoItem> UserToDoItems { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var cookie = this.Request.Cookies["user"];
            if (cookie == null)
            {
                this.Response.Redirect("Login.aspx?baseUrl=Todo.aspx");
            }
            else
            {
                var userCookie = cookie.Value;
                var dataProvider= new DataProvider();
                var user = dataProvider.GetUserByUserName(userCookie);
                if (!user.Roles.Contains("User"))
                {
                    this.Response.Redirect("Login.aspx?baseUrl=Todo.aspx");
                }
                UserToDoItems = dataProvider.GetToDoItemsByUserName(user.UserName);
            }
        }
    }
}