using System;

namespace static_binding_comliler_time_P3_100_200_
{
    class test
    {
        public int x = 100;

    }
    class Program:test
    {
        public  new int x = 200;
        void show()
        {
            // base kewword parent class variable asses:
            Console.WriteLine(base.x+" "+x);
          /* Console.WriteLine(x+" "+x);*/

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.show();
            // Out Put=100 200;
            // static binding not posible
            /*  test obj = new Program();
              obj.show();*/
            
        }
    }
}
