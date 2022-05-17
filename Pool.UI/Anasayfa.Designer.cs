
using Pool.Bll.Abstract;

namespace Pool.UI
{
    partial class Anasayfa
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
            this.components = new System.ComponentModel.Container();
            this.tlp_rightContentUp = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_rightUpContentButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_okey = new System.Windows.Forms.Button();
            this.btn_amerikan = new System.Windows.Forms.Button();
            this.btn_ucTop = new System.Windows.Forms.Button();
            this.btn_masaTenisi = new System.Windows.Forms.Button();
            this.btn_snooker = new System.Windows.Forms.Button();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_headerName = new System.Windows.Forms.Label();
            this.lbl_Saat = new System.Windows.Forms.Label();
            this.flp_masalar = new System.Windows.Forms.FlowLayoutPanel();
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_content = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_rightContent = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_leftContent = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_masaAdi = new System.Windows.Forms.Label();
            this.tlp_leftContentMasa = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_baslamaSaatiName = new System.Windows.Forms.Label();
            this.lbl_baslamaSaati = new System.Windows.Forms.Label();
            this.lbl_gecenSureName = new System.Windows.Forms.Label();
            this.lbl_masaUcretiName = new System.Windows.Forms.Label();
            this.lbl_gecenDk = new System.Windows.Forms.Label();
            this.lbl_masaUcreti = new System.Windows.Forms.Label();
            this.lbl_siparisToplamName = new System.Windows.Forms.Label();
            this.lbl_siparisToplam = new System.Windows.Forms.Label();
            this.lbl_odenenUcretName = new System.Windows.Forms.Label();
            this.lbl_odenenUcret = new System.Windows.Forms.Label();
            this.lbl_toplamName = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.lbl_aktarilanUcretName = new System.Windows.Forms.Label();
            this.lbl_aktarilanUcret = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tarife = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_startStop = new System.Windows.Forms.Button();
            this.btn_siparis = new System.Windows.Forms.Button();
            this.tmr_masa = new System.Windows.Forms.Timer(this.components);
            this.tmr_saat = new System.Windows.Forms.Timer(this.components);
            this.btn_rapor = new System.Windows.Forms.Button();
            this.tlp_rightContentUp.SuspendLayout();
            this.tlp_rightUpContentButtons.SuspendLayout();
            this.tlp_header.SuspendLayout();
            this.tlp_main.SuspendLayout();
            this.tlp_content.SuspendLayout();
            this.tlp_rightContent.SuspendLayout();
            this.tlp_leftContent.SuspendLayout();
            this.tlp_leftContentMasa.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_rightContentUp
            // 
            this.tlp_rightContentUp.ColumnCount = 3;
            this.tlp_rightContentUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_rightContentUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_rightContentUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_rightContentUp.Controls.Add(this.tlp_rightUpContentButtons, 0, 0);
            this.tlp_rightContentUp.Controls.Add(this.btn_rapor, 2, 0);
            this.tlp_rightContentUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_rightContentUp.Location = new System.Drawing.Point(0, 0);
            this.tlp_rightContentUp.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_rightContentUp.Name = "tlp_rightContentUp";
            this.tlp_rightContentUp.RowCount = 1;
            this.tlp_rightContentUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_rightContentUp.Size = new System.Drawing.Size(949, 31);
            this.tlp_rightContentUp.TabIndex = 1;
            // 
            // tlp_rightUpContentButtons
            // 
            this.tlp_rightUpContentButtons.BackColor = System.Drawing.Color.White;
            this.tlp_rightUpContentButtons.ColumnCount = 5;
            this.tlp_rightUpContentButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_rightUpContentButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_rightUpContentButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_rightUpContentButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_rightUpContentButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_rightUpContentButtons.Controls.Add(this.btn_okey, 2, 0);
            this.tlp_rightUpContentButtons.Controls.Add(this.btn_amerikan, 0, 0);
            this.tlp_rightUpContentButtons.Controls.Add(this.btn_ucTop, 1, 0);
            this.tlp_rightUpContentButtons.Controls.Add(this.btn_masaTenisi, 3, 0);
            this.tlp_rightUpContentButtons.Controls.Add(this.btn_snooker, 4, 0);
            this.tlp_rightUpContentButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_rightUpContentButtons.Location = new System.Drawing.Point(0, 0);
            this.tlp_rightUpContentButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_rightUpContentButtons.Name = "tlp_rightUpContentButtons";
            this.tlp_rightUpContentButtons.RowCount = 1;
            this.tlp_rightUpContentButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_rightUpContentButtons.Size = new System.Drawing.Size(474, 31);
            this.tlp_rightUpContentButtons.TabIndex = 2;
            // 
            // btn_okey
            // 
            this.btn_okey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_okey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_okey.Location = new System.Drawing.Point(189, 2);
            this.btn_okey.Margin = new System.Windows.Forms.Padding(1, 2, 1, 0);
            this.btn_okey.Name = "btn_okey";
            this.btn_okey.Size = new System.Drawing.Size(92, 29);
            this.btn_okey.TabIndex = 0;
            this.btn_okey.Text = "Okey";
            this.btn_okey.UseVisualStyleBackColor = true;
            this.btn_okey.Click += new System.EventHandler(this.btn_okey_Click);
            // 
            // btn_amerikan
            // 
            this.btn_amerikan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_amerikan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_amerikan.Location = new System.Drawing.Point(1, 2);
            this.btn_amerikan.Margin = new System.Windows.Forms.Padding(1, 2, 1, 0);
            this.btn_amerikan.Name = "btn_amerikan";
            this.btn_amerikan.Size = new System.Drawing.Size(92, 29);
            this.btn_amerikan.TabIndex = 0;
            this.btn_amerikan.Text = "amerikan";
            this.btn_amerikan.UseVisualStyleBackColor = true;
            this.btn_amerikan.Click += new System.EventHandler(this.btn_amerikan_Click);
            // 
            // btn_ucTop
            // 
            this.btn_ucTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ucTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ucTop.Location = new System.Drawing.Point(95, 2);
            this.btn_ucTop.Margin = new System.Windows.Forms.Padding(1, 2, 1, 0);
            this.btn_ucTop.Name = "btn_ucTop";
            this.btn_ucTop.Size = new System.Drawing.Size(92, 29);
            this.btn_ucTop.TabIndex = 0;
            this.btn_ucTop.Text = "Üç Top";
            this.btn_ucTop.UseVisualStyleBackColor = true;
            this.btn_ucTop.Click += new System.EventHandler(this.btn_ucTop_Click);
            // 
            // btn_masaTenisi
            // 
            this.btn_masaTenisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_masaTenisi.Location = new System.Drawing.Point(283, 2);
            this.btn_masaTenisi.Margin = new System.Windows.Forms.Padding(1, 2, 1, 0);
            this.btn_masaTenisi.Name = "btn_masaTenisi";
            this.btn_masaTenisi.Size = new System.Drawing.Size(92, 29);
            this.btn_masaTenisi.TabIndex = 1;
            this.btn_masaTenisi.Text = "Masa Tenisi";
            this.btn_masaTenisi.UseVisualStyleBackColor = true;
            this.btn_masaTenisi.Click += new System.EventHandler(this.btn_masaTenisi_Click);
            // 
            // btn_snooker
            // 
            this.btn_snooker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_snooker.Location = new System.Drawing.Point(377, 2);
            this.btn_snooker.Margin = new System.Windows.Forms.Padding(1, 2, 1, 0);
            this.btn_snooker.Name = "btn_snooker";
            this.btn_snooker.Size = new System.Drawing.Size(96, 29);
            this.btn_snooker.TabIndex = 1;
            this.btn_snooker.Text = "Snooker";
            this.btn_snooker.UseVisualStyleBackColor = true;
            this.btn_snooker.Click += new System.EventHandler(this.btn_snooker_Click);
            // 
            // tlp_header
            // 
            this.tlp_header.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_header.ColumnCount = 2;
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_header.Controls.Add(this.lbl_headerName, 0, 0);
            this.tlp_header.Controls.Add(this.lbl_Saat, 1, 0);
            this.tlp_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_header.Location = new System.Drawing.Point(0, 0);
            this.tlp_header.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_header.Name = "tlp_header";
            this.tlp_header.RowCount = 1;
            this.tlp_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_header.Size = new System.Drawing.Size(1186, 54);
            this.tlp_header.TabIndex = 2;
            // 
            // lbl_headerName
            // 
            this.lbl_headerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_headerName.AutoSize = true;
            this.lbl_headerName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_headerName.Location = new System.Drawing.Point(4, 14);
            this.lbl_headerName.Name = "lbl_headerName";
            this.lbl_headerName.Size = new System.Drawing.Size(353, 26);
            this.lbl_headerName.TabIndex = 0;
            this.lbl_headerName.Text = "DİAMOND BİLARDO SALONU";
            // 
            // lbl_Saat
            // 
            this.lbl_Saat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Saat.AutoSize = true;
            this.lbl_Saat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Saat.Location = new System.Drawing.Point(921, 14);
            this.lbl_Saat.Name = "lbl_Saat";
            this.lbl_Saat.Size = new System.Drawing.Size(261, 26);
            this.lbl_Saat.TabIndex = 1;
            this.lbl_Saat.Text = "12 MART 2022 22:12:00";
            // 
            // flp_masalar
            // 
            this.flp_masalar.AutoScroll = true;
            this.flp_masalar.BackColor = System.Drawing.Color.White;
            this.flp_masalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_masalar.Location = new System.Drawing.Point(0, 31);
            this.flp_masalar.Margin = new System.Windows.Forms.Padding(0);
            this.flp_masalar.Name = "flp_masalar";
            this.flp_masalar.Size = new System.Drawing.Size(949, 597);
            this.flp_masalar.TabIndex = 0;
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.tlp_header, 0, 0);
            this.tlp_main.Controls.Add(this.tlp_content, 0, 1);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 2;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tlp_main.Size = new System.Drawing.Size(1186, 682);
            this.tlp_main.TabIndex = 8;
            // 
            // tlp_content
            // 
            this.tlp_content.ColumnCount = 2;
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_content.Controls.Add(this.tlp_rightContent, 1, 0);
            this.tlp_content.Controls.Add(this.tlp_leftContent, 0, 0);
            this.tlp_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_content.Location = new System.Drawing.Point(0, 54);
            this.tlp_content.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_content.Name = "tlp_content";
            this.tlp_content.RowCount = 1;
            this.tlp_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.Size = new System.Drawing.Size(1186, 628);
            this.tlp_content.TabIndex = 3;
            // 
            // tlp_rightContent
            // 
            this.tlp_rightContent.ColumnCount = 1;
            this.tlp_rightContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_rightContent.Controls.Add(this.flp_masalar, 0, 1);
            this.tlp_rightContent.Controls.Add(this.tlp_rightContentUp, 0, 0);
            this.tlp_rightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_rightContent.Location = new System.Drawing.Point(237, 0);
            this.tlp_rightContent.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_rightContent.Name = "tlp_rightContent";
            this.tlp_rightContent.RowCount = 2;
            this.tlp_rightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_rightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlp_rightContent.Size = new System.Drawing.Size(949, 628);
            this.tlp_rightContent.TabIndex = 1;
            // 
            // tlp_leftContent
            // 
            this.tlp_leftContent.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_leftContent.ColumnCount = 1;
            this.tlp_leftContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_leftContent.Controls.Add(this.lbl_masaAdi, 0, 0);
            this.tlp_leftContent.Controls.Add(this.tlp_leftContentMasa, 0, 1);
            this.tlp_leftContent.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlp_leftContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_leftContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tlp_leftContent.Location = new System.Drawing.Point(0, 0);
            this.tlp_leftContent.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_leftContent.Name = "tlp_leftContent";
            this.tlp_leftContent.RowCount = 3;
            this.tlp_leftContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_leftContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_leftContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_leftContent.Size = new System.Drawing.Size(237, 628);
            this.tlp_leftContent.TabIndex = 2;
            // 
            // lbl_masaAdi
            // 
            this.lbl_masaAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_masaAdi.AutoSize = true;
            this.lbl_masaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_masaAdi.Location = new System.Drawing.Point(96, 16);
            this.lbl_masaAdi.Name = "lbl_masaAdi";
            this.lbl_masaAdi.Size = new System.Drawing.Size(45, 32);
            this.lbl_masaAdi.TabIndex = 0;
            this.lbl_masaAdi.Text = "---";
            // 
            // tlp_leftContentMasa
            // 
            this.tlp_leftContentMasa.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_leftContentMasa.ColumnCount = 2;
            this.tlp_leftContentMasa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_leftContentMasa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_leftContentMasa.Controls.Add(this.lbl_baslamaSaatiName, 0, 0);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_baslamaSaati, 1, 0);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_gecenSureName, 0, 1);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_masaUcretiName, 0, 3);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_gecenDk, 1, 1);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_masaUcreti, 1, 3);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_siparisToplamName, 0, 4);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_siparisToplam, 1, 4);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_odenenUcretName, 0, 5);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_odenenUcret, 1, 5);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_toplamName, 0, 7);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_toplam, 1, 7);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_aktarilanUcretName, 0, 6);
            this.tlp_leftContentMasa.Controls.Add(this.lbl_aktarilanUcret, 1, 6);
            this.tlp_leftContentMasa.Controls.Add(this.label1, 0, 2);
            this.tlp_leftContentMasa.Controls.Add(this.cmb_tarife, 1, 2);
            this.tlp_leftContentMasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_leftContentMasa.Location = new System.Drawing.Point(4, 67);
            this.tlp_leftContentMasa.Name = "tlp_leftContentMasa";
            this.tlp_leftContentMasa.RowCount = 8;
            this.tlp_leftContentMasa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_leftContentMasa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_leftContentMasa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_leftContentMasa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_leftContentMasa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_leftContentMasa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_leftContentMasa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp_leftContentMasa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp_leftContentMasa.Size = new System.Drawing.Size(229, 306);
            this.tlp_leftContentMasa.TabIndex = 1;
            // 
            // lbl_baslamaSaatiName
            // 
            this.lbl_baslamaSaatiName.AutoSize = true;
            this.lbl_baslamaSaatiName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_baslamaSaatiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslamaSaatiName.Location = new System.Drawing.Point(4, 1);
            this.lbl_baslamaSaatiName.Name = "lbl_baslamaSaatiName";
            this.lbl_baslamaSaatiName.Size = new System.Drawing.Size(107, 35);
            this.lbl_baslamaSaatiName.TabIndex = 0;
            this.lbl_baslamaSaatiName.Text = "Başlama Saati";
            this.lbl_baslamaSaatiName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_baslamaSaati
            // 
            this.lbl_baslamaSaati.AutoSize = true;
            this.lbl_baslamaSaati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_baslamaSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslamaSaati.Location = new System.Drawing.Point(118, 1);
            this.lbl_baslamaSaati.Name = "lbl_baslamaSaati";
            this.lbl_baslamaSaati.Size = new System.Drawing.Size(107, 35);
            this.lbl_baslamaSaati.TabIndex = 1;
            this.lbl_baslamaSaati.Text = "--:--:--";
            this.lbl_baslamaSaati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_gecenSureName
            // 
            this.lbl_gecenSureName.AutoSize = true;
            this.lbl_gecenSureName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_gecenSureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gecenSureName.Location = new System.Drawing.Point(4, 37);
            this.lbl_gecenSureName.Name = "lbl_gecenSureName";
            this.lbl_gecenSureName.Size = new System.Drawing.Size(107, 35);
            this.lbl_gecenSureName.TabIndex = 2;
            this.lbl_gecenSureName.Text = "Geçen Süre";
            this.lbl_gecenSureName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_masaUcretiName
            // 
            this.lbl_masaUcretiName.AutoSize = true;
            this.lbl_masaUcretiName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_masaUcretiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_masaUcretiName.Location = new System.Drawing.Point(4, 109);
            this.lbl_masaUcretiName.Name = "lbl_masaUcretiName";
            this.lbl_masaUcretiName.Size = new System.Drawing.Size(107, 35);
            this.lbl_masaUcretiName.TabIndex = 3;
            this.lbl_masaUcretiName.Text = "Masa Ücreti";
            this.lbl_masaUcretiName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_gecenDk
            // 
            this.lbl_gecenDk.AutoSize = true;
            this.lbl_gecenDk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_gecenDk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gecenDk.Location = new System.Drawing.Point(118, 37);
            this.lbl_gecenDk.Name = "lbl_gecenDk";
            this.lbl_gecenDk.Size = new System.Drawing.Size(107, 35);
            this.lbl_gecenDk.TabIndex = 4;
            this.lbl_gecenDk.Text = "00";
            this.lbl_gecenDk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_masaUcreti
            // 
            this.lbl_masaUcreti.AutoSize = true;
            this.lbl_masaUcreti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_masaUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_masaUcreti.Location = new System.Drawing.Point(118, 109);
            this.lbl_masaUcreti.Name = "lbl_masaUcreti";
            this.lbl_masaUcreti.Size = new System.Drawing.Size(107, 35);
            this.lbl_masaUcreti.TabIndex = 5;
            this.lbl_masaUcreti.Text = "0,00";
            this.lbl_masaUcreti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_siparisToplamName
            // 
            this.lbl_siparisToplamName.AutoSize = true;
            this.lbl_siparisToplamName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_siparisToplamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_siparisToplamName.Location = new System.Drawing.Point(4, 145);
            this.lbl_siparisToplamName.Name = "lbl_siparisToplamName";
            this.lbl_siparisToplamName.Size = new System.Drawing.Size(107, 35);
            this.lbl_siparisToplamName.TabIndex = 6;
            this.lbl_siparisToplamName.Text = "Sipariş Toplamı";
            this.lbl_siparisToplamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_siparisToplam
            // 
            this.lbl_siparisToplam.AutoSize = true;
            this.lbl_siparisToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_siparisToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_siparisToplam.Location = new System.Drawing.Point(118, 145);
            this.lbl_siparisToplam.Name = "lbl_siparisToplam";
            this.lbl_siparisToplam.Size = new System.Drawing.Size(107, 35);
            this.lbl_siparisToplam.TabIndex = 7;
            this.lbl_siparisToplam.Text = "0,00";
            this.lbl_siparisToplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_odenenUcretName
            // 
            this.lbl_odenenUcretName.AutoSize = true;
            this.lbl_odenenUcretName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_odenenUcretName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_odenenUcretName.Location = new System.Drawing.Point(4, 181);
            this.lbl_odenenUcretName.Name = "lbl_odenenUcretName";
            this.lbl_odenenUcretName.Size = new System.Drawing.Size(107, 35);
            this.lbl_odenenUcretName.TabIndex = 8;
            this.lbl_odenenUcretName.Text = "Ödenen Ücret";
            this.lbl_odenenUcretName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_odenenUcret
            // 
            this.lbl_odenenUcret.AutoSize = true;
            this.lbl_odenenUcret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_odenenUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_odenenUcret.Location = new System.Drawing.Point(118, 181);
            this.lbl_odenenUcret.Name = "lbl_odenenUcret";
            this.lbl_odenenUcret.Size = new System.Drawing.Size(107, 35);
            this.lbl_odenenUcret.TabIndex = 9;
            this.lbl_odenenUcret.Text = "0,00";
            this.lbl_odenenUcret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_toplamName
            // 
            this.lbl_toplamName.AutoSize = true;
            this.lbl_toplamName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_toplamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamName.Location = new System.Drawing.Point(4, 253);
            this.lbl_toplamName.Name = "lbl_toplamName";
            this.lbl_toplamName.Size = new System.Drawing.Size(107, 52);
            this.lbl_toplamName.TabIndex = 10;
            this.lbl_toplamName.Text = "Toplam";
            this.lbl_toplamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.Location = new System.Drawing.Point(118, 253);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(107, 52);
            this.lbl_toplam.TabIndex = 11;
            this.lbl_toplam.Text = "0,00";
            this.lbl_toplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_aktarilanUcretName
            // 
            this.lbl_aktarilanUcretName.AutoSize = true;
            this.lbl_aktarilanUcretName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_aktarilanUcretName.Location = new System.Drawing.Point(4, 217);
            this.lbl_aktarilanUcretName.Name = "lbl_aktarilanUcretName";
            this.lbl_aktarilanUcretName.Size = new System.Drawing.Size(107, 35);
            this.lbl_aktarilanUcretName.TabIndex = 12;
            this.lbl_aktarilanUcretName.Text = "Aktarılan Ücret";
            this.lbl_aktarilanUcretName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_aktarilanUcret
            // 
            this.lbl_aktarilanUcret.AutoSize = true;
            this.lbl_aktarilanUcret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_aktarilanUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aktarilanUcret.Location = new System.Drawing.Point(118, 217);
            this.lbl_aktarilanUcret.Name = "lbl_aktarilanUcret";
            this.lbl_aktarilanUcret.Size = new System.Drawing.Size(107, 35);
            this.lbl_aktarilanUcret.TabIndex = 13;
            this.lbl_aktarilanUcret.Text = "0,00";
            this.lbl_aktarilanUcret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Masa Tarifesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_tarife
            // 
            this.cmb_tarife.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_tarife.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_tarife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tarife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_tarife.FormattingEnabled = true;
            this.cmb_tarife.Items.AddRange(new object[] {
            "Antreman",
            "Standart",
            "Çoklu"});
            this.cmb_tarife.Location = new System.Drawing.Point(115, 74);
            this.cmb_tarife.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_tarife.Name = "cmb_tarife";
            this.cmb_tarife.Size = new System.Drawing.Size(113, 33);
            this.cmb_tarife.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_startStop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_siparis, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 380);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 244);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_startStop
            // 
            this.btn_startStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_startStop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_startStop.Location = new System.Drawing.Point(3, 3);
            this.btn_startStop.Name = "btn_startStop";
            this.btn_startStop.Size = new System.Drawing.Size(223, 42);
            this.btn_startStop.TabIndex = 0;
            this.btn_startStop.Text = "Başlat";
            this.btn_startStop.UseVisualStyleBackColor = true;
            this.btn_startStop.Click += new System.EventHandler(this.btn_startStop_Click);
            // 
            // btn_siparis
            // 
            this.btn_siparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_siparis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_siparis.Location = new System.Drawing.Point(3, 51);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.Size = new System.Drawing.Size(223, 42);
            this.btn_siparis.TabIndex = 1;
            this.btn_siparis.Text = "Sipariş Ekle";
            this.btn_siparis.UseVisualStyleBackColor = true;
            this.btn_siparis.Click += new System.EventHandler(this.btn_siparis_Click);
            // 
            // tmr_masa
            // 
            this.tmr_masa.Interval = 1000;
            this.tmr_masa.Tick += new System.EventHandler(this.tmr_masa_Tick);
            // 
            // tmr_saat
            // 
            this.tmr_saat.Enabled = true;
            this.tmr_saat.Tick += new System.EventHandler(this.tmr_saat_Tick);
            // 
            // btn_rapor
            // 
            this.btn_rapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rapor.Location = new System.Drawing.Point(856, 3);
            this.btn_rapor.Name = "btn_rapor";
            this.btn_rapor.Size = new System.Drawing.Size(90, 25);
            this.btn_rapor.TabIndex = 3;
            this.btn_rapor.Text = "Rapor";
            this.btn_rapor.UseVisualStyleBackColor = true;
            this.btn_rapor.Click += new System.EventHandler(this.btn_rapor_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1186, 682);
            this.Controls.Add(this.tlp_main);
            this.Name = "Anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.tlp_rightContentUp.ResumeLayout(false);
            this.tlp_rightUpContentButtons.ResumeLayout(false);
            this.tlp_header.ResumeLayout(false);
            this.tlp_header.PerformLayout();
            this.tlp_main.ResumeLayout(false);
            this.tlp_content.ResumeLayout(false);
            this.tlp_rightContent.ResumeLayout(false);
            this.tlp_leftContent.ResumeLayout(false);
            this.tlp_leftContent.PerformLayout();
            this.tlp_leftContentMasa.ResumeLayout(false);
            this.tlp_leftContentMasa.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp_rightContentUp;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private System.Windows.Forms.FlowLayoutPanel flp_masalar;
        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.TableLayoutPanel tlp_content;
        private System.Windows.Forms.TableLayoutPanel tlp_rightContent;
        private System.Windows.Forms.TableLayoutPanel tlp_leftContent;
        private System.Windows.Forms.Label lbl_headerName;
        private System.Windows.Forms.Label lbl_Saat;
        private System.Windows.Forms.Label lbl_masaAdi;
        private System.Windows.Forms.TableLayoutPanel tlp_rightUpContentButtons;
        private System.Windows.Forms.Button btn_okey;
        private System.Windows.Forms.Button btn_amerikan;
        private System.Windows.Forms.Button btn_ucTop;
        private System.Windows.Forms.TableLayoutPanel tlp_leftContentMasa;
        private System.Windows.Forms.Label lbl_baslamaSaatiName;
        private System.Windows.Forms.Label lbl_gecenSureName;
        private System.Windows.Forms.Label lbl_masaUcretiName;
        private System.Windows.Forms.Label lbl_siparisToplamName;
        private System.Windows.Forms.Label lbl_odenenUcretName;
        private System.Windows.Forms.Label lbl_toplamName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_startStop;
        private System.Windows.Forms.Button btn_siparis;
        private System.Windows.Forms.Label lbl_aktarilanUcretName;
        private System.Windows.Forms.Timer tmr_masa;
        private System.Windows.Forms.Timer tmr_saat;
        public System.Windows.Forms.Label lbl_baslamaSaati;
        public System.Windows.Forms.Label lbl_gecenDk;
        public System.Windows.Forms.Label lbl_masaUcreti;
        public System.Windows.Forms.Label lbl_siparisToplam;
        public System.Windows.Forms.Label lbl_odenenUcret;
        public System.Windows.Forms.Label lbl_toplam;
        public System.Windows.Forms.Label lbl_aktarilanUcret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tarife;
        private System.Windows.Forms.Button btn_masaTenisi;
        private System.Windows.Forms.Button btn_snooker;
        private System.Windows.Forms.Button btn_rapor;
    }
}