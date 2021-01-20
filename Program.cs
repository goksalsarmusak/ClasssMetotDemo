using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id=1,
                Ad = "Melih",
                Soyad = "Karakaş",
                HesapNo =61
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                Ad="Melike",
                Soyad="Yıldız",
                HesapNo=512
            };

            Customer customer3 = new Customer()
            {
                Id=3,
                Ad="Hamza",
                Soyad="Şimşek",
                HesapNo=345
            };


            Customer[] c = new Customer[] {customer1,customer2,customer3 };


            CustomerManager customerManager = new CustomerManager();

            customerManager.Listele(c);

            Console.WriteLine("************************");

            Console.WriteLine("-----Müşteri Ekleme İşlemi-----");

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("************************");

            Console.WriteLine("-----Müsteri Silme İşlemi");
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
        }
    }
}
