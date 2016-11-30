using System.Collections.Generic;
using System;
public class PowerLevels
{
    private List<string> power;

    
    public void RunList () {
        power = new List<string> ();


    }
}

     public class BoostsArray
{
    public int boosts;
    string[] myBoostsArray = {"Invisiblilty", "Unstoppable speed", "Lava", "Shark fins", "Pixie dust"};
    
    public class PowerBoostScript 
    {
        public int boosts = 4;


        void BoostOptions()
        {
            switch (boosts)
            {
            case 5:
                Console.WriteLine ("Your first power boost option is invisiblity that allows you to not be seen by your opponent. ");
                break;
            case 4:
                Console.WriteLine ("Your second power boost option is unstoppable speed that allows you to not be catched by your opponent.");
                break;
            case 3:
                Console.Writeline ("Your third power boost option is lava that allows you to give your opponent a little heat.");
                break;
            case 2:
                Console.WriteLine ("Your fourth power boost option is shark fins that allows you to swim in the water like a shark.");
                break;
            case 1:
                Console.WriteLine ("Your fifth and final power boost option is pixie dust that allows you to fly above your opponent.");
            default:
                Console.WriteLine ("If you do not select one of the five power boosts options, you will only have your one weapon or just your common sense.");
                break;
                }
