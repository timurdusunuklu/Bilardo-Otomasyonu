
namespace Pool.UI
{
    partial class Hesap
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
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.lbl_süre = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_masaUcretiName = new System.Windows.Forms.Label();
            this.lbl_masaTarifesiName = new System.Windows.Forms.Label();
            this.lbl_siparisTplamName = new System.Windows.Forms.Label();
            this.lbl_odenenUcretName = new System.Windows.Forms.Label();
            this.lbl_aktarılanÜcretName = new System.Windows.Forms.Label();
            this.txt_masaTarifesi = new System.Windows.Forms.TextBox();
            this.txt_masaUcreti = new System.Windows.Forms.TextBox();
            this.txt_siparisToplam = new System.Windows.Forms.TextBox();
            this.txt_odenenUcret = new System.Windows.Forms.TextBox();
            this.txt_aktarilanUcret = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_hesapKapat = new System.Windows.Forms.Button();
            this.tlp_main.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.lbl_toplam, 0, 0);
            this.tlp_main.Controls.Add(this.lbl_süre, 0, 1);
            this.tlp_main.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tlp_main.Controls.Add(this.btn_kaydet, 0, 3);
            this.tlp_main.Controls.Add(this.btn_hesapKapat, 0, 4);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 5;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_main.Size = new System.Drawing.Size(420, 575);
            this.tlp_main.TabIndex = 0;
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.Location = new System.Drawing.Point(4, 1);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(412, 85);
            this.lbl_toplam.TabIndex = 0;
            this.lbl_toplam.Text = "20,00";
            this.lbl_toplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_süre
            // 
            this.lbl_süre.AutoSize = true;
            this.lbl_süre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_süre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_süre.Location = new System.Drawing.Point(4, 87);
            this.lbl_süre.Name = "lbl_süre";
            this.lbl_süre.Size = new System.Drawing.Size(412, 45);
            this.lbl_süre.TabIndex = 1;
            this.lbl_süre.Text = "Toplam Süre: 0 Dk.";
            this.lbl_süre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_masaUcretiName, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl_masaTarifesiName, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_siparisTplamName, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.lbl_odenenUcretName, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.lbl_aktarılanÜcretName, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.txt_masaTarifesi, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txt_masaUcreti, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.txt_siparisToplam, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.txt_odenenUcret, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.txt_aktarilanUcret, 1, 4);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(1, 133);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(418, 301);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // lbl_masaUcretiName
            // 
            this.lbl_masaUcretiName.AutoSize = true;
            this.lbl_masaUcretiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_masaUcretiName.Location = new System.Drawing.Point(3, 50);
            this.lbl_masaUcretiName.Name = "lbl_masaUcretiName";
            this.lbl_masaUcretiName.Size = new System.Drawing.Size(83, 17);
            this.lbl_masaUcretiName.TabIndex = 0;
            this.lbl_masaUcretiName.Text = "Masa Ücreti";
            this.lbl_masaUcretiName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_masaTarifesiName
            // 
            this.lbl_masaTarifesiName.AutoSize = true;
            this.lbl_masaTarifesiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_masaTarifesiName.Location = new System.Drawing.Point(3, 0);
            this.lbl_masaTarifesiName.Name = "lbl_masaTarifesiName";
            this.lbl_masaTarifesiName.Size = new System.Drawing.Size(93, 17);
            this.lbl_masaTarifesiName.TabIndex = 0;
            this.lbl_masaTarifesiName.Text = "Masa Tarifesi";
            this.lbl_masaTarifesiName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_siparisTplamName
            // 
            this.lbl_siparisTplamName.AutoSize = true;
            this.lbl_siparisTplamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_siparisTplamName.Location = new System.Drawing.Point(3, 100);
            this.lbl_siparisTplamName.Name = "lbl_siparisTplamName";
            this.lbl_siparisTplamName.Size = new System.Drawing.Size(105, 17);
            this.lbl_siparisTplamName.TabIndex = 0;
            this.lbl_siparisTplamName.Text = "Sipariş Toplamı";
            this.lbl_siparisTplamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_odenenUcretName
            // 
            this.lbl_odenenUcretName.AutoSize = true;
            this.lbl_odenenUcretName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_odenenUcretName.Location = new System.Drawing.Point(3, 150);
            this.lbl_odenenUcretName.Name = "lbl_odenenUcretName";
            this.lbl_odenenUcretName.Size = new System.Drawing.Size(97, 17);
            this.lbl_odenenUcretName.TabIndex = 0;
            this.lbl_odenenUcretName.Tag = "";
            this.lbl_odenenUcretName.Text = "Ödenen Ücret";
            this.lbl_odenenUcretName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_aktarılanÜcretName
            // 
            this.lbl_aktarılanÜcretName.AutoSize = true;
            this.lbl_aktarılanÜcretName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aktarılanÜcretName.Location = new System.Drawing.Point(3, 200);
            this.lbl_aktarılanÜcretName.Name = "lbl_aktarılanÜcretName";
            this.lbl_aktarılanÜcretName.Size = new System.Drawing.Size(101, 17);
            this.lbl_aktarılanÜcretName.TabIndex = 0;
            this.lbl_aktarılanÜcretName.Text = "Aktarılan Ücret";
            this.lbl_aktarılanÜcretName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_masaTarifesi
            // 
            this.txt_masaTarifesi.Location = new System.Drawing.Point(131, 3);
            this.txt_masaTarifesi.Name = "txt_masaTarifesi";
            this.txt_masaTarifesi.ReadOnly = true;
            this.txt_masaTarifesi.Size = new System.Drawing.Size(100, 22);
            this.txt_masaTarifesi.TabIndex = 1;
            // 
            // txt_masaUcreti
            // 
            this.txt_masaUcreti.Location = new System.Drawing.Point(131, 53);
            this.txt_masaUcreti.Name = "txt_masaUcreti";
            this.txt_masaUcreti.ReadOnly = true;
            this.txt_masaUcreti.Size = new System.Drawing.Size(100, 22);
            this.txt_masaUcreti.TabIndex = 1;
            // 
            // txt_siparisToplam
            // 
            this.txt_siparisToplam.Location = new System.Drawing.Point(131, 103);
            this.txt_siparisToplam.Name = "txt_siparisToplam";
            this.txt_siparisToplam.ReadOnly = true;
            this.txt_siparisToplam.Size = new System.Drawing.Size(100, 22);
            this.txt_siparisToplam.TabIndex = 1;
            // 
            // txt_odenenUcret
            // 
            this.txt_odenenUcret.Location = new System.Drawing.Point(131, 153);
            this.txt_odenenUcret.Name = "txt_odenenUcret";
            this.txt_odenenUcret.Size = new System.Drawing.Size(100, 22);
            this.txt_odenenUcret.TabIndex = 1;
            // 
            // txt_aktarilanUcret
            // 
            this.txt_aktarilanUcret.Location = new System.Drawing.Point(131, 203);
            this.txt_aktarilanUcret.Name = "txt_aktarilanUcret";
            this.txt_aktarilanUcret.Size = new System.Drawing.Size(100, 22);
            this.txt_aktarilanUcret.TabIndex = 1;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_kaydet.Location = new System.Drawing.Point(4, 438);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(412, 62);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_hesapKapat
            // 
            this.btn_hesapKapat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_hesapKapat.Location = new System.Drawing.Point(4, 507);
            this.btn_hesapKapat.Name = "btn_hesapKapat";
            this.btn_hesapKapat.Size = new System.Drawing.Size(412, 64);
            this.btn_hesapKapat.TabIndex = 3;
            this.btn_hesapKapat.Text = "Hesabı Kapat";
            this.btn_hesapKapat.UseVisualStyleBackColor = true;
            this.btn_hesapKapat.Click += new System.EventHandler(this.btn_hesapKapat_Click);
            // 
            // Hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 575);
            this.Controls.Add(this.tlp_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Hesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap";
            this.Load += new System.EventHandler(this.Hesap_Load);
            this.tlp_main.ResumeLayout(false);
            this.tlp_main.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        public System.Windows.Forms.Label lbl_toplam;
        public System.Windows.Forms.Label lbl_süre;
        private System.Windows.Forms.Label lbl_masaTarifesiName;
        private System.Windows.Forms.Label lbl_masaUcretiName;
        private System.Windows.Forms.Label lbl_siparisTplamName;
        private System.Windows.Forms.Label lbl_odenenUcretName;
        private System.Windows.Forms.Label lbl_aktarılanÜcretName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_hesapKapat;
        public System.Windows.Forms.TextBox txt_masaTarifesi;
        public System.Windows.Forms.TextBox txt_masaUcreti;
        public System.Windows.Forms.TextBox txt_siparisToplam;
        public System.Windows.Forms.TextBox txt_odenenUcret;
        public System.Windows.Forms.TextBox txt_aktarilanUcret;
    }
}