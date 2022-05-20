//Switch
//a statement where we put a value into the () after switch, and then the code will find a match to that value based on the cases given

Console.WriteLine("Please give me a number 1-3");

string userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
    //you can add another case
    case "one":
        Console.WriteLine("You chose the number one.");
        break;
    case "2":
        Console.WriteLine("You chose the number two.");
        break;
    case "3":
        Console.WriteLine("You chose the number three.");
        break;
    default:
        Console.WriteLine("Please choose a number between 1 and 3");
        break;
}

switch (userInput)
{
    default:
        break;
}

/*
if statement syntax of our first case in the above switch case statement:

if (userInput == "1" || userInput == "one")
{
    Console.WriteLine("You chose the number one");
}

 */

//cw tab tab == Console.WriteLine();
//Console.WriteLine("Hello Everyone!");

//Boolean Review
bool one = true;
bool two = false;
bool three = true;

/*
1.
(one && two) --> false

2.
(three || (two && three)) --> true

3.
!two && (!three && (one || two)) || three --> true 
true && false || true

4.
one && two && three --> false

5. 
one || two || three --> true
*/

bool test = one && two && three;
Console.WriteLine(test);



//Loops
bool condition = true;

if (condition)
{
    Console.WriteLine("condition is true");
}

//3 parts of a loop
//start
//condition to check
// a way to stop the loop

//While loop
//int x = 1036;
//while (x >= 1)
//{
//    Console.WriteLine(x);
//    string stop = Console.ReadLine();
//    if (stop == "y")
//    {
//        //the break statement will break out of a loop, but try to do this by setting up a condition rather than using break
//        break;
//    }
//}


//do while loop
//while(x >= 1037)
//{
//    Console.WriteLine(x);
//}

//do
//{
//    Console.WriteLine(x);
//} while (x >= 1037);

//For loop
//task: count to ten
int num = 1;
while (num <= 10)
{
    Console.WriteLine(num);
    num++;
}

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
