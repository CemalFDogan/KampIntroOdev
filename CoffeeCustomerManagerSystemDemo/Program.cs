using CoffeeCustomerManagerSystemDemo.Entities;
using CoffeeCustomerManagerSystemDemo.Abstract;
using CoffeeCustomerManagerSystemDemo.Concrete;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCustomerManagerSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
               
             - Starbucks ve Nero firmasu için çalışıyoruz.
             - İki firmada verilerini veri tabanına kaydetmek istiyor.
             
                            Starbucks Firması
            - Starbucks müşterileri kaydederken mutlaka mernis doğrulaması istiyor
            - Starbuks müşteriler için her kahve alımı için yıldız kazandırmak istiyor
              
                           Nero Firması
            - Nero müşterileri kaydederken böyle bir şey istemiyor.

             */


            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2001, 9, 26),
                FirstName = "Cemal Faruk",
                LastName = "Doğan",
                NationalityId = "30581102572"
            });
        }
    }
}
