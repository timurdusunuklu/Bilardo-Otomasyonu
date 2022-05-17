using Pool.Bll.Abstract;
using Pool.Core.Utilities.Form.Infrastructure;
using Pool.Entities;
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
    public partial class Hesap : Form
    {
        public int masaId;
        private IHareketService _hareketService;

        public Hesap(IHareketService hareketService)
        {
            InitializeComponent();
            _hareketService = hareketService;
        }
        private void Hesap_Load(object sender, EventArgs e)
        {

        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            _hareketService.HareketEkle(new Hareket
            {
                Masa_Id= masaId,
                Odenmis_Ucret = Convert.ToDecimal(txt_odenenUcret.Text),
                aktarilan_Ucret= Convert.ToDecimal(txt_aktarilanUcret.Text),
                Durum=true
                
            });
            Anasayfa anasayfa = FormResolve.resolve<Anasayfa>();
            anasayfa.BilgiGetir();
            anasayfa.lbl_aktarilanUcret.Text = txt_odenenUcret.Text;
            anasayfa.lbl_odenenUcret.Text = txt_aktarilanUcret.Text;
            this.Close();
        }

        private void btn_hesapKapat_Click(object sender, EventArgs e)
        {
            _hareketService.HareketEkle(new Hareket
            {
                Masa_Id = masaId,
                Odenmis_Ucret = Convert.ToDecimal(txt_odenenUcret.Text),
                aktarilan_Ucret = Convert.ToDecimal(txt_aktarilanUcret.Text),
                Durum = false

            });
            this.Close();
        }
    }
}
