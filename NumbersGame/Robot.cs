using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    class Robot
    {
        private string _name;

        public Robot(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return this._name; }
        }

        public int MakeMove(int current)
        {
            string currentHolder = current.ToString();
            string testHolder;
            int test;
            int output = -1;

            for (int i = 0; i < currentHolder.Length; i++)
            {
                testHolder = currentHolder.Remove(i, 1);

                int.TryParse(testHolder, out test);
                
                if (test % 4 == 0)
                {
                    output = test;
                }
            }

            if (output == -1)
            {
                testHolder = currentHolder.Remove(1, 1);

                int.TryParse(testHolder, out output);
            }

            return output;
        }

        public bool IsVictorious(int choice)
        {
            if (choice % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
