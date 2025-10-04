
using BuoiTH1_Bai8;
using System;
using System.Text;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        GPTB2 pt = new GPTB2();
        pt.input();
        pt.TinhNghiem();
        pt.output();
        Console.ReadLine();

    }
}
