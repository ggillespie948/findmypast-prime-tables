using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeTables
{
    public static class MultiplicationTableOutput
    {
        public static bool GenerateMultiplicationTable(int[] primeNumbers)
        {
            string outputString = "";

            int padding = primeNumbers[primeNumbers.Length-1].ToString().Length + 4;

            //Calculate size of line break
            string lineBreak = "";
            for(int i=0; i< (primeNumbers.Length+1)*padding; i++)
            {
                lineBreak += "-";
            }

            Console.WriteLine("Prime Table Generation");
            Console.WriteLine(lineBreak);
            Console.WriteLine("Length: " + primeNumbers.Length);
            Console.WriteLine("Padding " + padding);
            Console.WriteLine(lineBreak);
            Console.WriteLine();
            
            for (int y = -1; y <= primeNumbers.Length - 1; y++)
            {
                for (int x = -1; x <= primeNumbers.Length - 1; x++)
                {

                    if (y == -1)
                    {
                        if (x == -1)
                        {
                            outputString = "[X]";
                        }
                        else
                        {
                            outputString = string.Format("[{0}]", primeNumbers[x]);
                        }
                    }
                    else
                    {
                        if (x == -1)
                        {
                            outputString = string.Format("[{0}]", primeNumbers[y]);
                        }
                        else
                        {
                            if(x != -1 && y != -1)
                                outputString = string.Format("{0}", primeNumbers[x] * primeNumbers[y]);
                        }
                    }
                    Console.Write(outputString.PadLeft(padding, ' '));
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine(lineBreak);
            return true;
        }
    }
}
