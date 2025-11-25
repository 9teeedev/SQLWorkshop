namespace WinFormsApp104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello : " + txtName.Text);
        }

        private void bntOK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
