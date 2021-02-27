using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace federico.gori._4j.datadelgiorno
{
    class Program
    {
        static void Main(string[] args)
        {

            Data data1 = new Data();
            Data data2 = new Data(20, 12, 2006);

            Console.WriteLine(data1.CostData());
            Console.WriteLine(data2.CostData());

            data1.TogliGiorni(10);
            data2.AggGiorni(26);



            if (data1.anno>data2.anno)
            {
                Console.WriteLine("la seconda data è precedente alla prima");
            }
            if (data1.anno < data2.anno)
            {
                Console.WriteLine("la prima data è precedente alla seconda");
            }
            if(data1.anno == data2.anno)
            {
                if (data1.mese > data2.mese)
                {
                    Console.WriteLine("la seconda data è precedente alla prima");
                }
                if (data1.mese < data2.mese)
                {
                    Console.WriteLine("la prima data è precedente alla seconda");
                }
                if(data1.mese == data2.mese)
                {
                    if (data1.giorno > data2.giorno)
                    {
                        Console.WriteLine("la seconda data è precedente alla prima");
                    }
                    if (data1.giorno < data2.giorno)
                    {
                        Console.WriteLine("la prima data è precedente alla seconda");
                    }
                    if (data1.giorno == data2.giorno)
                    {
                        Console.WriteLine("le date sono uguali");
                    }
                }
            }

            Console.ReadLine();
        }
    }

    class Data
    {
        public int giorno;
        public int mese;
        public int anno;
        public string datacomp;

        public Data()
        {
            giorno = 1;
            mese = 1;
            anno = 1900;
            datacomp = ("01/01/1900");
        }

        public Data(int g, int m, int a)
        {
            giorno = g;
            mese = m;
            anno = a;
            datacomp = (giorno + "/" + mese + "/" + anno);
        }

        public void AggGiorni(int gginpiu)
        {
            giorno = giorno + gginpiu;
            if (giorno > 30)
            {
                mese++;
                giorno = giorno - 30;
                if (mese > 12)
                {
                    anno++;
                    mese = mese - 12;
                }
            }
            Console.WriteLine(giorno + "/" + mese + "/" + anno);
        }

        public void TogliGiorni(int gginmeno)
        {
            giorno = giorno - gginmeno;
            if (giorno < 30)
            {
                mese--;
                giorno = giorno + 30;
                if (mese < 1)
                {
                    anno--;
                    mese = mese + 12;
                }
            }
            Console.WriteLine(giorno + "/" + mese + "/" + anno);
        }

        public string CostData()
        {
            return datacomp;
        }
        /*public string FormatoData(string formato)
        {
            string form = "";
            if (formato == "GMA")
            {
                form = (giorno + "/" + mese + "/" + anno);
            }
            if (formato == "MGA")
            {
                form = (mese + "/" + giorno + "/" + anno); 
            }
            if (formato == "AMG")
            {
                form = (anno + "/" + mese + "/" + giorno);
            }
            return form;
        }*/

    }
}
