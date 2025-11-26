using System.Reflection;

namespace RefactorSimpleDelegateApp
{

   // delegate void DPrintMessage(string name);// procedure or function?

    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            //  CaseStudy2();

            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBye);

        }
        static void ShutdownComputer(string name)
        {

            Console.WriteLine("shutting down the computer ");
            Console.WriteLine(name);
        }
        static void SendAnEmail(string name)
        {
            //your atual code to send email
            Console.WriteLine("sending email notfication for " + name);
        }
        static void PrintWizard(Action<string> fnPtrCallbck) //polymorphic
        {
            Console.WriteLine("inside printwizard..");
            Console.WriteLine("doing some printing operation and notify you once done");

            fnPtrCallbck.Invoke("Mr. PrintWizard1");
            // fnPtrCallbck.Invoke("Mr. PrintWizard2");
        }
        private static void CaseStudy2()
        {
            var fnPointer = new Action<string>(PrintGoodBye);//null pointer
                                                            // fnPointer =  PrintGoodBye;//object of delegate
            fnPointer += PrintHello;
            fnPointer += PrintGoodBye;

            fnPointer("CHAMP1");
            fnPointer("CHAMP2");
        }

        private static void CaseStudy1()
        {
            Action<string> fnPointer;//expects a function with same signature
            fnPointer = PrintGoodBye;//address or name of funciton
            fnPointer.Invoke("Emerson");

            fnPointer = PrintHello;
            fnPointer.Invoke("Krishna1");
            fnPointer.Invoke("Krishna2");
            fnPointer.Invoke("Krishna3");

            // fnPointer = Foo;
        }

        static void PrintGoodBye(string name)
        {

            Console.WriteLine($"GoodBye says {name}");
        }
        static void PrintHello(string name)
        {

            Console.WriteLine($"Hello says {name}");
        }
        static void Foo()
        {

        }
    }
}