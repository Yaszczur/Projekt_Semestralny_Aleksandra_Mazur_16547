using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektSemestralny_Aleksandra_Mazur_16547
{
    class GeneratorHasel
    {
        private Random _random = new Random();

        public string Generate(int length)
        {
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = (char)_random.Next(33, 126);
            }

            return new string(password);
        }
    }
}