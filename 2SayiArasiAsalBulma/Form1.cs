namespace _2SayiArasiAsalBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            Console.WriteLine();
            for (int sayi = s1; sayi <= s2; sayi++)
            {
                int kontrol = 0;

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol == 1)
                {
                    listBox1.Items.Add(sayi + " Asal değidir");
                }
                else
                {
                    listBox1.Items.Add(sayi + " Asaldır");
                    sayac++;
                }
            }
        }
    }
}

