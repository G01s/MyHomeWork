using System;


    class _06_Print_a_Sequence
    {
        static void Main()
        {
            // using for loop and 
            int numberToPrint;
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    numberToPrint = i;
                }
                else
                {
                    numberToPrint = i * (-1);
                }
                Console.WriteLine(numberToPrint);
            }
        }
    }
