using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helper
{
    internal class BatteryHelper
    {     
        LiionBattery _objLiionBattery = new LiionBattery();
        
        public BatteryHelper(float temp, float soc, float chargeRate)
        {
            _objLiionBattery.Temperature = temp;
            _objLiionBattery.Soc = soc;
            _objLiionBattery.ChargeRate = chargeRate;
        }

        public bool IsChargeRateInRange(float chargeRate)
        {
             if (_objLiionBattery.ChargeRate > 0.8)
                return false;
              else
                return true;
        }

        private bool IsSOCInRange(float soc)
        {
            if (_objLiionBattery.Soc < 20 || _objLiionBattery.Soc > 80)
                return false;
              else
                return true;
        }

        private bool IsTempInRange(double temperature)
        {
            if (_objLiionBattery.Temperature < 0 || _objLiionBattery.Temperature > 45)
                return false;
            else
                return true;
        }
        
        private void OutputInformation(string message)
        {
            try
            {
              Console.WriteLine(message);
            }
            catch(Exception ex)
            {
              throw ex;
            }
        }
        internal bool IsBatteryIsOk()
        {
             if (!IsTempInRange(_objLiionBattery.Temperature))
              {
                  OutputInformation("Temperature is out of range!");
                  return false;
              }
              else if (!IsSOCInRange(_objLiionBattery.Soc))
              {
                  OutputInformation("State of Charge is out of range!");
                  return false;
              }
              else if (!IsChargeRateInRange(_objLiionBattery.ChargeRate))
              {
                  OutputInformation("Charge Rate is out of range!");
                  return false;
              }
            return true;
        }
    }
}
