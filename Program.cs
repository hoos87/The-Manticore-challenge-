﻿
/* ==The Four Sisters and the DuckBear Challenge==

Console.WriteLine("Hello! Please enter the number of chocolate egss you have harvested today");
string eggHarvestedToday = Console.ReadLine(); 
int eggHarvestedNum = Convert.ToInt32(eggHarvestedToday);

int remainder = eggHarvestedNum % 4;

int eggPerSister = (eggHarvestedNum - remainder) / 4;
Console.WriteLine("Each sister will get {0} eggs today! The number of eggs going to the Duckbear = {1}", eggPerSister, remainder); 

*/


/* ==The Dominion of Kings Challenge==

int provinceNumber = 0;
int duchiesNumber = 0;

int estatesNumber = 0;

Console.WriteLine("Hello Lord, please enter the number of provinces you hold.");
string provinceCount = Console.ReadLine();
int provinceCountNum = Convert.ToInt32(provinceCount); // Convert from string to int
provinceNumber = provinceCountNum;
Console.WriteLine("Thank you.");

Console.WriteLine("Now please enter the number of duchies you hold.");
string duchiesCount = Console.ReadLine();
int duchiesCountNum = Convert.ToInt32(duchiesCount);
duchiesNumber = duchiesCountNum;
Console.WriteLine("Thank you.");

Console.WriteLine("And finally, please enter the number of estates you hold.");
string estatesCount = Console.ReadLine();
int estatesCountNum = Convert.ToInt32(estatesCount);
estatesNumber = estatesCountNum;
Console.WriteLine("Thank you.");


provinceNumber *= 6;
duchiesNumber *= 3;
estatesNumber *= 1;

int totalScore = provinceNumber + duchiesNumber + estatesNumber;
Console.WriteLine("Lord! your total score is {0}", totalScore); 

*/


/* ==Repaiting the Clocktower==
  
string clockInputText = Console.ReadLine();
int clockInput = Convert.ToInt32(clockInputText);


int clockEvenOrN = clockInput % 2;



if (clockEvenOrN == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}
*/


/* ==Watchtower==


Console.WriteLine("Give me the x coordinate!");
string xCoordinate = Console.ReadLine();
Console.WriteLine("Now give me the y coordinate!");
string yCoordinate = Console.ReadLine();

if (xCoordinate == "x<0" && yCoordinate == "y>0")
{
    Console.WriteLine("The enemy is NW!");
}
if (xCoordinate == "x=0" && yCoordinate == "y>0")
{
    Console.WriteLine("The enemy is N!");
}
if (xCoordinate == "x>0" && yCoordinate == "y>0")
{
    Console.WriteLine("The enemy is NE!");
}
if (xCoordinate == "x<0" && yCoordinate == "y=0")
{
    Console.WriteLine("The enemy is W!");
}
if (xCoordinate == "x=0" && yCoordinate == "y=0")
{
    Console.WriteLine("The enemy is HERE!!!");
}
if (xCoordinate == "x>0" && yCoordinate == "y=0")
{
    Console.WriteLine("The enemy is E!");
}
if (xCoordinate == "x<0" && yCoordinate == "y<0")
{
    Console.WriteLine("The enemy is SW!");
}
if (xCoordinate == "x=0" && yCoordinate == "y<0")
{
    Console.WriteLine("The enemy is S!");
}
if (xCoordinate == "x>0" && yCoordinate == "y<0")
{
    Console.WriteLine("The enemy is SE!");
}
*/


/* ==Watchtower== Ver.2.0


Console.WriteLine("Please give the x coordinate value");
int xInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now the y coordinate value");
int yInput = Convert.ToInt32(Console.ReadLine());

if(xInput < 0 && yInput > 0) Console.WriteLine("They are NW!!");
if(xInput == 0 && yInput > 0) Console.WriteLine("They are N!!");
if(xInput > 0 && yInput > 0) Console.WriteLine("They are NE!!");
if(xInput < 0 && yInput == 0) Console.WriteLine("They are W!!");
if(xInput == 0 && yInput == 0) Console.WriteLine("They are here!!");
if(xInput > 0 && yInput == 0) Console.WriteLine("They are E!!");
if(xInput < 0 && yInput < 0) Console.WriteLine("They are SW!!");
if(xInput == 0 && yInput < 0) Console.WriteLine("They are S!!");
if(xInput > 0 && yInput < 0) Console.WriteLine("They are SE!!");
*/


