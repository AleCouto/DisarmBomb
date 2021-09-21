using System;
using System.Collections;

namespace DisarmBomb
{
    public class Position
    {
        public string sq1;
        public string sq2;

        public Position()
        {

        }

        public Position(string sq1, string sq2)
        {
            this.sq1 = sq1;
            this.sq2 = sq2;
        }
        public bool CheckNextPosition(string sq1, string sq2)
        {
            bool flag = false;

            if (sq1 == "white")
            {
                if ((sq2 == "white") || (sq2 == "black"))
                {
                    flag = true;
                }
            }

            if (sq1 == "red")
            {
                if (sq2 != "green")
                {
                    flag = true;
                }
            }

            if (sq1 == "black")
            {
                if ((sq2 == "white") || (sq2 == "green") || (sq2 == "orange"))
                {
                    flag = true;
                }
            }

            if (sq1 == "orange")
            {
                if ((sq2 != "red") && (sq2 != "black"))
                {
                    flag = true;
                }
            }

            if (sq1 == "green")
            {
                if ((sq2 != "orange") && (sq2 != "white"))
                {
                    flag = true;
                }
            }
            if (sq1 == "purple")
            {
                if ((sq2 != "black") && (sq2 != "red"))
                {
                    flag = true;
                }
            }
            return flag;  
        }
    }
}

