namespace Labirintus
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Válasszon pályát nehézségi szint szerint!";
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            FormEasy easy = new FormEasy();
            easy.ShowDialog();
        }

        private void buttonMedium_Click(object sender, EventArgs e)
        {
            FormMedium medium = new FormMedium();
            medium.ShowDialog();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            FormHard hard = new FormHard();
            hard.ShowDialog();
        }
    }
}
