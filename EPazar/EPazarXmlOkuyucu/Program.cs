using System;

namespace EPazarXmlOkuyucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Start XML Reader-");
            Console.WriteLine("------------------");

            OrnekXml ornekXml = new OrnekXml();
            ornekXml.Reader();

            Console.ReadKey();
        }
    }
}
