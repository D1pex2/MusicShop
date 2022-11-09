namespace MusicShop.DomainModel.Users
{
    public interface IUserModel
    {
        User User { get; set; }

        void EditUser(string login, string password, string name, string surname, string patronymic, string phone, Role role);
    }
}
