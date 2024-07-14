# ASiNet.Win.IO

## The main functions of keyboard input:

These methods are a wrapper over the SendInput WinAPI function.
<a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendinput">See more information on SendInput function.</a>

1. `KeyboardInput.PressKey(ushort scanCode | char unicode | VKCode vK)` - Sends a key down event
2. `KeyboardInput.UpKey(ushort scanCode | char unicode | VKCode vK)` - Sends a key up event
3. `KeyboardInput.ClickKey(ushort scanCode | char unicode | VKCode vK)` - Sends a key click event (Sends a down sequentially, and then up event)
4. `KeyboardInput.ClickOneModifier(VKCode mod, VKCode vK)` - Sends a single modifier key click
5. `KeyboardInput.ClickTwoModifiers(VKCode mod1, VKCode mod2, VKCode vK)` - Sends a key click with two modifiers
6. `KeyboardInput.ClickThreeModifiers(VKCode mod1, VKCode mod2, VKCode mod3, VKCode vK)` - Sends a key click with three modifiers
7. `KeyboardInput.LongClick(VKCode vK, int duration, CancellationToken token = default)` - Sends a key down event, and after a while a key up event
8. `KeyboardInput.LongClick(VKCode vK, TimeSpan duration, CancellationToken token = default)` - Sends a key down event, and after a while a key up event
9. `KeyboardInput.RepeatClickByCount(VKCode vK, int repeatsCount, int interval, CancellationToken token = default)` - Repeats key click events a certain number of times, with a certain delay between clicks.
10. `KeyboardInput.RepeatClickByCount(VKCode vK, TimeSpan duration, TimeSpan interval, CancellationToken token = default)` - Repeats key click events a certain number of times, with a certain delay between clicks.
11. `KeyboardInput.RepeatClickByTime(VKCode vK, TimeSpan duration, TimeSpan interval, CancellationToken token = default)` - Repeats key click events for a certain time, with a certain delay between clicks
12. `KeyboardInput.RepeatClickByTime(VKCode vK, int duration, int interval, CancellationToken token = default)` - Repeats key click events for a certain time, with a certain delay between clicks

## Auxiliary keyboard input functions:

1. `KeyboardInput.MapScanCodeToVirtualCode(ushort scanCode)` - <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeya">See more info.</a>
2. `KeyboardInput.MapScanCodeToVirtualCodeEx(ushort scanCode)` - <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeya">See more info.</a>
3. `KeyboardInput.MapVirtualCodeToScanCode(VKCode scanCode)` - <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeya">See more info.</a>
4. `KeyboardInput.MapVirtualCodeToScanCodeEx(VKCode scanCode)` - <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeya">See more info.</a>
5. `KeyboardInput.MapVirtualCodeToChar(VKCode scanCode)` - <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeya">See more info.</a>
