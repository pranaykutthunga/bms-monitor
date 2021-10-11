using System;
using System.Diagnostics;
using Helper;

class Checker
{
    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        var batteryHelper =Helper(25, 70, 0.7f);
        ExpectTrue(batteryHelper.IsBatteryIsOk());
        
        var helper =Helper(50, 85, 0.0f);
        ExpectFalse(batteryHelper.IsBatteryIsOk());
        
        
        Console.WriteLine("All ok");
        return 0;
    }
}
