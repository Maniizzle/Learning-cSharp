using System;
using OlamideUtility.core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1week2
{
    class Program
    {
        static string state = @" 
            
            ";
        static string[] questions = { " WHO WAS THE FIRST MAN TO WALK ON THE MOON?",
                                     " When was Microsoft FOunded?,",
                                      " HOW many Local Government does Lagos have?",
                                  " _______ is the Minister of Science and Technology? ",
                                     " The Largest River in the World is?",
                                       " Who is the COO of Cyberspace Network Limited? ",
                                        " What does the eagle in the Nigerian coat of arm represent?",
             " Who is the current president of Liberia?",
            " 'OS' computer abbreviation usually means ?",
            " Who developed Yahoo?"};
        static string[] options =
           {"A. Neil Armstrong \nB. Micheal Collin \nC. Buzz Aldrin \nD. Elon MUsk ",
                 "A. 4 April, 1975 \nB. 1 April, 1976 \nC. 4 April, 1976 \nD. 1 April, 1975" ,
                "A. 20 \nB. 15 \nC. 17 \nD. 24 ",
                "A. Muhammed Musa Bello \nB. Ogbonnaya Onu \nC. Kayode Fayemi \nD. Chris Ngige",
                 "A. Amazon River \nB. Red Sea  \nC. Yellow River \nD. RIver Nile",
                 "A. Jim Ovia \nB. Victor Agbulele \nC. Stanley Odua \nD. Evans Okosodo",
                 "A. Strength \nB. Dignity \nC. Peace \nD. Power",
                   "A. Muhammadu Buhari \nB. George Weah \nC. DOnald Trump \nD. Uhuru Kenyatta",
                 "A. Order of Significance \nB. Open Software \nC. Operating System \nD. Optical Sensor",
               "A. Dennis Ritchie & Ken Thompson \nB. David Filo & Jerry Yang \nC. Vint Cerf & Robert Kahn \nD. Steve Case & Jeff Bezos"};

        //static int Num(int s)
        //{
        //    return s;
        //}
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> randomNumbers = new List<int>();
            List<int> ranNumbers = new List<int>();
            int optioncount = 4;
            int count = 10;
            for (int i = 0; i < count; i++)
            {
                int number;
                do number = random.Next(0, 10);
                while (randomNumbers.Contains(number));
                randomNumbers.Add(number);
            }
            for (int j = 0; j < optioncount; j++)
            {
                    int numbers;
                    do numbers = random.Next(0, 4);
                    while (ranNumbers.Contains(numbers));
                    ranNumbers.Add(numbers);
            }
            
            int f = 1;
            string[] Option = { "A", "B", "C", "D" };
            int y = 0;
            foreach (int a in randomNumbers)
            {
                
                Console.WriteLine($"{f}. {questions[a]}");

                foreach (int b in ranNumbers)
                {
                    Console.WriteLine($"{Option[y]}. {options[a]}");
                    y++;
                }
                f++;
            }
            Console.ReadLine();

            //Console.WriteLine(OlaUtility.ConvertNumberToWords(900060823));
            //Console.WriteLine(OlaUtility.BaseToBase("123456789abcdef", 16, 2));
            //Console.ReadKey();



            //    Console.WriteLine(MaxNumber(4, 5));
            //    string word = Left("coming", 3);
            //    string Mid = Middle("happy people", 6, 2);
            //    Console.WriteLine(Mid);
            //    Console.WriteLine(word);
            //    Console.ReadLine();

            //    string postman = "Politics, election, 2019 voters card, presidential election";
            //    string[] seperators = new[] { ",", "_" };
            //    string[] B = postman.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            //    Console.WriteLine(B.Length + "Seperate string Found!");
            //    if (B.Length > 0)
            //    {
            //        foreach (string item in B)
            //        {
            //            Console.WriteLine($"{item}");

            //        }
            //    }
            //}
            //static string Left(string a, int b)
            //{
            //    return a.Substring(0, b);
            //}
            //static string Right(string n, int b)
            //{
            //    int c = n.Length - b;

            //    return n.Substring(c, b);
            //}

            //static string Middle(string n, int a, int b)
            //{
            //    int c = a - 1;
            //    return n.Substring(c, b);
            //}


            //char a = 'A';
            //char b = 'B';

            //static double MaxNumber(double firstValue, double secondValue)
            //{
            //    var res = firstValue;
            //    if (firstValue < secondValue){
            //        res = secondValue;
            //    }
            //        return res;
            //}


            //bool c = char.

            //escape characters
            /*
             * Example of escape characters:
             \n : the new line character
             \t: tab character(use this escape token to create tab spaces)
             \r: Carriage return(similar to presssing the eneter key in your keyboard)
             \\ :Escape the backlash character useful when working with part in code e.g C:myfile.txt
             \": escape the quote character
             */

        }
    }
}
