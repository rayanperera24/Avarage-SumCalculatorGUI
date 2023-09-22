namespace first_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int n01, n02, sum;
            double avg;

            n01 = Convert.ToInt32(this.txt1.Text);
            n02 = Convert.ToInt32(this.txt2.Text);

            sum = n01 + n02;
            avg = sum / 2.00;

            this.txt3.Text = avg.ToString();
            this.txt4.Text = sum.ToString();


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}