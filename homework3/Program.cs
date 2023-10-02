namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK1
            Console.Write("Enter a text: ");
            string input = Console.ReadLine();

            int countA = input.Count(c => c == 'a' || c == 'A');
            int countO = input.Count(c => c == 'o' || c == 'O');
            int countI = input.Count(c => c == 'i' || c == 'I');
            int countE = input.Count(c => c == 'e' || c == 'E');

            Console.WriteLine($"Count loud literature: {countA + countO + countI + countE}");



            //TASK2
            Console.Write("Enter the number of the month (1-12): ");
            if (int.TryParse(Console.ReadLine(), out int monthNumber))
            {
                int daysInMonth = GetDaysInMonth(monthNumber);
                if (daysInMonth > 0)
                {
                    Console.WriteLine($"The month {monthNumber} has {daysInMonth} days.");
                }
                else
                {
                    Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }


            //TASK3

            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter integer #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    numbers[i] = inputNumber;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--;
                }
            }

            int sumFirst5 = 0;
            int productLast5 = 1;
            bool nonPositiveFound = false;

            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    if (numbers[i] <= 0)
                    {
                        nonPositiveFound = true;
                        break;
                    }
                    sumFirst5 += numbers[i];
                }

            }
            for (int i = numbers.Length - 5; i < numbers.Length; i++)
            {
                productLast5 *= numbers[i];
                Console.WriteLine($"Product of the last 5 numbers: {productLast5}");
            }

            if (!nonPositiveFound)
            {
                Console.WriteLine($"Sum of the first 5 positive numbers: {sumFirst5}");
            }
            else
            {
                Console.WriteLine($"Product of the last 5 numbers: {productLast5}");
            }

        }

        //TASK2
        static int GetDaysInMonth(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:  // January
                case 3:  // March
                case 5:  // May
                case 7:  // July
                case 8:  // August
                case 10: // October
                case 12: // December
                    return 31;
                case 4:  // April
                case 6:  // June
                case 9:  // September
                case 11: // November
                    return 30;
                case 2:  // February

                    return DateTime.IsLeapYear(DateTime.Now.Year) ? 29 : 28;
                default:
                    return -1; 
            }
        }


    }

}