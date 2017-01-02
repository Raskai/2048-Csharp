using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        ulong board = 0;
        Random r = new Random();
        int pos1;
        int pos2;
        pos1 = 1 << (int)(r.Next(0, 16) * 4);
        pos2 = 1 << (int)(r.Next(0, 15) * 4);
        if(pos2 >= pos1) {
            pos2 = pos2 << 4;
        }
        Console.WriteLine(pos1);
        Console.WriteLine(pos2);
        board = (ulong)pos1 + (ulong)pos2;
        Console.WriteLine(board);
        
    }
}
