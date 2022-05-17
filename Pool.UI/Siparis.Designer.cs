
namespace Pool.UI
{
    partial class Siparis
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
            this.nud_Adet = new System.Windows.Forms.NumericUpDown();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_sicak = new System.Windows.Forms.Button();
            this.btn_soguk = new System.Windows.Forms.Button();
            this.btn_market = new System.Windows.Forms.Button();
            this.btn_mutfak = new System.Windows.Forms.Button();
            this.flp_stok = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_toplamName = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.lvw_siparisler = new System.Windows.Forms.ListView();
            this.urunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nud_Adet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // nud_Adet
            // 
            this.nud_Adet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_Adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_Adet.Location = new System.Drawing.Point(274, 0);
            this.nud_Adet.Margin = new System.Windows.Forms.Padding(0);
            this.nud_Adet.Name = "nud_Adet";
            this.nud_Adet.Size = new System.Drawing.Size(61, 38);
            this.nud_Adet.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(274, 43);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Ekle";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.Location = new System.Drawing.Point(335, 0);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(275, 43);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Sil";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 684);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flp_stok, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55555F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(610, 678);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btn_sicak, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_soguk, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_market, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_mutfak, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(610, 105);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btn_sicak
            // 
            this.btn_sicak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sicak.Location = new System.Drawing.Point(3, 3);
            this.btn_sicak.Name = "btn_sicak";
            this.btn_sicak.Size = new System.Drawing.Size(146, 99);
            this.btn_sicak.TabIndex = 0;
            this.btn_sicak.Text = "Sıcak İçecekler";
            this.btn_sicak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sicak.UseVisualStyleBackColor = true;
            this.btn_sicak.Click += new System.EventHandler(this.btn_sicak_Click);
            // 
            // btn_soguk
            // 
            this.btn_soguk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_soguk.Location = new System.Drawing.Point(155, 3);
            this.btn_soguk.Name = "btn_soguk";
            this.btn_soguk.Size = new System.Drawing.Size(146, 99);
            this.btn_soguk.TabIndex = 1;
            this.btn_soguk.Text = "Soğuk İçecekler";
            this.btn_soguk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_soguk.UseVisualStyleBackColor = true;
            this.btn_soguk.Click += new System.EventHandler(this.btn_soguk_Click);
            // 
            // btn_market
            // 
            this.btn_market.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_market.Location = new System.Drawing.Point(307, 3);
            this.btn_market.Name = "btn_market";
            this.btn_market.Size = new System.Drawing.Size(146, 99);
            this.btn_market.TabIndex = 2;
            this.btn_market.Text = "Market";
            this.btn_market.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_market.UseVisualStyleBackColor = true;
            this.btn_market.Click += new System.EventHandler(this.btn_market_Click);
            // 
            // btn_mutfak
            // 
            this.btn_mutfak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_mutfak.Location = new System.Drawing.Point(459, 3);
            this.btn_mutfak.Name = "btn_mutfak";
            this.btn_mutfak.Size = new System.Drawing.Size(148, 99);
            this.btn_mutfak.TabIndex = 3;
            this.btn_mutfak.Text = "Mutfak";
            this.btn_mutfak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_mutfak.UseVisualStyleBackColor = true;
            this.btn_mutfak.Click += new System.EventHandler(this.btn_mutfak_Click);
            // 
            // flp_stok
            // 
            this.flp_stok.BackColor = System.Drawing.Color.White;
            this.flp_stok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_stok.Location = new System.Drawing.Point(3, 108);
            this.flp_stok.Name = "flp_stok";
            this.flp_stok.Size = new System.Drawing.Size(604, 346);
            this.flp_stok.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.Controls.Add(this.btn_delete, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.nud_Adet, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_add, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 457);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(610, 43);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lvw_siparisler, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(616, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(332, 684);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_toplamName, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_toplam, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 617);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(324, 63);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // lbl_toplamName
            // 
            this.lbl_toplamName.AutoSize = true;
            this.lbl_toplamName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_toplamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamName.Location = new System.Drawing.Point(3, 0);
            this.lbl_toplamName.Name = "lbl_toplamName";
            this.lbl_toplamName.Size = new System.Drawing.Size(156, 63);
            this.lbl_toplamName.TabIndex = 0;
            this.lbl_toplamName.Text = "Toplam:";
            this.lbl_toplamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.Location = new System.Drawing.Point(165, 0);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(156, 63);
            this.lbl_toplam.TabIndex = 0;
            this.lbl_toplam.Text = "0,00 TL";
            this.lbl_toplam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvw_siparisler
            // 
            this.lvw_siparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunAdi,
            this.adet,
            this.tutar});
            this.lvw_siparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_siparisler.FullRowSelect = true;
            this.lvw_siparisler.GridLines = true;
            this.lvw_siparisler.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvw_siparisler.HideSelection = false;
            this.lvw_siparisler.Location = new System.Drawing.Point(4, 4);
            this.lvw_siparisler.MultiSelect = false;
            this.lvw_siparisler.Name = "lvw_siparisler";
            this.lvw_siparisler.Size = new System.Drawing.Size(324, 606);
            this.lvw_siparisler.TabIndex = 6;
            this.lvw_siparisler.UseCompatibleStateImageBehavior = false;
            this.lvw_siparisler.View = System.Windows.Forms.View.Details;
            // 
            // urunAdi
            // 
            this.urunAdi.Text = "Ürün Adı";
            this.urunAdi.Width = 63;
            // 
            // adet
            // 
            this.adet.DisplayIndex = 0;
            this.adet.Text = "Adet";
            this.adet.Width = 40;
            // 
            // tutar
            // 
            this.tutar.Text = "Tutar";
            this.tutar.Width = 217;
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 684);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Siparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparis";
            this.Load += new System.EventHandler(this.Siparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Adet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_Adet;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_sicak;
        private System.Windows.Forms.Button btn_soguk;
        private System.Windows.Forms.Button btn_market;
        private System.Windows.Forms.Button btn_mutfak;
        private System.Windows.Forms.FlowLayoutPanel flp_stok;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lbl_toplamName;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.ListView lvw_siparisler;
        private System.Windows.Forms.ColumnHeader urunAdi;
        private System.Windows.Forms.ColumnHeader adet;
        private System.Windows.Forms.ColumnHeader tutar;
    }
}