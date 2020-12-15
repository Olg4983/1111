using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_12_2020_detach_mode
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



            //---DataTable class
            //DataTable table = new DataTable();
            //table.Columns.Add("id");
            //table.Columns.Add("name");
            //table.Columns.Add("email");

            //DataRow row = table.NewRow();
            //row[0] = 100;
            //row[1] = "vasia";
            //row[2] = "vasia@gmail.com";

            //table.Rows.Add(row);
        }
    }
}
