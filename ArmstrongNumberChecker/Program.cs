using ArmstrongNumberChecker;

namespace ArmstrongNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var armstrongnumber = new ArmstrongNumber();
            Console.Write("Enter number: ");
            var armstrongnumberchecking = Convert.ToInt32(Console.ReadLine());
            var result = armstrongnumber.IsArmstrong(armstrongnumberchecking);
            Console.WriteLine("number == sum of its digits: "+result);
        }
    }
}
