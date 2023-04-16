namespace Anketa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            result.textBox1.Text = this.textBox1.Text + " " + this.textBox2.Text+" "+ this.textBox3.Text + " " + this.textBox4.Text+" "+ this.textBox5.Text + " " + this.textBox6.Text;
            result.ShowDialog();
        }
    }
}