using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Uni
{
    public static class Factory
    {
        public static string Name()
        {
            string path = Path.GetFullPath(@"..\..\data/names.txt");
            string[] names = File.ReadAllLines(path);
            return names[new Random().Next(0, names.Length)];
        }
        public static ulong PESEL()
        {
            Random random = new Random();
            string str = "";
            str += random.Next(50, 100).ToString();
            str += random.Next(0, 13).ToString();
            str += random.Next(0, 31).ToString();
            str += random.Next(10000, 100000).ToString();
            return ulong.Parse(str);
        }
        public static int Phone()
        {
            return new Random().Next(100000000, 1000000000);
        }
        public static string Email()
        {
            string[] emails = File.ReadAllLines("./data/emails.txt");
            return emails[new Random().Next(0, emails.Length)];
        }
        public static string Birthday()
        {
            Random random = new Random();
            string str = "";
            str += random.Next(1970, 2002).ToString();
            str += random.Next(0, 13).ToString();
            str += random.Next(0, 31).ToString();
            return str;
        }
    }
}
