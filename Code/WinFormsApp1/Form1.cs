namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            var count = await CountAnimals(); // Good
            button1.Text = count.ToString();
            await Task.Delay(1);
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            var count = CountAnimals().Result; // Result without await?  Deadlock.
            button2.Text = count.ToString();
            await Task.Delay(1);
        }

        private async void Button3_Click(object sender, EventArgs e)
        {
            // Continuation won't be on UI thread...
            var count = await CountAnimals().ConfigureAwait(false);
            // ... so this won't work.
            button3.Text = count.ToString();
            await Task.Delay(1);
        }

        private static async Task<int> CountAnimals()
        {
            await Task.Delay(200);
            return 50;
        }
    }
}
