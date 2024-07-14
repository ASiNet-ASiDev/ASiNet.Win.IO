using System.Runtime.InteropServices;

namespace ASiNet.Win.IO.Base;
[StructLayout(LayoutKind.Sequential)]
internal struct HardwareInput
{
    public uint uMsg;
    public ushort wParamL;
    public ushort wParamH;
}