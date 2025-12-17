namespace OnlineShopModulation
{
    public class Store
    {
        public List<Product> Products;
        public List<Product> Basket;
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

            Basket = new List<Product>();
        }

        public void ShowCatalog()
        {
            int number = 1;
            foreach (Product product in Products)
            {
                Console.Write(number + ". ");
                product.Print();
                number++;
            }
        }

       public void AddToBasket(int numberProduct)
        {
            Basket.Add(Products[numberProduct - 1]);
            Console.WriteLine($"Продукт {Products[numberProduct - 1].Name} успешно добавлен в корзину.");
            Console.WriteLine($"В корзине {Basket.Count} продуктов.");
        }
    }
}
