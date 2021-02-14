using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    //クラス
    class MyClass { 
        public int X { get; set; } 
        public int Y { get; set; }

        public MyClass(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    //構造体
    struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MyStruct(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Main
    {
        MyClass myClass = new MyClass(1,1);

        MyStruct myStruct = new MyStruct(1,1);
    }

}
