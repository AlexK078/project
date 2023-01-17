using System.Web;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
       {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = fullname();



            listBox1.Items.Clear();
            listBox1.Items.Add(" ");
            listBox1.Items.Add(fullname());
            listBox1.Items.Add(" ");
            listBox1.Items.Add(textBox3.Text);
            listBox1.Items.Add(textBox4.Text + " " + textBox5.Text);

            
        }
        private string fullname()
        {       
            return textBox1.Text + " " + textBox2.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}