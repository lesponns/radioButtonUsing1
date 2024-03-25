namespace radioButtonUsing1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            black = new RadioButton();
            yellow = new RadioButton();
            red = new RadioButton();
            pink = new RadioButton();
            white = new RadioButton();
            SuspendLayout();
            // 
            // black
            // 
            black.AutoSize = true;
            black.Location = new Point(21, 20);
            black.Margin = new Padding(8);
            black.Name = "black";
            black.Size = new Size(115, 45);
            black.TabIndex = 0;
            black.TabStop = true;
            black.Text = "Siyah";
            black.UseVisualStyleBackColor = true;
            black.CheckedChanged += black_CheckedChanged;
            // 
            // yellow
            // 
            yellow.AutoSize = true;
            yellow.Location = new Point(161, 20);
            yellow.Margin = new Padding(8);
            yellow.Name = "yellow";
            yellow.Size = new Size(93, 45);
            yellow.TabIndex = 1;
            yellow.TabStop = true;
            yellow.Text = "Sarı";
            yellow.UseVisualStyleBackColor = true;
            yellow.CheckedChanged += yellow_CheckedChanged;
            // 
            // red
            // 
            red.AutoSize = true;
            red.Location = new Point(278, 20);
            red.Margin = new Padding(8);
            red.Name = "red";
            red.Size = new Size(138, 45);
            red.TabIndex = 2;
            red.TabStop = true;
            red.Text = "Kırmızı";
            red.UseVisualStyleBackColor = true;
            red.CheckedChanged += red_CheckedChanged;
            // 
            // pink
            // 
            pink.AutoSize = true;
            pink.Location = new Point(55, 81);
            pink.Margin = new Padding(8);
            pink.Name = "pink";
            pink.Size = new Size(134, 45);
            pink.TabIndex = 3;
            pink.TabStop = true;
            pink.Text = "Pembe";
            pink.UseVisualStyleBackColor = true;
            pink.CheckedChanged += pink_CheckedChanged;
            // 
            // white
            // 
            white.AutoSize = true;
            white.Location = new Point(217, 81);
            white.Margin = new Padding(8);
            white.Name = "white";
            white.Size = new Size(120, 45);
            white.TabIndex = 4;
            white.TabStop = true;
            white.Text = "Beyaz";
            white.UseVisualStyleBackColor = true;
            white.CheckedChanged += white_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 158);
            Controls.Add(white);
            Controls.Add(pink);
            Controls.Add(red);
            Controls.Add(yellow);
            Controls.Add(black);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(8);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton black;
        private RadioButton yellow;
        private RadioButton red;
        private RadioButton pink;
        private RadioButton white;
    }
}
