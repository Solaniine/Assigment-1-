//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            

            //Create 'Input' object
            //Get either manually entered text, or text from a file


                Input text = new();
                string text_file = text.FileTextInput();




            //Create an 'Analyse' object
                Analyse analysee = new Analyse();

            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }
        
        
    
    }
}
