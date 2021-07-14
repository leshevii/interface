using System;

namespace Homework11_2
{
    interface I1
    {
        void M();
    }
    interface I2
    {
        void M();
    }
    class A : I1, I2
    {
        public void M()
        {
            Console.WriteLine("A.M()");
        }

        void I1.M()
        {            
        }

        void I2.M()
        {
        }
    }
}
