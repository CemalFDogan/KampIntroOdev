using System;
using System.Linq;

namespace Odev2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();

            //int number1 = 20;
            //int number2 = 100;
            //var sonuc2 = Add3(ref number1, number2);

            //Console.WriteLine(sonuc2);
            //Console.WriteLine(number1);

            Console.WriteLine("****************");

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();

        }

        static void Add()
        {
            Console.WriteLine("Added!");

            var sonuc = Add2(20, 30);
            Console.WriteLine(sonuc);

        }

        // void --> Git şunu yap, şunu kaydet vb. işemlerde kullanılır.
        // Ama aşağıdaki örnekte bir sonuç döndürdüğümüz için o tipte kullanmamız gerekir
        // ve bu yüzden int kullandık.

        static int Add2(int number1, int number2)    // static int Add2(int number1 = 40, int number2 = 50){ }
        {                                            // Şeklinde bir varsayılan değer tanımlanırsa yukarıda
            var result = number1 + number2;          // çağrılan Add2() metoduna değer girmesek de olur.
            return result;                           // Ama static int Add2(int number1, int number2 = 50){ } 
        }                                            // şeklinde olursa number1 için bir değer girmemiz gereklidir.


        static int Add3(ref int number1, int number2)  // ref - out ----> İkisi de değer tip olan değişkenleri referans tip 
        {                                              // olarak görülmesini sağlar ve metot içerisindeki değişimleri metot     
            number1 = 30;                              // dışındaki değişkenlere de etki etmesini sağlar.
            return number1 + number2;                  //
                                                       // ref --> ref kullandığımız zaman metot dışındaki değişkene mutlaka
        }                                               //         değer atanmalıdır. Yoksa program bize kızar.
                                                        //
                                                        // out --> out kullanıldığı zaman metot dışındaki değişkene değer
                                                        //         atanmasa da olur ama mutlaka metot içinde değişken bir kere
                                                        //         set edilmelidir. Yoksa program bize kızar.



        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }                                                               // Method Overloading --> Anı ada sahip metotlar
                                                                        // olmalarına rağmen imzaları farklı olduğu için 
                                                                        // iki metotta aynı ayna çalışabilir.
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }



        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();                                   // Add4() metodu çağrıldığında 20 sonucunu döndürmesinin
        }                                                           // nedeni params parametresinden önce başka bir parametre
                                                                    // gelmekte ve bundan dolayı yukarıda tanımladıımız
                                                                    // sayıların en başındaki 1 sayısını number değişkenine
                                                                    // atadı ve numbers dizisinin toplamının 20 çıkmasına
                                                                    // neden oldu.
    }
}

