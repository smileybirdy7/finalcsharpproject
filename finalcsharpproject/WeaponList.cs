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

}
     
    
       

     
    
        
    
