namespace fukuv0531
{
    public partial class Form1 : Form
    {
        int vy = 15;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vy = -15;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vy = 15;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top = label1.Top + vy;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "ファン　クォック　フン";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float fw = 3.14f;
            string str = $"{fw}";
            int a = (int)fw;

            str = "3";
            a = int.Parse(str);
            fw = a;
            fw = float.Parse(str);
        }
    }
}