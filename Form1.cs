namespace AsalSayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            long sayac = 0;

            long TCkimlik = 100000;

            for (long sayi = 2; sayi <= TCkimlik; sayi++)
            {
                long kontrol = 0;

                for (long i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol == 1)
                {

                }
                else
                {
                    listBox1.Items.Add(sayi);
                    sayac++;
                }

            }




        }
    }

    
}