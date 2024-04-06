namespace C_Class_Extention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            while (true)
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1. Mehsul elave et");
                Console.WriteLine("2.Mehul sil");
                Console.WriteLine("3. Mehsula bax ");
                Console.WriteLine("4.Type gore mehsula bax");
                Console.WriteLine("5. Ada gore mehsula bax");
                Console.WriteLine("0. Proqramdancixis");

                Console.Write("\nSecimini daxil et: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct(store);
                        break;

                }
                break;

            }
    }
         }
}
