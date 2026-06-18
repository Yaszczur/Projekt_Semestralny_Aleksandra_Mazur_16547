using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjektSemestralny_Aleksandra_Mazur_16547
{
    class PlikZHaslami
    {
        private readonly string _path;

        public PlikZHaslami(string path)
        {
            _path = path;
        }

        public void AddPassword(string password)
        {
            File.AppendAllText(_path, password + System.Environment.NewLine);
        }

        public string[] GetAllPasswords()
        {
            if (!File.Exists(_path))
                return new string[0];

            return File.ReadAllLines(_path);
        }
    }
}