using System.Collections.Generic;
using System;

public class EnemyArray
{
    string[] myEnemyArray = {"Maleficient", "the Red Queen", "the Boogy Man", "Davy Jones"};
    }

    public class EnemiesScript: Enemy 
{
    public int foes = 4;

     void EnemyCollection()
    {
        switch (foes)
        {
            case 5:
                print ("Your first opponent is Maleficient, who is famous for putting people to sleep with the prick from the spindle of a spinning wheel. ");
                break;
            case 4:
                print ("Your second opponent is the Red Queen, who is well known for taking off peoples heads for making her angry.");
                break;
            case 3:
                print ("Your third opponent is the Boogy Man, who is one of the best poker placers in the world.");
                break;
            case 2:
                print ("Your fourth opponent is Davy Jones, who is notorious for taking your soul away from you.");
                break;
            default:
                print ("If you do not select one of the five opponents, you will have to battle all five.");
                break;
                }

{
    foreach (string enemy in listOfEnemies)
    {
        Console.WriteLine(enemy.name + "is the name of your enemy.");
        Console.WriteLine(enemy.strength + "is the strength of your enemy.");
        Console.WriteLine(enemy.power + "is the power of your enemy.");
        Console.WriteLine(enemy.weapon + "is the weapon of your enemy.");
        }

        