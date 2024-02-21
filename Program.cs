//Extras:
//rounding up the total at POS pickup for chases bar tab


Console.Clear();


//Main

// Priming read
string userChoice = DisplayMenu();
 
// Condition Check
while(userChoice != "4"){
    RouteEm(userChoice);
 
    // update read
    userChoice = DisplayMenu();
}

//End Main


//display menu
static string DisplayMenu(){
    System.Console.WriteLine("1. Convert Units of Measure\n2. Bakery POS\n3. Exit");
    return Console.ReadLine();
}
static void RouteEm(string userChoice){
    switch (userChoice){
        case "1":
            ConvertUnitsOfMeasure();
            break;
        case "2":
            BakeryPOS();
            break; 
        case "3":
            SayBye();
            break;
        default:
            DisplayError();
            break;
    }
}

//unit conversion
static void ConvertUnitsOfMeasure() {
    Console.WriteLine("Would you like to convert to or from Gallons?\n1. To\n2. From");
    int choice = int.Parse(Console.ReadLine());

//Too Gallons
    if (choice == 1) {
        Console.WriteLine("What unit are you converting with?\n1. Quarts\n2. Pints\n3. Cups\n4. Ounces\n5. Tablespoons\n6. Teaspoons");
        int unitChoice = int.Parse(Console.ReadLine());
        double value;
    
        switch (unitChoice) {
            case 1:
                Console.WriteLine("Enter how many quarts.");
                value = double.Parse(Console.ReadLine());
                Console.WriteLine("Your Conversion is " + value / 4 + " Gallons");
                break;
            case 2:
                Console.WriteLine("Enter how many pints.");
                value = double.Parse(Console.ReadLine());
                Console.WriteLine("Your Conversion is " + value / 8 + " Gallons");
                break;
            case 3:
                Console.WriteLine("Enter how many cups.");
                value = double.Parse(Console.ReadLine());
                Console.WriteLine("Your Conversion is " + value / 16 + " Gallons");
                break;
            case 4:
                Console.WriteLine("Enter how many ounces.");
                value = double.Parse(Console.ReadLine());
                Console.WriteLine("Your Conversion is " + value / 128 + " Gallons");
                break;
            case 5:
                Console.WriteLine("Enter how many Tablespoons.");
                value = double.Parse(Console.ReadLine());
                Console.WriteLine("Your Conversion is " + value / 256 + " Gallons");
                break;
            case 6:
                Console.WriteLine("Enter how many teaspoons.");
                value = double.Parse(Console.ReadLine());
                Console.WriteLine("Your Conversion is " + value / 768 + " Gallons");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
    //From gallons
    else if (choice == 2) {
        Console.WriteLine("Enter how many Gallons.");
        double gallons = double.Parse(Console.ReadLine());
        Console.WriteLine("What unit are you converting to?\n1. Quarts\n2. Pints\n3. Cups\n4. Ounces\n5. Tablespoons\n6. Teaspoons");
        int unitChoice = int.Parse(Console.ReadLine());
        double result = 0;

        switch (unitChoice) {
            case 1:
                result = gallons * 4;
                break;
            case 2:
                result = gallons * 8;
                break;
            case 3:
                result = gallons * 16;
                break;
            case 4:
                result = gallons * 128;
                break;
            case 5:
                result = gallons * 256;
                break;
            case 6:
                result = gallons * 768;
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        Console.WriteLine($"Your Conversion is {result} of the selected unit.");
    }
    else {
        Console.WriteLine("Invalid choice.");
    }
}

//bakery POS
static void BakeryPOS() {
    Console.WriteLine("How many cakes would you like?");
    double amountOfCakes = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Your cakes are " + amountOfCakes * 28.63 + " dollars. Would you like delivery or pick up?\n1. Delivery\n2. Pick Up");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 1) {
        Console.WriteLine("Your total is: " + amountOfCakes * 28.63 + "\nDelivery Fee = 4.99\nTax = " + amountOfCakes * 28.63 * 0.07);
    }
    else if (choice == 2) {
        Console.WriteLine("Your Total is " + ((amountOfCakes * 28.63) + ((amountOfCakes * 28.63) * 0.07)) + " \nTip:");
        double tip = double.Parse(Console.ReadLine());
        Console.WriteLine("You tipped: " + tip);
        Console.WriteLine("Would you like to round up for Chase Callahan's Innis Free bar tab?\n1. Yes\n2. No");
        double round = double.Parse(Console.ReadLine());
        //Extra
        if (round == 1) {
        double total = ((amountOfCakes * 28.63) + ((amountOfCakes * 28.63) * 0.07) + tip);
        double roundedTotal = Math.Ceiling(total); //Had help from an upper classman with Math.Ceiling
        Console.WriteLine("Your total is " + roundedTotal);
}
        
        else if (round == 2) {
            Console.WriteLine("You're one of those people...");
        }
        //end Extra
        else {
            Console.WriteLine("Invalid choice.");
        }
    }
    else {
        Console.WriteLine("Invalid choice.");
    }
}


//bye method
static void SayBye(){
    System.Console.WriteLine("Adios!");
}
//  //error method
static void DisplayError(){
    System.Console.WriteLine("Error.");
}