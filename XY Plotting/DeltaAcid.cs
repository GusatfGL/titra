using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XY_Plotting
{
    class DeltaAcid
    {
        public string Acid { get; set; }
        public double Match
        {
            get
            {
                return Math.Round(FfPKa1 + FfPKa2 + FfMolarMass, 2);
            }
        }
        public double FfPKa1 { get; set; }
        public double FfPKa2 { get; set; }
        public double FfMolarMass { get; set; }
        
    }
}
