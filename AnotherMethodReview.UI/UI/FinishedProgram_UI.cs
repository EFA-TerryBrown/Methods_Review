using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class FinishedProgram_UI
    {
        // Make a method that takes in a string and Greets the user
    public void GreetUser(string name)
    {
        System.Console.WriteLine($"Hello {name}!");
    }

    // Make a method that takes in two integers and returns the added result
    public int AddMe(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    // Make a method that takes in two decimal and returns the subtracted result as an integer
    public int SubtractMe(decimal firstNumber, decimal secondNumber)
    {
        return Convert.ToInt32(firstNumber - secondNumber);
    }


    // Make a method that takes in two doubles and returns the Multiplied result
    public double MultiplyMe(double firstNumber, double secondNumber)
    {
        return firstNumber * secondNumber;
    }

    // Make a method that takes in a person object and returns all of the details of the person
    public void DisplayPersonDetails(Person person)
    {
        System.Console.WriteLine($"ID: {person.ID}\nName: {person.Name}\nAddress:{person.Address}\nSalary: {person.Salary}\nPhone Number: {person.PhoneNumber}\n");
    }
    // Make a method that takes in a number and outputs a string that states wheather or not the number
    // is evenly divisble by 5
    public void IsDivisableByFive(int value)
    {
        if (value % 5 == 0)
        {
            System.Console.WriteLine($"{value} is divisible by Five.");
        }
        else
        {
            System.Console.WriteLine($"{value} is not divisible by Five.");
        }
    }
    // Make a mehtod that takes in two interger values, one for the minValue and one for the maxValue.
    // Next, using a nexted loop that displays times tables from 1 to 5.
    // 1 X 1 = 1

    // ….

    // 1 X 12 = 12
    public void MultiplicationFacts(int minValue, int maxValue)
    {
        for (int i = minValue; i <= maxValue; i++)
        {
            for (int j = 0; j <= maxValue; j++)
            {
                System.Console.WriteLine($"{i} X {j} = {j * i}");
            }
        }
    }

    // Declare a method that takes in a list of Person and return the sum of all Salaries on the list.
    public decimal SumOfAllSaleries(List<Person> people)
    {
        if (people != null)
        {
            var totalSalary = 0.0m;
            foreach (var person in people)
            {
                totalSalary += person.Salary;
            }
            return totalSalary;
        }
        return 0;
    }


    //total Salaries combined =125000
    public List<Person> SeedPeople()
    {
        List<Person> people = new List<Person>();

        var personA = new Person(1, "Bill Burr", "111 IDk", 25_000, "1234449999");
        var personB = new Person(2, "George Carlin", "111 IDk", 55_000, "1234443333");
        var personC = new Person(3, "Ted", "111 IDk", 45_000, "1234445555");

        people.Add(personA);
        people.Add(personB);
        people.Add(personC);

        return people;
    }

    public Person SeedOnePerson()
    {
        var personA = new Person(1, "Bill Burr", "111 IDk", 25_000, "1234449999");
        return personA;
    }
    }
