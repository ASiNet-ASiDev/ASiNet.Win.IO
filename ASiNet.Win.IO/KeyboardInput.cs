using System.Runtime.InteropServices;
using ASiNet.Win.IO.Base;
using ASiNet.Win.IO.Base.Enums;

namespace ASiNet.Win.IO;
public class KeyboardInput
{

    private static int _inputSize = Marshal.SizeOf<Input>();

    /// <summary>
    /// Down key by scan code
    /// </summary>
    /// <param name="scanCode">Key scan code</param>
    /// <returns></returns>
    public static uint PressKey(ushort scanCode) =>
        Functions.SendInput(1, [NewKeyboardInput(scanCode, KeyEventFlag.KeyDown)], _inputSize);
    /// <summary>
    /// Up key by scan code
    /// </summary>
    /// <param name="scanCode">Key scan code</param>
    /// <returns></returns>
    public static uint UpKey(ushort scanCode) =>
        Functions.SendInput(1, [NewKeyboardInput(scanCode, KeyEventFlag.KeyUp)], _inputSize);
    /// <summary>
    /// Click key by scan code:
    /// <list type="number">
    /// <item>Down key</item>
    /// <item>Up key</item>
    /// </list>
    /// </summary>
    /// <param name="scanCode">Key scan code</param>
    /// <returns></returns>
    public static uint ClickKey(ushort scanCode) =>
        Functions.SendInput(2, [NewKeyboardInput(scanCode, KeyEventFlag.KeyDown), NewKeyboardInput(scanCode, KeyEventFlag.KeyUp)], _inputSize);
    /// <summary>
    /// Down key by unicode char
    /// </summary>
    /// <param name="scanCode">Unicode char</param>
    /// <returns></returns>
    public static uint PressKey(char unicode) =>
        Functions.SendInput(1, [NewKeyboardInput(unicode, KeyEventFlag.KeyDown)], _inputSize);
    /// <summary>
    /// Up key by unicode char
    /// </summary>
    /// <param name="scanCode">Unicode char</param>
    /// <returns></returns>
    public static uint UpKey(char unicode) =>
        Functions.SendInput(1, [NewKeyboardInput(unicode, KeyEventFlag.KeyUp)], _inputSize);
    /// <summary>
    /// Click key by unicode char:
    /// <list type="number">
    /// <item>Down key</item>
    /// <item>Up key</item>
    /// </list>
    /// </summary>
    /// <param name="scanCode">Unicode char</param>
    /// <returns></returns>
    public static uint ClickKey(char unicode) =>
        Functions.SendInput(2, [NewKeyboardInput(unicode, KeyEventFlag.KeyDown), NewKeyboardInput(unicode, KeyEventFlag.KeyUp)], _inputSize);
    /// <summary>
    /// Down key by virtual keycode
    /// </summary>
    /// <param name="vK">Virtual keycode</param>
    /// <returns></returns>
    public static uint PressKey(VKCode vK) =>
        Functions.SendInput(1, [NewKeyboardInput(vK, KeyEventFlag.KeyDown)], _inputSize);
    /// <summary>
    /// Up key by virtual keycode
    /// </summary>
    /// <param name="vK">Virtual keycode</param>
    /// <returns></returns>
    public static uint UpKey(VKCode vK) =>
        Functions.SendInput(1, [NewKeyboardInput(vK, KeyEventFlag.KeyUp)], _inputSize);
    /// <summary>
    /// Click key by virtual keycode:
    /// <list type="number">
    /// <item>Down key</item>
    /// <item>Up key</item>
    /// </list>
    /// </summary>
    /// <param name="vK">Virtual keycode</param>
    /// <returns></returns>
    public static uint ClickKey(VKCode vK) =>
        Functions.SendInput(2, [NewKeyboardInput(vK, KeyEventFlag.KeyDown), NewKeyboardInput(vK, KeyEventFlag.KeyUp)], _inputSize);

