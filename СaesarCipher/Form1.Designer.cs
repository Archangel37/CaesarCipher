namespace СaesarCipher
{
    partial class CaesarMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Code_btn = new System.Windows.Forms.Button();
            this.Decode_btn = new System.Windows.Forms.Button();
            this.richTextBox_input = new System.Windows.Forms.RichTextBox();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.textBox_shift = new System.Windows.Forms.TextBox();
            this.label_shift = new System.Windows.Forms.Label();
            this.label_input = new System.Windows.Forms.Label();
            this.label_outout = new System.Windows.Forms.Label();
            this.CodeFile_btn = new System.Windows.Forms.Button();
            this.DecodeFile_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Code_btn
            // 
            this.Code_btn.Location = new System.Drawing.Point(429, 28);
            this.Code_btn.Name = "Code_btn";
            this.Code_btn.Size = new System.Drawing.Size(75, 23);
            this.Code_btn.TabIndex = 0;
            this.Code_btn.Text = "Code";
            this.Code_btn.UseVisualStyleBackColor = true;
            this.Code_btn.Click += new System.EventHandler(this.Code_btn_Click);
            // 
            // Decode_btn
            // 
            this.Decode_btn.Location = new System.Drawing.Point(429, 57);
            this.Decode_btn.Name = "Decode_btn";
            this.Decode_btn.Size = new System.Drawing.Size(75, 23);
            this.Decode_btn.TabIndex = 1;
            this.Decode_btn.Text = "Decode";
            this.Decode_btn.UseVisualStyleBackColor = true;
            this.Decode_btn.Click += new System.EventHandler(this.Decode_btn_Click);
            // 
            // richTextBox_input
            // 
            this.richTextBox_input.Location = new System.Drawing.Point(43, 28);
            this.richTextBox_input.Name = "richTextBox_input";
            this.richTextBox_input.Size = new System.Drawing.Size(380, 138);
            this.richTextBox_input.TabIndex = 2;
            this.richTextBox_input.Text = "";
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Location = new System.Drawing.Point(46, 246);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.Size = new System.Drawing.Size(380, 144);
            this.richTextBox_output.TabIndex = 3;
            this.richTextBox_output.Text = "";
            // 
            // textBox_shift
            // 
            this.textBox_shift.Location = new System.Drawing.Point(80, 188);
            this.textBox_shift.Name = "textBox_shift";
            this.textBox_shift.Size = new System.Drawing.Size(143, 20);
            this.textBox_shift.TabIndex = 4;
            // 
            // label_shift
            // 
            this.label_shift.AutoSize = true;
            this.label_shift.Location = new System.Drawing.Point(43, 191);
            this.label_shift.Name = "label_shift";
            this.label_shift.Size = new System.Drawing.Size(31, 13);
            this.label_shift.TabIndex = 5;
            this.label_shift.Text = "Shift:";
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(46, 9);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(54, 13);
            this.label_input.TabIndex = 6;
            this.label_input.Text = "Input text:";
            // 
            // label_outout
            // 
            this.label_outout.AutoSize = true;
            this.label_outout.Location = new System.Drawing.Point(46, 230);
            this.label_outout.Name = "label_outout";
            this.label_outout.Size = new System.Drawing.Size(62, 13);
            this.label_outout.TabIndex = 7;
            this.label_outout.Text = "Output text:";
            // 
            // CodeFile_btn
            // 
            this.CodeFile_btn.Location = new System.Drawing.Point(254, 188);
            this.CodeFile_btn.Name = "CodeFile_btn";
            this.CodeFile_btn.Size = new System.Drawing.Size(75, 23);
            this.CodeFile_btn.TabIndex = 8;
            this.CodeFile_btn.Text = "Code File";
            this.CodeFile_btn.UseVisualStyleBackColor = true;
            this.CodeFile_btn.Click += new System.EventHandler(this.CodeFile_btn_Click);
            // 
            // DecodeFile_btn
            // 
            this.DecodeFile_btn.Location = new System.Drawing.Point(335, 188);
            this.DecodeFile_btn.Name = "DecodeFile_btn";
            this.DecodeFile_btn.Size = new System.Drawing.Size(75, 23);
            this.DecodeFile_btn.TabIndex = 9;
            this.DecodeFile_btn.Text = "Decode File";
            this.DecodeFile_btn.UseVisualStyleBackColor = true;
            this.DecodeFile_btn.Click += new System.EventHandler(this.DecodeFile_btn_Click);
            // 
            // CaesarMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 425);
            this.Controls.Add(this.DecodeFile_btn);
            this.Controls.Add(this.CodeFile_btn);
            this.Controls.Add(this.label_outout);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.label_shift);
            this.Controls.Add(this.textBox_shift);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.richTextBox_input);
            this.Controls.Add(this.Decode_btn);
            this.Controls.Add(this.Code_btn);
            this.Name = "CaesarMainForm";
            this.Text = "Caesar cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Code_btn;
        private System.Windows.Forms.Button Decode_btn;
        private System.Windows.Forms.RichTextBox richTextBox_input;
        private System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.TextBox textBox_shift;
        private System.Windows.Forms.Label label_shift;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label_outout;
        private System.Windows.Forms.Button CodeFile_btn;
        private System.Windows.Forms.Button DecodeFile_btn;
    }
}

