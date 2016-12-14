using System;
using System.Collections.Generic;

public class IfStatement : IntroductionFunction
{
    bool characterName = true;
    bool characterPower = true;

    public void Check()
    {
        //If the character matches his or her power use that same character with their power.
        if (characterName = characterPower)
        {
            Console.WriteLine("Use the character with his or her equal power");
        }
        //If the character doesn't match his or her power don't use that certain power.
        else
        {
            Console.WriteLine("Don't use a different characters power with another character.");
        }
    }

}

public class ForeachLoop : Character
{


    void Character()
    {
        string[] character = new string[4];

        character[0] = "Sleeping Beauty";
        character[1] = "Alice";
        character[2] = "Jack Skeleton";
        character[3] = "Captain Jack Sparrow";

        foreach (string item in character)
        {
            Console.WriteLine(item);
        }
    }

}

public class CharacterList
{
    private void ChangeList(string name, int character)
    {


        string characterName = Console.ReadLine();
        string characterPower = (Console.ReadLine());
        listOfCharacter.Add(newCharacter);
    }

    Character newCharacter = new Character();

    //List
    public List<Character> listOfCharacter;

    public void RunList()
    {
        listOfCharacter.Add(new Character());
        ChangeList("Sleeping Beauty", 0);


    }

}
public class Character
{

    public class Array : Character
    {
        string[] myCharacterArray = { "Sleeping Beauty", "Alice", "Jack Skeleton", "Captain Jack Sparrow" };


        public class CharacterScript : Character
        {
            public int characters = 4;

            void CharacterCollection()
            {
                switch (characters)
                {
                    case 4:
                        Console.WriteLine("Your character is Sleeping Beauty, who loves to fall asleep anywhere she can.");
                        break;
                    case 3:
                        Console.WriteLine("Your character is Alice, who let's her curiosity get the better of her.");
                        break;
                    case 2:
                        Console.WriteLine("Your third character is Jack Skeleton, who has some clever ideas and schemes.");
                        break;
                    case 1:
                        Console.WriteLine("Your fourth character is Captain Jack Sparrow, who has a very good taste for adventure.");
                        break;
                    default:
                        Console.WriteLine("If you do not select one of the four characters, you will not be able to proceed in the game.");
                        break;
                }

            }
        }
    }
}







