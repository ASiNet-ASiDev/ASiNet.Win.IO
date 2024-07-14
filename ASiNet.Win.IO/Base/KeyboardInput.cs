using System.Runtime.InteropServices;
using ASiNet.Win.IO.Base.Enums;

namespace ASiNet.Win.IO.Base;
[StructLayout(LayoutKind.Sequential)]
internal struct KeyboardInput
{
    public ushort wVk;
    public ushort wScan;
    public KeyEventFlag dwFlags;
    public uint time;
    public IntPtr dwExtraInfo;
}