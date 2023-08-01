// See https://aka.ms/new-console-template for more information;
//Console.WriteLine("Hello, World!");
//1. write a math function to get the square root of 144,36, 10,000,2500 and 40,000 the sstore the answer in a variable

int num = 40000;
int sqrtOfNum = Convert.ToInt32(Math.Sqrt(num));
Console.WriteLine("The square root of " + num + " is " + sqrtOfNum);


//2.  use the math function to look for answer ;
int Num1 = 12;
int Num2 = 4;
int Answer =Convert.ToInt32( Math.Pow(Num1, Num2));
Console.WriteLine(Num1 +  " raised to the power of " + Num2 + " is  " +  Answer);


//3. solve the following equation
Console.WriteLine((20*20)/100);
Console.WriteLine(78+50-(300/2));
Console.WriteLine(45*20-(400+34));
Console.WriteLine((100/2)*(23+34));
Console.WriteLine((200*3)*(300+23));


//4. write the user input , generate the following , 
Console.WriteLine("Enter your Name: ");
string NameInput = Console.ReadLine();

Console.WriteLine("Enter your Age: ");
string AgeInput = Console.ReadLine();

Console.WriteLine("Enter your Email Address: ");
string EmailInput = Console.ReadLine();

Console.WriteLine("Enter your House Address: ");
string AddressInput = Console.ReadLine();

Console.WriteLine("Enter your Discipline: ");
string DisciplineInput = Console.ReadLine();

Console.WriteLine("My name is "+ NameInput + " I am a " + AgeInput + " years old, and my discipline is " + DisciplineInput);
Console.ReadLine();

// int num = Convert.ToInt32("200");
// Console.WriteLine(num + 200);
// Console.ReadLine();