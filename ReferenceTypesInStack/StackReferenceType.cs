using System;

namespace ReferenceTypesInStack
{
    public class StackReferenceType
    {
        public int Field;
        public override string ToString()
        {
            return "AHHAHHAHA";
        }

        public virtual void StubMethod()
        {
            Console.WriteLine("CALL");
        }
    }
}
