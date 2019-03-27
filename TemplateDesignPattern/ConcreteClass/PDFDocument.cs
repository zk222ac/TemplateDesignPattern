using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDesignPattern.AbstractClass;

namespace TemplateDesignPattern.ConcreteClass
{
    class PdfDocument : DocumentReader
    {
        public override void InterpretDocumentFormat()
        {
            Console.WriteLine("Document file is processed with Pdf Interpretation");
        }
    }
}
