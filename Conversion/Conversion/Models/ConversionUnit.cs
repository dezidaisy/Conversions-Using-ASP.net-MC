using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conversion
{
    public class ConversionUnit
    {
        public double celsius { get; set; }
        public double fahrenheit { get; set; }
        public double meters { get; set; }
        public double feet { get; set; }
        public double kg { get; set; }
        public double pounds { get; set; }
        public void tcelsius()
        {
            celsius = (fahrenheit - 32)/1.8;
           
        }
        public void tfahrenheit()
        {
            fahrenheit = (celsius * 1.8)+32;
            
        }
        public void lmeters()
        {
            meters = feet * 0.3048;
  
        }
        public void lfeet()
        {
            feet = meters / 0.3048;
            
        }
        public void wkg()
        {
            kg = pounds * 0.45359237;
            
        }
        public void wpounds()
        {
            pounds = kg / 0.45359237;
            
        }



    }
}
