using Pool.Bll.Abstract;
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
    public partial class Siparis : Form
    {
        private IMasaService _masaService;
        private ISiparisService _siparisService;
        private IKategoriService _kategoriService;
        private IStokService _stokService;
        private IHareketService _hareketService;
        public Siparis(
            ISiparisService siparisService,
            IKategoriService kategoriService,
            IStokService stokService,
            IHareketService hareketService,
            IMasaService masaService)
        {
            InitializeComponent();
            _siparisService = siparisService;
            _kategoriService = kategoriService;
            _stokService = stokService;
            _hareketService = hareketService;
            _masaService = masaService;
        }
        public int _hareketId;
        private void Siparis_Load(object sender, EventArgs e)
        {

            SiparisGetir();
            StokGetAllType(1);

        }


        private void Kategori_Button_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            StokGetAllType(Convert.ToInt32(button.Name));

        }

        int _btnStokId;
        private void Stok_Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _btnStokId = Convert.ToInt32(button.Name);
            nud_Adet.Value++;
        }



        private void btn_add_Click(object sender, EventArgs e)
        {

            _siparisService.SiparisEkleme((int)nud_Adet.Value, _hareketId, _btnStokId);
            SiparisGetir();
            nud_Adet.Value = 0;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var item = lvw_siparisler.SelectedItems[0].Text;
            _siparisService.SiparisSilme((int)nud_Adet.Value, _hareketId,item);
            SiparisGetir();
            nud_Adet.Value = 0;
        }

        private void SiparisGetir()
        {
            lvw_siparisler.Items.Clear();
            decimal toplam = 0;
            var result = _siparisService.SiparisDetailsGetAll(_hareketId);
            if (result != null) 
            {
                foreach (var item in result)
                {
                    ListViewItem list = new ListViewItem(item.Ürün_Adi);
                    //list.SubItems.Add();
                    list.SubItems.Add(item.Adet.ToString());
                    list.SubItems.Add((item.Adet * item.BirimTutar).ToString());
                    lvw_siparisler.Items.Add(list);
                    toplam += item.Adet * item.BirimTutar;
                }
            }

            lbl_toplam.Text = toplam.ToString();



        }
        private void btn_sicak_Click(object sender, EventArgs e)
        {
            StokGetAllType(1);
        }

        private void btn_soguk_Click(object sender, EventArgs e)
        {
            StokGetAllType(2);
        }

        private void btn_market_Click(object sender, EventArgs e)
        {
            StokGetAllType(3);
        }

        private void btn_mutfak_Click(object sender, EventArgs e)
        {
            StokGetAllType(4);
        }



        //Seçilen kategoriye ait stokları getirir.
        private void StokGetAllType(int KategoriType)
        {
            flp_stok.Controls.Clear();
            int top = 25;
            int left = 25;
            int i = 0;
            foreach (var item in _stokService.GetAllType(KategoriType))
            {
                i++;
                if (i % 7 == 0)
                {
                    top += 95;
                    left = 25;
                }
                Button button = new Button();
                button.TextAlign = ContentAlignment.BottomCenter;
                button.Width = 70;
                button.Height = 70;
                button.Left += left;
                button.Top += top;
                button.Text = item.Ürün_Adı;
                button.Name = Convert.ToString(item.Id);
                button.Click += Stok_Button_Click;
                flp_stok.Controls.Add(button);
                left += 95;
            }
        }
    }
}
