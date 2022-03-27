using System.Diagnostics;

namespace CorePrograms
{
    public class ConsonentVowelDetect
    {
        char userCharacter;
        bool checkCharIsNum = true;
        public void getChar()
        {
            //Get character from user
            Console.Write("Enter a character");
            userCharacter = Convert.ToChar(Console.Read());
            //Console.WriteLine($"{userCharacter}");
        }

        public void checkConsonentOrVowel()
        {
            // check if entered character is in small case
            if (userCharacter == 'a' || userCharacter == 'e' || userCharacter == 'i' || userCharacter == 'o' || userCharacter == 'u')
            {
                Console.WriteLine($"{userCharacter} is a Vowel");
            }

            // check if entered character is in Capital case
            else if (userCharacter == 'A' || userCharacter == 'E' || userCharacter == 'I' || userCharacter == 'O' || userCharacter == 'U')
            {
                Console.WriteLine($"{userCharacter} is a Vowel");
            }

            //Check if entered character is a Number
            else if (checkCharIsNum == Char.IsNumber(userCharacter))
            {
                    Console.WriteLine($"{userCharacter} is a Number. \nPlease Enter Character");
            }
            else
            {
                Console.WriteLine($"{userCharacter} is a Consonent");
            }
        }
    }
}