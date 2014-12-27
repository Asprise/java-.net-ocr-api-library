using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// Sample application of Asprise OCR C#/VB.NET SDK. Visit http://asprise.com/product/ocr for more details.
namespace ocr_sample_csharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Sample application of Asprise OCR C#/VB.NET SDK. Visit http://asprise.com/product/ocr for more details.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
