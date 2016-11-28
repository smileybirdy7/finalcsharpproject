using System.Collections.Generic;
using System;
public class WeaponList
{
    private void ChangeList()

    {
        foreach (string weapon in listOfWeapons)
        {
            //Console.WriteLine(weapon.name + "is the name of your weapon.");
            //Console.WriteLine(weapon.power + "is the power of your weapon.");
        }
        Console.WriteLine(listOfWeapons.Count);

    string newWeapon;
        
        listOfWeapons.Add(newWeapon);
        ChangeList();
    }


    //List
    public List<string> listOfWeapons;

    public void RunList()
    {
        listOfWeapons = new List<string>();

        ChangeList();
    }

    public class Array : Weapons
{
    public GameObject[] weapons;
    {
    int[] myWeaponArray = {"Sword", "Knife", "Torch", "Water", "Wind"};

    void Start ()
    {
        weapons = GameObject.FindGameObjectsWithTag("Weapon");

        for(int i = 0; i < weapons.Length; i++)
        {
            Debug.Log("Weapon Number "+i+" is named " +weapons[i].name);
            }

    public class WeaponScript : ChoiceOfWeaponary
    {
        public int choices = 5;


        void WeaponSelection()
        {
            switch (choices)
            {
            case 5:
                print ("Your first choice of weaponary is a silver, metal sword.");
                break;
            case 4:
                print ("Your second choice of weaponary is a newly sharpened knife.");
                break;
            case 3:
                print ("Your third choice of weaponary is unextinguishable torch.");
                break;
            case 4:
                print ("Your fourth choice of weaponary is an unlimited amount of water.");
                break;
            case 5:
                print ("Your fifth and final choice of weaponary is wind from Mother Nature herself.");
                break;
            default:
                print ("If you do not select one of the five choices of weaponary, you are left with your own common sense.");
                break;
                }


}
     
    
       

     
    
        
    
