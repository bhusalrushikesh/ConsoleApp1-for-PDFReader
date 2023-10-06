using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PDFReader
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pdfFilePath = "file:///D:/Demand_1.pdf";

            using (PdfReader reader = new PdfReader(pdfFilePath))
            {
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string pageText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);

                    Console.WriteLine($"Page {page}:\n{pageText}");
                }
            }
        }
    }
}