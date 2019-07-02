using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz();
        }

        static string[] questions = { "\n1. WHO WAS THE FIRST MAN TO WALK ON THE MOON?",
                                     "\n2. When was Microsoft FOunded?,",
                                      "\n3. HOW many Local Government does Lagos have?",
                                  "\n4. _______ is the Minister of Science and Technology? ",
                                     "\n5. The Largest River in the World is?",
                                       "\n6. Who is the COO of Cyberspace Network Limited? ",
                                        "\n7. What does the eagle in the Nigerian coat of arm represent?",
             "\n8. Who is the current president of Liberia?",
            "\n9. 'OS' computer abbreviation usually means ?",
            "\n10. Who developed Yahoo?"};
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
        static string[] answer = { "a", "b", "a", "b", "d", "c", "a", "b", "c", "b" };
        static string userName = "";
        static string userAge = "";
        static string userAddress = "";

        static void Quiz()
        {
            Console.WriteLine("WELCOME TO CYBERACADEMY QUIZ CHALLENGE");
            Console.WriteLine(" KINDLY INPUT  YOUR  FULL  NAME");
            userName = Console.ReadLine();
            Console.WriteLine("KINDLY INPUT YOUR AGE");
            userAge = Console.ReadLine();
            Console.WriteLine("KINDLY INPUT YOUR ADDRESS");
            userAddress = Console.ReadLine();
            Console.WriteLine("\nINSTRUCTION: ANSWER ALL QUESTIONS. " +
                    "\nCHOOSE THE CORRECT ANSWER FROM THE OPTIONS(Either A,B,C,or D) AVAILABLE \n PRESS ANY KEY TO START YOUR QUIZ");
            Console.ReadLine();
            UserInfo();
            Questions();
            //double res = Questions();
            //string User = UserInfo();

            Console.ReadKey();

        }

       
        static string UserInfo()
        {
             return (userName + "\n" + userAge + "\n" + userAddress);
        }
        static ArrayList maAL = new ArrayList();
        static ArrayList maAl2 = new ArrayList();
        static ArrayList maAl3 = new ArrayList();

        static double Questions()
        {
            int result = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(questions[i]);
                Console.WriteLine(options[i]);
                string userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == answer[i])
                    result += 1;

                else { result += 0; }
                if (userAnswer.ToLower() != answer[i])
                {
                    maAL.Add(questions[i]);
                    maAl2.Add(options[i]);
                    maAl3.Add(answer[i]);
                }
            }
            string[] myArray = (string[])maAL.ToArray(typeof(string));
            string[] myArray2 = (string[])maAl2.ToArray(typeof(string));
            string[] myArray3 = (string[])maAl3.ToArray(typeof(string));
            Console.WriteLine($"THANK YOU! \n {userName} Scored {result}/10  ");

            Console.WriteLine("THE ANSWERS TO THE QUESTION YOU FAILED CAN BE FOUND BELOW");
            for (int i = 0; i < maAL.Count; i++)
            {
                Console.WriteLine($"{myArray[i]}  {myArray2[i]}  {myArray3[i].ToUpper()}");
           
            }
            Console.ReadKey();
           
            return result;

            //foreach(Object o in maAL )
            //    Console.WriteLine(o);
            //foreach (Object o in maAl2)
            //    Console.WriteLine(o);
            //foreach (Object o in maAl3)
            //    Console.WriteLine(o);
            // double resultPercent = (result / 10) * 100;


        }
    }
}

