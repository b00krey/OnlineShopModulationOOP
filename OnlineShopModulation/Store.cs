namespace OnlineShopModulation
{
    public class Store
    {
        public List<Product> Products;

        public Store()
        {
            Products = new List<Product>
            {
            new Product("Хлеб", 25),
            new Product("Молоко", 100),
            new Product("Печенье", 50),
            new Product("Масло", 250),
            new Product("Йогурт", 300),
            new Product("Сок", 80)
            };
        }

        public void ShowCatalog()
        {
            foreach (Product product in Products)
                product.Print();
        }
    }
}
