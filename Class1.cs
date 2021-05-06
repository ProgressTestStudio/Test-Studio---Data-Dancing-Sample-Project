using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data_Dancing
{
    public class Class1
    
    {
        /// <summary>
        /// Create a random number
        /// </summary>
        /// <param name="min">minimum number</param>
        /// <param name="max">maximum number</param>
        /// <returns>number between min and max</returns>
        public static int RandomNumberGenerator(int min, int max) {
            
            Random rnd = new Random();
            
            int randomProduct = rnd.Next(min, max);
            
            return randomProduct;
            
            
        }
        
        
    }


    
}
