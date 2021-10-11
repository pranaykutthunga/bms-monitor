using System;
using System.Diagnostics;
using Helper;

class Checker
{
    static void ExpectTrue(bool expression) {
        if(!expression) {
            BatteryHelper.OutputInformation("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            BatteryHelper.OutputInformation("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(BatteryHelper.IsBatteryIsOk(25, 70, 0.7f));
        ExpectFalse(BatteryHelper.IsBatteryIsOk(50, 85, 0.0f));
        
        
        Console.WriteLine("All ok");
        return 0;
    }
}
