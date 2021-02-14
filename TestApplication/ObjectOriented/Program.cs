using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Product karinto = new Product(123, "かりんとう", 180);
            Product daihuku = new Product(235, "大福もち", 160);

            Console.WriteLine("値型と参照型の違い\n値型");

            MyStruct myStruct1 = new MyStruct(1, 1);
            MyStruct myStruct2 = myStruct1;
            Console.WriteLine($@"myStruct1:X={myStruct1.X},Y={myStruct1.Y}");
            Console.WriteLine("myStruct1 = myStruct2");
            Console.WriteLine($@"myStruct2:X={myStruct2.X},Y={myStruct2.Y}");
            Console.WriteLine("myStruct1.X = 3");
            myStruct1.X = 3;
            Console.WriteLine($@"myStruct1:X={myStruct1.X},Y={myStruct1.Y}");
            Console.WriteLine($@"myStruct2:X={myStruct2.X},Y={myStruct2.Y}");
            Console.WriteLine("参照型");

            MyClass myClass1 = new MyClass(1, 1);
            MyClass myClass2 = myClass1;
            Console.WriteLine($@"myClass1:X={myClass1.X},Y={myClass1.Y}");
            Console.WriteLine("myClass1 = myClass2");
            Console.WriteLine($@"myClass2:X={myClass2.X},Y={myClass2.Y}");
            Console.WriteLine("myClass1.X = 3");
            myClass1.X = 3;
            Console.WriteLine($@"myClass1:X={myClass1.X},Y={myClass1.Y}");
            Console.WriteLine($@"myClass2:X={myClass2.X},Y={myClass2.Y}");

            Console.WriteLine("\n継承関係\n");

            //社員は人である
            Person person = new Employee {
                //NameとBirthdayは親クラスのプロパティだが利用できる
                Id = 100,
                Name = "佐藤",
                Birthday = new DateTime(1992,4,5),
                DivisionName = "第一営業部"
            };

            //すべてのクラスはObjectを継承している
            Object person1 = new Employee();

            
        }
    }
}
