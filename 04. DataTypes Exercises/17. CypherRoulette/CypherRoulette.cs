using System;

namespace _17.CypherRoulette
{
    class CypherRoulette
    {
        static void Main()
        {
            var numberOfStrings = int.Parse(Console.ReadLine());
            var cypheredString = "";
            var currentString = "";
            var lastString = "";
            var spins = 0;
            for (int i = 0; i < numberOfStrings; i++)
            {
                currentString = Console.ReadLine();
                if (currentString == "spin")
                {
                    i--;
                    spins++;
                }
                else if (spins % 2 == 1)
                {
                    //frontString += currentString;
                    cypheredString = currentString + cypheredString;
                }
                else if (spins % 2 == 0)
                {
                    cypheredString += currentString;
                }
                else
                {
                    cypheredString += currentString;
                }
                if (currentString == lastString)
                {
                    cypheredString = "";
                }
                lastString = currentString;
            }
            if (numberOfStrings != 0)
            {
                Console.WriteLine(cypheredString);
            }
        }
        public void FromDeni()
        {
            int num = int.Parse(Console.ReadLine());
            string result = String.Empty;
            var spinCount = 1;
            string lastStr = String.Empty;

            for (int i = 0; i < num; i++)
            {
                string newStr = Console.ReadLine();

                if (newStr == lastStr)
                {
                    result = String.Empty;

                    if (newStr == "spin")
                    {
                        i--;
                    }
                }
                else
                {
                    if (newStr == "spin")
                    {
                        i--;
                        spinCount++;
                    }
                    else if (newStr != "spin")
                    {
                        if (spinCount % 2 == 0)
                        {
                            result = newStr + result;
                        }
                        else if (spinCount % 2 != 0)
                        {
                            result = result + newStr;
                        }
                    }
                }

                lastStr = newStr;
            }

            Console.WriteLine(result);
        }
    }
}
