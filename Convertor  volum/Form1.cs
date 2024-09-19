namespace Convertor__volum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxcub.Enabled = false;
        }

        private void buttonConvers_Click(object sender, EventArgs e)
        {
            double mc;
            double litri;
            if (textBoxLit.Text =="")
            {
                MessageBox.Show("Completati campul !");
            }
            else
            {
                litri = Convert.ToInt32(textBoxLit.Text);
                mc = litri / 1000;
                textBoxcub.Text = mc.ToString();
            }
        }

        private void buttonsterge_Click(object sender, EventArgs e)
        {
            textBoxLit.Text = "";
            textBoxcub.Text = "";
        }
    }
}