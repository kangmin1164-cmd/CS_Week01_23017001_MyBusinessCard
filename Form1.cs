namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            // 0~255 사이의R, G, B 값을무작위로생성하여배경색에적용
            this.BackColor = Color.FromArgb(rd.Next(250), rd.Next(250), rd.Next(250));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
    {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/kangmin1164-cmd",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
    {
                MessageBox.Show("오류가 발생했습니다: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.images;
        }
    }
}
