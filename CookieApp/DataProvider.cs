using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookieApp
{
    public class DataProvider
    {
        public IList<string> GetAllUsers()
        {
            return new List<string> {"Janek","Adam","Admin","Admin2" };
        }
        public IList<ToDoItem> GetAllToDoItems()
        {
            var list = new List<ToDoItem>
            {
                new ToDoItem
                {
                    Id = 1,
                    Name = "Zakupy",
                    User = "Janek"
                },
                new ToDoItem
                {
                    Id = 2,
                    Name = "Lekcje",
                    User = "Janek"
                },
                new ToDoItem
                {
                    Id = 3,
                    Name = "Zajęcia dodatkowe",
                    User = "Janek"
                },
                new ToDoItem
                {
                    Id = 4,
                    Name = "Sprzątanie ogrodu",
                    User = "Janek"
                },
                new ToDoItem
                {
                    Id = 5,
                    Name = "Zebranie",
                    User = "Adam"
                },
                new ToDoItem
                {
                    Id = 6,
                    Name = "Spotkanie",
                    User = "Adam"
                },
                new ToDoItem
                {
                    Id = 7,
                    Name = "Lekcje",
                    User = "Adam"
                },
                new ToDoItem
                {
                    Id = 8,
                    Name = "Administracja",
                    User = "Admin"
                },
                new ToDoItem
                {
                    Id = 9,
                    Name = "Konfiguracja",
                    User = "Admin"
                },
            };
            return list;
        }

        public IList<ToDoItem> GetAllToDoItemsByUser(string user)
        {
            return GetAllToDoItems().Where(x => x.User == user).ToList();
        }

        public IList<UserStat> GetAllUserStats()
        {
            var toDoItems = GetAllToDoItems().ToList();

            var userStats = toDoItems.GroupBy(x => x.User).Select(x => new UserStat { 
                User = x.Key,
                ItemsCount = x.Count(),
            }).ToList();
            return userStats;
        }
    }

    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
    }

    public class UserStat
    {
        public string User { get; set; }
        public int ItemsCount { get; set; }
    }
}