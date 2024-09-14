using BatterMonitor;

BatteryMonitor batteryMonitor = new BatteryMonitor(100);

batteryMonitor.BatteryLow += (sender, e) =>
{
    Console.WriteLine("Warning: Battery level is critically low!");
};

for (int i = 100; i >= 0; i -= 10)
{
    Console.WriteLine($"Battery Level: {i}%");
    batteryMonitor.BatteryLevel = i;
    System.Threading.Thread.Sleep(500); 
}