using System.ComponentModel;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Drawing;

namespace Demo
{
    #region Q1) Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.
    //enum WeekDays : byte { 
    //Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    //}
    #endregion Q3) Create an enum called "Season" with the four seasons (Spring, Summer,Autumn, Winter) as its members.Write a C# program that takes a seasonname as input from the user and displays the corresponding month range for that season. Note range for seasons (spring march to may , summer june to august, autumn September to November, winter December to February)

    #region Q2) Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

    //internal struct Person{
    //    string name;
    //    int age;

    //    public Person(string name,int age) { 
    //    this.name = name;
    //    this.age = age;
    //    }

    //    public override string ToString()
    //    {
    //        return $"name: {name}, age: {age}";
    //    }
    //}
    #endregion

    #region Q3) Create an enum called "Season" with the four seasons (Spring, Summer,Autumn, Winter) as its members.Write a C# program that takes a seasonname as input from the user and displays the corresponding month range for that season. Note range for seasons (spring march to may , summer june to august, autumn September to November, winter December to February)
    //enum Season {
    //Spring=1,Summer,Autumn,Winter
    //}
    #endregion

    #region Q4)Assign the following Permissions (Read, write, Delete, Execute) in a form ofEnum.
    //[Flags]
    //enum Permissions : byte { 
    //Read=1,Write=2,Delete=4,Execute=8
    //}
    #endregion

    #region Q5)Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
    //enum Colors
    //{
    //    Red=1, Green, Blue
    //}
    #endregion
    internal class Program
    {

        static void Main(string[] args)
        {


            #region Q1) Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.
            //WeekDays week;
            //for (int i = 0; i < 6; i++)
            //{
            //    week = (WeekDays) i;
            //    Console.WriteLine(week);

            //}
            #endregion

            #region Q2) Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] people = new Person[3] { new Person("Mostafa",23), new Person("Ahmed",27), new Person("Omar",24) };

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"Person Number {i+1} : {people[i]}");
            //}
            #endregion

            #region Q3) Create an enum called "Season" with the four seasons (Spring, Summer,Autumn, Winter) as its members.Write a C# program that takes a seasonname as input from the user and displays the corresponding month range for that season. Note range for seasons (spring march to may , summer june to august, autumn September to November, winter December to February)
            //string userInput;
            //do
            //{
            //    Console.WriteLine("Enter a season");
            //     userInput = Console.ReadLine();
            //}
            //while (userInput == "");
            //Season season;
            //Enum.TryParse<Season>(userInput,true,out season);
            //switch (season) {
            //case Season.Spring:
            //        Console.WriteLine("March to may");
            //        break;
            //case Season.Summer:
            //        Console.WriteLine("June to august");
            //        break;
            //case Season.Autumn:
            //        Console.WriteLine("September to November");
            //        break;
            //case Season.Winter:
            //        Console.WriteLine("December to February");
            //        break;
            //    default:
            //        Console.WriteLine("This is not a valid month name");
            //        break;

            #endregion


            #region Q4)Assign the following Permissions (Read, write, Delete, Execute) in a form ofEnum.
            //Permissions permission = (Permissions)1;
            //Console.WriteLine(permission);
            //// Add new permission
            //permission = permission | Permissions.Write;
            //Console.WriteLine(permission);
            //// Remove permission
            //permission = permission & ~(Permissions.Read);
            //Console.WriteLine(permission);
            //// Toggle permission
            //permission = permission ^ Permissions.Read;
            //Console.WriteLine(permission); 
            //permission = permission ^ Permissions.Read;
            //Console.WriteLine(permission);
            #endregion

            #region Q5)Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //string userInput;
            //do
            //{
            //    Console.WriteLine("Enter a Color");
            //    userInput = Console.ReadLine();
            //}
            //while (userInput == "");
            //Colors color;
            //Enum.TryParse<Colors>(userInput, true, out color);
            //switch (color)
            //{
            //    case Colors.Red:
            //        goto case Colors.Blue;

            //    case Colors.Green:

            //        goto case Colors.Blue;
            //    case Colors.Blue:
            //        Console.WriteLine("Primary Color");
            //        break;

            //    default:
            //        Console.WriteLine("Not A Primary Color");
            //        break;
                    #endregion
           
        
        }

        }


    }
}