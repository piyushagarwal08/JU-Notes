using System.Activities;
using System.ComponentModel;
using System.IO;
using System;
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

    public class ReadRange : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        [DisplayName("FilePath")]
        [Description("Please enter full path of workbook")]
        public InArgument<string> In_FilePath { get; set; }

        [Category("Input")]
        [RequiredArgument]
        [Description("Please enter sheet name")]
        [DisplayName("Sheet")]
        public InArgument<string> In_SheetName { get; set; } = "Sheet1";

        [Category("Input")]
        [Description("Please enter range")]
        [RequiredArgument]
        [DisplayName("Range")]
        public InArgument<string> In_Range { get; set; } = "";

        [Category("Output")]
        [RequiredArgument]
        [Description("Please use a Data Table variable")]
        [DisplayName("DT")]
        public OutArgument<System.Data.DataTable> Out_DT { get; set; }

    
        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                
                string filePath = In_FilePath.Get(context);
                string sheetName = In_SheetName.Get(context);
                string sheetRange = In_Range.Get(context);

              

                // Insert Data in DataTable
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DTSet;
                System.Data.DataTable DT1;
                System.Data.OleDb.OleDbDataAdapter MyCommand;

                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filePath + "';Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [" + sheetName + "$" + sheetRange + "]", MyConnection);
                MyCommand.TableMappings.Add("Table", "TestTable");
                DTSet = new System.Data.DataSet();
                MyCommand.Fill(DTSet);
                DT1 = DTSet.Tables[0];
                MyConnection.Close();
                
                // Assigning Output Varaible
                Out_DT.Set(context, DT1);
            }
            catch(System.Exception e)
            {
                System.Console.WriteLine("Exception: " + e.Message+Environment.NewLine+In_Range.Get(context)+Environment.NewLine+In_SheetName.Get(context) + Environment.NewLine+In_FilePath.Get(context));
            }
        }
    
    }
}




namespace CustomActivities.ExcelFormatting
{
    public class WriteCellAsText: CodeActivity
    {

        [Category("Input")]
        [RequiredArgument]
        [Description("Enter full file path")]
        [DisplayName("FilePath")]
        public InArgument<string> FilePath { get; set; }

        [Category("Input")]
        [RequiredArgument]
        [DisplayName("SheetName")]
        [Description("Value")]
        public InArgument<string> SheetName { get; set; }

        [Category("Input")]
        [RequiredArgument]
        [DisplayName("Cell")]
        [Description("Enter the cell address")]
        public InArgument<string> Cell { get; set; }

        [Category("Input")]
        [RequiredArgument]
        [DisplayName("CellValue")]
        [Description("Value")]
        public InArgument<string> Value { get; set; }


        protected override void Execute(CodeActivityContext context)
        {
            string ExcelRange = Cell.Get(context);
            string ExcelPath = FilePath.Get(context);
            string ExcelValue = Value.Get(context);
            string ExcelSheet = SheetName.Get(context);

            Application xlApp = new Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(ExcelPath);
            Worksheet xlWorksheet = xlWorkbook.Worksheets.get_Item(ExcelSheet);
            try
            {
                // To get range with some data in it
                //Range rng = xlWorksheet.UsedRange;

                Range rng = xlWorksheet.get_Range(ExcelRange);

                // To change the format of cell to Text
                rng.NumberFormat = "@";

                // Get ASCII Value
                char c = char.Parse(ExcelRange.Substring(0, 1));

                // Get Cell row and column value
                int colIndex = (int)c-64;
                int rowIndex = int.Parse(ExcelRange.Substring(1));
                
                xlWorksheet.Cells[rowIndex,colIndex] = ExcelValue;

                // Close Excel Objects
                xlWorkbook.Save();
                xlWorkbook.Close();
                xlApp.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message+Environment.NewLine+e.Source);
            }
            finally
            {
                Marshal.ReleaseComObject(xlWorksheet);
                Marshal.ReleaseComObject(xlWorkbook);
                Marshal.ReleaseComObject(xlApp);
            }
        }

    }
}