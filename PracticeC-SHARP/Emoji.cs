using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PracticeC_SHARP
{
    internal class Emoji
    {
        private static Timer aTimer;
        char S = ' ';
        public Emoji()
        {
            bool eyeOn = true;
            aTimer = new System.Timers.Timer(500);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
            void OnTimedEvent(Object source, ElapsedEventArgs e)
            {
                eyeFunction();
            }
        

            void eyeFunction()
            {
                if (eyeOn)
                {
                    Console.Clear();
                    PrintHead();
                    PrintEyeOpen();
                    PrintNose();
                    PrintMouth();

                }
                else
                {
                    Console.Clear();
                    PrintHead();
                    PrintEyeClose();
                    PrintNose();
                    PrintMouth();
                }
                eyeOn = !eyeOn;
            }
            /*PrintHead();
           PrintEyeOpen();
           PrintNose();
           PrintMouth();*/
        }
        void PrintHead()
        {
            
            int lines = 5;
            int initialSpaces = 10;
            int initialStars = 4;
            for(int i = 1; i<=lines; i++)
            {
                for(int j = 1; j<=initialSpaces+initialStars; j++)
                {
                    if (j <= initialSpaces)
                    {
                        Console.Write(S);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
                initialSpaces = initialSpaces - 2;
                initialStars = initialStars + 4;
            }
        }
        void PrintEyeOpen()
        {
            int lines = 2;
            int initialSpaces = 1;
            int initialStars = 22;
            int printEyeSpaceAfterOrBefore = 4;
            int eyeSize = 3;
            for(int i = 1; i<=lines; i++)
            {
                for(int j = 1; j<=initialSpaces+initialStars; j++)
                {
                    if (j <= initialSpaces)
                    {
                        Console.Write(S);
                    }
                    else
                    {
                        if ( 
                            ((j > printEyeSpaceAfterOrBefore) && (j <= printEyeSpaceAfterOrBefore + eyeSize)) ||
                            (((initialSpaces + initialStars)-j <= printEyeSpaceAfterOrBefore-initialSpaces+eyeSize-1) && j <= (((initialSpaces*2) + initialStars)- printEyeSpaceAfterOrBefore))
                           )
                        {
                            Console.Write(S);
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                Console.Write("\n");
                initialSpaces = initialSpaces - 1;
                initialStars = initialStars + 2;
            }
        }


        void PrintEyeClose()
        {
            int lines = 2;
            int initialSpaces = 1;
            int initialStars = 22;
            int printEyeSpaceAfterOrBefore = 4;
            int eyeSize = 3;
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= initialSpaces + initialStars; j++)
                {
                    if (j <= initialSpaces)
                    {
                        Console.Write(S);
                    }
                    else
                    {
                        if (
                            (((initialSpaces + initialStars) - j <= printEyeSpaceAfterOrBefore - initialSpaces + eyeSize - 1) && j <= (((initialSpaces * 2) + initialStars) - printEyeSpaceAfterOrBefore))
                           )
                        {
                            Console.Write(S);
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                Console.Write("\n");
                initialSpaces = initialSpaces - 1;
                initialStars = initialStars + 2;
            }
        }

        void PrintNose()
        {
            int lines = 2;
            int alonLine = 1;
            int initialSpaces = 0;
            int initialStars = 24;
            for (int i = 1; i <= lines; i++)
            {
                for(int j = 1; j <= initialSpaces+initialStars; j++)
                {
                    if(j/2 == 6)
                    {
                        Console.Write(S);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }

            int initialSpacesForAlonLine = 1;
            for(int i = 1; i<=alonLine; i++)
            {
                for(int j = 1; j<= initialSpacesForAlonLine + 22; j++)
                {
                    if (j <= initialSpacesForAlonLine)
                    {
                        Console.Write(S);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }

        }
        void PrintMouth()
        {
            int lines = 2;
            int initialSpaces = 2;
            int initialStars = 20;
            int printSpaceAfterOrBefore = 4;

            for(int i = 1; i<= lines; i++)
            {
                for(int j = 1; j<= initialSpaces+initialStars; j++)
                {
                    if(j <= initialSpaces)
                    {
                        Console.Write(S);
                    }
                    else
                    {
                        if((j > printSpaceAfterOrBefore+initialSpaces) && j <= (((initialSpaces)+initialStars)- printSpaceAfterOrBefore))
                        {
                            Console.Write(S);
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                Console.Write("\n");
                initialStars = initialStars - 4;
                initialSpaces = initialSpaces + 2;
            }

            int lastLineInitialSpaces = 6;
            int lastLineInitialStars = 12;
            for(int i = 1; i< lastLineInitialSpaces + lastLineInitialStars; i++)
            {
                if(i <= lastLineInitialSpaces)
                {
                    Console.Write(S);
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.Write("\n");    
        }
    }
}
