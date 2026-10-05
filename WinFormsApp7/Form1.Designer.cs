namespace WinFormsApp7
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
            buttonStart = new Button();
            labelTimeLeft = new Label();
            buttonGuess = new Button();
            textBoxNumber = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(180, 173);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelTimeLeft
            // 
            labelTimeLeft.AutoSize = true;
            labelTimeLeft.Location = new Point(354, 254);
            labelTimeLeft.Name = "labelTimeLeft";
            labelTimeLeft.Size = new Size(0, 20);
            labelTimeLeft.TabIndex = 1;
            // 
            // buttonGuess
            // 
            buttonGuess.Location = new Point(478, 174);
            buttonGuess.Name = "buttonGuess";
            buttonGuess.Size = new Size(94, 29);
            buttonGuess.TabIndex = 2;
            buttonGuess.Text = "Guess";
            buttonGuess.UseVisualStyleBackColor = true;
            buttonGuess.Click += buttonGuess_Click;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(312, 176);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(125, 27);
            textBoxNumber.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 38);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 4;
            label1.Text = "Guess The Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBoxNumber);
            Controls.Add(buttonGuess);
            Controls.Add(labelTimeLeft);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Label labelTimeLeft;
        private Button buttonGuess;
        private TextBox textBoxNumber;
        private Label label1;
    }
}
