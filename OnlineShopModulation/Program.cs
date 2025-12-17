namespace OnlineShopModulation
{
    internal class Program
    {
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
        }
    }
}