/* ==Buying Inventory==

Console.WriteLine("Here is a list of my inventory");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torch");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supply");
Console.WriteLine("Which number do you want to see the price of?");
int itemNumber = Convert.ToInt32(Console.ReadLine());

string itemName = itemNumber switch
{
    1 => "Rope",
    2 => "Torch",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supply",
};

int itemPrice = itemName switch
{
    "Rope" => 10,
    "Torch" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supply" => 1,
};

Console.WriteLine("the {0} costs {1} gold", itemName, itemPrice);
*/

/* ==Discounted Inventory==

string playerName = "hoos";


Console.WriteLine("Here is a list of my inventory");
if (playerName == "hoos")
{
    Console.WriteLine("Ah! {0}! It is good to see you! Please accept a 50% discount on all items as thanks for helping me earlier!", playerName);
}
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torch");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supply");
Console.WriteLine("Which number do you want to see the price of?");
int itemNumber = Convert.ToInt32(Console.ReadLine());

string itemName = itemNumber switch
{
    1 => "Rope",
    2 => "Torch",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supply",
};

int itemPrice = itemName switch
{
    "Rope" => 10,
    "Torch" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supply" => 1,
};

if (playerName == "hoos")
{
    float discountItem = itemPrice / 2;
    Console.WriteLine("For you the {0} costs {1} gold", itemName, discountItem); // Option one for displaying variable inside a Console.WriteLine
    Console.WriteLine($"For you the {itemName} costs {discountItem} gold");      // Option two for displaying variable inside a Console.WriteLine
}
else
Console.WriteLine("the {0} costs {1} gold", itemName, itemPrice);

*/


// Console.Clear(); - this clears the console



/* == The Prototype==

int pilotNumber; // This variable has been set now so that it is accessible in the "do"


do
{
    Console.WriteLine("Hello Pilot, please choose a number between 1 and 100");
    pilotNumber = Convert.ToInt32(Console.ReadLine());
    if (pilotNumber < 0 || pilotNumber > 100)
    {
        Console.WriteLine("The given number is out of range, please try again");
    }
    else if( pilotNumber >= 0 || pilotNumber <= 100)
    {
        Console.WriteLine("Thank you");
    }
}
while (pilotNumber < 0 || pilotNumber > 100) ;

Console.Clear(); // Clears screen for next user to now input guess

int hunterGuess; // This variable has been set now so that it is accessible in the "do"

do
{
    Console.WriteLine("Hello Hunter! Try and guess a number between 0 and 100");
    hunterGuess = Convert.ToInt32(Console.ReadLine());

    if (hunterGuess > pilotNumber)
        Console.WriteLine("You guessed too high! Please try again.");

    if (hunterGuess < pilotNumber)
        Console.WriteLine("You guessed too low! Please try again.");

    if (hunterGuess == pilotNumber)
        Console.WriteLine("Yes! You got em!");

}
while (hunterGuess > pilotNumber || hunterGuess < pilotNumber);

*/

/* ==The Magic Cannon==

for (int cannonNumber = 1; cannonNumber <= 100; cannonNumber++)
{

    

    if (cannonNumber % 5 == 0 && cannonNumber % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{cannonNumber}: Electric and Fire");
    } 
    else if (cannonNumber % 5 == 0)
    { 
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{cannonNumber}: Electric");
    }
    else if (cannonNumber % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{cannonNumber}: Fire");
    }   
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"{cannonNumber}: Normal");
    }


}
*/

/* int[] highScore = new int[10]; // created an array named "highScore" that can hold 10 elements.

// If we wish to assign a value to one of the elements within the array do the following:
highScore[0] = 5; // the number inside the square brackets is the position of the element within the array
highScore[1] = 6;
highScore[2] = 7;
highScore[3] = 8;
highScore[4] = 9;
highScore[5] = 10;
highScore[6] = 11;
highScore[7] = 12;
highScore[8] = 13;
highScore[9] = 14;


Console.WriteLine(highScore[0]);
Console.WriteLine(highScore[1]);
Console.WriteLine(highScore[2]);    
Console.WriteLine(highScore[3]); 
Console.WriteLine(highScore[4]);
Console.WriteLine(highScore[5]);
Console.WriteLine(highScore[6]);
Console.WriteLine(highScore[7]);
Console.WriteLine(highScore[8]);
Console.WriteLine(highScore[9]); 


int[] firstThreeScores = highScore[0..6]; // when creating a new array and copying in a range, the size / number of elements will match the size of the range being copied in
Console.WriteLine(firstThreeScores[0]);
Console.WriteLine(firstThreeScores[1]);
Console.WriteLine(highScore.Length);
Console.WriteLine(firstThreeScores.Length);
*/


