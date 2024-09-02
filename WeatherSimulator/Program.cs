using System.Diagnostics.CodeAnalysis;

namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate");
            int days = int.Parse(Console.ReadLine());
            int[] temp = new int[days];
            string[] conditions = {"Sunny", "Rainy", "Cloudy", "Snowy"};
            string[] weather_conditions = new string[days];

            Random random = new Random();
            for(int i = 0; i < days; i++)
            {
                temp[i] = random.Next(-20, 43);
                weather_conditions[i] = conditions[random.Next(conditions.Length)]; 
            }

            double average_temp = CalculateAverageTemp(temp);
            Console.WriteLine($"Temperature average is: {CalculateAverageTemp(temp)}");
            Console.WriteLine($"Maximum temperature is: {temp.Max()}");
            Console.WriteLine($"Minimum temperature is: {temp.Min()}");
            Console.WriteLine($"Most Common Conditions is: {MostCommonConditions(conditions)}");

            Console.ReadKey();
        }

        static string MostCommonConditions(string[] conditions)
        {
            int count = 0;
            string most_common = conditions[0];
            // first interation
            for(int i = 0; i < conditions.Length; i++)
            {
                int temp_count = 0;
                // for loop in for loop
                for(int j = 0; j < conditions.Length; j++)
                {
                    if(conditions[j] == conditions[i])
                    {
                        temp_count++;
                    }
                }
                if(temp_count > count)
                {
                    most_common = conditions[i];
                }
            }
            return most_common;

        }

        static double CalculateAverageTemp(int[] temp_values)
        {
            double sum = 0;
            foreach (int value in temp_values)
            {
                sum += value; // Sum the values
       

            }
            double average = sum / temp_values.Length;
            return average; // Return average of temperture

        }
    }
}
