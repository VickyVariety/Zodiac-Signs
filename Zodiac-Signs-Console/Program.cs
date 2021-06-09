using System;
using System.Collections.Generic;

namespace Zodiac_Signs_Console
{
    class Program
    {
        static List<string> Capricorn()
        {
            return new List<string>()
            {
                "Capricorn\n",
                "STRENGHTS\nResponsible, disciplined, self-control, good managers\n",
                "WEAKNESSES\nKnow-it-all, unforgiving, condescending, expecting the worst\n"
            };
        }
        static List<string> Aquarius()
        { 
            return new List<string>()
            {
                "Aquarius\n",
                "STRENGHTS\nProgressive, original, independent, humanitarian\n",
                "WEAKNESSES\nRuns from emotional expression, temperamental, uncompromising, aloof\n"
            };
        }
        static List<string> Pisces()
        {
            return new List<string>()
            {
            "Pisces\n",
            "STRENGHTS\nCompassionate, artistic, intuitive, gentle, wise, musical\n",
            "WEAKNESSES\nFearful, overly trusting, sad, desire to escape reality, can be a victim or a martyr\n"
            };
        }
        static List<string> Aries()
        {
            return new List<string>()
            {
            "Aries\n",
            "STRENGHTS\nCourageous, determined, confident, enthusiastic, optimistic, honest, passionate\n",
            "WEAKNESSES\nImpatient, moody, short-tempered, impulsive, aggressive\n"
            };
        }
        static List<string> Taurus()
        {
            return new List<string>()
            {
            "Taurus\n",
            "STRENGHTS\nReliable, patient, practical, devoted, responsible, stable\n",
            "WEAKNESSES\nStubborn, possessive, uncompromising\n"
            };
        }
        static List<string> Gemini()
        {
            return new List<string>()
            {
            "Gemini\n",
            "STRENGHTS\nGentle, affectionate, curious, adaptable, ability to learn quickly and exchange ideas\n",
            "WEAKNESSES\nNervous, inconsistent, indecisive\n"
            };
        }
        static List<string> Cancer()
        {
            return new List<string>()
            {            
            "Cancer\n",
            "STRENGHTS\nTenacious, highly imaginative, loyal, emotional, sympathetic, persuasive\n",
            "WEAKNESSES\nMoody, pessimistic, suspicious, manipulative, insecure\n"
            };
        }
        static List<string> Leo()
        {
            return new List<string>()
            {
            "Leo\n",
            "STRENGHTS\nCreative, passionate, generous, warm-hearted, cheerful, humorous\n",
            "WEAKNESSES\nArrogant, stubborn, self-centered, lazy, inflexible\n"
            };
        }
        static List<string> Virgo()
        {
            return new List<string>()
            {
            "Virgo\n",
            "STRENGHTS\nLoyal, analytical, kind, hardworking, practical\n",
            "WEAKNESSES\nShyness, worry, overly critical of self and others, all work and no play\n"
            };
        }
        static List<string> Libra()
        {
            return new List<string>()
            {
            "Libra\n",
            "STRENGHTS\nCooperative,diplomatic, gracious, fair-minded, social\n",
            "WEAKNESSES\nIndecisive, avoids confrontations, will carry a grudge, self-pity\n"
            };
        }
        static List<string> Scorpio()
        {
            return new List<string>()
            {
            "Scorpio\n",
            "STRENGHTS\nResourceful, brave, passionate, stubborn, a true friend\n",
            "WEAKNESSES\nDistrusting, jealous, secretive, violent\n"
            };
        }
        static List<string> Sagittarius()
        {
            return new List<string>()
            {
            "Sagittarius\n",
            "STRENGHTS\nGenerous, idealistic, great sense of humor\n",
            "WEAKNESSES\nPromises more than can deliver, very impatient, will say anything no matter how undiplomatic\n"
            };
        }
        /*static void ErrorMessage()
        {
        Your Zodiac sign is: 
            Console.WriteLine("Sorry, that month\\day is not valid. [Press ENTER to start over]");
            Console.ReadLine();
            Console.Clear();d
            MyZodiac();
        }*/
        static bool ParseInput(out List<string> result, string myMonth, int myDay)
        {
            result = new List<string>();
            
            switch (myMonth)
            {
                case "JANUARY":
                    if (myDay < 23)
                        result = Capricorn();
                    if (myDay > 22 && myDay < 32)
                        result = Aquarius();
                    break;
                case "FEBRUARY":
                    if (myDay < 23)
                        result = Capricorn();
                    if (myDay > 22 && myDay < 30)
                        result = Aquarius();
                    break;
                case "MARS":
                    if (myDay < 21)
                        result = Pisces();
                    if (myDay > 20 && myDay < 32)
                        result = Aries();
                    break;
                case "APRIL":
                    if (myDay < 20)
                        result = Aries();
                    if (myDay > 19 && myDay < 31)
                        result = Taurus();
                    break;
                case "MAY":
                    if (myDay < 21)
                        result = Taurus();
                    if (myDay > 20 && myDay < 32)
                        result = Gemini();
                    break;
                case "JUNE":
                    if (myDay < 22)
                        result = Gemini();
                    if (myDay > 21 && myDay < 31)
                        result = Cancer();
                    break;
                case "JULY":
                    if (myDay < 23)
                        result = Cancer();
                    if (myDay > 22 && myDay < 32)
                        result = Leo();
                    break;
                case "AUGUST":
                    if (myDay < 23)
                        result = Leo();
                    if (myDay > 22 && myDay < 32)
                        result = Virgo();
                    break;
                case "SEPTEMBER":
                    if (myDay < 23)
                        result = Virgo();
                    if (myDay > 22 && myDay < 31)
                        result = Libra();
                    break;
                case "OCTOBER":
                    if (myDay < 24)
                        result = Libra();
                    if (myDay > 23 && myDay < 32)
                        result = Scorpio();
                    break;
                case "NOVEMBER":
                    if (myDay < 22)
                        result = Scorpio();
                    if(myDay > 21 && myDay < 31)
                        result = Sagittarius();
                    break;
                case "DECEMBER":
                    if (myDay < 22)
                        result = Sagittarius();
                    if(myDay > 21 && myDay < 32)
                        result = Capricorn();
                    break;
            }
            if (result.Count == 0)
            {
                result = new List<string>()
                {
                    "Sorry, that month\\day is not valid. [Press ENTER to start over]"
                };
                return false;
            }
            return true;
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
            if (!ParseInput(out List<string> result, myMonth, myDay))
            {
                PrintResult(result);
                return;
            }
            result.Insert(0, "Your Zodiac sign is: ");
            PrintResult(result);
        }
        static void PrintResult(List<string> result) {
            Console.WriteLine(String.Join("\n", result));
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
