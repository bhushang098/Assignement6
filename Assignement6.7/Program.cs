﻿class Program

{

    static void Main(string[] args)

    {

        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };

        char name = ' ';

        int[] a = new int[10];

        for (int i = 0; i < letters.Length; i++)

        {

            name = letters[i];

            a[i] = i + 1;

            SendMessage(name, a[i]);

        }

        Console.ReadKey();

        static void SendMessage(char name, int msg)

        {

            Console.WriteLine("Hello, " + name + "! Count to " + msg);

        }

    }

}
