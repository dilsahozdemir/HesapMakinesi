namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double ilkSayi = 0; 
        private string islem = ""; 

        private void Sayilar_Click(object sender, EventArgs e)
        {

            Button buton = sender as Button; 
            if (buton != null)
            {
                displayRichTextBox.Text += buton.Text; 
            }
        }

        private void Ýslemler_Click(object sender, EventArgs e)
        {
            Button buton = sender as Button;
            if (buton != null)
            {
                ilkSayi = Convert.ToDouble(displayRichTextBox.Text); 
                islem = buton.Text; 
                displayRichTextBox.Clear(); 
            }
        }

        private void buttonEsittir_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(displayRichTextBox.Text); 
            double sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = ilkSayi + ikinciSayi;
                    break;
                case "-":
                    sonuc = ilkSayi - ikinciSayi;
                    break;
                case "*":
                    sonuc = ilkSayi * ikinciSayi;
                    break;
                case "/":
                    if (ikinciSayi != 0)
                        sonuc = ilkSayi / ikinciSayi;
                    else
                        MessageBox.Show("Bir sayýyý 0'a bölemezsiniz!");
                    break;
            }

            displayRichTextBox.Text = sonuc.ToString(); 



        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            displayRichTextBox.Clear();
            ilkSayi = 0;
            islem = "";
            
        }
    }
}
