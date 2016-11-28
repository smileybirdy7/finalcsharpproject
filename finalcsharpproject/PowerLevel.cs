using System.Collections.Generic;
public class PowerLevels
{
    private List<string> power;

    
    public void RunList () {
        power = new List<string> ();


    }
}

    private void ChangeList(){
        PowerLevels.Add(Console.WriteLine());
        Console.WriteLine
    }

    public class Array : WeaponBoosts
{
    public GameObject[] weaponboosts;
    {
    int[] myWeaponBoostsArray = {"Invisiblilty", "Unstoppable speed", "Lava", "Shark fins", "Pixie dust"};

    void Start ()
    {
        weaponboosts = GameObject.FindGameObjectsWithTag("WeaponBoost");

        for(int i = 0; i < weaponsboosts.Length; i++)
        {
            Debug.Log("WeaponBoosts Number "+i+" is named " +weaponsboosts[i].name);
            }

    public class PowerBoostScript : OptionalPowerBoost 
    {
        public int boosts = 4;


        void BoostOptions()
        {
            switch (boosts)
            {
            case 5:
                print ("Your first power boost option is invisiblity that allows you to not be seen by your opponent. ");
                break;
            case 4:
                print ("Your second power boost option is unstoppable speed that allows you to not be catched by your opponent.");
                break;
            case 3:
                print ("Your third power boost option is lava that allows you to give your opponent a little heat.");
                break;
            case 2:
                print ("Your fourth power boost option is shark fins that allows you to swim in the water like a shark.");
                break;
            case 1:
                print ("Your fifth and final power boost option is pixie dust that allows you to fly above your opponent.");
            default:
                print ("If you do not select one of the five power boosts options, you will only have your one weapon or just your common sense.");
                break;
                }
