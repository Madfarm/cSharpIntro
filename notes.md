# C#

dotnet new and then the template of choice to get started

> dotnet new console 


add a built-in gitignore
> dotnet new gitignore


> dotnet run

## Getting Started 
in Program.cs,

create a namespace:
namespace <whatever> 
{

}


then inside the namespace make a new class called Program
then make a static method with no return called Main taking in string[] args

namespace <whatever> 
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}


## Strings

strings in C# are immutable, all methods that appear to modify a string actually return a new string instance, including concatenation


## Methods
### Clone() - clones a given string ex:
 
string myStr = "Wow this is a dope language";
string cloned = (string)myStr.Clone();

Type object must be cast to string first



### CompareTo() - checks if two strings are the same, returns 0 for true and 1 for false

example:
 if(cloned.CompareTo("Balls in my mouth") == 0)


### Length property
string.Length

don't forget it's capital!!



### Split() - splits the string into a char array based on a given char

> Splits by every space
string word = "wahtever stuff here"
string[] splitWord = word.Split(' ');


> Splits by a given array of chars
char[] delimiterChars = {' ', ',', '.', ':', '\t'};
string myStr = "one\ttwo three:four,five six seven";

System.Console.WriteLine($"Original string: {myStr} \n");

string[] split = myStr.Split(delimiterChars);

foreach (string item in split)
{
    System.Console.WriteLine(item);
}


strings arrays also work






