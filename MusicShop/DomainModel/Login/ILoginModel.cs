namespace MusicShop.DomainModel.Login
{
    public interface ILoginModel
    {
        User Login(string login, string password);
    }
}
