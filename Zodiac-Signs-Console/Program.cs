using System;

namespace Zodiac_Signs_Console
{
    class Program
    {
        static void Capricorn()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Capricorn\n");
            Console.WriteLine("STRENGHTS\nResponsible, disciplined, self-control, good managers\n");
            Console.WriteLine("WEAKNESSES\nKnow-it-all, unforgiving, condescending, expecting the worst\n");
        }
        static void Aquarius()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Aquarius\n");
            Console.WriteLine("STRENGHTS\nProgressive, original, independent, humanitarian\n");
            Console.WriteLine("WEAKNESSES\nRuns from emotional expression, temperamental, uncompromising, aloof\n");
        }
        static void Pisces()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Pisces\n");
            Console.WriteLine("STRENGHTS\nCompassionate, artistic, intuitive, gentle, wise, musical\n");
            Console.WriteLine("WEAKNESSES\nFearful, overly trusting, sad, desire to escape reality, can be a victim or a martyr\n");
        }
        static void Aries()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Aries\n");
            Console.WriteLine("STRENGHTS\nCourageous, determined, confident, enthusiastic, optimistic, honest, passionate\n");
            Console.WriteLine("WEAKNESSES\nImpatient, moody, short-tempered, impulsive, aggressive\n");
        }
        static void Taurus()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Taurus\n");
            Console.WriteLine("STRENGHTS\nReliable, patient, practical, devoted, responsible, stable\n");
            Console.WriteLine("WEAKNESSES\nStubborn, possessive, uncompromising\n");
        }
        static void Gemini()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Gemini\n");
            Console.WriteLine("STRENGHTS\nGentle, affectionate, curious, adaptable, ability to learn quickly and exchange ideas\n");
            Console.WriteLine("WEAKNESSES\nNervous, inconsistent, indecisive\n");
        }
        static void Cancer()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Cancer\n");
            Console.WriteLine("STRENGHTS\nTenacious, highly imaginative, loyal, emotional, sympathetic, persuasive\n");
            Console.WriteLine("WEAKNESSES\nMoody, pessimistic, suspicious, manipulative, insecure\n");
        }
        static void Leo()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Leo\n");
            Console.WriteLine("STRENGHTS\nCreative, passionate, generous, warm-hearted, cheerful, humorous\n");
            Console.WriteLine("WEAKNESSES\nArrogant, stubborn, self-centered, lazy, inflexible\n");
        }
        static void Virgo()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Virgo\n");
            Console.WriteLine("STRENGHTS\nLoyal, analytical, kind, hardworking, practical\n");
            Console.WriteLine("WEAKNESSES\nShyness, worry, overly critical of self and others, all work and no play\n");
        }
        static void Libra()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Libra\n");
            Console.WriteLine("STRENGHTS\nCooperative,diplomatic, gracious, fair-minded, social\n");
            Console.WriteLine("WEAKNESSES\nIndecisive, avoids confrontations, will carry a grudge, self-pity\n");
        }
        static void Scorpio()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Scorpio\n");
            Console.WriteLine("STRENGHTS\nResourceful, brave, passionate, stubborn, a true friend\n");
            Console.WriteLine("WEAKNESSES\nDistrusting, jealous, secretive, violent\n");
        }
        static void Sagittarius()
        {
            Console.WriteLine("Your Zodiac sign is: ");
            Console.WriteLine("Sagittarius\n");
            Console.WriteLine("STRENGHTS\nGenerous, idealistic, great sense of humor\n");
            Console.WriteLine("WEAKNESSES\nPromises more than can deliver, very impatient, will say anything no matter how undiplomatic\n");
        }
        static void ErrorMessage()
        {
            Console.WriteLine("Sorry, that month\\day is not valid. [Press ENTER to start over]");
            Console.ReadLine();
            Console.Clear();
            MyZodiac();
        }
        static void MyZodiac()
        {
            // User inputs month and day of birth
            Console.WriteLine("Enter your month of birth: ");
            string inputMonth = Console.ReadLine();
            string myMonth = inputMonth.ToUpper(); // (kinda lazy) way to go around case sensetivity
            Console.WriteLine("Enter your day of birth: ");
            int myDay = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            // Months and corresponding Zodiac sign            
            switch (myMonth)
            {
                case "JANUARY":
                    if (myDay < 23)
                    {
                        Capricorn();
                    }
                    else if (myDay > 22 && myDay < 32)
                    {
                        Aquarius();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case "FEBRUARY":
                    if (myDay < 19)
                    {
                        Aquarius();
                    }
                    else if (myDay > 18 && myDay < 30)
                    {
                        Pisces();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case "MARS":
                    if (myDay < 21)
                    {
                        Pisces();
                    }
                    else if(myDay > 20 && myDay < 32)
                    {                        
                        Aries();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case "APRIL":
                    if (myDay < 20)
                    {
                        Aries();
                    }
                    else if (myDay > 19 && myDay < 31)
                    {
                        Taurus();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case "MAY":
                    if (myDay < 21)
                    {
                        Taurus();
                    }
                    else if (myDay > 20 && myDay < 32)
                    {
                        Gemini();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case "JUNE":
                    if (myDay < 22)
                    {
                        Gemini();
                    }
                    else if (myDay > 21 && myDay < 31)
                    {
                        Cancer();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case "JULY":
                    if (myDay < 23)
                    {
                        Cancer();
                    }
                    else if (myDay > 22 && myDay < 32)
                    {
                        Leo();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case "AUGUST":
                    if (myDay < 23)
                    {
                        Leo();
                    }
                    else if (myDay > 22 && myDay < 32)
                    {
                        Virgo();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case "SEPTEMBER":
                    if (myDay < 23)
                    {
                        Virgo();
                    }
                    else if (myDay > 22 && myDay < 31)
                    {
                        Libra();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case "OCTOBER":
                    if (myDay < 24)
                    {
                        Libra();
                    }
                    else if (myDay > 23 && myDay < 32)
                    {
                        Scorpio();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case "NOVEMBER":
                    if (myDay < 22)
                    {
                        Scorpio();
                    }
                    else if (myDay > 21 && myDay < 31)
                    {
                        Sagittarius();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case "DECEMBER":
                    if (myDay < 22)
                    {
                        Sagittarius();
                    }
                    else if (myDay > 21 && myDay < 32)
                    {
                        Capricorn();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                default:
                    {
                        ErrorMessage();
                    }
                    break;
            }
        }
        static void Main()
        {
            // Infinite loop of the Zodiac Signs method and clearing the screen on user input
            for (; ; )
            {
                MyZodiac();
                Console.WriteLine("[Press ENTER to start over]");
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
