using System;
using System.Windows.Forms;
using System.Linq;

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
            try
            {
                richTextBox_output.Text = EncoderDecoder.Code(richTextBox_input.Text, int.Parse(textBox_shift.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Decode_btn_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox_output.Text = EncoderDecoder.Decode(richTextBox_input.Text, int.Parse(textBox_shift.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CodeFile_btn_Click(object sender, EventArgs e)
        {
            try
            {
                FileWorker.CodeFileVigenere();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DecodeFile_btn_Click(object sender, EventArgs e)
        {
            try
            {
                FileWorker.DecodeFileVigenere();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
