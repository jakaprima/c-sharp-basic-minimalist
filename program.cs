using System;

// Define a class representing a Person
class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to greet the person
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}


namespace MyNameSpace {
    class Program{
        static void Main(string[] args)
        {
            // Create an array of Person objects
            Person[] people = new Person[2];
            people[0] = new Person("Jaka", 30);
            people[1] = new Person("Bayi", 5);

            // Loop through the array of people
            foreach (var person in people)
            {
                // Check if the person is above 21 years old
                if (person.Age >= 21)
                {
                    // If they are, greet them
                    person.Greet();
                }
                else
                {
                    // If they are not, print a message
                    Console.WriteLine($"{person.Name} is too young to greet.");
                }
            }

            // single
            Person people2 = new Person("prima", 10);
            people2.Greet();



            // number
            // NumberExample numberInstance = new NumberExample();
            // numberInstance.Process();

            // // string example
            // StringExample stringInstance = new StringExample();
            // stringInstance.Process();

            // // list example
            // ListExample listInstance = new ListExample();
            // listInstance.Process();

            // // Control example
            // ControlFlowExample controlFlowInstance = new ControlFlowExample();
            // controlFlowInstance.Process();

            // // Data structure
            // DataStructureExample dataStructureInstance = new DataStructureExample();
            // dataStructureInstance.Process();

            // OOP
            OOPExample oopInstance = new OOPExample();
            oopInstance.Process();
        }
    }
}
