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
        public IList<ToDoItem> ToDoItems { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var cookie = this.Request.Cookies["user"];
            if (cookie == null)
            {
                this.Response.Redirect("Login.aspx?baseUrl=Todo.aspx");
            }
            else
            {
                var user = cookie.Value;
                if (user == "Admin2")
                {
                    this.Response.Redirect("Login.aspx?baseUrl=Todo.aspx");
                }
                var dataProvider = new DataProvider();
                ToDoItems = dataProvider.GetAllToDoItemsByUser(user);
            }
        }
    }
}