    /// <summary>
    /// The principle of operation:
    /// <list type="number">
    /// <item>Down mod</item>
    /// <item>Down vK</item>
    /// <item>Up vK</item>
    /// <item>Up mod</item>
    /// </list>
    /// </summary>
    /// <param name="mod">Modifier</param>
    /// <param name="vK">Key</param>
    /// <returns></returns>
    public static uint ClickOneModifier(VKCode mod, VKCode vK) =>
        Functions.SendInput(
            4,
            [
                NewKeyboardInput(mod, KeyEventFlag.KeyDown),
                NewKeyboardInput(vK, KeyEventFlag.KeyDown),
                NewKeyboardInput(vK, KeyEventFlag.KeyUp),
                NewKeyboardInput(mod, KeyEventFlag.KeyUp)
            ],
            _inputSize);

    /// <summary>
    /// The principle of operation:
    /// <list type="number">
    /// <item>Down mod1</item>
    /// <item>Down mod2</item>
    /// <item>Down vK</item>
    /// <item>Up vK</item>
    /// <item>Up mod1</item>
    /// <item>Up mod2</item>
    /// </list>
    /// </summary>
    /// <param name="mod1">Modifier</param>
    /// <param name="mod2">Modifier</param>
    /// <param name="vK">Key</param>
    /// <returns></returns>
    public static uint ClickTwoModifiers(VKCode mod1, VKCode mod2, VKCode vK) =>
        Functions.SendInput(
            6,
            [
                NewKeyboardInput(mod1, KeyEventFlag.KeyDown),
                NewKeyboardInput(mod2, KeyEventFlag.KeyDown),
                NewKeyboardInput(vK, KeyEventFlag.KeyDown),
                NewKeyboardInput(vK, KeyEventFlag.KeyUp),
                NewKeyboardInput(mod1, KeyEventFlag.KeyUp),
                NewKeyboardInput(mod2, KeyEventFlag.KeyUp)
            ],
            _inputSize);

    /// <summary>
    /// The principle of operation:
    /// <list type="number">
    /// <item>Down mod1</item>
    /// <item>Down mod2</item>
    /// <item>Down mod3</item>
    /// <item>Down vK</item>
    /// <item>Up vK</item>
    /// <item>Up mod1</item>
    /// <item>Up mod2</item>
    /// <item>Down mod3</item>
    /// </list>
    /// </summary>
    /// <param name="mod1">Modifier</param>
    /// <param name="mod2">Modifier</param>
    /// <param name="mod3">Modifier</param>
    /// <param name="vK">Key</param>
    /// <returns></returns>
    public static uint ClickThreeModifiers(VKCode mod1, VKCode mod2, VKCode mod3, VKCode vK) =>
        Functions.SendInput(
            6,
            [
                NewKeyboardInput(mod1, KeyEventFlag.KeyDown),
                NewKeyboardInput(mod2, KeyEventFlag.KeyDown),
                NewKeyboardInput(mod3, KeyEventFlag.KeyDown),
                NewKeyboardInput(vK, KeyEventFlag.KeyDown),
                NewKeyboardInput(vK, KeyEventFlag.KeyUp),
                NewKeyboardInput(mod1, KeyEventFlag.KeyUp),
                NewKeyboardInput(mod2, KeyEventFlag.KeyUp),
                NewKeyboardInput(mod3, KeyEventFlag.KeyUp)
            ],
            _inputSize);

