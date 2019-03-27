using System;

namespace TemplateDesignPattern.AbstractClass
{
    // Abstract Class
   abstract class DocumentReader
    {
        // default steps 
        public void LoadFile()
        {
            Console.WriteLine("Document File Loaded");
        }

        // Steps that will be overriden by subclass
        public abstract void InterpretDocumentFormat();

        // open method 
        public void Open()
        {
            Console.WriteLine("Document file opens");
        }
        // Template method 
            
        public void OpenDocument()
        {
            this.LoadFile();
            this.InterpretDocumentFormat();
            this.Open();
        }

    }
}
