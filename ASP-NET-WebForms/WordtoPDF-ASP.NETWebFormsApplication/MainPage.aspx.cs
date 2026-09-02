using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;

namespace WordtoPDF_ASP.NETWebFormsApplication
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void OnButtonClicked(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            // Validate that a file has been uploaded
            if (!FileUpload1.HasFile)
            {
                lblMessage.Text = "Please select a Word document to convert.";
                return;
            }

            // Validate the file extension
            string uploadedFileName = FileUpload1.FileName;
            string extension = Path.GetExtension(uploadedFileName);
            if (!string.Equals(extension, ".doc", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(extension, ".docx", StringComparison.OrdinalIgnoreCase))
            {
                lblMessage.Text = "Please select a valid Word document (.doc or .docx).";
                return;
            }

            // Build the output PDF name (same as the source, with .pdf extension)
            string outputFileName = Path.GetFileNameWithoutExtension(uploadedFileName) + ".pdf";

            // Open the uploaded Word document from the posted file's input stream
            using (Stream wordStream = FileUpload1.PostedFile.InputStream)
            using (WordDocument document = new WordDocument(wordStream, GetFormatType(extension)))
            {
                //Instantiation of DocToPDFConverter for Word to PDF conversion
                using (DocToPDFConverter converter = new DocToPDFConverter())
                {
                    //Converts Word document into PDF document
                    using (PdfDocument pdfDocument = converter.ConvertToPDF(document))
                    {
                        //Saves the PDF document to the HTTP response so the user gets a download
                        pdfDocument.Save(outputFileName, HttpContext.Current.Response, HttpReadType.Save);
                    }
                }
            }
        }

        private static FormatType GetFormatType(string extension)
        {
            return string.Equals(extension, ".doc", StringComparison.OrdinalIgnoreCase)
                ? FormatType.Doc
                : FormatType.Docx;
        }
    }
}