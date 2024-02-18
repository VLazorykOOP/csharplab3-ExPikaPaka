using System;
using Lab3CSharp.src;
namespace Lab3CSharp {
    internal class Program {
        static void Main(string[] args) {
            int number = 1;

            while (number != 0) {
                Console.Write("Input task number [1-4], [0] to exit: ");

                try {
                    string? input = Console.ReadLine();

                    if (input != null) {
                        number = int.Parse(input);

                        switch (number) {
                            case 0:
                                return;

                            case 1:
                                task1(); // Testing task 1
                                break;

                            case 2:
                                task2(); // Testing task 2
                                break;

                            default:
                                break;
                        }
                    } else {
                        Console.WriteLine("Nothing provided. Exiting...");
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }

                Console.WriteLine();
            }
        }

        static void task1() {
            Console.WriteLine("|===~        Testing task 1.1        ~===|");

            // Example of using the Point class
            Point point1 = new Point(3, 4);
            point1.PrintCoordinates();
            Console.WriteLine($"Distance to origin: {point1.CalculateDistanceToOrigin()}");

            // Example of moving the point
            point1.Move(1, 1);
            point1.PrintCoordinates();

            // Example of using properties
            point1.X = 10;
            point1.Y = 20;
            Console.WriteLine($"New coordinates: ({point1.X}, {point1.Y})");
        }

        static void task2() {
            Console.WriteLine("|===~        Testing task 2.1        ~===|");

            List<Person> people = new List<Person>();
            // Populate the array with objects of different derived classes
            people.Add(new Student("John", 20, 1234));
            people.Add(new Teacher("Mary", 35, "Mathematics"));
            people.Add(new DepartmentHead("David", 45, "Physics", "Science Department"));

            // Sort the array by name
            people.Sort((x, y) => String.Compare(x.GetType().Name, y.GetType().Name));

            // Display information about each person
            foreach (var person in people) {
                person.Show();
                Console.WriteLine();
            }
        }
    }
}
