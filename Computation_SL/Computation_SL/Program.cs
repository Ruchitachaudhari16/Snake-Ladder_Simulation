namespace Computation_SL
{
    internal class Program
    {
        static void Main(string[] args)
        { //The player rolls the die to get the number between 1 to 6

            int Dice_rolled;
         Random random= new Random();
            Dice_rolled=random.Next(1,7);
            Console.WriteLine("Number get after Dice rolled:" + Dice_rolled);
            Console.ReadLine();
        }
    }
}