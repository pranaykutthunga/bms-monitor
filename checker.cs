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
        LiionBattery _objLiionBattery = new LiionBattery()  
        {  
            Temperature  = 25,   
            Soc  = 70,  
            ChargeRate  = 0.7f
        };  
        ExpectTrue(BatteryHelper.IsBatteryIsOk(_objLiionBattery));
        
        _objLiionBattery = new LiionBattery()  
        {  
            Temperature  = 50,   
            Soc  = 85,  
            ChargeRate  = 0.0f
        };  
        ExpectFalse(BatteryHelper.IsBatteryIsOk(_objLiionBattery));
        
        
        Console.WriteLine("All ok");
        return 0;
    }
}
