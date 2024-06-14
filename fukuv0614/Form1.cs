namespace fukuv0614
{

    public partial class Form1 : Form
    {
        static Random random = new Random();
        int count = 0;
        int ans = 0;

        public Form1()
        {
            InitializeComponent();

            ans = random.Next(51);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            count++;
            MessageBox.Show($"{count}‰ñ–Ú‚Ì’§í");

            int yosou;
            yosou = int.Parse(textBox1.Text);

            if (ans == yosou)
            {
                MessageBox.Show("Bingo!!");
                count = 0;
                ans = random.Next(51);
            }
            else if (yosou > ans)
            {
                MessageBox.Show("Greater");
            }
            else
            {
                MessageBox.Show("Less");
            }
        }
    }
}