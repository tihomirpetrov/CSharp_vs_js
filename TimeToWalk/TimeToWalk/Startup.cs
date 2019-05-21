namespace TimeToWalk
{
    using System;
    public class Startup
    {
        public static void Main()
        {
            int numberOfSteps = int.Parse(Console.ReadLine());
            double lentgthInKm = double.Parse(Console.ReadLine()) * numberOfSteps / 1000;
            double studentSpeedInKm = double.Parse(Console.ReadLine());

            double time = (lentgthInKm / studentSpeedInKm);
            double rest = lentgthInKm / 0.5;
            double hours = 0;
            double minutes = Math.Floor(time * 60);
            double seconds = Math.Round(((time * 60) - minutes) * 60);
            minutes = Math.Floor(minutes + rest);

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}