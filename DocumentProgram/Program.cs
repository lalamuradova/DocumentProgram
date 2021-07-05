using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProgramm
{
    class DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened. . .");
        }
	public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions. . .");
        }
	public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions. . .");
        }
    }
    class ProDocumentProgram : DocumentProgram
    {        
         public override sealed void EditDocument()
         {
            Console.WriteLine("Document Edited. . .");
         }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet. . .");
        }
    }
    class ExpertDocument : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format. . .");
        }
    }
    
    class Program
    {
        public static void Run()
        {
            while (true)
            {

            Console.Write("Enter key: ");
            string key = Console.ReadLine();
            if(key== "basic")
            {
                DocumentProgram docProgram = new DocumentProgram();
                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();
            }
            else if(key== "pro")
            {
                DocumentProgram docProgram = new ProDocumentProgram();
                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();
            }
            else if(key== "expert")
            {
                DocumentProgram docProgram=new ExpertDocument();
                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();
            }
            else
            {
                Console.WriteLine("Key is wrong");
            }
            }
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}
