using System.Collections.Generic;
using System;

public class Array : CharacterNames
{
    public GameObject[] characternames;
    {
    int[] myCharacterNameArray = {"Sleeping Beauty", "Alice", "Jack Skeleton", "Captain Jack Sparrow"};
    }

     public class CharacterNameScript : CharacterChoice
    {
        public int names = 4;


        void Characters()
        {
            switch (names)
            {
            case 5:
                print ("Your first character choice is Sleeping Beauty, who loves to fall a sleep whenever she can.");
                break;
            case 4:
                print ("Your second character choice is Alice, who is will always take you on a new adventure with her curiosity.");
                break;
            case 3:
                print ("Your third character choice is Jack Skeleton, who is well known for his grand ideas and schemes.");
                break;
            case 2:
                print ("Your fourth character choice is Captain Jack Sparrow, who is also well known for his sly and mischevious ways of getting out of bad situations.");
                break;
            default:
                print ("If you do not select one of the five characters, you will not have a name at all.");
                break;
                }

    
