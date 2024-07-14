using System.Runtime.InteropServices;
using ASiNet.Win.IO.Base.Enums;

namespace ASiNet.Win.IO.Base;
internal static class Functions
{

    [DllImport("user32.dll", SetLastError = true)]
    public static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

    [DllImport("User32.dll")]
    public static extern ushort MapVirtualKeyA(ushort uCode, MapType Flags);


    [DllImport("user32.dll")]
    public static extern IntPtr GetMessageExtraInfo();
}