/*
int userSizeArray = Convert.ToInt32(Console.ReadLine());


int[] array = new int[userSizeArray];
Console.WriteLine("array length is equal to {0}",array.Length);

for (int index = 0; index < array.Length; index++) // Initialisation is int index variable set to 0; condition index < array.Length which is set by user input, this will stop the loop before exceeding array limit; increment index number +1 per loop
{
    array[index] = 3;                              // This is the same as saying array[0] = 1
    Console.WriteLine(array[index]);
    Console.WriteLine("I'm the value assigned to index {0}", index);
}

*/

/*
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue;
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < currentSmallest)
    {
        currentSmallest = array[index]; // currentSmallest value is being replaced by the value stored in each index IF the value is smaller than currentSmallest's value
    }

}

Console.WriteLine(currentSmallest); 
*/
/*
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int total = 0;
for (int index = 0; index < array.Length; index++)
{
    total += array[index];
}

float avarage = total / array.Length;
Console.WriteLine(avarage);
*/

/*
Console.WriteLine("Hero! Please create an array that can hold 5 elements!!");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[arraySize];
int numberOne = 1;

for (int index = 0; index < arraySize; index++)
{
    Console.WriteLine($"Please enter a value for number {numberOne++}");
    int userValue = Convert.ToInt32(Console.ReadLine());
    myArray[index] = userValue;
}


int[] arrayCopy = new int[5];

for (int indexCopy = 0; indexCopy < 5; indexCopy++)
{
    arrayCopy[indexCopy] = myArray[indexCopy];
}

for (int indexReview = 0; indexReview < 5; indexReview++)
{
    Console.WriteLine($"{myArray[indexReview]} and {arrayCopy[indexReview]}");

}
*/
/*
Console.WriteLine("Hero! Please create an array that can hold 5 elements!!");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[arraySize];
int numberOne = 1;


for (int index = 0; index < arraySize; index++)
{
    Console.WriteLine($"Please enter a value for number {numberOne++}");
    int userValue = Convert.ToInt32(Console.ReadLine());
    myArray[index] = userValue;
}

int[] arrayCopy = myArray[0..5];
// int[] arrayCopy = new int[5];

/*for (int indexCopy = 0; indexCopy < 5; indexCopy++)
{
    arrayCopy[indexCopy] = myArray[indexCopy];
}


for (int indexReview = 0; indexReview < 5; indexReview++)
{
    Console.WriteLine($"{myArray[indexReview]} and {arrayCopy[indexReview]}");

}
*/
/*int UserNumber = AskForNumber("Hello, please give me a number");
Console.WriteLine(UserNumber);  



int AskForNumber(string question)
{
    Console.WriteLine(question);
    int numberToReturn = Convert.ToInt32(Console.ReadLine());
    
    
    return (numberToReturn);

}


int min = 4;
int max = 500;
Console.WriteLine("Enter a number between {0} and {1}", min, max);
int userInput = Convert.ToInt32(Console.ReadLine());
AskNumberInRange(userInput, min, max);







int AskNumberInRange(int userNumber, int min, int max)
{
    while (userNumber < min && userNumber > max)
    {

        if (userNumber >= min && userNumber <= max)
        {
            return userNumber;
        }

        else
        {
            Console.WriteLine("please enter a number between {0} and {1}", min, max);
            userNumber = Convert.ToInt32(Console.ReadLine());
        }
        
    }


}
*/


/*
int number = AskForNumberInRange("User 1, enter a number between 0 and 100:", 0, 100);

Console.Clear();

Console.WriteLine("User 2, guess the number.");

while (true)
{
    int guess = AskForNumber("What is your next guess?");
    if (guess > number) Console.WriteLine($"{guess} is too high.");
    else if (guess < number) Console.WriteLine($"{guess} is too low.");
    else break;
}

Console.WriteLine("You guessed the number!");


int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number <= max)
            return number;
    }
}

*/


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

 
    







