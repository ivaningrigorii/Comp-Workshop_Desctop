using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace course_project._DataBase
{
    class DataBaseWorker
    {
        string path = "tmp.xlsx";
        public static SqlDataAdapter adapter;
        public static SqlConnection connection = new SqlConnection(
            ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public static SqlCommand cmd;

        public void printToMSWordCheque(DataGridView g, string numberOfStatement, string sumOfStatement)
        {
            printToExcelWithoutOneIdd(g);
            string xlSheetPath = path;

            Microsoft.Office.Interop.Excel._Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Word._Application wdApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = xlApp.Workbooks.Open(xlSheetPath);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets[1];

            try
            {
                string ext = xlSheetPath.Substring(xlSheetPath.LastIndexOf("."), xlSheetPath.Length - xlSheetPath.LastIndexOf("."));
                int xlVersion = (xlSheetPath.Substring(xlSheetPath.LastIndexOf("."), xlSheetPath.Length - xlSheetPath.LastIndexOf(".")) == ".xls") ? 8 : 12;

                xlApp.Visible = false;

                Microsoft.Office.Interop.Word.Document document = wdApp.Documents.Add();
                document.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;
               
                worksheet.Range["B1", $"C{g.Rows.Count}"].Copy();
                document.Range().PasteExcelTable(true, true, true);

                document.Content.Application.Selection.Range.Text += 
                $"Ваш заказ: {numberOfStatement}\n" +
                $"Сумма всего заказа: {sumOfStatement} р.\n" +
               $"Дата обращения: {DateTime.Now}\n"+
                "\nВаше ФИО и роспись:\n" +
                "\nФИО в системе:\n" +
                "\nФИО и роспись ответственного:"+
                "\n\nКомплектация:";
                document.Content.Font.Size = 14;
            }
            catch (Exception)
            {
                MessageBox.Show("Операция невозможна!");
            }
            finally
            {
                workbook.Close();
                xlApp.Quit();
                
                wdApp.Visible = true;
            }
        }

        public void printToExcelWithoutOneIdd(DataGridView g)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = false;
            worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;

            worksheet.Name = "Лист1";
            try
            {
                for (int i = 1; i < g.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = g.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < g.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < g.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            finally
            {
                workbook.SaveAs(path);
                workbook.Close();
                app.Quit();
            }
        }


        public void easyPrint(string numberOfStatement)
        {
            Microsoft.Office.Interop.Excel._Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Word._Application wdApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document document = wdApp.Documents.Add();
            document.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;

            document.Content.Application.Selection.Range.Text +=
            $"Ваш заказ: {numberOfStatement}\n" +
            $"Дата получения ПК: {DateTime.Now}\n" +
            "\nКомпьютер готов, осмотрен, работает и исправен (ваше ФИО, подпись):\n" +
            "\nФИО, подпись ответственного менеджера:\n";

            wdApp.Visible = true;
        }
    }
}


