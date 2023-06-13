using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class ExcelForm : Form
    {
        private String fileName;

        private String ExcelHoja;

        public ExcelForm()
        {
            InitializeComponent();
            DVExcel.Visible = false;
        }

        private void CambiarExcelHoja(object sender, EventArgs e)
        {
            ExcelHoja = TextHoja.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result= openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                if (file.Length == 0)
                {
                    fileName= file;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                Path.GetFileName(fileName) +
                ";Extended Properties='Excel 8.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(conexion);
            OleDbCommand cmd = new OleDbCommand("Select * From [" + ExcelHoja + "$]", con);
            try
            {
                con.Open();
                OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
                DataTable data = new DataTable();
                sda.Fill(data);
                DVExcel.DataSource = data;
                DVExcel.Visible = !DVExcel.Visible;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error en la lectura del archivo: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
