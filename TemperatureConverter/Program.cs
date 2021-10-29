using System;

namespace TemperatureCoverter
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Does not allow the user to enter invalid values
            {
                Console.Write("Please enter the value in Celsius: ");
                double celsius = double.Parse(Console.ReadLine()); // Converts to double for the users input
                double celsiusTofahrenheit = (celsius * 9 / 5) + 32; // Function that converts the tempereature from celsius to fahrenheit

                Console.WriteLine("The temperature converted from Celsius to Fahrenheit is: " + celsiusTofahrenheit + "°F");

                Console.Write("Please enter the value in Fahrenheit: ");
                double fahrenheit = double.Parse(Console.ReadLine()); // Converts to double for the users input
                double fahrenheitTocelsius = (fahrenheit - 32) * 5 / 9; // // Function that converts the tempereature from fahrenheit to celsius


                Console.WriteLine("The temperature converted from Fahrenheit to Celsius is: " + fahrenheitTocelsius + "°C");

                Console.WriteLine("PLEASE PRESS ANY KEY TO SHOW WHICH TEMPERATURE IS BIGGER");
                Console.ReadKey();


                double differenceIncelsius = celsius - fahrenheitTocelsius; // Function that shows which value of temperature is bigger
                double differenceInfahrenheit = fahrenheit - celsiusTofahrenheit; // Function that shows which value of temperature is bigger

                if (celsius > fahrenheitTocelsius) // The condition,controls if a program enters a section of code or not
                {
                    Console.WriteLine("The entered temperature is bigger and the difference is: " + differenceIncelsius + "°C");
                }
                else if (fahrenheitTocelsius > celsius)
                {
                    Console.WriteLine("The converted temperature is bigger and the difference is: " + differenceIncelsius + "°C");
                }
                else
                {
                    Console.WriteLine("Values in celsius are equal");
                }

                if (fahrenheit > celsiusTofahrenheit) // The condition,controls if a program enters a section of code or not
                {
                    Console.WriteLine("The entered temperature is bigger and the difference is: " + differenceInfahrenheit + "°C");
                }
                else if (celsiusTofahrenheit > fahrenheit)
                {
                    Console.WriteLine("The converted temperature is bigger and the difference is: " + differenceInfahrenheit + "°C");
                }
                else
                {
                    Console.WriteLine("Values in fahrenheit are equal");
                }



            }
            catch
            {
                Console.WriteLine("Please enter a valid value");
            }
        }
    }
}
