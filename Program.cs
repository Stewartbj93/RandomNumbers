//Generating Random Numbers
Console.Clear();
Random rnd = new Random();

//Anything within range of System.Int32 (Yknow, that 2billionish number)
int myRandomNumber = rnd.Next();
Console.WriteLine(myRandomNumber);

//When we have option pieces that we can "pass in" or provide to the function it is referred as an "Overload"
//Anything below a specified number
//Single overload means anything below the provided number
int moreSpecificNum = rnd.Next(11);
Console.WriteLine(moreSpecificNum);

//Double Overload
int mostSpecificNum = rnd.Next(500,5000);
Console.WriteLine(mostSpecificNum);

int guess = 0; 
int target = rnd.Next(1, 21);
Console.WriteLine(target);
while(guess != target){
    Console.WriteLine("Try to guess my number!");
    guess = Convert.ToInt32(Console.ReadLine()); 
}
Console.WriteLine("Yay you escaped the loop! My number was " + target);

Random banana = new Random(); 
Console.WriteLine(banana.Next(66,666));

