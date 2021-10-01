using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracsiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnrenk_Click(object sender, EventArgs e)
        {
            //kullanıcıya renk seçtirip butonun o rengine bürünmesi

            //burada kullanıcı color ekranından tamam butonunamı basmış veya iptale mi basmış bunu yakalamam için dialogresult tipinde bir değişken oluşturdum.

            DialogResult sonuc = colorDialog1.ShowDialog();

            //burada ise dialogresult sonucu okeye eşitse,demekki kullanıcı tamamma basmış,kullanıcınınseçmiş oldugu rengi butonun arka planına atmam lazım

            if (sonuc == DialogResult.OK)
            {

                btnrenk.BackColor = colorDialog1.Color;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmodel.Items.Clear();
            //seçme işlemi sırasında clear metodunu kullanmasaydım sürekli her seçtigim markanın model kısmında kendini tekrar edicekti,bunun için seçtikten hemen sonra model ekranını temizlemesi gerekliydi.
            switch (cmbmarka.Text)
            {
                case "VOLKSWAGEN":
                    cmbmodel.Items.Add("JETTA");
                    cmbmodel.Items.Add("PASSAT");
                    cmbmodel.Items.Add("CC");
                    break;
                case "AUDİ":
                    cmbmodel.Items.Add("A7");
                    cmbmodel.Items.Add("Q7");
                    cmbmodel.Items.Add("R8");
                    break;
                case "BMW":
                    cmbmodel.Items.Add("5.20");
                    cmbmodel.Items.Add("X7");
                    cmbmodel.Items.Add("M6");
                    break;
                case "MERCEDES":
                    cmbmodel.Items.Add("200 AMG");
                    cmbmodel.Items.Add("E 250");
                    cmbmodel.Items.Add("CLA 200");
                    break;
                case "VOLVO":
                    cmbmodel.Items.Add("S90");
                    cmbmodel.Items.Add("XC90");
                    cmbmodel.Items.Add("V90");
                    break;
                case "HONDA":
                    cmbmodel.Items.Add("CİVİC");
                    cmbmodel.Items.Add("CR-V");
                    cmbmodel.Items.Add("CR-Z");
                    break;
                default:
                    break;
            }
        }
        private void btnekle_Click(object sender, EventArgs e)
        {



            //referans bir tip oldugu için buradan instance alıyorum
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = cmbmarka.Text;
            lvi.SubItems.Add(cmbmodel.Text);
            lvi.SubItems.Add(cmbyakittipi.Text);
            lvi.SubItems.Add(cmbkasatipi.Text);
            lvi.SubItems.Add(cmbvitestipi.Text);
            lvi.SubItems.Add(cmbmotortipi.Text);
            lvi.SubItems.Add(string.Empty);
            //renk kısmında hangi rengi seçtiyse rengin adını değilde o satırın o renge boyanmasını istiyorum.
            lvi.SubItems[6].BackColor = btnrenk.BackColor;
            lvi.SubItems.Add(dtpyil.Text);
            listView1.Items.Add(lvi);


            //döngüyle niye dönüyorum eklendikten sonra önceki kayıtlar formda seçili kalmasın.sıfırlansın diye böyle bir yol çizdim

            foreach (Control item in this.Controls)
            {
                //gelen tip(item) elemanı combobax mı 
                // == (eşiteşit) değişkenin degerine göre kullanılır,burada ben is komutunu değişkenin tipine göre sorguladım
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if (item is Button)
                {
                    //((Button)item).BackColor=Color.Gray;

                    //formda iki button oldugu için renk butonunu yakalmam için name isminde formda sadece btnrenk adında bir buton ve name isminde kontrol olabiliyor.başka bir eleman daha olamaz aynı isimde.

                    Button btn = (Button)item;
                    if (btn.Name == "btnrenk")
                    {
                        btn.BackColor = Color.Gray;
                    }

                }
                
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }


        }
        ListViewItem secili;
        private void btnduzenle_Click(object sender, EventArgs e)
        {
            //hiç kayıt seçilmemiş
            /*
            if (listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("düzenlemek istediğiniz kaydı seçiniz");
                return;
            }

            secili= listView1.SelectedItems[0];
            cmbmarka.Text = secili.Text;
            cmbmodel.Text = secili.SubItems[1].Text;
            cmbyakittipi.Text = secili.SubItems[2].Text;
            cmbkasatipi.Text = secili.SubItems[3].Text;
            cmbvitestipi.Text = secili.SubItems[4].Text;
            cmbmotortipi.Text = secili.SubItems[5].Text;
            btnrenk.BackColor = secili.SubItems[6].BackColor;
            dtpyil.Value = Convert.ToDateTime(string.Format("01.01.{0}", secili.SubItems[7].Text));
            */
            //burayıda bir metot haline getirdim
            //metot geriye bir deger döndürmüyor
            
            Duzenle();
        }
        
        public void Duzenle()
        {
             if (listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("düzenlemek istediğiniz kaydı seçiniz");
                return;
            }

            secili= listView1.SelectedItems[0];
            cmbmarka.Text = secili.Text;
            cmbmodel.Text = secili.SubItems[1].Text;
            cmbyakittipi.Text = secili.SubItems[2].Text;
            cmbkasatipi.Text = secili.SubItems[3].Text;
            cmbvitestipi.Text = secili.SubItems[4].Text;
            cmbmotortipi.Text = secili.SubItems[5].Text;
            btnrenk.BackColor = secili.SubItems[6].BackColor;
            dtpyil.Value = Convert.ToDateTime(string.Format("01.01.{0}", secili.SubItems[7].Text));




        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //eski değerlerle yeni değerleri değiştirmiş oluyorum
             
             /*
            secili.SubItems[0].Text = cmbmarka.Text;
            secili.SubItems[1].Text = cmbmodel.Text;
            secili.SubItems[2].Text = cmbyakittipi.Text;
            secili.SubItems[3].Text = cmbkasatipi.Text;
            secili.SubItems[4].Text = cmbvitestipi.Text;
            secili.SubItems[5].Text = cmbmotortipi.Text;
            secili.SubItems[6].BackColor = btnrenk.BackColor;
            secili.SubItems[7].Text = dtpyil.Text;

            */
            //burayı metot haline aldım
            //metot geriye bir deger göndermiyor.
            
             Kaydet();

        }

        private void btnsilinsin_KeyDown(object sender, KeyEventArgs e)
        {

            //keycode, basılan tuşun code nu tutar
            //delete tuşuna basıldıgında satır silinecektir

            if (e.KeyCode==Keys.Delete)
            {
                if (listView1.SelectedItems.Count>0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }



        }


        //sag click yapıp kısayoldan seçilen satırı silecektir
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
        
         public void Kaydet()
        {

            secili.SubItems[0].Text = cmbmarka.Text;
            secili.SubItems[1].Text = cmbmodel.Text;
            secili.SubItems[2].Text = cmbyakittipi.Text;
            secili.SubItems[3].Text = cmbkasatipi.Text;
            secili.SubItems[4].Text = cmbvitestipi.Text;
            secili.SubItems[5].Text = cmbmotortipi.Text;
            secili.SubItems[6].BackColor = btnrenk.BackColor;
            secili.SubItems[7].Text = dtpyil.Text;



        }
        
    }
}
