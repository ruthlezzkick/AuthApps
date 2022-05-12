using System.Collections.Generic;
using System.Linq;

namespace CookieApp
{
    public class DataProvider
    {
        public IList<ToDoItem> ToDoItems { get;}
        public IList<User> Users { get;}

        public DataProvider()
        {
            Users = CreateUsers();
            ToDoItems = CreateToDoItems();
        }

        public IList<ToDoItem> GetToDoItemsByUserName(string userName)
        {
            return ToDoItems.Where(x => x.UserName == userName).ToList();
        }
        public IList<UserStat> GetAllUserStats()
        {
            var userStats = ToDoItems.GroupBy(x => x.UserName).Select(x => new UserStat
            {
                UserName = x.Key,
                ItemsCount = x.Count()
            }).ToList();
            return userStats;
        }
        public User GetUserByUserName(string userName)
        {
            return Users.FirstOrDefault(x => x.UserName == userName);
        }

        private IList<ToDoItem> CreateToDoItems()
        {
            var list = new List<ToDoItem>
            {
                new ToDoItem
                {
                    Id = 1,
                    Name = "Zakupy",
                    UserName = "Janek"
                },
                new ToDoItem
                {
                    Id = 2,
                    Name = "Lekcje",
                    UserName = "Janek"
                },
                new ToDoItem
                {
                    Id = 3,
                    Name = "Zajęcia dodatkowe",
                    UserName = "Janek"
                },
                new ToDoItem
                {
                    Id = 4,
                    Name = "Sprzątanie ogrodu",
                    UserName = "Janek"
                },
                new ToDoItem
                {
                    Id = 5,
                    Name = "Zebranie",
                    UserName = "Adam"
                },
                new ToDoItem
                {
                    Id = 6,
                    Name = "Spotkanie",
                    UserName = "Adam"
                },
                new ToDoItem
                {
                    Id = 7,
                    Name = "Lekcje",
                    UserName = "Adam"
                },
                new ToDoItem
                {
                    Id = 8,
                    Name = "Administracja",
                    UserName = "Admin"
                },
                new ToDoItem
                {
                    Id = 9,
                    Name = "Konfiguracja",
                    UserName = "Admin"
                }
            };
            return list;
        }
        private IList<User> CreateUsers()
        {
            var list = new List<User>
            {
                new User
                {
                    UserName = "Janek",
                    Password = "Janek",
                    Roles = new List<string>{"User"}
                },
                new User
                {
                    UserName = "Adam",
                    Password = "Adam",
                    Roles = new List<string>{"User"}
                },
                new User
                {
                    UserName = "Admin",
                    Password = "Admin",
                    Roles = new List<string>{"User","Admin"}
                },
                new User
                {
                    UserName = "Admin2",
                    Password = "Admin2",
                    Roles = new List<string>{"Admin"}
                }
            };
            return list;
        }
    }

    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
    }
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public IList<string> Roles { get; set; }
    }
    public class UserStat
    {
        public string UserName { get; set; }
        public int ItemsCount { get; set; }
    }
}