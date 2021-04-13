using System;
using System.Collections.Generic;

namespace Lab4._3_Program
{
    enum Prime
    {
        Prime,
        NotPrime
    }

    public class PrimeNumbers
    {
        /* This prime list/loop code is from Alaa, I could not get mine to work but know that this lab was more about the testing.
        I ran multiple failed tests as I attempted to get the prime numbers to work. Once I put in this prime number code my tests passed! */


        public void GetPrime(int userInput)
        {
            List<int> primeNumbers = new List<int>(); 
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            Prime primes;
            int i;

            for (i = 4; primeNumbers.Count < userInput; i++)
            {
                int primeCount = primeNumbers.Count;

                for (int i2 = 0; i2 < primeCount; i2++)
                {
                    if (i % primeNumbers[i2] == 0)
                    {
                        break;
                    }
                    else if (i2 == primeCount - 1)
                    {
                        primeNumbers.Add(i);
                    }
                }
            }
            int userinputPrime = primeNumbers[userInput - 1];

            if (primeNumbers.Contains(userinputPrime))
            {
                primes = Prime.Prime;
            }
            else
            {
                primes = Prime.NotPrime;
            }
             Console.WriteLine($"The number {userInput} prime is {primeNumbers[userInput - 1]}");
        }
    }


        class Program
    {
        //This is back to my own code :)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to PRIME TIME!");
            Console.WriteLine("\nThis application will find you any prime, in order, from first prime number on.");
            Console.WriteLine("\nWhich prime number are you looking for?: ");
            int userInput = Int32.Parse(Console.ReadLine());
            PrimeNumbers newprime = new PrimeNumbers();
            newprime.GetPrime(userInput);
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Do you want to find another prime number? (y/n): ");
                string response = Console.ReadLine();



                if (response == "n")
                {
                    done = true;
                    Console.WriteLine("goodybye!");
                    break;
                }
                else if (response == "y")
                {
                    Console.WriteLine("\nWhich prime number are you looking for?: ");
                    userInput = Int32.Parse(Console.ReadLine());
                    newprime = new PrimeNumbers();
                    newprime.GetPrime(userInput);
                }
                else
                {
                    Console.WriteLine("invalid entry"); 
                }
            }
            
           
        }
    }
}
