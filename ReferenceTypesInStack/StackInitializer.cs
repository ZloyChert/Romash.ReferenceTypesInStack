using ReferenceTypesInStack.Pointer_Cast;

namespace ReferenceTypesInStack
{
    public class StackInitializer
    {
        public static unsafe T InitializeOnStack<T>(int* pointer) where T : new()
        {
            T r = new T();
            var caster = new PointerCaster().Caster;
            int* ptr = caster.GetPointerByManagedReference(r);
            pointer[0] = ptr[0];
            T reference = caster.GetManagedReferenceByPointer<T>(pointer);
            return reference;
        }
    }
}
