using System;
public class Vehicles
{
    bool vehicleName = true;
    bool vehicleSpeed = true;

    public void Check()
    {
        //If the gamer chooses from the choices of transportation than they can move on and play the game.
        if (vehicleName = vehicleSpeed)
        {
            Console.WriteLine("Select a vehicle of your choice, but choose wisely because you only get to pick once.");
        }
        //If the gamer doesn't select any of the transportation options than he or she will not be able to move on and play the game.
        else
        {
            Console.WriteLine("If you don't select some kind of transportation than you will not be able to move on and play the game.");
        }
    }

    public class forloop : Transportation
    {
        int numvehicles = 4;

        //Function with a return.
        public void Transportation()
        {

        }
        int MultiplyByFour(int number)
        {
            int ret;
            ret = number * 4;
            return ret;
        }

        public class transportation
        {


            void Transportation()
            {
                string[] vehicle = new string[4];

                vehicle[0] = "A Dragon";
                vehicle[1] = "A Royal Carriage";
                vehicle[2] = "A Tub";
                vehicle[3] = "A Pirate Ship";

                foreach (string item in vehicle)
                {
                    Console.WriteLine(item);
                }
            }

        }

        public class WhileLoop : Transportation
        {
            int numberOfVehicles = 4;
            void vehicle()
            {
                while (numberOfVehicles > 0) ;
            }




            public class Transportation


            {

                public class Array : Vehicles
                {
                    string[] myVehiclesArray = { "A Dragon", "A Royal Carriage", "A Tub", "A Pirate Ship" };

                    public class TransportationScript : Transportation
                    {
                        public int vehicles = 4;


                        void ChoicesOfTransportation()
                        {
                            switch (vehicles)
                            {
                                case 4:
                                    Console.WriteLine("Your first choice of transportation is a dragon that really helps you battle against Maleficient.");
                                    break;
                                case 3:
                                    Console.WriteLine("Your second choice of transportation is a royal carriage that you can ride in luxury on your way to battle against The Red Queen.");
                                    break;
                                case 2:
                                    Console.WriteLine("Your third choice of transportation is a tub that will literally walk you to The Boogy Man's laire.");
                                    break;
                                case 1:
                                    Console.WriteLine("Your last choice of transportation is a pirate ship that you can sail to defeat Davy Jones.");
                                    break;
                                default:
                                    Console.WriteLine("If you do not select one of the four choices of transportation, you will not be able to play this game.");
                                    break;
                            }
                        }
                    }
                }
            }
        }