    /// <summary>
    /// Presses and holds the button down for a while.
    /// </summary>
    /// <param name="vK">Virtual keycode.</param>
    /// <param name="duration">Holding time in the pressed state</param>
    /// <param name="token">Cancellation token</param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static async Task<uint> LongClick(VKCode vK, int duration, CancellationToken token = default)
    {
        if (duration is < 0 or >= int.MaxValue)
            throw new ArgumentOutOfRangeException(nameof(duration), "duration < 0 or >= int.MaxValue");
        var res = 0u;
        res += Functions.SendInput(1, [NewKeyboardInput(vK, KeyEventFlag.KeyDown)], _inputSize);

        try
        {
            await Task.Delay(duration, token);
        }
        catch (OperationCanceledException)
        { }
        catch
        {
            throw;
        }

        res += Functions.SendInput(1, [NewKeyboardInput(vK, KeyEventFlag.KeyUp)], _inputSize);

        return res;
    }
    /// <summary>
    /// Presses and holds the button down for a while.
    /// </summary>
    /// <param name="vK">Virtual keycode.</param>
    /// <param name="duration">Holding time in the pressed state</param>
    /// <param name="token">Cancellation token</param>
    /// <returns></returns>
    public static async Task<uint> LongClick(VKCode vK, TimeSpan duration, CancellationToken token = default)
    {
        var res = 0u;
        res += Functions.SendInput(1, [NewKeyboardInput(vK, KeyEventFlag.KeyDown)], _inputSize);

        try
        {
            await Task.Delay(duration, token);
        }
        catch (OperationCanceledException)
        { }
        catch
        {
            throw;
        }

        res += Functions.SendInput(1, [NewKeyboardInput(vK, KeyEventFlag.KeyUp)], _inputSize);

        return res;
    }

    public static async Task<uint> RepeatClickByCount(VKCode vK, int repeatsCount, TimeSpan interval, CancellationToken token = default)
    {
        if (repeatsCount is < 0 or >= int.MaxValue)
            throw new ArgumentOutOfRangeException(nameof(interval), "repeatsCount < 0 or >= int.MaxValue");
        var res = 0u;
        try
        {
            for (int i = 0; i < repeatsCount; i++)
            {
                res += Functions.SendInput(1, [NewKeyboardInput(vK, KeyEventFlag.KeyDown), NewKeyboardInput(vK, KeyEventFlag.KeyUp)], _inputSize);
                await Task.Delay(interval, token);
                token.ThrowIfCancellationRequested();
            }
        }
        catch (OperationCanceledException)
        { }
        catch
        {
            throw;
        }

        return res;
    }

    public static async Task<uint> RepeatClickByCount(VKCode vK, int repeatsCount, int interval, CancellationToken token = default)
    {
        if (interval is < 0 or >= int.MaxValue)
            throw new ArgumentOutOfRangeException(nameof(interval), "interval < 0 or >= int.MaxValue");
        if (repeatsCount is < 0 or >= int.MaxValue)
            throw new ArgumentOutOfRangeException(nameof(interval), "repeatsCount < 0 or >= int.MaxValue");
        var res = 0u;
        try
        {
            for (int i = 0; i < repeatsCount; i++)
            {
                res += Functions.SendInput(2, [NewKeyboardInput(vK, KeyEventFlag.KeyDown), NewKeyboardInput(vK, KeyEventFlag.KeyUp)], _inputSize);
                await Task.Delay(interval, token);
                token.ThrowIfCancellationRequested();
            }
        }
        catch (OperationCanceledException)
        { }
        catch
        {
            throw;
        }

        return res;
    }


    public static async Task<uint> RepeatClickByTime(VKCode vK, TimeSpan duration, TimeSpan interval, CancellationToken token = default)
    {
        var res = 0u;
        using var cts = new CancellationTokenSource();
        cts.CancelAfter(duration);
        try
        {
            while (!cts.Token.IsCancellationRequested && !token.IsCancellationRequested)
            {
                res += Functions.SendInput(1, [NewKeyboardInput(vK, KeyEventFlag.KeyDown), NewKeyboardInput(vK, KeyEventFlag.KeyUp)], _inputSize);
                await Task.Delay(interval, token);
                token.ThrowIfCancellationRequested();
            }
        }
        catch (OperationCanceledException)
        { }
        catch
        {
            throw;
        }

        return res;
    }

