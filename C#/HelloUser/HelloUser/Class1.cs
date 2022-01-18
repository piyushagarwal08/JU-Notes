using System.Activities;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CustomActivities.Starter
{
    public class SayHello:CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        [Description("Enter your First Name")]
        public InArgument<string> FirstName { get; set; }

        [Category("Input")]
        [RequiredArgument]
        [Description("Enter your Last Name")]
        public InArgument<string> LastName { get; set; }

        [Category("Output")]
        [Description("String Variable for output")]
        public OutArgument<string> Result { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            string name = FirstName.Get(context)+" "+LastName.Get(context);
            string result = "Hello " + name;
            Result.Set(context, result);
        }
    }

    public class PDFTotalCount: CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        [Description("Enter PDF Path")]
        public InArgument<string> PdfFile { get; set; }

        [Category("Output")]
        [RequiredArgument]
        [Description("Total Count of Pages")]
        public OutArgument<int> PageCount { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string FilePath = PdfFile.Get(context);
            StreamReader reader = new StreamReader(FilePath);
            Regex reg = new Regex(@"/Type\s*/Page[^s]");
            MatchCollection matches = reg.Matches(reader.ReadToEnd());
            int Count = matches.Count;
            PageCount.Set(context, Count);
        }
    }

    public class CreateWorkbook : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        [Description("Please enter the path of new workbook")]
        public InArgument<string> WorkbookPath { get; set; }

        [Category("Output")]
        [Description("Workbook type variable")]
        public OutArgument<Workbook> ExcelWorkbook { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string FilePath = WorkbookPath.Get(context);
            Application xlApp = new Application();
            Workbook xlWorkBook = xlApp.Workbooks.Add(Missing.Value);
            xlWorkBook.SaveAs(FilePath);
            xlWorkBook.Close(true, Missing.Value, Missing.Value);
            xlApp.Quit();
            ExcelWorkbook.Set(context, xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            Marshal.ReleaseComObject(xlWorkBook);
        }
        
    }
}
