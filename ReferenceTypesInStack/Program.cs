using System;
using ReferenceTypesInStack.Pointer_Cast;

namespace ReferenceTypesInStack
{
    unsafe class Program
    {
        public static void Main()
        {
            int* pointer = stackalloc int[2];
            var a = StackInitializer.InitializeOnStack<StackReferenceType>(pointer);

            a.StubMethod();
            Console.WriteLine(a.Field);
            Console.WriteLine(a);
            Console.Read();
        }
    }

}
