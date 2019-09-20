using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace WConsoleApp2
{
    public class Project
    {
        public static string[] Op = { "+", "-", "*", "/" };
        public StringBuilder str = new StringBuilder("", 200);
        public string Formula()
        {
            StringBuilder res = new StringBuilder("", 200);
            Random tool = new Random();

            int opnu = tool.Next(2, 3);
            int len = opnu * 2 + 1;
            for (int i = 0; i < opnu + 1; i++)
            {
                res.Append(tool.Next(100).ToString());
                if (i != opnu)
                    res.Append(Op[tool.Next(4)]);
            }
            return res.ToString();
        }

        public string Caculator(string formula)
        {
            string res = "";
            DataTable p = new DataTable();
            res = p.Compute(formula, "").ToString();
            return (res);
        }
        public static void Main(string[] args)
        {
            string path = @"F:Caculator.txt";
            File.WriteAllText(path,"");
            int n = int.Parse(Console.ReadLine());
            Project p = new Project();
            int sum = 0;
            string formula = "";
            string res = "";
            string store = "";

            while (sum != n)
            {

                formula = p.Formula();
                System.Threading.Thread.Sleep(10);
                res = p.Caculator(formula);
                //Console.WriteLine(res);
                if (res.Contains("-") || res.Contains("."))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(formula + " = "+ res);
                    store = formula + " = " + res +" \n" ;
                    File.AppendAllText(path, store.ToString());
                    sum++;
                }

            }

        }
    }
}
