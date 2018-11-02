using System.Runtime.InteropServices;

namespace ReferenceTypesInStack.Pointer_Cast
{
    [StructLayout(LayoutKind.Explicit)]
    public class PointerCaster
    {
        public PointerCaster()
        {
            underground = new PointerCasterUnderground();
        }

        [FieldOffset(0)]
        private PointerCasterUnderground underground;

        [FieldOffset(0)]
        public PointerCasterFacad Caster;
    }
}
