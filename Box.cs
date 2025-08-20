using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseOpgaver
{
    public enum Størrelse
    {
        lille=1,
        mellem=2,
        stor=3,
    }
    public class Box
    {
        private readonly Størrelse _størrelse;
        public Størrelse Størrelse => _størrelse;
        public Box(Størrelse størrelse)
        {

            _størrelse = størrelse;


            //if (boxtype == "lille") { BoxType = BoxType.lille; }
            //else if (boxtype == "mellem") { BoxType = BoxType.mellem; }
            //else { BoxType = BoxType.stor; }
        }
        //public Box operator +(Box box1, Box box2) {
        //    int  box1int =(int)box1.Størrelse;
            
        //    return new Box box3(box1, box2);
        //}
        //public static Box operator +(Box left, Box right)
        //{
        //    return
        //        }
        //public static Box Create(BoxType boxType) { 
        //return new Box(boxType);
        //}
        //    public static void BoxCalculator(Box(Boxtye) box, Box box2)
        //    {
        //        BoxType boxt2 = box2.BoxType;

        //        Enum box3 = box.BoxType+box2.BoxType;
        //        Box C=new(boxt1+boxt2);
        //        return new Box(Box.BoxType + box2.BoxType);
        //    }
        //}
    }
}

