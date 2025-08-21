using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseOpgaver
{
    public enum boxType
    {
        None = 0,
        lille=1,
        mellem=2,
        stor=3,
    }
    public class Box : IComparable<Box>
    {
        public double Højde { get; set; }
        public boxType Type { get; set; }
        public double Bredde { get; set; }
        public double Længde { get; set; }

        public Box() { 
        
        }
        public Box(double højde, double bredde, double længde, boxType type)
        {
            Højde = højde;
            Bredde = bredde;
            Længde= længde;
            Type = type;
        }
        public override string ToString()
        {
            string retur = $"Højde: {Højde}\nBredde: {Bredde}\nLængde: {Længde}\n{Type}";
            return retur;
        }
        public double GetVolume() {
            return Højde * Længde * Bredde;
        }

        public int CompareTo(Box? other)
        {
            return Type.CompareTo(other.Type);
        }

        public static Box operator + (Box box1, Box box2)
        {
            int box1int = (int)box1.Type,
                box2int = (int)box2.Type,
                box3int = box1int + box2int;
            Box newBox = new Box();
            if(box3int > 2)
            {
                newBox.Type = (boxType)3;
            } else newBox.Type = (boxType)box3int;

            newBox.Højde = (box1.Højde + box2.Højde) * 0.95;
            newBox.Bredde = (box1.Bredde + box2.Bredde) * 0.95;
            newBox.Længde = (box1.Længde + box2.Længde) * 0.95;

            return newBox;
        }
    }
}

