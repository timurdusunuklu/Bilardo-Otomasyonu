using Pool.Bll.Abstract;
using Pool.Core.CrossCuttingConcerns.Caching.Microsoft;
using Pool.Core.Utilities.Form.Infrastructure;
using Pool.Entities;
using Pool.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool.UI
{
    public partial class Anasayfa : Form
    {
        List<Button> _btnMasa = new List<Button>();
        int _masaId;
        MasaHareket _masa = null;
        private IHareketService _hareketService;
        private IMasaService _masaService;

        public Anasayfa(IMasaService masaService, IHareketService hareketService)
        {
            InitializeComponent();
            _masaService = masaService;
            _hareketService = hareketService;
        }


        private void Anasayfa_Load(object sender, EventArgs e)
        {
            //tarihi 3 gün önceden küçük olan hareket kayırlarını temizler.
            _hareketService.HareketTemizle();
            LoadingTable();
            //default olarak amerikan masalarını getirme
            BringTable("A");
            //Açık Masaları Yakalma
            foreach (var item in _hareketService.GetOnAll())
            {
                for (int i = 0; i < _btnMasa.Count(); i++)
                {
                    if (item.Masa_Id.ToString() == _btnMasa[i].Name)
                    {
                        _btnMasa[i].BackColor = Color.Green;
                    }
                }
            }

        }

        public void BringTable(string masaTipi)
        {
            foreach (var item in _btnMasa.ToList())
            {
                if (item.Text.StartsWith(masaTipi))
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }

            }
        }

        public void LoadingTable()
        {
            int _width = flp_masalar.Size.Width;
            int _height = flp_masalar.Size.Height;
            int bGenislik = (_width / 5) - 7;
            int bYukseklik = (_height / 4) - 7;


            for (int j = 1; j <= 5; j++)
            {
                int top = 0;
                int left = 0;
                int i = 0;
                foreach (var item in _masaService.GetAllType(j))
                {
                    Button button = new Button();
                    i++;

                    button.Top += top;
                    button.Left += left;
                    button.Width = bGenislik;
                    button.Height = bYukseklik;
                    button.Name = Convert.ToString(item.Id);
                    button.Text = item.Masa_Adi;
                    button.Font = new Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold);
                    button.BackColor = Color.BurlyWood;
                    if (i % 5 == 0)
                    {
                        top += bYukseklik;
                        left = 0;

                    }
                    else
                    {
                        left += bGenislik;
                    }

                    _btnMasa.Add(button);
                   flp_masalar.Controls.Add(button);
                    button.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            _masaId = Convert.ToInt32(button.Name);

            _masa = _masaService.MasaHareket(_masaId);
            lbl_masaAdi.Text = button.Text;
            BilgiGetir();

        }
      

        private void btn_siparis_Click(object sender, EventArgs e)
        {
           
            Siparis siparis = FormResolve.resolve<Siparis>();
            siparis.Text = lbl_masaAdi.Text + " Sipariş";
            siparis._hareketId = _masa.hareketId;
            siparis.ShowDialog();
        }

        private void btn_startStop_Click(object sender, EventArgs e)
        {
            if (btn_startStop.Text == "Hesapla")
            {

                BilgiGetir();
                Hesap hesap = FormResolve.resolve<Hesap>();
                hesap.Text = lbl_masaAdi.Text + "-Hesap";                
                hesap.lbl_toplam.Text = lbl_toplam.Text;
                hesap.lbl_süre.Text = "Geçen Süre:" + lbl_gecenDk.Text;
                hesap.txt_masaTarifesi.Text = cmb_tarife.SelectedItem.ToString();
                hesap.txt_masaUcreti.Text = lbl_masaUcreti.Text;
                hesap.txt_siparisToplam.Text = lbl_siparisToplam.Text;
                hesap.txt_odenenUcret.Text = lbl_odenenUcret.Text;
                hesap.txt_aktarilanUcret.Text = lbl_aktarilanUcret.Text;
                hesap.masaId = _masaId;
               
                hesap.ShowDialog();

            }
            else
            {
               
                foreach (var item in _btnMasa)
                {
                    if (item.Text == lbl_masaAdi.Text)
                    {
                        item.BackColor = Color.Green;
                    }

                }

                
                int tarife;
                switch (cmb_tarife.SelectedItem)
                {
                    case "Standart":
                        tarife = 1;
                        break;
                    case "Antreman":
                        tarife = 0;
                        break;
                    case "Çoklu":
                        tarife = 2;
                        break;
                    default:
                        tarife = 1;
                        break;
                }
                var result = _hareketService.HareketEkle(new Hareket
                {
                    Tarife = tarife,
                    Masa_Id = _masaId,
                    Durum=true
                    
                });
                lbl_baslamaSaati.Text = result.Baslanma_saati.ToString(@"hh\:mm");
                btn_startStop.Text = "Hesapla";
                cmb_tarife.Enabled = false;
                _masa = _masaService.MasaHareket(_masaId);
                btn_siparis.Enabled = true;
                tmr_masa.Start();

            }
        }


        public void BilgiGetir()
        {
            if (_masa != null)
            {
                 if (_masa.Durum == true)
                {
                    
                   
                    cmb_tarife.Enabled = false;
                    btn_siparis.Enabled = true;
                    btn_startStop.Text = "Hesapla";
                    cmb_tarife.SelectedIndex = _masa.Tarife;
                    lbl_baslamaSaati.Text = _masa.Baslanma_saati.ToString(@"hh\:mm");
                    switch (_masa.Tarife)
                    {
                        case 0:
                            lbl_masaUcreti.Text = ((_masa.Antreman_Masa_Ucreti / 60) * Convert.ToInt32(lbl_gecenDk.Text)).ToString("F");
                            break;
                        case 1:
                            lbl_masaUcreti.Text = ((_masa.Standart_Masa_Ucreti / 60) * Convert.ToInt32(lbl_gecenDk.Text)).ToString("F");
                            break;
                        case 2:
                            lbl_masaUcreti.Text = ((_masa.Coklu_Masa_Ucreti / 60) * Convert.ToInt32(lbl_gecenDk.Text)).ToString("F");
                            break;

                    } 
                    lbl_odenenUcret.Text = _masa.Odenmis_Ucret.ToString("F");
                    lbl_aktarilanUcret.Text = _masa.aktarilan_Ucret.ToString("F");


                    lbl_toplam.Text =
                        (Convert.ToDecimal(lbl_masaUcreti.Text) +
                        Convert.ToDecimal(lbl_aktarilanUcret.Text) +
                        Convert.ToDecimal(lbl_siparisToplam.Text) -
                        Convert.ToDecimal(lbl_odenenUcret.Text)).ToString("F");
                    tmr_masa.Start();
                }
            }
            else
            {
                tmr_masa.Stop();
                cmb_tarife.Enabled = true;
                btn_siparis.Enabled = false;
                btn_startStop.Text = "Başlat";
                lbl_baslamaSaati.Text = "--:--";
                cmb_tarife.SelectedIndex = 1;
                lbl_gecenDk.Text = "00";
                lbl_masaUcreti.Text = "0,00";
                lbl_siparisToplam.Text = "0,00";
                lbl_odenenUcret.Text = "0,00";
                lbl_aktarilanUcret.Text = "0,00";
                lbl_toplam.Text = "0,00";
            }
        }

        private void tmr_masa_Tick(object sender, EventArgs e)
        {
            double gecensure = (DateTime.Now.TimeOfDay - Convert.ToDateTime(lbl_baslamaSaati.Text).TimeOfDay).TotalMinutes;
            lbl_gecenDk.Text = Convert.ToInt32(gecensure).ToString();
            switch (_masa.Tarife)
            {

                case 0:
                    lbl_masaUcreti.Text = ((_masa.Antreman_Masa_Ucreti / 60) * Convert.ToInt32(lbl_gecenDk.Text)).ToString("F");
                    break;
                case 1:
                    lbl_masaUcreti.Text = ((_masa.Standart_Masa_Ucreti / 60) * Convert.ToInt32(lbl_gecenDk.Text)).ToString("F");
                    break;
                case 2:
                    lbl_masaUcreti.Text = ((_masa.Coklu_Masa_Ucreti / 60) * Convert.ToInt32(lbl_gecenDk.Text)).ToString("F");
                    break;

            }
            lbl_toplam.Text =
                       (Convert.ToDecimal(lbl_masaUcreti.Text) +
                       Convert.ToDecimal(lbl_aktarilanUcret.Text) +
                       Convert.ToDecimal(lbl_siparisToplam.Text) -
                       Convert.ToDecimal(lbl_odenenUcret.Text)).ToString("F");
        }

        private void tmr_saat_Tick(object sender, EventArgs e)
        {
            lbl_Saat.Text = DateTime.Now.ToString();
        }

        private void btn_ucTop_Click(object sender, EventArgs e)
        {
            
            BringTable("U");
        }

        private void btn_amerikan_Click(object sender, EventArgs e)
        {
            BringTable("A");
        }

        private void btn_okey_Click(object sender, EventArgs e)
        {  
            BringTable("O");
        }
        private void btn_masaTenisi_Click(object sender, EventArgs e)
        {
            BringTable("T");
        }

        private void btn_snooker_Click(object sender, EventArgs e)
        {
            BringTable("S");
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            Rapor rapor = FormResolve.resolve<Rapor>();
            rapor.Show();
        }
    }
}
