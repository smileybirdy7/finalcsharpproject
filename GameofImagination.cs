using System;
public class IntroductionFunction
{
    string myWelcome = "Welcome gamer to the Game of Imagination. In this game you and your imagination will be playing against the forces of evil.";
}

public class ChoosingACharacter
{
    string myName = "Please select a character.";
}

public class SelectionOfWeapon
{
    string myWeapon = "Please select one of the five weapons. If you don't you will be WEAPONLESS throughout the entire game.";
}

public class ChoiceOfVillian
{
    string myVillian = "Please choose a villian to fight against. Your choices are Maleficient, The Red Queen, The Boogy Man, and Davy Jones. Make sure you choose very wisely.";
}

public class Transportation
{
    string myTransportation = "Please choose one of the transportation options to help you move throughout the game.";
}

public class EndOfGame
{
    bool Defeated = true;
    bool Victorious = true;

    public void Check()
    {
        //If the gamer defeats their opponent they win the game.
        if (Defeated = Victorious)
        {
            Console.WriteLine("Congratulations for successfully defeating your opponent! You have one the game!");
        }
        //If the gamer doesn't defeat his or her opponent they don't win the game.
        else
        {
            Console.WriteLine("Sorry you weren't able to defeat your opponent.");
        }
    }

}









