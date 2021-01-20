using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Listele(Customer[] customer)
        {
            Console.WriteLine("-----Sistemde Kayıtlı Müşteriler-----");
            foreach (var listCustomer in customer)
            {
                Console.WriteLine("{0}-) {1} {2} {3}",listCustomer.Id,listCustomer.Ad,listCustomer.Soyad,listCustomer.HesapNo);
            }
        }
        public void Add(Customer customer)
        {
            
            Console.WriteLine("{0}-) {1} {2} isimli {3} hesap numaralı müşteri başarıyla eklenmiştir."
                , customer.Id, customer.Ad, customer.Soyad, customer.HesapNo);
        }
        public void Delete(Customer customer)
        {
            
            Console.WriteLine("{0} numaralı müşteri başarıyla silinmiştir.", customer.Id);
        }
    }
}
