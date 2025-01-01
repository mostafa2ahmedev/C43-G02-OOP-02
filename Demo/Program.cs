using System.ComponentModel;
using System.Threading;

namespace Demo
{
    #region Q1) Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.
    //enum WeekDays : byte { 
    //Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    //}
    #endregion

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
        }
    }
}
