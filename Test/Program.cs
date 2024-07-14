using ASiNet.Win.IO;


Console.WriteLine("Start\n");

Console.WriteLine("Delay - 5s");
await Task.Delay(5000);

Console.WriteLine("Down - VK -> VK.A\n");
KeyboardInput.PressKey(VKCode.A);

Console.WriteLine("Delay - 500ms");
await Task.Delay(500);

Console.WriteLine("Up - VK -> VK.A\n");
KeyboardInput.UpKey(VKCode.A);

Console.WriteLine("Delay - 1s");
await Task.Delay(1000);

Console.WriteLine("Click - VK -> VK.B\n");
KeyboardInput.ClickKey(VKCode.B);

Console.WriteLine("Delay - 1s");
await Task.Delay(1000);

Console.WriteLine("Click - Unicode -> Char.C\n");
KeyboardInput.ClickKey('C');

Console.WriteLine("Delay - 1s");
await Task.Delay(1000);

Console.WriteLine("Click - ScanCode -> VkToScanCode - VK.D\n");
KeyboardInput.ClickKey(KeyboardInput.MapVirtualCodeToScanCode(VKCode.D));

Console.WriteLine("Delay - 1s");
await Task.Delay(1000);

Console.WriteLine("Click - Mod - VK -> VK.Shift + VK.E\n");
KeyboardInput.ClickOneModifier(VKCode.Shift, VKCode.E);

Console.WriteLine("Delay - 1s");
await Task.Delay(1000);

Console.WriteLine("Click - Long - VK -> VK.F");
await KeyboardInput.LongClick(VKCode.F, 2000);
Console.WriteLine("[Long:OK]\n");

Console.WriteLine("Delay - 1s");
await Task.Delay(1000);

Console.WriteLine("Click - Repeat - by count - VK -> VK.G");
await KeyboardInput.RepeatClickByCount(VKCode.G, 10, 100);
Console.WriteLine("[Long:OK]\n");

Console.WriteLine("Delay - 1s");
await Task.Delay(1000);

Console.WriteLine("Click - Repeat - by time - VK -> VK.G");
await KeyboardInput.RepeatClickByTime(VKCode.J, 1000, 100);
Console.WriteLine("[Long:OK]\n");

Console.WriteLine("Delay - 1s");
await Task.Delay(1000);

Console.WriteLine("Click - Long - Canceled - VK -> VK.H");
using var cts = new CancellationTokenSource();
cts.CancelAfter(2000);
await KeyboardInput.LongClick(VKCode.H, 30_000, cts.Token);
Console.WriteLine("[Long:OK]\n");


Console.WriteLine("End\n");

Console.WriteLine("Maps:");

Console.WriteLine($"* {VKCode.A} [VkToScan]-> {KeyboardInput.MapVirtualCodeToScanCode(VKCode.A)}");
Console.WriteLine($"* {VKCode.B} [VkToScan]-> {KeyboardInput.MapVirtualCodeToScanCode(VKCode.B)}");
Console.WriteLine($"* {VKCode.C} [VkToScan]-> {KeyboardInput.MapVirtualCodeToScanCode(VKCode.C)}");
Console.WriteLine($"* {VKCode.D} [VkToScan]-> {KeyboardInput.MapVirtualCodeToScanCode(VKCode.D)}");
Console.WriteLine($"* {VKCode.E} [VkToScan]-> {KeyboardInput.MapVirtualCodeToScanCode(VKCode.E)}");
Console.WriteLine($"* {VKCode.F} [VkToScan]-> {KeyboardInput.MapVirtualCodeToScanCode(VKCode.F)}");
Console.WriteLine($"* {VKCode.Shift} [VkToScan]-> {KeyboardInput.MapVirtualCodeToScanCode(VKCode.Shift)}");
Console.WriteLine($"* {VKCode.C} [VkToChar]-> {KeyboardInput.MapVirtualCodeToChar(VKCode.C)}");



Console.WriteLine("Press any key to exit...\n");
Console.ReadKey();