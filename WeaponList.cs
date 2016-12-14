using System.Collections.Generic;
using System;

public class listofWeapon
{
    bool weaponName = true;
    bool weaponType = true;

    public void Check()
    {
        //Use a weapon that matches the power of your character.
        if (weaponName = weaponType)
        {
            Console.WriteLine("Use a weapon that matches your character's power.");
        }
        //Don't use a certain weapon if it doesn't match the power of your character.
        else
        {
            Console.WriteLine("Don't use a certain weapon if it doesn't match your character's power.");
        }
    }

}

public class WhileLoop : Weapon
{
    int weaponsInTheList = 5;


    void Weapon()
    {
        while (weaponsInTheList > 0) ;
    }
}
public class WeaponList
{
    private void ChangeList(string name, int power)
    {

        Weapon newWeapon = new Weapon();
        string Weaponname = Console.ReadLine();
        string Weaponpower = (Console.ReadLine());
        listOfWeapons.Add(newWeapon);
    }

    //List
    public List<Weapon> listOfWeapons;

    public void RunList()
    {
        listOfWeapons = new List<Weapon>();
        ChangeList("Hammer", 10);


    }

}

public class Array : Weapon
{
    string[] myWeaponArray = { "Sword", "Knife", "Torch", "Water", "Wind" };
}

public class WeaponScript : Weapon
{
    public int choices = 5;


    void WeaponSelection()
    {
        switch (choices)
        {
            case 5:
                Console.WriteLine("Your first choice of weaponary is a silver, metal sword.");
                break;
            case 4:
                Console.WriteLine("Your second choice of weaponary is a newly sharpened knife.");
                break;
            case 3:
                Console.WriteLine("Your third choice of weaponary is unextinguishable torch.");
                break;
            case 2:
                Console.WriteLine("Your fourth choice of weaponary is an unlimited amount of water.");
                break;
            case 1:
                Console.WriteLine("Your fifth and final choice of weaponary is wind from Mother Nature herself.");
                break;
            default:
                Console.WriteLine("If you do not select one of the five choices of weaponary, you are left with your own common sense.");
                break;
        }
    }
}









