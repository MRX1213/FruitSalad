using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsaladLibrary
{
    public class Strawberry : Fruit
    {
        public bool IsItGoodForJam { get; set; }
        public int SweetnessLevel { get; set; }
        public Strawberry(string color, double weight, bool isOrganic, bool isItGoodForJam, int sweetnessLevel): 
            base ("Strawberry", color, weight, isOrganic)
        {
            SweetnessLevel = sweetnessLevel;
            IsItGoodForJam = isItGoodForJam;
        }
        // implementation of Describe() Method
        public override string Describe()
        {
            string jam_lable = IsItGoodForJam ? "Good for Jam" : "Not good for jam (may kill you)";
            return $"{base.ToString()}, Sweetness level: {SweetnessLevel}, {jam_lable}";
        }
    }
}
