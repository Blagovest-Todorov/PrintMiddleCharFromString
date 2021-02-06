using System;

namespace TakeMiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            int length = inputWord.Length;

            string endResult = string.Empty; 

            if (length % 2 == 0)  // array has even number elements
            {
                endResult = GetMiddleElements(inputWord[length/2 - 1], inputWord[length/2]);                
            }
            else // if (length % 2 != 0)  //Array has odd numebr elemetns   
            {
                endResult = GetMiddleElement(inputWord[length/2]);                
            }

            Console.WriteLine(endResult);
            
        }

        public static string GetMiddleElements(char firstMiddleElement, char secMiddleElement)
        {
            return (firstMiddleElement.ToString() + secMiddleElement.ToString());
        }

        public static string GetMiddleElement(char middleElement)
        {
            return middleElement.ToString();
        }

    }
}
