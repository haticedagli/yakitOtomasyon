using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yakitOtotmasyon
{

    public partial class Form1 : Form
    {
        // string[] yakitFiyat = new string[] { "4.75", "5.75", "2.33" };  //fiyatlar

        double benzinFiyati = 4.75;
        double dizelFİyati = 5.75;  //yakıt fiyatları  
        double lpgFiyati = 2.33;

        ArrayList aliKazanc = new ArrayList();
        ArrayList mehmetKazanc = new ArrayList();   //kazancların kaydedilmesi için Arraylist olusturduk 
        ArrayList ahmetKazanc = new ArrayList();


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personel.Items.Add("ali");    // uygulama acıldıgında yapılcaklar 
            personel.Items.Add("mehmet");
            personel.Items.Add("ahmet");

            personelKazanc.Items.Add("ali");
            personelKazanc.Items.Add("mehmet");
            personelKazanc.Items.Add("ahmet");

            yakit.Items.Add("Benzin");
            yakit.Items.Add("Dizel");
            yakit.Items.Add("LPG");

            benzin.Enabled = false;   //kutuyu kitleme 
            dizel.Enabled = false;
            lpg.Enabled = false;

            benzin.Text = benzinFiyati.ToString();
            dizel.Text = dizelFİyati.ToString();   //kutudan  veri alma  
            lpg.Text = lpgFiyati.ToString();

            //progresbar

            benzinbar.Minimum = 5;
            benzinbar.Maximum = 1500;  //barların en fazla ve en az alacağı yakıt miktarı 

            dizelBar.Minimum = 5;
            dizelBar.Maximum = 1500;





            lpgBar.Minimum = 5;
            lpgBar.Maximum = 1500;

            benzinbar.Value = 450;   //value varsayılan degeri 
            dizelBar.Value = 650;
            lpgBar.Value = 364;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                benzin.Enabled = true;
            }
            else if (checkBox3.Checked == false)
            {
                benzin.Enabled = false;
            }


        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                dizel.Enabled = true;   // checkbox tıklanmasını kontrol edip kutu kilidini kaldırıyor 
            }
            else if (checkBox4.Checked == false)
            {
                dizel.Enabled = false;
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox5.Checked == true)
            {
                lpg.Enabled = true;
            }
            else if (checkBox5.Checked == false)
            {
                lpg.Enabled = false;
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {

            benzinFiyati = Convert.ToDouble(benzin.Text);
            dizelFİyati = Convert.ToDouble(dizel.Text);
            lpgFiyati = Convert.ToDouble(lpg.Text);


            benzin.Text = benzinFiyati.ToString();  //int türünü string olarak değiştirme işlemi  
            dizel.Text = dizelFİyati.ToString();
            lpg.Text = lpgFiyati.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yakitMiktari = int.Parse(yakitMiktar.Text);  //int degeri string degere dönüştürme 

            if (alis.Checked == true)
            {
                if (yakit.SelectedItem.ToString() == "Benzin")
                {
                    if (tutaragore.Checked == true)
                    {

                        double litreHesap = yakitMiktari / benzinFiyati;  //tutara gore litre hesabı  

                        if (litreHesap > benzinbar.Value)
                        {  // uyarı mesajı  
                            MessageBox.Show("Benzin deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + benzinbar.Value + " en fazla " + (benzinbar.Maximum - benzinbar.Value) * benzinFiyati + " tutarında benzin alabilirsiniz.");
                        }
                        else
                        {
                            benzinbar.Value += Convert.ToInt32(litreHesap);
                            // bara alınacak degerin eklenmesi 
                        }

                    }
                    else if (litreyegore.Checked == true)
                    {

                        if (yakitMiktari > benzinbar.Value)
                        {
                            MessageBox.Show("Benzin deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + benzinbar.Value + " en fazla " + (benzinbar.Maximum - benzinbar.Value) + " litre alabilirsiniz.");
                        }
                        else
                        {
                            benzinbar.Value += yakitMiktari;

                        }

                    }
                }
                else if (yakit.SelectedItem.ToString() == "Dizel")
                {
                    if (tutaragore.Checked == true)
                    {

                        double litreHesap = yakitMiktari / dizelFİyati;

                        if (litreHesap > dizelBar.Value)
                        {
                            MessageBox.Show("Dizel deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + dizelBar.Value + " en fazla " + (dizelBar.Maximum - dizelBar.Value) * dizelFİyati + " tutarında Dizel alabilirsiniz.");
                        }
                        else
                        {
                            dizelBar.Value += Convert.ToInt32(litreHesap);
                        }

                    }
                    else if (litreyegore.Checked == true)
                    {

                        if (yakitMiktari > dizelBar.Value)
                        {
                            MessageBox.Show("dizel deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + dizelBar.Value + " en fazla " + (dizelBar.Maximum - dizelBar.Value) + " litre alabilirsiniz.");
                        }
                        else
                        {
                            dizelBar.Value += yakitMiktari;
                        }

                    }
                }
                else if (yakit.SelectedItem.ToString() == "LPG")
                {
                    if (tutaragore.Checked == true)
                    {

                        double litreHesap = yakitMiktari / lpgFiyati;

                        if (litreHesap > lpgBar.Value)
                        {
                            MessageBox.Show("LPG deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + lpgBar.Value + " en fazla " + (lpgBar.Maximum - lpgBar.Value) * lpgFiyati + " tutarında LPG alabilirsiniz.");
                        }
                        else
                        {
                            lpgBar.Value += Convert.ToInt32(litreHesap);
                        }

                    }
                    else if (litreyegore.Checked == true)
                    {

                        if (yakitMiktari > lpgBar.Value)
                        {
                            MessageBox.Show("LPG deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + lpgBar.Value + " en fazla " + (lpgBar.Maximum - lpgBar.Value) + " litre alabilirsiniz.");
                        }
                        else
                        {
                            lpgBar.Value += yakitMiktari;
                        }

                    }
                }



            }
            else if (satis.Checked == true)   /// satis //
            {
                if (yakit.SelectedItem.ToString() == "Benzin")  //acılır menudeki yazıyı  okuyup karşılaştırma 
                {
                    if (tutaragore.Checked == true)
                    {
                        double fiyat = Convert.ToDouble(benzin.Text);
                        double litreHesap = yakitMiktari / fiyat;
                        int yakitTutari = int.Parse(yakitMiktar.Text);

                        if (litreHesap > benzinbar.Value)
                        {
                            MessageBox.Show("Benzin deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + benzinbar.Value + " en fazla " + (benzinbar.Maximum - benzinbar.Value) * fiyat + " tutarında benzin alabilirsiniz.");
                        }
                        else
                        {
                            benzinbar.Value -= Convert.ToInt32(litreHesap);


                            if (personel.SelectedItem.ToString() == "ali")
                            {
                                aliKazanc.Add(yakitTutari);    //kazançların hesaplanması 
                            }
                            else if (personel.SelectedItem.ToString() == "ahmet")
                            {
                                ahmetKazanc.Add(yakitTutari);
                            }
                            else if (personel.SelectedItem.ToString() == "mehmet")
                            {
                                mehmetKazanc.Add(yakitTutari);
                            }
                        }

                    }
                    else if (litreyegore.Checked == true)
                    {

                        if (yakitMiktari > benzinbar.Value)
                        {
                            MessageBox.Show("Benzin deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + benzinbar.Value + " en fazla " + (benzinbar.Maximum - benzinbar.Value) + " litre alabilirsiniz.");
                        }
                        else
                        {
                            benzinbar.Value -= yakitMiktari;

                            // hesap  // 

                            int kazancmiktari = yakitMiktari * Convert.ToInt32(benzinFiyati);

                            if (personel.SelectedItem.ToString() == "ali")
                            {
                                aliKazanc.Add(kazancmiktari);  //kazancı hesaplayıp ArrayListe ekleme işlemi yapıyor 

                            }
                            else if (personel.SelectedItem.ToString() == "ahmet")
                            {
                                ahmetKazanc.Add(kazancmiktari);
                            }
                            else if (personel.SelectedItem.ToString() == "mehmet")
                            {
                                mehmetKazanc.Add(kazancmiktari);
                            }

                        }

                    }
                }
                else if (yakit.SelectedItem.ToString() == "Dizel")
                {
                    if (tutaragore.Checked == true)
                    {
                        double fiyat = Convert.ToDouble(dizel.Text);
                        double litreHesap = yakitMiktari / fiyat;
                        int yakitTutari = int.Parse(yakitMiktar.Text);

                        if (litreHesap > dizelBar.Value)
                        {
                            MessageBox.Show("Dizel deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + dizelBar.Value + " en fazla " + (dizelBar.Maximum - dizelBar.Value) * fiyat + " tutarında Dizel alabilirsiniz.");
                        }
                        else
                        {
                            dizelBar.Value -= Convert.ToInt32(litreHesap);

                            if (personel.SelectedItem.ToString() == "ali")
                            {
                                aliKazanc.Add(yakitTutari);
                            }
                            else if (personel.SelectedItem.ToString() == "ahmet")
                            {
                                ahmetKazanc.Add(yakitTutari);
                            }
                            else if (personel.SelectedItem.ToString() == "mehmet")
                            {
                                mehmetKazanc.Add(yakitTutari);
                            }
                        }

                    }
                    else if (litreyegore.Checked == true)
                    {

                        if (yakitMiktari > dizelBar.Value)
                        {
                            MessageBox.Show("dizel deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + dizelBar.Value + " en fazla " + (dizelBar.Maximum - dizelBar.Value) + " litre alabilirsiniz.");
                        }
                        else
                        {
                            dizelBar.Value -= yakitMiktari;

                            // hesap  // 

                            int kazancmiktari = yakitMiktari * Convert.ToInt32(dizelFİyati);

                            if (personel.SelectedItem.ToString() == "ali")
                            {
                                aliKazanc.Add(kazancmiktari);
                            }
                            else if (personel.SelectedItem.ToString() == "ahmet")
                            {
                                ahmetKazanc.Add(kazancmiktari);
                            }
                            else if (personel.SelectedItem.ToString() == "mehmet")
                            {
                                mehmetKazanc.Add(kazancmiktari);
                            }
                        }

                    }
                }
                else if (yakit.SelectedItem.ToString() == "LPG")
                {
                    if (tutaragore.Checked == true)
                    {
                        double fiyat = Convert.ToDouble(lpg.Text);
                        double litreHesap = yakitMiktari / fiyat;
                        int yakitTutari = int.Parse(yakitMiktar.Text);

                        if (litreHesap > lpgBar.Value)
                        {
                            MessageBox.Show("LPG deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + lpgBar.Value + " en fazla " + (lpgBar.Maximum - lpgBar.Value) * fiyat + " tutarında LPG alabilirsiniz.");
                        }

                        else
                        {
                            lpgBar.Value -= Convert.ToInt32(litreHesap);

                            if (personel.SelectedItem.ToString() == "ali")
                            {
                                aliKazanc.Add(yakitTutari);
                            }
                            else if (personel.SelectedItem.ToString() == "ahmet")
                            {
                                ahmetKazanc.Add(yakitTutari);
                            }
                            else if (personel.SelectedItem.ToString() == "mehmet")
                            {
                                mehmetKazanc.Add(yakitTutari);
                            }
                        }

                    }
                    else if (litreyegore.Checked == true)
                    {

                        if (yakitMiktari > lpgBar.Value)
                        {
                            MessageBox.Show("LPG deposu maksimum 1500 litre alır. Şuan ki doluluk oranı : " + lpgBar.Value + " en fazla " + (lpgBar.Maximum - lpgBar.Value) + " litre alabilirsiniz.");
                        }

                        else
                        {
                            lpgBar.Value -= yakitMiktari;

                            // hesap  // 

                            int kazancmiktari = yakitMiktari * Convert.ToInt32(lpgFiyati);

                            if (personel.SelectedItem.ToString() == "ali")
                            {
                                aliKazanc.Add(kazancmiktari);
                            }
                            else if (personel.SelectedItem.ToString() == "ahmet")
                            {
                                ahmetKazanc.Add(kazancmiktari);
                            }
                            else if (personel.SelectedItem.ToString() == "mehmet")
                            {
                                mehmetKazanc.Add(kazancmiktari);
                            }
                        }

                    }
                }

            }




        }




        private void kazancgetir_Click(object sender, EventArgs e)
        {
            kazancKutu.Items.Clear();

            //////// KAZANCLAR //////////
            ///

            if (personelKazanc.SelectedItem.ToString() == "ali")
            {

                foreach (object eleman in aliKazanc)
                {
                    kazancKutu.Items.Add(eleman);     // listeyi elemana yazdırıyoruz 
                }


                int alitoplam = 0;
                foreach (int sayi in aliKazanc)
                {

                    alitoplam = alitoplam + sayi;
                }

                toplamkazanc.Text = alitoplam.ToString();
            }
            //
            if (personelKazanc.SelectedItem.ToString() == "mehmet")
            {

                foreach (object eleman in mehmetKazanc)
                {
                    kazancKutu.Items.Add(eleman);
                }


                int mehmettoplam = 0;
                foreach (int sayi in mehmetKazanc)
                {

                    mehmettoplam = mehmettoplam + sayi;
                }

                toplamkazanc.Text = mehmettoplam.ToString();
            }
            //
            if (personelKazanc.SelectedItem.ToString() == "ahmet")
            {

                foreach (object eleman in ahmetKazanc)
                {
                    kazancKutu.Items.Add(eleman);   // liste içindeki elemanları kazanc kutusuna yazıyoruz
                }


                int ahmettoplam = 0;
                foreach (int sayi in ahmetKazanc)
                {

                    ahmettoplam = ahmettoplam + sayi;
                }

                toplamkazanc.Text = ahmettoplam.ToString();   //liste elemanlarını toplayıp toplam degere yazdık 
            }
        }
    }
}
