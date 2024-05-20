using System.Diagnostics;
using System.Threading.Tasks.Sources;
using Exercise;

#region Wlcome

Quiz quiz = new Quiz();

Console.WriteLine("Enter your FirstName");
string FName = Console.ReadLine();
Console.WriteLine("Enter your LastName");
string LName = Console.ReadLine();
string Fullname = quiz.Fullname(FName, LName);
Console.WriteLine(Fullname);

Console.WriteLine("Enter your Age");
int Age = int.Parse(Console.ReadLine());

DateTime Date = DateTime.Now;

Console.WriteLine($"The name is : {Fullname},\nThe age is : {Age}, " +
    $"\nThe date is :{Date}\nWelcome to quiz");

#endregion

#region Question1
string Quesion1 = "Is a byte larger than a bit ?";
Console.WriteLine(Quesion1);
SortedList<string, string> data = new SortedList<string, string>();
data.Add("a", "Yes");
data.Add("b", "No");
foreach (var name in data)
{
    Console.WriteLine(name.Key + ")" + name.Value);
}
string answers = Console.ReadLine();
if (answers == "a")
{
    Console.WriteLine("Right");
}
else
{
    Console.WriteLine("False");
}
#endregion

#region Quesion2

string Quesion2 = " what is the datatype ?";
Console.WriteLine(Quesion2);
SortedList<string, string> answer = new SortedList<string, string>();
answer.Add("a", "String");
answer.Add("b", "Int");
answer.Add("c", "Double");
answer.Add("d", "all the above");
foreach (var name in answer)
{
    Console.WriteLine(name.Key + ")" + name.Value);
}
string answers2 = Console.ReadLine();

if (answers2 == "d")
{
    Console.WriteLine("Right");
}
else
{
    Console.WriteLine("False");
}

#endregion

int sum;

if (answers == "a" && answers2 == "d")
{
    sum = 2;
}
else if (answers == "a" && (answers2 == "a" || answers2 == "b" || answers2 == "c"))
{
    sum = 1;
}
else if ((answers == "a" || answers == "b") && answers2 == "d")
{
    sum = 1;
}
else
{
    sum = 0;
}

Console.WriteLine("The sum is ; " + sum); 


