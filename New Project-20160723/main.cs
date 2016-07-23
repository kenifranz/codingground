using System.IO;
using System;
public class UnitConverter{
    int ratio;//field
    public UnitConverter(int unitRatio){
        ratio = unitRatio;//constructor
    }
    public int Convert(int unit){
        return unit*ratio;//method
    }
    class Test{
        static void Main(){
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);
            
            Console.WriteLine(feetToInchesConverter.Convert(30)); //360
            Console.WriteLine(feetToInchesConverter.Convert(100)); //1200
            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1))); ///63360
        }
    }
}