using System;
using System.Drawing.Printing;
using System.Drawing;

public class PDFGeneration
{
    static Random r = new Random();
    public static void Main()
    {
        
        var document = new PrintDocument();        
        document.PrinterSettings.PrinterName = "Microsoft Print to PDF";
        document.PrinterSettings.PrintToFile = true;
        document.PrinterSettings.PrintFileName = "c:/temp/pdf" + r.NextInt64() + ".pdf";
        document.PrintPage += new PrintPageEventHandler(OnPrintPage);
        document.Print();
    }

    private static void OnPrintPage(object sender, PrintPageEventArgs e)
    {
        e.Graphics.DrawString("Hello, World! " + r.NextInt64(), new Font("Arial", 20), Brushes.Red, 0, 0);
    }
}