    public static async Task<uint> RepeatClickByTime(VKCode vK, int duration, int interval, CancellationToken token = default)
    {
        if (duration is < 0 or >= int.MaxValue)
            throw new ArgumentOutOfRangeException(nameof(duration), "duration < 0 or >= int.MaxValue");
        if (interval is < 0 or >= int.MaxValue)
            throw new ArgumentOutOfRangeException(nameof(interval), "interval < 0 or >= int.MaxValue");
        var res = 0u;
        using var cts = new CancellationTokenSource();
        cts.CancelAfter(duration);
        try
        {
            while (!cts.Token.IsCancellationRequested && !token.IsCancellationRequested)
            {
                res += Functions.SendInput(1, [NewKeyboardInput(vK, KeyEventFlag.KeyDown), NewKeyboardInput(vK, KeyEventFlag.KeyUp)], _inputSize);
                await Task.Delay(interval, token);
                token.ThrowIfCancellationRequested();
            }
        }
        catch (OperationCanceledException)
        { }
        catch
        {
            throw;
        }

        return res;
    }


    private static Input NewKeyboardInput(VKCode code, KeyEventFlag flag) => new()
    {
        Type = InputType.Keyboard,
        Union = new InputUnion()
        {
            ki = new()
            {
                wVk = (ushort)code,
                wScan = 0,
                dwFlags = flag,
                dwExtraInfo = Functions.GetMessageExtraInfo(),
            }
        }
    };

    private static Input NewKeyboardInput(char unicode, KeyEventFlag flag) =>
        new()
        {
            Type = InputType.Keyboard,
            Union = new InputUnion()
            {
                ki = new()
                {
                    wVk = unicode,
                    wScan = 0,
                    dwFlags = flag | KeyEventFlag.Unicode,
                    dwExtraInfo = Functions.GetMessageExtraInfo(),
                }
            }
        };

    private static Input NewKeyboardInput(ushort scanCode, KeyEventFlag flag) =>
        new()
        {
            Type = InputType.Keyboard,
            Union = new InputUnion()
            {
                ki = new()
                {
                    wVk = 0,
                    wScan = scanCode,
                    dwFlags = flag | KeyEventFlag.Scancode,
                    dwExtraInfo = Functions.GetMessageExtraInfo(),
                }
            }
        };

    #region MAP KEY CODES

    /// <summary>
    /// Map scan code to virtual code
    /// <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeya">See more info.</a>
    /// </summary>
    public static VKCode MapScanCodeToVirtualCode(ushort scanCode) =>
        (VKCode)Functions.MapVirtualKeyA(scanCode, MapType.ScanCodeToVirtualKey);

    /// <summary>
    /// Map virtual code to scan code
    /// <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeya">See more info.</a>
    /// </summary>
    public static ushort MapVirtualCodeToScanCode(VKCode scanCode) =>
        Functions.MapVirtualKeyA((ushort)scanCode, MapType.VirtualCodeToScanCode);

    /// <summary>
    /// Map scan code to virtual code
    /// <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeya">See more info.</a>
    /// </summary>
    public static VKCode MapScanCodeToVirtualCodeEx(ushort scanCode) =>
        (VKCode)Functions.MapVirtualKeyA(scanCode, MapType.ScanCodeToVirtualKeyEx);
    /// <summary>
    /// Map virtual code to scan code
    /// <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeya">See more info.</a>
    /// </summary>
    public static ushort MapVirtualCodeToScanCodeEx(VKCode scanCode) =>
        Functions.MapVirtualKeyA((ushort)scanCode, MapType.VirtualKeyToScanCodeEx);

    /// <summary>
    /// Map virtual code to char
    /// <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeya">See more info.</a>
    /// </summary>
    public static char MapVirtualCodeToChar(VKCode scanCode) =>
        (char)Functions.MapVirtualKeyA((ushort)scanCode, MapType.VirtualKeyToChar);
    #endregion
}
