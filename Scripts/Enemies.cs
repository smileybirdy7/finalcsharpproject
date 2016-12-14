using System;

public class Foes
{
    bool enemyName = true;
    bool enemyPower = true;

    public void Check()
    {
        //If the enemy matches his or her power use that same enemy with their power.
        if (enemyName = enemyPower)
        {
            Console.WriteLine("Use the enemy with his or her equal power.");
        }
        //If the enemy doesn't match his or her power don't use that certain power.
        else
        {
            Console.WriteLine("Don't use a different enemy's power with another enemy.");
        }
    }

}

public class forloop : Enemies
{
    int numEnemies = 4;

    //Function with a return.
    public void Enemies()
    {

    }
    int MultiplyByFour(int number)
    {
        int ret;
        ret = number * 4;
        return ret;
    }
}


public class Enemies
{


    void Enemy()
    {
        string[] enemy = new string[4];

        enemy[0] = "Maleficient";
        enemy[1] = "The Red Queen";
        enemy[2] = "The Boogy Man";
        enemy[3] = "Davy Jones";

        foreach (string item in enemy)
        {
            Console.WriteLine(item);
        }
    }

}

public class Enemy
{

    public class Array : Enemies
    {
        string[] myEnemyArray = { "Maleficient", "The Red Queen", "The Boogy Man", "Davy Jones" };

        public class EnemyScript : Enemies
        {
            public int enemies = 4;


            void EnemyVariety()
            {
                switch (enemies)
                {
                    case 4:
                        Console.WriteLine("Your first opponent is Maleficient, who is well-known for putting people to sleep.");
                        break;
                    case 3:
                        Console.WriteLine("Your second opponent is The Red Queen, who is feared for taking peoples heads off for making her mad.");
                        break;
                    case 2:
                        Console.WriteLine("Your third opponent is The Boogy Man, who supposedly is the best poker player in the world.");
                        break;
                    case 1:
                        Console.WriteLine("Your fourth opponent is Davy Jones, who is notorious for taking peoples souls.");
                        break;
                    default:
                        Console.WriteLine("If you do not select one of the four opponents, you will be forced to battle them all.");
                        break;
                }
            }


        }


    }
}

