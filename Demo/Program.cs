using System.ComponentModel;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Drawing;
using System;
using System.Reflection.Emit;

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


    #region Q6)Create a struct called "Point" to represent a 2D point with properties "X" and"Y".Write a C# program that takes two points as input from the user and calculates the distance between them.
    //public struct Point {
    //    int x;
    //    int y;
    //    public Point(int x, int y) { 
    //    this.x=x; 
    //    this.y = y;

    //    }

    //    public void GetDistance(Point p) {

    //        Console.WriteLine($"Distance is {(this.y-p.y)/(this.x-p.x)}");
    //    }
    //}
    #endregion

    #region Q7)Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
    //public struct Person {
    //   public string name;
    //   public int age;

    //    public Person(string name, int age) {
    //        this.name = name;
    //        this.age = age;
    //    }
    //}
    #endregion

    // Part 02
    #region  Q1)Design and implement a Class for the employees in acompany: Employee is identified by an ID, Name, security level, salary, hire dateand Gender.

    //public class Employee
    //{
    //    private int id;
    //    private string name;
    //    private decimal salary;
    //    private HiringDate hireDate;
    //    private Security_Privileges securityLevel;
    //    private Gender gender;

    //    public int ID
    //    {
    //        get => id;
    //        set => id = value;
    //    }

    //    public string Name
    //    {
    //        get => name;
    //        set => name = value;
    //    }

    //    public decimal Salary
    //    {
    //        get => salary;
    //        set => salary = value;
    //    }

    //    public HiringDate HireDate
    //    {
    //        get => hireDate;
    //        set => hireDate = value;
    //    }

    //    public Security_Privileges SecurityLevel
    //    {
    //        get => securityLevel;
    //        set => securityLevel = value;
    //    }

    //    public Gender Gender
    //    {
    //        get => gender;
    //        set => gender = value;
    //    }

    //    public Employee()
    //    {
    //        ID = 1;
    //        Name = "Default";
    //        Salary = 0;
    //        HireDate = new HiringDate();
    //        SecurityLevel = Security_Privileges.Guest;
    //        Gender = Gender.Male;
    //    }


    //    public Employee(int id, string name, decimal salary, HiringDate hireDate, Security_Privileges securityLevel, Gender gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        SecurityLevel = securityLevel;
    //        Gender = gender;
    //    }


    //    public override string ToString()
    //    {
    //        return $"ID: {ID}, Name: {Name}, Salary: {Salary:C}, Hire Date: {HireDate}, Security Level: {SecurityLevel}, Gender: {Gender}";
    //    }
    //}

    //public class HiringDate
    //{
    //    private int day;
    //    private int month;
    //    private int year;


    //    public int Day
    //    {
    //        get => day;
    //        set => day = value;
    //    }

    //    public int Month
    //    {
    //        get => month;
    //        set => month = value;
    //    }

    //    public int Year
    //    {
    //        get => year;
    //        set => year = value;
    //    }


    //    public HiringDate()
    //    {
    //        Day = 1;
    //        Month = 1;
    //        Year = 2000;
    //    }


    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    // public enum Gender
    //{
    //    Male, Female
    //}
    //[Flags]
    //public enum Security_Privileges:byte
    //{
    //    Guest=1, Developer=2, Secretary=4, DBA=8
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

            #region Q6)Create a struct called "Point" to represent a 2D point with properties "X" and"Y".Write a C# program that takes two points as input from the user and calculates the distance between them.


            //Point[] points = new Point[2];
            //bool fflag = false;
            //bool sflag = false;
            //for (int i = 0; i < points.Length;)
            //{

            //    do
            //    {
            //        Console.WriteLine($"Enter x for point {i + 1}");
            //        fflag = int.TryParse(Console.ReadLine(), out int x);
            //    }
            //    while (!fflag);
            //    do
            //    {
            //        Console.WriteLine($"Enter y for point {i + 1}");
            //        sflag = int.TryParse(Console.ReadLine(), out int y);
            //    }
            //    while (!sflag);


            //}
            //points[1].GetDistance(points[0]);

            #endregion


            #region Q7)Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] people = new Person[3];
            //bool flag = false;
            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.Write($"Enter the name for Person Number {i + 1} : ");
            //    people[i].name =Console.ReadLine()?? "No Name";
            //    do
            //    {
            //        Console.Write($"Enter the age for Person Number {i + 1} : ");
            //        flag = int.TryParse(Console.ReadLine(),out people[i].age);
            //    }
            //    while (!flag);
            //}
            //int maxAge = people[0].age;
            //int index=0;
            //for (int i = 0; i < people.Length; i++)
            //{
            //    if (people[i].age > maxAge) {
            //        index = i;
            //            }   
            //}
            //Console.WriteLine($"Max age is {people[index].age} for the person {people[index].name}");
            #endregion

            // Part 02
            #region  Q1)Design and implement a Class for the employees in acompany: Employee is identified by an ID, Name, security level, salary, hire dateand Gender.
            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee(1, "Ahmed Mohamed", 20000, new HiringDate(1, 1, 2015), Security_Privileges.DBA, Gender.Male);
            //EmpArr[1] = new Employee(2, "Mostafa Ahmed", 30000, new HiringDate(15, 8, 2024), Security_Privileges.Guest, Gender.Male);
            //EmpArr[2] = new Employee(3, "Ayman Nasr", 25000, new HiringDate(1, 1, 2020), (Security_Privileges) 15, Gender.Male);


            //foreach (var employee in EmpArr)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

        }

    }


    }
