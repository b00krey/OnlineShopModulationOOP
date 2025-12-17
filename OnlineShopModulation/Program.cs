namespace OnlineShopModulation
{
    static class Program
    {
        static bool IsYes(string answer)
        {
            return answer.ToLower() == "да";
        }

        static void Main(string[] args)
        {
            Store onlineStore = new Store();

            Console.WriteLine("Здравствуйте. Выберите действие:");
            Console.WriteLine("1. Показать каталог продуктов?");
            Console.WriteLine("Выберите номер действия, которое хотите совершить.");
            int numberAction = Convert.ToInt32(Console.ReadLine());

            switch (numberAction)
            {
                case 1:
                    onlineStore.ShowCatalog(); break;

                default:
                    Console.WriteLine("Выберите номер действия из списка");
                    break;
            }

            Console.WriteLine("Хотите добавить продукт в корзину? Наберите Да или Нет.");
            bool yes = IsYes(Console.ReadLine());

            while (IsYes)
            {
                onlineStore.ShowCatalog();
                Console.WriteLine("Напишите номер продукта, которого нужно добавить в корзину");
                int numberProduct = int.Parse(Console.ReadLine());
                onlineStore.AddToBasket(numberProduct);

                Console.WriteLine("Хотите добавить продукт в корзину? Наберите Да или Нет.");
                yes = IsYes(Console.ReadLine());
            }
        }
    }
}
