using System;

namespace Abstract_class_and_vitrual_method
{
    public abstract class AbstractClass
    {
        public virtual void ACM()
        {
            Console.WriteLine("Default implementation");
        }
    }
        public class SomeClass1 : AbstractClass
        { }

        public class SomeClass2 : AbstractClass
        {
            public override void ACM()
            {
                Console.WriteLine("New Default implementation");
            }
        }
    
    class Program
    {
        public static void Main(string[] args)
        {
            SomeClass1 sc = new SomeClass1();
            sc.ACM();

            SomeClass2 soc = new SomeClass2();
            soc.ACM();
        }
    }
}
