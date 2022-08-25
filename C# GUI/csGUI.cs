namespace GUI_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);

                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }

                float result = num1 / num2;

                label3.Text = result.ToString();
            } 
            catch(DivideByZeroException) {
                label3.Text = "Cannot divide by Zero";
            } 
            catch (FormatException) {
                label3.Text = "Please enter only numbers";
            }  
            catch (Exception ex) {
                label3.Text = ex.GetType() + ex.Message;
            }
            finally
            {

            }

        }
    }
}
