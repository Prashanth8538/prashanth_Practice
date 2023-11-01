using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170F2023
{
    public class Temp
    {
        public string TemperatureConverter(float ambientTemp)
        {
            string outputTemp = "";

            if (ambientTemp >= 30.0f && ambientTemp <= 40.0f)
            {
                outputTemp = "It's Too Hot!!";
            }
            else if (ambientTemp >= 20.0f && ambientTemp <= 29.9f)
            {
                outputTemp = "It's pleasant outside";
            }
            else if (ambientTemp >= 10.0f && ambientTemp <= 19.9f)
            {
                outputTemp = "It's quite comfortable";
            }
            else if (ambientTemp >= 0.0f && ambientTemp <= 9.9f)
            {
                outputTemp = "It's getting cold out there!";
            }
            else
            {
                outputTemp = "Your input temperature is not within the acceptable range";
            }
            return outputTemp;
        }
    }
}