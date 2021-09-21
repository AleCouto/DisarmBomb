using System;

namespace DisarmBomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            do
            {
                DisplayMenu();
                SplitSequence(Console.ReadLine());
                DisplayMenu2();
                i = Convert.ToInt32(Console.ReadLine());
            }
            while (i != 2);
            Console.Clear();
            Console.WriteLine("End");
        }

        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("---------------------*******DISARM BOMB******---------------------");
            Console.WriteLine("Your mission is to defuse the bomb by choosing a string of wires.");
            Console.WriteLine("You will have to choose the right sequence between the colors:");
            Console.WriteLine("Black, White, Green, Red, Orange and Purple.");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Enter a color sequence to disarm the Bomb: ");
        }

        public static void DisplayMenu2()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------****DISARM BOMB****---------");
            Console.WriteLine("Would you like to try one more time?");
            Console.WriteLine("[1]-Sim");
            Console.WriteLine("[2]-Não");
            Console.WriteLine("-------------------------------------");
        }

        public static void SplitSequence(string sequence)
        {
            Position pst = new Position();
            char[] separator = { ' ' };
            string[] sliceSequence = sequence.Split(separator);
            for (int count = 0; count <= sliceSequence.Length - 1; count++)
            {
                try
                {
                    string sq1 = sliceSequence[count];
                    string sq2 = sliceSequence[count + 1];

                    //Console.WriteLine(string.Format("Parte {0}: {1}", count + 1, sliceSequence[count]));// linha de verificação
                    //Console.WriteLine("* {0}", sq1);// linha de verificação
                    //Console.WriteLine("* {0}", sq2);// linha de verificação

                    if (pst.CheckNextPosition(sq1, sq2))
                    {
                        Console.WriteLine("#############################");
                        Console.WriteLine("###### Bomb Exploded!! ######");
                        Console.WriteLine("#############################");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("------ Bomb Disarmed!! ------");
                    break;
                }
            }
        }
    }
}
