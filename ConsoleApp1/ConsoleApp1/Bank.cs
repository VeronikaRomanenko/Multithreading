using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bank
    {
        public int Id { set; get; }
        public int Money { set; get; }
        string name;
        public string Name { set { ParameterizedThreadStart threadstart = new ParameterizedThreadStart(Method); Thread thread = new Thread(threadstart); thread.Start(value as object); thread.Join(); name = value;  } get { return name; } }
        public int Percent { set; get; }
        public override string ToString()
        {
            return $"Money - {Money}\tName - {Name}\tPercent - {Percent}";
        }

        static void Method(object obj)
        {
            try
            {
                using (FileStream fs = new FileStream("file.txt", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(obj as string);
                    }
                }
            }
            catch { }
        }
    }
}