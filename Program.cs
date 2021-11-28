﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Problem12();
            Console.ReadKey();
        }

        public void ProblemOne()
        {
            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.\nFind the sum of all the multiples of 3 or 5 below 1000.");
            int Total = 0;
            for(int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    Total += i;
                }
            }
            Console.WriteLine(Total);
        }
        public void ProblemTwo()
        {
            Console.WriteLine("Each new term in the Fibonacci sequence is generated by adding the previous two terms.\nBy considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.");
            List<int> Fibonacci = new List<int>
            {
                1,2
            };
            int n = 1;
            while (Fibonacci[n] < 4000000)
            {
                Fibonacci.Add(Fibonacci[n - 1] + Fibonacci[n]);
                n++;
            }
            int Total = 0;
            foreach (var interger in Fibonacci)
            {
                if (interger % 2 == 0)
                {
                    Total += interger;
                }
            }
            Console.WriteLine(Total);
        }
        public void ProblemThree()
        {
            Console.WriteLine("What is the largest prime factor of the number 600851475143 ?");
            long Number = 600851475143;
            List<int> Primes = new List<int>();
            for (int div = 2; div <= Number; div++)
            {
                while (Number % div == 0)
                {
                    Primes.Add(div);
                    Number /= div;
                }
            }
            Console.WriteLine(Primes.Last());
        }
        public void ProblemFour()
        {
            Console.WriteLine("A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.\nFind the largest palindrome made from the product of two 3-digit numbers.");
            var result =
                Enumerable.Range(100, 900).
                SelectMany(x => Enumerable.Range(x, 1000 - x).Select(y => x * y)).
                Where(IsPalindrome).
                Max();
            Console.WriteLine(result);
        }
        public bool IsPalindrome(int Number)
        {
            var s = Number.ToString();
            return s.Reverse().SequenceEqual(s);
        }
        public void ProblemFive()
        {
            Console.WriteLine("2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.\nWhat is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ? ");
            bool found = false;
            int number = 0;
            while (!found)
            {
                found = true;
                number++;
                for (int i = 1; i < 21; i++)
                {
                    if (number % i != 0)
                    {
                        found = false;
                        break;
                    }
                }

            }
            Console.WriteLine(number);
        }
        public void ProblemSix()
        {
            Console.WriteLine("The sum of the squares of the first ten natural numbers is 385.\nThe square of the sum of the first ten natural numbers is 3025.\nHence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 2640.\nFind the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.");
            int Sum = Enumerable.Range(1,100).Sum();
            int Sqaure = Sum * Sum;
            int SumOfSqaure = Enumerable.Range(1, 100).Select(x => x * x).Sum();
            int Difference = Sqaure - SumOfSqaure;
            Console.WriteLine(Difference);
        }
        public void ProblemSeven()
        {
            Console.WriteLine("By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.\nWhat is the 10 001st prime number?");
            List<int> Primes = new List<int>();
            for (int n = 1; Primes.Count<10001; n++)
            {
                int divide = 0;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        divide++;
                        break;
                    }
                }
                if (divide == 0 && n != 1)
                {
                    Primes.Add(n);
                }
            }
            Console.WriteLine(Primes.Last());
        }
        public void ProblemEight()
        {
            Console.WriteLine("The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.\n" +
                            "73167176531330624919225119674426574742355349194934\n" +
                            "96983520312774506326239578318016984801869478851843\n" +
                            "85861560789112949495459501737958331952853208805511\n" +
                            "12540698747158523863050715693290963295227443043557\n" +
                            "66896648950445244523161731856403098711121722383113\n" +
                            "62229893423380308135336276614282806444486645238749\n" +
                            "30358907296290491560440772390713810515859307960866\n" +
                            "70172427121883998797908792274921901699720888093776\n" +
                            "65727333001053367881220235421809751254540594752243\n" +
                            "52584907711670556013604839586446706324415722155397\n" +
                            "53697817977846174064955149290862569321978468622482\n" +
                            "83972241375657056057490261407972968652414535100474\n" +
                            "82166370484403199890008895243450658541227588666881\n" +
                            "16427171479924442928230863465674813919123162824586\n" +
                            "17866458359124566529476545682848912883142607690042\n" +
                            "24219022671055626321111109370544217506941658960408\n" +
                            "07198403850962455444362981230987879927244284909188\n" +
                            "84580156166097919133875499200524063689912560717606\n" +
                            "05886116467109405077541002256983155200055935729725\n" +
                            "71636269561882670428252483600823257530420752963450\n" +
                            "Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?");
            string input = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            long number = 1;
            long max = 0;
            for(int i = 0; i < input.Length - 13; i++)
            {
                number = 1;
                string inputCheck = input.Substring(i, 13);
                if (!inputCheck.Contains("0"))
                {
                    foreach(var num in inputCheck)
                    {
                        int value = Int32.Parse(num.ToString());
                        number *= value;
                    }
                    if (number > max)
                    {
                        max = number;
                    }
                }
            }
            Console.WriteLine(max);

        }
        public void ProblemNine()
        {
            Console.WriteLine("A Pythagorean triplet is a set of three natural numbers, a < b < c, for which a2 + b2 = c2.\nThere exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc. ");
            int a = 0, b = 0, c = 0;
            int s = 1000;
            bool found = false;

            for (a = 1; a < 1000; a++)
            {
                for (b = 1; b < 1000; b++)
                {
                    c = s - a - b;
                    if (a * a + b * b == c * c)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            Console.WriteLine(a*b*c);
        }
        public void ProblemTen()
        {
            Console.WriteLine("The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.\nFind the sum of all the primes below two million.");
            List<int> Primes = new List<int>() { 2 };
            List<int> NumbersToCheck = Enumerable.Range(1, 2000000).Where((c, i) => i % 2 == 0).ToList(); 
            foreach(var n in NumbersToCheck)
            {
                if (IsPrime(n))
                {
                    Primes.Add(n);
                }
            }
            long result = 0;
            foreach(var prime in Primes)
            {
                result += prime;
            }
            Console.WriteLine(result);
        }
        private bool IsPrime(int Number)
        {
            if (Number <= 1)
            {
                return false;
            }

            if (Number == 2)
            {
                return true;
            }

            if (Number % 2 == 0)
            {
                return false;
            }

            int counter = 3;

            while ((counter * counter) <= Number)
            {
                if (Number % counter == 0)
                {
                    return false;
                }
                else
                {
                    counter += 2;
                }
            }

            return true;
        }
        public void ProblemEleven()
        {
            Console.WriteLine("");
        }
        public void Problem12()
        {
            Console.WriteLine("The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:1, 3, 6, 10, 15, 21, 28, 36, 45, 55\nWe can see that 28 is the first triangle number to have over five divisors.\nWhat is the value of the first triangle number to have over five hundred divisors?");
            List<int> Divisors = new List<int>() { 1 };

        }

    }
}
