using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PDFGenerate
{
    class Program
    {
        static void Main(string[] args)
        {

           //var da =  getdata().Result;



            var currentPath = Directory.GetCurrentDirectory();


            FileStream fs = new FileStream(currentPath + "\\" + "First PDF document.pdf", FileMode.Create);

            // Create an instance of the document class which represents the PDF document itself.  
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            // Create an instance to the PDF file by creating an instance of the PDF   
            // Writer class using the document and the filestrem in the constructor.  

            PdfWriter writer = PdfWriter.GetInstance(document, fs);



            // Open the document to enable you to write to the document  
            document.Open();

            // Creating an ImageData object 

            Image ImageLogo = Image.GetInstance(@"G:\Pushpendra\Projects\Rovicare Project\Rovicare File\Rovicare-dark-1.png");
            ImageLogo.ScalePercent(50);
            ImageLogo.SetAbsolutePosition(220, document.PageSize.Height - 50);

            document.Add(ImageLogo);

            // Add a simple and wellknown phrase to the document in a flow layout manner  
            //document.Add(new Paragraph("Hello World!"));
            // Close the document  

            document.Close();
            // Close the writer instance  
            writer.Close();
            // Always close open filehandles explicity  
            fs.Close();




            //FileInfo file = new FileInfo(currentPath + "\\" + "First PDF document.pdf");

            //file.Delete();


        }


        //public static  Task<string> getdata()
        //{
        //    return "Data";
        //}
    }
}
