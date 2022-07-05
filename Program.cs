namespace RentDistributionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the rent
            Console.WriteLine("Enter the rent: ");
            int rent = Convert.ToInt32(Console.ReadLine());
            //Ask how many people are paying rent
            Console.WriteLine("Enter the number of people paying rent: ");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());
            //Ask each person's monthly salary
            Console.WriteLine("Enter each person's monthly salary: ");
            int[] monthlySalary = new int[numberOfPeople];
            for (int i = 0; i < numberOfPeople; i++)
            {
                monthlySalary[i] = Convert.ToInt32(Console.ReadLine());
            }
            int combinedSalary = 0;
            for (int i = 0; i < numberOfPeople; i++)
            {
                combinedSalary += monthlySalary[i];
            }
            //If the combined salary of all people is less or equal than the rent, then we cannot pay the rent.
            if (combinedSalary < rent)
            {
                Console.WriteLine("The rent is not enough for all people to pay.");
                Environment.Exit(0);
            }
            // Otherwise, continue the calculation.
            double rentPercentage = (double)rent / combinedSalary;
            Console.WriteLine("The rent percentage is: " + rentPercentage * 100 + "%");
            //Calculate the rent for each person.
            double[] rentForEachPerson = new double[numberOfPeople];
            for (int i = 0; i < numberOfPeople; i++)
            {
                rentForEachPerson[i] = (double)(monthlySalary[i] * rentPercentage);
            }
            //Print the rent for each person.
            for (int i = 0; i < numberOfPeople; i++)
            {
                Console.WriteLine("Person " + i + ": " + rentForEachPerson[i]);
            }
            //Show's the percentage and show's how much each person needs to pay
        }
    }
}