


////calculates the factorial of a given number using methods. 
//The factorial of a non-negative integer n is the product of all positive integers less than or equal to n. For example, the factorial of 5 (written as 5!) is calculated as 5 x 4 x 3 x 2 x 1 = 120.

//Your program should have the following:

//A method called CalculateFactorial that takes an integer parameter n and returns the factorial of n.
//The CalculateFactorial method should use a loop (e.g., a for loop or a while loop) to calculate the factorial.
//The program should prompt the user to enter a number and call the CalculateFactorial method to calculate and display the factorial of the entered number.



//using System.Threading.Channels;


//int CalculateFactorial(int n)
//{ 
//int factorial = 1;

//    for (int i =1; i <= n; i++) 
//    {

//    factorial = factorial * i;

//    }
//    return factorial;
//}
//Console.WriteLine("factorial: " + CalculateFactorial(5));

//ka 2 hat employee, petq a hashvel irants average salaryn


//using System.Runtime.CompilerServices;
//using System.Security.Cryptography.X509Certificates;


//static int MyMethod(int x)
//{

//    return 3 - x;


//}

//Console.WriteLine(MyMethod(2));
//Console.WriteLine(MyMethod(1));

//

//1024 hat meshok ka, meki mej 0.8gramnaotsner en , mnatsatsneri mej 1 gramanotsner, mi kshrumov gtnel keghts meshok


//using System.ComponentModel;

//int a = 10;
//int b = 5;

//Console.WriteLine($"Before swapping: a = {a} b = {b}");
//SwapValues(ref a, ref b);
//Console.WriteLine($"After swapping: a = {a} b = {b}");


//static void SwapValues (ref int a, ref int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}

//string anun = "Armen";
//string azganun = "Rafayelyan";
//Console.WriteLine($"Before swapping: anun = {anun} azganun = {azganun}");

//SwapStrings(ref anun, ref azganun);
//Console.WriteLine($"After swapping: anun = {azganun} azganun = {anun}");

//string fullName = AppendText(ref anun, ref azganun);

//Console.WriteLine($"FullName: {fullName}");

//static void SwapStrings(ref string anun, ref string azganun) 
//{
// string firstName = anun;
//    anun = azganun;
//    azganun = firstName;   

//}

//static string AppendText(ref string anun, ref string azganun) 
//{
//    string fullName = anun + " " + azganun;
//    return fullName;
//}

//int OutSideVar=20;
//SomeFunction(ref OutSideVar);


//static void SomeFunction ( ref int InsideVar)
//{

//    InsideVar = InsideVar + 10;
//}

//Console.WriteLine(OutSideVar);

//int OutSideVar = 20;
//SomeFunction(out OutSideVar);


//static void SomeFunction(out int InsideVar)
//{
//    InsideVar = 5;
//    InsideVar = InsideVar + 10;
//}

//Console.WriteLine(OutSideVar);

//int m = 10;
//int n = 15;
//int max = Max(m, n, out max);
//Console.WriteLine("The maximum return value is: {0}", max);

//Max(m, n, out max);

//Console.WriteLine("The maximum value of out is: {0}", max);

//Maxref(m, n, ref max);
//Console.WriteLine("The maximum value of ref is: {0}", max);

//Console.Read();
//        }

//        static int Max(int a, int b)
//{
//    return a > b ? a : b;
//}

//static void Max(int a, int b, out int max)
//{
//    //out parameter must be initialized (assigned) inside the method
//    //It implies that the out parameter must be changed.

//    max = a > b ? a : b;
//}

//static void Maxref(int a, int b, ref int max)
//{
//    //Nothing is done, ref chooses not to change the original value of max
//}


//string str = "hello";
//Test(ref str);
//Console.WriteLine(str);

//Console.Read();




//        static void Test(ref string a)
//{
//    a = "test";
//}

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

