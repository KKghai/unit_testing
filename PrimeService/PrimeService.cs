using System;

namespace PrimeService
{
    public class PrimeService
    {
    	public bool IsPrime(int candidate)
        {
        	//Console.writeLine("Hello World!");
        	bool isPrime = true;
        	for (int i = 2; i< candidate; i++)
        	{
        		if(candidate%i == 0)
        		{
        	//		Console.writeline("{o} is a  factor of {1}", i, candidate );
        			isPrime = false;
        			break;
        		}
        	}
        	return isPrime;
        	/*if(candidate==1)
        	{
        		return false;
        	}
            throw new NotImplementedException("Please create a test first");*/
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
