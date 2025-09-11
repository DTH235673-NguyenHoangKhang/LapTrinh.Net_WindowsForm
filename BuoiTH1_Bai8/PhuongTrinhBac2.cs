using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace BuoiTH1_Bai8

{
    internal class GPTB2
    {
        private int Soa;
        private int Sob;
        private int Soc;
        private float x1;
        private float x2;   

        public float X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public float X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int SoA
        {
            get { return Soa; }
            set { Soa = value; }
        }
        public int SoB
        {
            get { return Sob; }
            set { Sob = value; }
        }
        public int SoC
        {
            get { return SoC; }
            set { SoC = value; }
        }
        public void input()
        {
            Console.Write(" \t -Nhap so thu 1:");
            SoA = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \t -Nhap so thu 2:");
            SoB = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \t -Nhap so thu 3:");
            SoC = Convert.ToInt32(Console.ReadLine());

        }
        public int TinhNghiem()
        {
            float delta = SoB * SoB - 4 * SoA * SoC;
            float CanDelta = Convert.ToSingle(Math.Sqrt(delta));
            if (CanDelta < 0)
            {
                return 0;
            }
            if (CanDelta == 0)
            {

                X1 = -(float)SoB /( 2 * SoA);
                X2 = X1;
                return 1;
            }
            if (CanDelta > 0)
            {

                X1 = (float)(-SoB + CanDelta) / (2 * SoA);
                X2 = (float)(-SoB - CanDelta) /( 2 * SoA);
            }
            return 2;
        }
        public void output()
        {
            int kq = TinhNghiem();
            if (kq == 0)
            {
                Console.WriteLine(" \t -Phuong trinh vo nghiem");
            }
            if (kq == 1)
            {
                Console.WriteLine(" \t -Phuong trinh co nghiem kep x1=x2={0}", X1);
            }
            if (kq == 2)
            {
                Console.WriteLine(" \t -Phuong trinh co 2 nghiem phan biet:");
                Console.WriteLine(" \t +Nghiem thu nhat x1={0}", X1);
                Console.WriteLine(" \t +Nghiem thu hai x2={0}", X2);
            }
        }
    }

}