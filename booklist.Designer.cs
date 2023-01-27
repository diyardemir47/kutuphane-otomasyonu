
namespace Kutuphane
{
    partial class booklist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booklist));
            this.dgv_kitaplist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.pnl_BaslikBar = new System.Windows.Forms.Panel();
            this.btn_buyut = new System.Windows.Forms.Button();
            this.btn_alttaal = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_baslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitaplist)).BeginInit();
            this.pnl_BaslikBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_kitaplist
            // 
            this.dgv_kitaplist.AllowUserToAddRows = false;
            this.dgv_kitaplist.AllowUserToDeleteRows = false;
            this.dgv_kitaplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kitaplist.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgv_kitaplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kitaplist.Location = new System.Drawing.Point(138, 191);
            this.dgv_kitaplist.Name = "dgv_kitaplist";
            this.dgv_kitaplist.ReadOnly = true;
            this.dgv_kitaplist.RowHeadersWidth = 51;
            this.dgv_kitaplist.RowTemplate.Height = 24;
            this.dgv_kitaplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kitaplist.Size = new System.Drawing.Size(931, 438);
            this.dgv_kitaplist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(138, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "KİTAP ARA:";
            // 
            // txt_arama
            // 
            this.txt_arama.BackColor = System.Drawing.SystemColors.Control;
            this.txt_arama.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arama.Location = new System.Drawing.Point(265, 148);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(804, 28);
            this.txt_arama.TabIndex = 2;
            this.txt_arama.TextChanged += new System.EventHandler(this.txt_arama_TextChanged);
            // 
            // pnl_BaslikBar
            // 
            this.pnl_BaslikBar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnl_BaslikBar.Controls.Add(this.btn_buyut);
            this.pnl_BaslikBar.Controls.Add(this.btn_alttaal);
            this.pnl_BaslikBar.Controls.Add(this.btn_kapat);
            this.pnl_BaslikBar.Controls.Add(this.lbl_baslik);
            this.pnl_BaslikBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BaslikBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_BaslikBar.Name = "pnl_BaslikBar";
            this.pnl_BaslikBar.Size = new System.Drawing.Size(1165, 122);
            this.pnl_BaslikBar.TabIndex = 15;
            this.pnl_BaslikBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_BaslikBar_Paint);
            this.pnl_BaslikBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_BaslikBar_MouseDown);
            // 
            // btn_buyut
            // 
            this.btn_buyut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buyut.FlatAppearance.BorderSize = 0;
            this.btn_buyut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buyut.ForeColor = System.Drawing.Color.White;
            this.btn_buyut.Location = new System.Drawing.Point(1075, 3);
            this.btn_buyut.Name = "btn_buyut";
            this.btn_buyut.Size = new System.Drawing.Size(42, 42);
            this.btn_buyut.TabIndex = 4;
            this.btn_buyut.Text = "O";
            this.btn_buyut.UseVisualStyleBackColor = true;
            this.btn_buyut.Click += new System.EventHandler(this.btn_buyut_Click);
            // 
            // btn_alttaal
            // 
            this.btn_alttaal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_alttaal.FlatAppearance.BorderSize = 0;
            this.btn_alttaal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alttaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alttaal.ForeColor = System.Drawing.Color.White;
            this.btn_alttaal.Location = new System.Drawing.Point(1027, 3);
            this.btn_alttaal.Name = "btn_alttaal";
            this.btn_alttaal.Size = new System.Drawing.Size(42, 42);
            this.btn_alttaal.TabIndex = 3;
            this.btn_alttaal.Text = "O";
            this.btn_alttaal.UseVisualStyleBackColor = true;
            this.btn_alttaal.Click += new System.EventHandler(this.btn_alttaal_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(1123, 3);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(42, 42);
            this.btn_kapat.TabIndex = 2;
            this.btn_kapat.Text = "O";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.White;
            this.lbl_baslik.Location = new System.Drawing.Point(473, 29);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(258, 49);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "Kitap Listesi";
            // 
            // booklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 655);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_BaslikBar);
            this.Controls.Add(this.txt_arama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_kitaplist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "booklist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "booklist";
            this.Load += new System.EventHandler(this.booklist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitaplist)).EndInit();
            this.pnl_BaslikBar.ResumeLayout(false);
            this.pnl_BaslikBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kitaplist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.Panel pnl_BaslikBar;
        private System.Windows.Forms.Button btn_buyut;
        private System.Windows.Forms.Button btn_alttaal;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_baslik;
    }
}