using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
using Syncfusion.Pdf;
using Syncfusion.DocToPDFConverter;

namespace WordtoPDF_ASP.NETMVCApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ConvertWordtoPDF(HttpPostedFileBase file)
        {
            //Validate that a file was selected
            if (file == null || file.ContentLength == 0)
            {
                ViewBag.Message = "Please select a Word document to convert.";
                return View("Index");
            }

            //Validate that the uploaded file is a Word document (.doc or .docx)
            string extension = Path.GetExtension(file.FileName);
            if (string.IsNullOrEmpty(extension) ||
                !(extension.Equals(".docx", StringComparison.OrdinalIgnoreCase) ||
                  extension.Equals(".doc", StringComparison.OrdinalIgnoreCase)))
            {
                ViewBag.Message = "Please select a valid Word document (.doc or .docx).";
                return View("Index");
            }

            //Loads the uploaded file stream into Word document
            using (WordDocument wordDocument = new WordDocument(file.InputStream, FormatType.Automatic))
            {
                //Instantiation of DocToPDFConverter for Word to PDF conversion
                using (DocToPDFConverter converter = new DocToPDFConverter())
                {
                    //Converts Word document into PDF document
                    using (PdfDocument pdfDocument = converter.ConvertToPDF(wordDocument))
                    {
                        //Saves the PDF document to MemoryStream.
                        MemoryStream stream = new MemoryStream();
                        pdfDocument.Save(stream);
                        stream.Position = 0;

                        //Download PDF document in the browser using the original file name.
                        string pdfFileName = Path.GetFileNameWithoutExtension(file.FileName) + ".pdf";
                        return File(stream, "application/pdf", pdfFileName);
                    }
                }
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}