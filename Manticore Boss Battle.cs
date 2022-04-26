


// ==The Manticore Boss Battle!==

// We need to set the distance of the Manticore at the start of the app
int manticoreDistance = InitialDistanceOfManticore("Player 1 enter the distance the Manticore is from the city, this can be between 0 and 100", 0, 100);

// To check InitialDistanceOfManticore works correctly
Console.Clear();
Console.WriteLine(manticoreDistance);

// Method to get the distance of the Manticore
int InitialDistanceOfManticore(string question, int min, int max)
{
    while (true)
    {
        Console.WriteLine(question + " ");
        int userDistanceInput = Convert.ToInt32(Console.ReadLine());
        if (userDistanceInput >= min && userDistanceInput <= max)
        {
            return userDistanceInput;
        }
        Console.WriteLine("value entered was outside range");
    }
}

Console.Clear();

//initial values for Manticore and City HP
int startingManticoreHp = 10;
int startingCityHp = 15;

Console.WriteLine("Player 2, it is now your turn");

for (int currentRound = 1; currentRound <= 20; currentRound++)
{
    bool damageDoneToMant = HitTarget("Enter a distance to strike the Manticore", manticoreDistance);
    int totalDamageDone = ElementalDamagePerTurn(damageDoneToMant, currentRound);


    startingManticoreHp -= totalDamageDone;
    if (startingManticoreHp <= 0)
    {
        Console.WriteLine("YOU HAVE WON!"); // Need a way to stop the application once the manticore is destroyed

    }
    
    int currentCityHp = (--startingCityHp);
    if (currentCityHp == 0)
    {
        Console.WriteLine($"City HP:{ currentCityHp}/ 15");
        Console.WriteLine("The city is reduced to rubble! You have lost.");
        break;
    }

    
    Console.WriteLine("----------------------------------");
    Console.WriteLine($" Current round: {currentRound} City HP:{currentCityHp}/15  Manticore HP:{startingManticoreHp}/10");

    // Method to check if the Manticore has been hit or not
    bool HitTarget(string request, int manticoreDistance)
    {
        Console.WriteLine(request);
        int userTarget = Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            if (userTarget == manticoreDistance)
            {
                Console.WriteLine("A direct hit!");
                return true;
            }
            else if (userTarget < manticoreDistance)
            {
                Console.WriteLine("The shot fell too short of the target!");
                return false;
            }
            else if (userTarget > manticoreDistance)
            {

                Console.WriteLine("You overshot the target!");
                return false;
            }
            
        }
    }

    // calling method to calculate final damage
    // int totalDamageDone = ElementalDamagePerTurn(damageDoneToMant, currentRound);
    Console.WriteLine($"You scored {totalDamageDone} damage!"); 

    // Need to fix code below - I keep getting locked out of scope
    int ElementalDamagePerTurn(bool hitSuccess, int roundCount)
    {
        if (damageDoneToMant == true)

        {
            int cannonStatusThree = (roundCount % 3);
            int cannonStatusFive = (roundCount % 5);

            // this needs to be a method that I give parameters to calc damage and return to a more visible area
            if (cannonStatusThree == 0 && cannonStatusFive == 0 && hitSuccess == true)
            {
                return 10;
            }
            else if (cannonStatusThree == 0 || cannonStatusFive == 0 && hitSuccess == true)
            {
                return 3;
            }
            else
                return 1;

        }
        else
            return 0;
    }
}

 
    







