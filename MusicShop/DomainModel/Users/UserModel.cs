using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MusicShop.DomainModel.Users
{
    public class UserModel : IUserModel
    {
        public User User { get; set; }

        public UserModel(User user)
        {
            User = user;
        }

        public UserModel()
        {
            User = new User();
        }

        public void EditUser(string login, string password, string name, string surname, string patronymic, string phone, Role role)
        {
            StringBuilder errors = new StringBuilder();
            if (login == Connection.Admin.Login || Core.Context.Users.Any(u => u.Login == login && u.IdUser != User.IdUser))
            {
                throw new Exception("Логин занят другим пользователем.");
            }
            if (String.IsNullOrWhiteSpace(surname))
            {
                errors.AppendLine("Пожалуйста укажите фамилию.");
            }
            if (String.IsNullOrWhiteSpace(name))
            {
                errors.AppendLine("Пожалуйста укажите имя.");
            }
            if (!Regex.IsMatch(phone, @"^7|8+[0-9]{10}$"))
            {
                errors.AppendLine("Пожалуйста укажите корректный номер телефона.");
            }
            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]{2,20}$") || login.Contains(" "))
            {
                errors.AppendLine("Пожалуйста укажите корректный логин. Логин должен состоять из 2 - 20 символов, которые могут быть строчными и прописными латинскими буквами и цифрами.");
            }
            if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]{8,30}$") || password.Contains(" "))
            {
                errors.AppendLine("Пожалуйста укажите корректный пароль. Пароль должен состоять из 8 - 30 символов, которые могут быть строчными и прописными латинскими буквами, цифрами.");
            }
            if (errors.Length > 0)
            {
                throw new Exception("Некорректно заполнены поля ввода:\n" + errors.ToString());
            }
            User.Role = role;
            User.Name = name;
            User.Surname = surname;
            User.Patronymic = patronymic;
            User.Login = login;
            User.Phone = phone;
            User.Password = password;
            if (User.IdUser == 0)
            {
                Core.Context.Users.Add(User);
            }
            Core.Context.SaveChanges();
        }
    }
}
