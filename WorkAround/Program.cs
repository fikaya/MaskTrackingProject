using System;
using Business.Concrete;
using Entities.Concrete;

class Program
{
    static public void Main(String[] args)
    {
        Person person = new Person();
        person.NationalIdentity = 1;
        person.FirstName = "Test";
        person.LastName = "Test";
        person.DateOfBirthYear = 1;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);
        Console.WriteLine("Main Method");
    }
}