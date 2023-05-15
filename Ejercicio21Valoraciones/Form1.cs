using System.Text.RegularExpressions;

namespace Ejercicio21Valoraciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
            string input = maskedTextBox.Text;

            if (!Regex.IsMatch(input, @"^\d{3}[A-Z]{3}$"))
            {

                maskedTextBox.Select(0, maskedTextBox.Text.Length); 

                MessageBox.Show("El valor ingresado no es válido. Debe tener tres números seguidos de tres letras mayúsculas.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = maskedDate.Text;
            string text2 = maskedHour.Text;
            string text3 = maskedId.Text;
            string text4 = maskedPhone.Text;
            string text5 = maskedCar.Text;
            string text6 = maskedValue.Text;

            string itemText = $"{text1} - {text2} - {text3}-{text4} - {text5} - {text6}";

            listBoxInf.Items.Add(itemText);
        }
    }
}