using System;

internal class BalanceException:ApplicationException
    {
    public BalanceException(string msg):base(msg) {

    }

}
public class qno5
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the balance and withdraw amount =");
            double balance = double.Parse(Console.ReadLine());
            double withdraw = double.Parse(Console.ReadLine());
            if (withdraw < balance)
            {
                balance -= withdraw;
                Console.WriteLine("Remaining balance =" + balance);
            }
            else
            {
                throw (new BalanceException("Insufficient balance"));
            }
        }

        catch (BalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("End a the Program:");
        }
        Console.ReadKey();
    }
}