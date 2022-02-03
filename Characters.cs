using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    public abstract class Characters
    {
        
    }
}


/*public abstract class Person
{
    public double Height { get; set; }
    public double Weight { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Person()
    {

    }
    public Person(string first, string last, string gender, int age)
    {
        FirstName = first;
        LastName = last;
        Gender = gender;
        Age = age;
    }
    public Person(double height, double weight, string gender, int age, string firstName, string lastName)
    {
        Height = height;
        Weight = weight;
        Gender = gender;
        Age = age;
        FirstName = firstName;
        LastName = lastName;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old.";
    }
    public virtual string ToPipeDelimitedString()
    {
        return $"{FirstName}|{LastName}|{Gender}|{Age}|{Height}|{Weight}";
    }
    abstract public void Move();
    public virtual void Eat()
    {
        Console.WriteLine("Eating Food...");
    }
    public virtual void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
    public virtual void Communicate()
    {
        Console.WriteLine("Communicating...");*/
