namespace Bədən_Kütlə_indeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_height.Text = String.Empty;
            txt_index.Text = String.Empty;
            txt_mass.Text = String.Empty;
            txt_status.Text = String.Empty;
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

            if (txt_height.Text == String.Empty || txt_mass.Text == String.Empty)
            {
                MessageBox.Show("Please, Enter the values", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {

                double h = Double.Parse(txt_height.Text);
                double m = Double.Parse(txt_mass.Text);

                double index = (double)(int)((m/Math.Pow(h ,2)*100))/100;

                txt_index.Text = index.ToString();
                }
                catch
                {
                    MessageBox.Show("Please enter a proper number first!", "Parsing error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            double status = Convert.ToDouble(txt_index.Text);

            if (status < 18.5)
            {
                txt_status.Text = "Underweight";
            }

            else if (status >= 18.5 && status < 25)
            {
                txt_status.Text = "Normal weight";
            }

            else if (status >= 25 && status < 30)
            {
                txt_status.Text = "Overweight";
            }

            else if(status >= 30 && status < 35)
            {
                txt_status.Text = "Obesity I";
            }

            else if (status >= 35 && status < 40)
            {
                txt_status.Text = "Obesity II";
            }

            else if (status >= 40)
            {
                txt_status.Text = "Obesity III";
            }
        }
    }
}