using System.Runtime.InteropServices;
using ASiNet.Win.IO.Base.Enums;

namespace ASiNet.Win.IO.Base;
[StructLayout(LayoutKind.Sequential)]
internal struct MouseInput
{
    public int dx;
    public int dy;
    public int mouseData;
    public MouseEventFlag dwFlags;
    public uint time;
    public IntPtr dwExtraInfo;
}