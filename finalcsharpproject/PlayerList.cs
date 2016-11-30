using System.Collections.Generic;
using System;

public class CharacterArray
{
    string[] myCharacterArray = {"Sleeping Beauty", "Alice", "Jack Skeleton", "Captain Jack Sparrow"};
    }

    public class CharacterScript : Character
{
    public int names = 4;

    void CharacterVariety()
    {
        switch (names)
        {
            case 5:
                Console.WriteLine("The first charcter is Sleeping Beauty, who loves to fall asleep whenever she has the chance.");
                break;
            case 4:
                Console.WriteLine("The second character is Alice, who let's her curiosity get the better of her on adventures.");
                break;
            case 3:
                Console.WriteLine("The third character is Jack Skeleton, who is well-known for his ideas and schemes.");
                break;
            case 2:
                Console.WriteLine("The last character is Jack Sparrow, who is notorious for taking his crew on wild quests.");
                break;
            default:
                Console.WriteLine("If you do not select one of the four characters, you will not be able to proceed in the game.");
                break;
        }
    }
}
