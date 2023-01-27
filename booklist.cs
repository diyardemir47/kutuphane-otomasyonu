using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace Kutuphane
{
    public partial class booklist : Form
    {


        OleDbConnection bagla;

        OleDbDataAdapter adapter;
        DataTable dt;

        public booklist()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        void GetKitaplar()
        {
            bagla = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0;Data Source=kutuphanem.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM book", bagla);
            bagla.Open();
            adapter.Fill(dt);
            dgv_kitaplist.DataSource = dt;
            bagla.Close();

        }

        private void booklist_Load(object sender, EventArgs e)
        {
            GetKitaplar();
        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            //dv.RowFilter =String.Format( "Kitap İsmi LIKE '%" + txt_arama.Text);
            dv.RowFilter = String.Format("book_title like '%{0}%'", txt_arama.Text);

            dgv_kitaplist.DataSource = dv.ToTable();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buyut_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)

                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_alttaal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_BaslikBar_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl_BaslikBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
