using System;
using System.Collections;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace InnerJoinData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<string> noPegawai, nama, id, mulai, selesai, divisi, departement, jabatan, kelas, section, subsection, groups, bagian;
        List<Jointable> joinTable;

        private void button4_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Excel.Application xlexcel;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            panelProses.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelProses.Visible = true;
            joinTable = new List<Jointable>();
            string[] noPegawai2 = noPegawai.ToArray();
            string[] nama2 = nama.ToArray();
            string[] id2 = id.ToArray();
            string[] mulai2 = mulai.ToArray();
            string[] selesai2 = selesai.ToArray();
            string[] divisi2 = divisi.ToArray();
            string[] departement2 = departement.ToArray();
            string[] jabatan2 = jabatan.ToArray();
            string[] kelas2 = kelas.ToArray();
            string[] section2 = section.ToArray();
            string[] subsection2 = subsection.ToArray();
            string[] groups2 = groups.ToArray();
            string[] bagian2 = bagian.ToArray();
            pbProses.Minimum = 0;
            pbProses.Value = 0;
            pbProses.Maximum = id2.Length * noPegawai2.Length;
            for (int i=0; i<id2.Length; i++)
            {
                for (int j=0; j<noPegawai2.Length; j++)
                {
                    if (id2[i]==noPegawai2[j])
                    {
                        joinTable.Add(new Jointable() { NOPEGAWAI = noPegawai2[j], NAMA = nama2[j], MULAI = mulai2[i], SELESAI = selesai2[i], DIVISI = divisi2[j], DEPARTMENT = departement2[j], JABATAN = jabatan2[j], KELAS = kelas2[j], SECTION = section2[j], SUBSECTION = subsection2[j], GROUP = groups2[j], BAGIAN = bagian2[j] });
                    }
                    pbProses.Value += 1;
                }
            }
            tbJKL.Text = joinTable.LongCount<Jointable>().ToString();
            dgvProses.DataSource = joinTable;
        }

        public DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=NO;IMEX=1';"; //dibawah excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //diatas excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con); //baca data data dari sheet1  
                    oleAdpt.Fill(dtexcel); //mengisi data excel ke dataTable 
                }
                catch (Exception e) {
                    MessageBox.Show(e.Message.ToString());
                }
            }
            return dtexcel;
        }

        private void copyAlltoClipboard()
        {
            dgvProses.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvProses.MultiSelect = true;
            dgvProses.SelectAll();
            DataObject dataObj = dgvProses.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Excel files| *.xlsx; *.xls ",
                FilterIndex = 2,
                Title = "Open Query"
            }; //open dialog untuk memilih file  
            if (ofd.ShowDialog() == DialogResult.OK) //file dipilih oleh user  
            {
                filePath = ofd.FileName; //get path dari file  
                fileExt = Path.GetExtension(filePath); //get file extension  
                tbQuery.Text = filePath;
                DataTable dtExcel = new DataTable();
                dtExcel = ReadExcel(filePath, fileExt); //baca excel file  
                DataRow row = dtExcel.Rows[0];
                int rownumber = dtExcel.Rows.Count;
                foreach (DataColumn column in dtExcel.Columns)
                {
                    string cName = dtExcel.Rows[0][column.ColumnName].ToString();
                    if (!dtExcel.Columns.Contains(cName) && cName != "")
                    {
                        column.ColumnName = cName;
                    }
                }
                dtExcel.Rows.Remove(row);
                noPegawai = new List<string>();
                nama = new List<string>();
                divisi = new List<string>();
                departement = new List<string>();
                jabatan = new List<string>();
                kelas = new List<string>();
                section = new List<string>();
                subsection = new List<string>();
                groups = new List<string>();
                bagian = new List<string>(); 
                for (int i = 0; i < dtExcel.Rows.Count; i++)
                {
                    noPegawai.Add(dtExcel.Rows[i][8].ToString());
                    nama.Add(dtExcel.Rows[i][9].ToString());
                    divisi.Add(dtExcel.Rows[i][11].ToString());
                    departement.Add(dtExcel.Rows[i][12].ToString());
                    jabatan.Add(dtExcel.Rows[i][22].ToString());
                    kelas.Add(dtExcel.Rows[i][23].ToString());
                    section.Add(dtExcel.Rows[i][25].ToString());
                    subsection.Add(dtExcel.Rows[i][26].ToString());
                    groups.Add(dtExcel.Rows[i][27].ToString());
                    bagian.Add(dtExcel.Rows[i][28].ToString());
                }
                dgvQuery.Visible = true;
                dgvQuery.DataSource = dtExcel;
            }
        }

        private void btnSPL_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Excel files| *.xlsx; *.xls ",
                FilterIndex = 2,
                Title = "Open SPL"
            }; //open dialog untuk memilih file  
            if (ofd.ShowDialog() == DialogResult.OK) //file dipilih oleh user
            {
                filePath = ofd.FileName; //get path dari file
                fileExt = Path.GetExtension(filePath); //get file extension
                tbSPL.Text = filePath;
                DataTable dtExcel = new DataTable();
                dtExcel = ReadExcel(filePath, fileExt); //baca excel file  
                DataRow row = dtExcel.Rows[0];
                int rownumber = dtExcel.Rows.Count;
                foreach (DataColumn column in dtExcel.Columns)
                {
                    string cName = dtExcel.Rows[0][column.ColumnName].ToString();
                    if (!dtExcel.Columns.Contains(cName) && cName != "")
                    {
                        column.ColumnName = cName;
                    }
                }
                dtExcel.Rows.Remove(row);
                
                id = new List<string>();
                mulai = new List<string>();
                selesai = new List<string>();
                for (int i = 0; i < dtExcel.Rows.Count; i++)
                {
                    if (dtExcel.Rows[i][1].ToString().Length == 5)
                    {
                        id.Add(dtExcel.Rows[i][1].ToString());
                        mulai.Add(dtExcel.Rows[i][3].ToString());
                        selesai.Add(dtExcel.Rows[i][5].ToString());
                    }
                }
                dgvSPL.Visible = true;
                dgvSPL.DataSource = dtExcel;
            }
        }
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Test Page Print";
                printDocument1.Print();
            }
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgvProses.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgvProses.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dgvProses.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgvProses.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Data Proses Karyawan Lembur", new Font(dgvProses.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Data Proses Karyawan Lembur", new Font(dgvProses.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(dgvProses.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dgvProses.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Data Proses Karyawan Lembur", new Font(new Font(dgvProses.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dgvProses.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
