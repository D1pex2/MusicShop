namespace MusicShop.DomainModel.ProductModel
{
    public interface IProductModel
    {
        Product Product { get; set; }

        void AddToCart(Product product);

        void Rate(decimal rating);
    }
}
