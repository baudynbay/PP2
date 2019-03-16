using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;



namespace Task1
{
    public class Program
    {
        [Serializable]
        public class ComplexN
        {
            public int a;
            public int b;

            public ComplexN() { }
            public ComplexN(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public override string ToString()
            {
                if (b > 0)
                {
                    return string.Format(a + "+" + b + "i");
                }
                else if (b < 0)
                {
                    return string.Format(a + "-" + b + "i");
                }
                else return string.Format(a.ToString());
            }
        }
        static void Main(string[] args)
        {
           /* int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            ComplexN one = new ComplexN(a,b);

            Console.WriteLine(one.ToString());

            XmlSerializer number = new XmlSerializer(typeof(ComplexN));
            using (TextWriter writer = new StreamWriter(@"Xml.xml"))
            {
                number.Serialize(writer, one);
                writer.Close();
            }*/

            XmlSerializer deserializer = new XmlSerializer(typeof(ComplexN));
            using (TextReader reader = new StreamReader(@"Xml.xml"))
            {
                object obj = deserializer.Deserialize(reader);
                ComplexN two = (ComplexN)obj;
                reader.Close();
                Console.WriteLine(two);

            }



        }
    }
}
