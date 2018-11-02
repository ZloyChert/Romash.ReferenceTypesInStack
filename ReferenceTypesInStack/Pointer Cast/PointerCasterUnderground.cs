namespace ReferenceTypesInStack.Pointer_Cast
{
    public class PointerCasterUnderground
    {
        public virtual T GetManagedReferenceByPointer<T>(T reference)
        {
            return reference;
        }

        public virtual unsafe int* GetPointerByManagedReference<T>(int* pointer)
        {
            return pointer;
        }
    }
}
