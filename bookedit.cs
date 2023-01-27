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
    public partial class bookedit : Form
    {
        //fields
    

        OleDbConnection bagla;
        OleDbCommand komut;
        OleDbDataAdapter adapter;
        DataTable dt;

        public bookedit()
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
            dgv_kitap.DataSource = dt;
            bagla.Close();
        
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO book ( author,book_title, page_count,shelf_no) VALUES" + "(@@KitapYazari,@Kitapİsmi,@KitapSayfaSayisi,@KitapRafNo)";
            komut = new OleDbCommand(query, bagla);

                komut.Parameters.AddWithValue("@KitapYazari", txt_kitapyazari.Text);
            komut.Parameters.AddWithValue("@Kitapİsmi", txt_kitapismi.Text);
       
   
            komut.Parameters.AddWithValue("@KitapSayfaSayisi", txt_kitapsayfasayisi.Text);
            komut.Parameters.AddWithValue("@KitapRafNo", txt_kitaprafno.Text);
            bagla.Open();
            komut.ExecuteNonQuery();
            bagla.Close();
            MessageBox.Show("KİTAP EKLENDİ", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            GetKitaplar();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string query = "UPDATE book SET  author= @KitapYazari, book_title=@Kitapİsmi, page_count=@KitapSayfasi,shelf_no=@KitapRafNo WHERE barcode_no=@kitap_no ";
            komut = new OleDbCommand(query, bagla);
     komut.Parameters.AddWithValue("@KitapYazari", txt_kitapyazari.Text);
            komut.Parameters.AddWithValue("@Kitapismi", txt_kitapismi.Text);
       

            komut.Parameters.AddWithValue("@KitapSayfasi", txt_kitapsayfasayisi.Text);
            komut.Parameters.AddWithValue("@KitapRafNo", txt_kitaprafno.Text);
            komut.Parameters.AddWithValue("@kitap_no", Convert.ToInt32(txt_kitapno.Text));
            bagla.Open();
            komut.ExecuteNonQuery();
            bagla.Close();
            MessageBox.Show("KİTAP GÜNCELLENDİ", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetKitaplar();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string query = "DELETE  FROM book WHERE barcode_no=@kitap_no";
            komut = new OleDbCommand(query, bagla);


            komut.Parameters.AddWithValue("@kitap_no", Convert.ToInt32(txt_kitapno.Text));
            bagla.Open();
            komut.ExecuteNonQuery();
            bagla.Close();
            MessageBox.Show("KİTAP SİLİNDİ", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            GetKitaplar();
        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
              //dv.RowFilter =String.Format( "Kitap İsmi LIKE '%" + txt_arama.Text);
         dv.RowFilter = String.Format("book_title like '%{0}%'", txt_arama.Text);

            dgv_kitap.DataSource = dv.ToTable(); 
                
        }

        private void bookedit_Load(object sender, EventArgs e)
        {
            GetKitaplar();
        }

        private void dgv_kitap_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
         
            txt_kitapno.Text = dgv_kitap.CurrentRow.Cells[0].Value.ToString();

            txt_kitapismi.Text = dgv_kitap.CurrentRow.Cells[2].Value.ToString();
                     txt_kitapyazari.Text = dgv_kitap.CurrentRow.Cells[1].Value.ToString();
           // date_kitapalmatarihi.Text = dgv_kitap.CurrentRow.Cells[3].Value.ToString();
            txt_kitapsayfasayisi.Text = dgv_kitap.CurrentRow.Cells[3].Value.ToString();
            txt_kitaprafno.Text = dgv_kitap.CurrentRow.Cells[4].Value.ToString();
        }

   

     

        private void pnl_BaslikBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btn_altta_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
