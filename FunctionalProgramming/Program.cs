using System;
using System.Collections.Generic;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cube(8);
            //Cost(17);
            //Console.WriteLine(vector(14, 19));
            //fiveTimesTable(68);
            //UpperAndLowerBound(70,44,26);   
            Remainders();
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
        // Q3. These lines of code take two parameters
        // representing a vector x and y, and multiplies both by -1 to invert the vector.
        // The outut will be returned as a tuple.
        private static (int first, int second) vector(int x, int y)
        {
            // multiplies the two given parameters by -1 and returns the result as a tuple
            return (x * -1, y * -1);
        }

        private static void fiveTimesTable(int value)
        {
            // Declares a list with the int32 objects 
            List<Int32> FiveTimeTable = new List<Int32>();

            int Into_100 = 100 / 5;
            
            for (int i = 1; i < Into_100 + 1; i++)
            {
                // multiplies the given digit by 5
                FiveTimeTable.Add(i * 5);
            }

            double value3 = Math.Round(value / 5.0) * 5;
            // contains the calculated results
            int UpperValue; 
            int LowerValue;
            // This ensures that the number is between 1-100 otherise it will display a different output message.
            if (value >= 0 && value <= 100)
            {
                if (value3 > value)
                {
                    // This calcullates the lowervalue of the given number to the nearest 5 of the number provided.
                    UpperValue = Convert.ToInt32(value3);
                    LowerValue = Convert.ToInt32(value3) - 5;
                // This provides the output line that shows the upper and
                // lower value.
                    Console.WriteLine($"Your Upper Value is {UpperValue} and your Lower Value" +
                    $" is {LowerValue}");
                }

                else if (value3 <= value)
                {
                    // This calculates the uppervalue of the given number
                    LowerValue = Convert.ToInt32(value3);
                    UpperValue = Convert.ToInt32(value3) + 5;
                    // This provides the output line that shows the upper and
                    // lower value.
                    Console.WriteLine($"Your Upper Value is {UpperValue} and your Lower Value" +
                    $" is {LowerValue}");
                }
            }
            //This is the output message for any number above 100 inputed. 
            else
            {
                Console.WriteLine("Please Choose an number in between 0 - 100. ");
            }
        }
        //Q4. 
        private static void UpperAndLowerBound(int value, int step1, int step2)
        {
            // Declares a list called tens with the int32 objects 
            List<Int32> tens = new List<Int32>();

            for (int i = 0; i < 11; i++)
            {
                // multiplies the given number by 10.
                tens.Add(i * 10);
            }
            // caculates value 2
            int value2 = ((int)Math.Round(value / 3.0)) * 10;
            // calculates value 3
            int value3 = value2 - value;

            // Contains the calculated values
            int uppervalue;
            int trueuppervalue;
            int lowervalue;
            int truelowervalue;

            // calculates the upper and lower values, provides the different output messages.
            if (value3 > 0)
            {
                //calculates lower value 
                uppervalue = value2;
                truelowervalue = value2 - 10;
                // provides the output message containing the calculated result
                Console.WriteLine($"Your Upper Value is {uppervalue} and your Lower Value" +
                    $" is {truelowervalue}");
            }
            else
            {
                //calculates upper value 
                lowervalue = value2;
                lowervalue = value2;
                trueuppervalue = value2 + 10;
                // provides the output message containing the calculated result
                Console.WriteLine($"Your Upper Value is {trueuppervalue} and your Lower Value" +
                    $" is {lowervalue}");
            }  
            //contains the index values
            int index = 0;
            int index2 = 0;

            // 
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
            //
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
            // Creates the lists for Difference, IndexPoints and Jumps
            List<Int32> Difference = new List<Int32>();
            List<Int32> IndexPoints = new List<Int32>();
            List<Int32> Jumps = new List<Int32>();

            if (index > index2)
            {
                //calcultes the difference between the two indexes if first index is larger.
                int DifferenceOfIndex = index - index2;

                if (DifferenceOfIndex <= 1)
                {
                    // This is the output message if the step value is none
                    Console.WriteLine("There have been no step values");
                }
                else if (DifferenceOfIndex > 1)
                {
                    //  
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
                //calcultes the difference between the two indexes if index2 is larger.
                int DifferenceOfIndex = index2 - index;

                if (DifferenceOfIndex <= 1)
                {
                    // An output mssage for no step values 
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
            // if the indexes are equal if would provide a different output
            else if (index2 == index)
            {
                // this is one of the output message 
                Console.WriteLine("Your Step value is 0");
            }

            foreach (int item in Jumps)
            {
                Console.WriteLine(item);
            }
        }
        // Q6. Creates a list containing the results of the number 1 to 100 by 7. 
        private static void Remainders()
        {
            // defines a list named numbers that contains the int32 objects
            List<Int32> numbers = new List<Int32>();
            // provides the 1 to 100 numbers
            for (int i = 1; i < 101; i++)
            {
                int remainder = i % 7;

                numbers.Add(remainder);
            }
            // provides the outut result and prints them to terminal.
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}