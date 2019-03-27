using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDesignPattern.AbstractClass;
using TemplateDesignPattern.ConcreteClass;

namespace TemplateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("......................................");

            Console.WriteLine("Document Reader ---  PDF doc");
            DocumentReader pdfReader = new PdfDocument();
            pdfReader.OpenDocument();

            Console.WriteLine("Document Reader ---  RTF doc");
            DocumentReader rtfReader = new RtfDocument();
            rtfReader.OpenDocument();
            Console.WriteLine("......................................");
            
        }
    }
}
