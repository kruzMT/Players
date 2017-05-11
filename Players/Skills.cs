using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    class Skills: Player
    {
    
        public int Speed { get; set; }
        public int Strenght { get; set; }
        public int Stamina { get; set; }
        public int Service { get; set; }
        public int RightHand { get; set; }
        public int LeftHand { get; set; }

        public int NetGame { get; set; }
        public int Mentality { get; set; }

        public int Momentum { get; set; }

        public PitchType Pitch { get; set; }

        public int Competition { get; set; }

       

    }
 public enum PitchType
        {
            grass = 10,
            solid = 20,
            soil = 15,
        }
   
}





