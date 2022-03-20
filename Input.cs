using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{

    public class Input
    {
        //Handles the text input for Assessment 1
        //string textfile = "nothing";


        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        
        public string FileTextInput()
        {
            try
            {

                //grabs file and writes whats the file
                string textfile = File.ReadLines(@"C:\Users\Student\Desktop\C++\Assigment 1\CMP1903M Assessment 1 Base Code\CMP1903M Assessment 1 Base Code/textfile.txt");
                return textfile;

            }

            //error handling if it can't read the file
            catch (IOException)
            {
                return "Seems to be an error with reading file, sort me out pls:)"; 
            }


        }
    }
}
