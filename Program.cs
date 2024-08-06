//Number Analyzer program

//Variable that keeps the program running endlessly until user wants to exit
bool runProgram = true;

//Ask user for name
Console.WriteLine("Hello! Please enter your name: ");

string name = Console.ReadLine();

//start loop
while (runProgram){

    Console.WriteLine($"Hello, {name}! Please enter an integer between 1 and 100 inclusive:");

    
    int input = int.Parse(Console.ReadLine());
   

    //If statements that analyze the inputted number and determine if it is even, odd, less than 60, etc.
    if (input % 2 == 1 && input < 60){
        Console.WriteLine($"{input} is odd and less than 60");
    }
    else if (input % 2 == 0 && input >= 2 && input <= 24 ){
        Console.WriteLine($"{input} is even and less than 25");
    }
    else if (input % 2 == 0 && input >= 26 && input <= 60){
        Console.WriteLine($"{input} is even and between 26 and 60 inclusive");
    }
    else if (input % 2 == 0 && input > 60){
     Console.WriteLine($"{input} is even and greater than 60");
    }
    else if (input % 2 == 1 && input > 60){
        Console.WriteLine($"{input} is odd and greater than 60");
    }

    while (true){
        Console.WriteLine("Would you like to continue? Please enter y/n or Yes/No");
        
        string loopChoice = Console.ReadLine();
        if (loopChoice == "y" || loopChoice == "Yes"){
            break;
        }
        else if (loopChoice == "n" || loopChoice == "No"){
            runProgram = false;
            Console.WriteLine($"Thank you, {name}! Good bye!")
            break;
        } else{
            Console.WriteLine("Invalid input");
        }
    }
}