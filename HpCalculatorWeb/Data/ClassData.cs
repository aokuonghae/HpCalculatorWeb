using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HpCalculatorWeb.Data
{
    public class ClassData
    {
        static public Dictionary<string, string> GetClasses()
        {
            Dictionary<string, string> classChoices = new Dictionary<string, string>();
            classChoices.Add("fighter", "Fighter");
            classChoices.Add("barbarian", "Barbarian");
            classChoices.Add("ranger", "Ranger");
            classChoices.Add("wizard", "Wizard");
            classChoices.Add("sorcerer", "Sorcerer");
            classChoices.Add("rogue", "Rogue");
            classChoices.Add("warlock", "Warlock");
            classChoices.Add("druid", "Druid");
            classChoices.Add("cleric", "Cleric");
            return classChoices;
        }
    }
}
