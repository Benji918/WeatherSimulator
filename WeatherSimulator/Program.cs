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

            Console.ReadKey();
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
