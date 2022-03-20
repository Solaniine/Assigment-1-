using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {

        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
;

        public List<int> analyseText(string input)
        {


            int i = 0;
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            int numberofsentences = 0;
            for (i = 0; i < FileTextInput.Length; i++)
            {

                if (FileTextInput.Contains("."))
                {
                    numberofsentences++;
                }
            }
            //2. Number of vowels
            int numberofvowels = 0;
            for (i = 0; i < FileTextInput.Length; i++)
            {
                
                if (FileTextInput.Contains("a") || FileTextInput.Contains("e") || FileTextInput.Contains("i") || FileTextInput.Contains("o") || FileTextInput.Contains("u"))
                {
                    numberofvowels++;
                }
            }
            //3. Number of consonants
            int numberofcons = 0;
            for(i =0; i <FileTextInput.Length; i++)
            {
                numberofcons =  FileTextInput.Length - numberofvowels;
            }
            //4. Number of upper case letters
            int numberofupper = 0;
            for(i = 0; i < FileTextInput.Length; i++)
            {
                if(FileTextInput.IsUpper(FileTextInput[i]))
                {
                    numberofupper++;
                }
            }
            //5. Number of lower case letters
            int numberoflower = 0;
            for (i = 0; i < FileTextInput.Length; i++)
            {
                if (FileTextInput.IsLower(FileTextInput[i]))
                {
                    numberoflower++;
                }
            }
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int j = 0; j<5; j++)
            {
                values.Add(0);
                Console.WriteLine("amount of sentences", numberofsentences);
            }


            return values;
        }
    }
}
