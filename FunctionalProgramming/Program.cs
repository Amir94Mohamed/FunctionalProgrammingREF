using System;
using System.Collections.Generic;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cube(8);
            Cost(127);
            //fiveTimesTable(65);
            //Console.WriteLine(vector(1, 2));
            //UpperAndLowerBound(50,10);
            //Remainders();
        }

        // Q1. This cubes the given number. Simple line of code that
        // uses the given number and cubes it by multiplying the number agains itself twice. 
        private static void Cube(int Cube)
        {
            Console.WriteLine("The Cubed result is ");
            Console.WriteLine(Cube * Cube * Cube);
        }

        // Q2. This will display a message that depends on the vaule that as been given. Each message depends
        // on the value that has been input. 
        private static void Cost(int Cost)
        {
            Console.WriteLine("This purchase was ");
            // It will diplay "Expensive" if the input value was over a 100.
            if (Cost > 100)
            {
                Console.WriteLine("Expensive");
            }
            // It will diplay "Good Value" if the input value was over a 50 and 100 and under. 
            else if (Cost <= 100 && Cost > 50)
            {
                Console.WriteLine("Good Value");
            }
            // It will diplay "A Bargain" if the input value was 50 or under.
            else if (Cost <= 50)
            {
                Console.WriteLine("A Bargain");
            }
        }

        private static (int first, int second) vector(int x, int y)
        {
            return (x * -1, y * -1);
        }

        private static void fiveTimesTable(int value)
        {
            List<Int32> FiveTimeTable = new List<Int32>();

            int Into_100 = 100 / 5;

            for (int i = 1; i < Into_100 + 1; i++)
            {
                FiveTimeTable.Add(i * 5);
            }

            double value3 = Math.Round(value / 5.0) * 5;

            int UpperValue;
            int LowerValue;

            if (value >= 0 && value <= 100)
            {
                if (value3 > value)
                {
                    UpperValue = Convert.ToInt32(value3);
                    LowerValue = Convert.ToInt32(value3) - 5;

                    Console.WriteLine($"Your Upper Value is {UpperValue} and your Lower Value" +
                    $" is {LowerValue}");
                }

                else if (value3 <= value)
                {
                    LowerValue = Convert.ToInt32(value3);
                    UpperValue = Convert.ToInt32(value3) + 5;

                    Console.WriteLine($"Your Upper Value is {UpperValue} and your Lower Value" +
                    $" is {LowerValue}");
                }
            }
            else
            {
                Console.WriteLine("Choose an number in between 0 - 100 please ");
            }
        }

        private static void UpperAndLowerBound(int value, int step1, int step2)
        {
            List<Int32> tens = new List<Int32>();

            for (int i = 0; i < 11; i++)
            {
                tens.Add(i * 10);
            }

            int value2 = ((int)Math.Round(value / 3.0)) * 10;

            int value3 = value2 - value;

            int uppervalue;
            int trueuppervalue;
            int lowervalue;
            int truelowervalue;

            if (value3 > 0)
            {
                uppervalue = value2;
                truelowervalue = value2 - 10;

                Console.WriteLine($"Your Upper Value is {uppervalue} and your Lower Value" +
                    $" is {truelowervalue}");
            }
            else
            {
                lowervalue = value2;
                lowervalue = value2;
                trueuppervalue = value2 + 10;

                Console.WriteLine($"Your Upper Value is {trueuppervalue} and your Lower Value" +
                    $" is {lowervalue}");
            }

            int index = 0;
            int index2 = 0;

            foreach (int item in tens)
            {
                if (step1 != item)
                {
                    index++;
                }
                else if (step1 == item)
                {
                    break;
                }
            }

            foreach (int item in tens)
            {
                if (step2 != item)
                {
                    index2++;
                }
                else if (step2 == item)
                {
                    break;
                }
            }

            List<Int32> Difference = new List<Int32>();
            List<Int32> IndexPoints = new List<Int32>();
            List<Int32> Jumps = new List<Int32>();

            if (index > index2)
            {
                int DifferenceOfIndex = index - index2;

                if (DifferenceOfIndex <= 1)
                {
                    Console.WriteLine("There have been no step values");
                }
                else if (DifferenceOfIndex > 1)
                {
                    for (int i = index2 + 1; i < index; i++)
                    {
                        IndexPoints.Add(i);
                    }

                    int counterIndex = 0;

                    foreach (int item in Difference)
                    {
                        counterIndex++;
                        foreach (int items in IndexPoints)
                        {
                            if (counterIndex == items)
                            {
                                Jumps.Add(item);
                            }
                        }
                    }
                }
            }

            else if (index2 > index)
            {
                int DifferenceOfIndex = index2 - index;

                if (DifferenceOfIndex <= 1)
                {
                    Console.WriteLine("There have been no step values");
                }
                else if (DifferenceOfIndex > 1)
                {
                    for (int i = index + 1; i < index2; i++)
                    {
                        IndexPoints.Add(i);
                    }

                    int counterIndex = 0;

                    foreach (int item in Difference)
                    {
                        counterIndex++;
                        foreach (int items in IndexPoints)
                        {
                            if (counterIndex == items)
                            {
                                Jumps.Add(item);
                            }
                        }
                    }
                }
            }

            else if (index2 == index)
            {
                Console.WriteLine("Your Step value is 0");
            }

            foreach (int item in Jumps)
            {
                Console.WriteLine(item);
            }
        }

        private static void Remainders()
        {
            List<Int32> numbers = new List<Int32>();

            for (int i = 1; i < 101; i++)
            {
                int remainder = i % 7;

                numbers.Add(remainder);
            }

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}