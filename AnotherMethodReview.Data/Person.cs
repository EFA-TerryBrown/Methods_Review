using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Person
{
    public Person(int id, string name, string address, decimal salary, string phoneNumber)
    {
        ID = id;
        Name = name;
        Address = address;
        Salary = salary;
        PhoneNumber = phoneNumber;
    }

    public int ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public decimal Salary { get; set; }
    public string PhoneNumber { get; set; }
}
