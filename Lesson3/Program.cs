
//calculates the factorial of a given number using methods. 
//the factorial of a non-negative integer n is the product of all positive integers less than or equal to n. for example, the factorial of 5 (written as 5!) is calculated as 5 x 4 x 3 x 2 x 1 = 120.
//your program should have the following:
//a method called calculatefactorial that takes an integer parameter n and returns the factorial of n.
// the calculatefactorial method should use a loop (e.g., a for loop or a while loop) to calculate the factorial.
//the program should prompt the user to enter a number and call the calculatefactorial method to calculate and display the factorial of the entered number.



using System.Threading.Channels;

using System.Threading.Channels;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


int CalculateFactorial(int n)
{
    int factorial = 1;

    for (int i = 1; i <= n; i++)
    {

        factorial = factorial * i;

    }
    return factorial;
}
Console.WriteLine("factorial: " + CalculateFactorial(5));

// ka 2 hat employee, petq a hashvel irants average salaryn




static int mymethod(int x)
{

    return 3 - x;


}

Console.WriteLine(mymethod(2));
Console.WriteLine(mymethod(1));



1024 hat meshok ka, meki mej 0.8gramnaotsner en , mnatsatsneri mej 1 gramanotsner, mi kshrumov gtnel keghts meshok


using system.componentmodel;

int a = 10;
int b = 5;

Console.WriteLine($"before swapping: a = {a} b = {b}");
swapvalues(ref a, ref b);
Console.WriteLine($"after swapping: a = {a} b = {b}");


static void swapvalues(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

string anun = "armen";
string azganun = "rafayelyan";
Console.WriteLine($"before swapping: anun = {anun} azganun = {azganun}");

swapstrings(ref anun, ref azganun);
Console.WriteLine($"after swapping: anun = {azganun} azganun = {anun}");

string fullname = appendtext(ref anun, ref azganun);

Console.WriteLine($"fullname: {fullname}");

static void swapstrings(ref string anun, ref string azganun)
{
    string firstname = anun;
    anun = azganun;
    azganun = firstname;

}

static string appendtext(ref string anun, ref string azganun)
{
    string fullname = anun + " " + azganun;
    return fullname;
}

int outsidevar = 20;
somefunction(ref outsidevar);


static void somefunction(ref int insidevar)
{

    insidevar = insidevar + 10;
}

Console.WriteLine(outsidevar);

int outsidevar = 20;
somefunction(out outsidevar);


static void somefunction(out int insidevar)
{
    insidevar = 5;
    insidevar = insidevar + 10;
}

Console.WriteLine(outsidevar);

int m = 10;
int n = 15;
int max = max(m, n, out max);
Console.WriteLine("the maximum return value is: {0}", max);

max(m, n, out max);

Console.WriteLine("the maximum value of out is: {0}", max);

maxref(m, n, ref max);
Console.WriteLine("the maximum value of ref is: {0}", max);

Console.Read();
        

        static int Max(int a, int b)
{
    return a > b ? a : b;
}

static void Max(int a, int b, out int max)
{
    //out parameter must be initialized (assigned) inside the method
    //it implies that the out parameter must be changed.

    max = a > b ? a : b;
}

static void maxref(int a, int b, ref int max)
{
    //nothing is done, ref chooses not to change the original value of max
}


string str = "hello";
test(ref str);
Console.WriteLine(str);

Console.read();




static void test(ref string a)
{
    a = "test";
}

Console.WriteLine("please enter user name");
string name = Console.ReadLine();
Console.WriteLine("Please enter password");
string pwd = Console.ReadLine();
string msg;
if (IsLogin(name, pwd, out msg))
{

    //todo
}
Console.WriteLine(msg);


Console.Read();



static bool IsLogin(string name, string pwd, out string msg)
{
    if (name == "andmin" && pwd == "666")
    {
        msg = "login successful!";
        return true;
    }
    else
    {
        msg = "Login failed!";
        return false;
    }
}

