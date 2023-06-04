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


## String methods
Clone() - clones a given string ex:
 
string myStr = "Wow this is a dope language";
string cloned = (string)myStr.Clone();


Type object must be cast to string first


