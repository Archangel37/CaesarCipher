using System;
using System.Windows.Forms;

namespace СaesarCipher
{
    public partial class CaesarMainForm : Form
    {
        public CaesarMainForm()
        {
            InitializeComponent();
        }

        private void Code_btn_Click(object sender, EventArgs e)
        {
            EncoderDecoder encoder = new EncoderDecoder();
            try
            {
                richTextBox_output.Text = encoder.Code(richTextBox_input.Text, int.Parse(textBox_shift.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Decode_btn_Click(object sender, EventArgs e)
        {
            EncoderDecoder decoder = new EncoderDecoder();
            try
            {
                richTextBox_output.Text = decoder.Decode(richTextBox_input.Text, int.Parse(textBox_shift.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
