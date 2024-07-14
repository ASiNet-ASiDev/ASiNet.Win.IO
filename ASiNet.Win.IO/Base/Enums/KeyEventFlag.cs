﻿namespace ASiNet.Win.IO.Base.Enums;
[Flags]
internal enum KeyEventFlag : uint
{
    KeyDown = 0x0000,
    ExtendedKey = 0x0001,
    KeyUp = 0x0002,
    Unicode = 0x0004,
    Scancode = 0x0008
}