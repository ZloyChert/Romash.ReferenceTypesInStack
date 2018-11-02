namespace ReferenceTypesInStack.Pointer_Cast
{
    public class PointerCasterFacad
    {
        public virtual unsafe T GetManagedReferenceByPointer<T>(int* pointer)
        {
            return default(T);
        }

        public virtual unsafe int* GetPointerByManagedReference<T>(T managedReference)
        {
            return (int*)0;
        }
    }
}
