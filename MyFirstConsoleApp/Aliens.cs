using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    public class Aliens
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int HealthPoints { get; set; }

        public void Attack()
        {

        }

        public void Defend()
        {

        }

        public void Move()
        {

        }

        public void Decide()
        {
            Random randNum = new Random();
            int num = randNum.Next(1, 20);

            if(IsEven(num))
            {
                //Engage
                int rand = randNum.Next(1, 10);
                if(IsEven(rand))
                {
                    Attack();
                }
                else
                {
                    Defend();
                }
            }
            else
            {
                //Flee
            }
        }
        // Local Function()
        bool IsEven(int num)
        {
            return (num % 2 == 0);
        }
    }
}
