namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 251, 251, 251);
            diffViewer1.Margin = new Padding(0);
            diffViewer1.ForeColor = Color.FromArgb(255, 32, 32, 32);
            diffViewer1.OldText = "turtle doves eat turtles";
            diffViewer1.NewText = "rhinos throw eat turtles";
        }
    }
}