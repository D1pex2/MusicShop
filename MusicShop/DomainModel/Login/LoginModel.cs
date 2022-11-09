using System;
using System.Linq;

namespace MusicShop.DomainModel.Login
{
    public class LoginModel : ILoginModel
    {
        public User Login(string login, string password)
        {
            if (login == Connection.Admin.Login && password == Connection.Admin.Password)
            {
                return Connection.Admin;
            }
            User user = Core.Context.Users.AsNoTracking().FirstOrDefault(u => u.Login.ToLower() == login.ToLower());
            if (user == null || user.Password != password)
            {
                throw new Exception("Введен неправильный логин или пароль.");
            }
            return user;
        }
    }
}
