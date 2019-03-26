using System;

namespace techgig
{
    class test

    {
        static void Main(string[] args)
        {
            //enter no. of words to enter
            Console.WriteLine("Enter no. of words to enter");
            int noOfWords = Convert.ToInt32(Console.ReadLine());
            string[] wordsArray = new string[noOfWords];
            for (int i = 0; i < noOfWords; i++)
            {
                wordsArray[i] = Console.ReadLine();
            }

            //looping through each array
            for (int i = 0; i < wordsArray.Length; i++)
            {
                for (int j = 0; j < wordsArray.Length - 1; j++)
                {
                    if (!IsSmaller(wordsArray[j], wordsArray[j + 1]))
                    {
                        string temp = wordsArray[j];
                        wordsArray[j] = wordsArray[j + 1];
                        wordsArray[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Result");
            for (int i = 0; i < wordsArray.Length; i++)
            {
                Console.WriteLine(wordsArray[i]);
            }

        }
        static bool IsSmaller(string word1, string word2)
        {
            int compareLength = word1.Length < word2.Length ? word1.Length : word2.Length;
            for (int i = 0; i < compareLength; i++)
            {
                if (word1[i] < word2[i])
                {
                    return true;
                }
                else if (word1[i] > word2[i])
                {
                    return false;
                }

            }
            char[] substr = new char[compareLength];
            if (word1.Length > word2.Length) {
                for (int i = 0; i < compareLength; i++)
                {
                    substr[i] = word1[i];
                }
                if (substr.ToString() == word2)
                {
                    return false;
                }

            }
            else
            {
                for (int j = 0; j < compareLength; j++)
                {
                    substr[j] = word2[j];
                }

                if (substr.ToString()==word1)
                {
                    return false;
                } }

            
            return false;
        }
    }


}