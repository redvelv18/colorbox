namespace colorbox
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
            redBox = new PictureBox();
            numericRed = new NumericUpDown();
            blueBox = new PictureBox();
            greenBox = new PictureBox();
            numericBlue = new NumericUpDown();
            numericGreen = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)redBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).BeginInit();
            SuspendLayout();
            // 
            // redBox
            // 
            redBox.Location = new Point(62, 53);
            redBox.Name = "redBox";
            redBox.Size = new Size(190, 189);
            redBox.TabIndex = 0;
            redBox.TabStop = false;
            redBox.Click += redBox_Click;
            // 
            // numericRed
            // 
            numericRed.Location = new Point(62, 267);
            numericRed.Name = "numericRed";
            numericRed.Size = new Size(190, 31);
            numericRed.TabIndex = 1;
            numericRed.ValueChanged += numericRed_ValueChanged;
            // 
            // blueBox
            // 
            blueBox.Location = new Point(292, 53);
            blueBox.Name = "blueBox";
            blueBox.Size = new Size(190, 189);
            blueBox.TabIndex = 2;
            blueBox.TabStop = false;
            // 
            // greenBox
            // 
            greenBox.Location = new Point(529, 53);
            greenBox.Name = "greenBox";
            greenBox.Size = new Size(190, 189);
            greenBox.TabIndex = 3;
            greenBox.TabStop = false;
            // 
            // numericBlue
            // 
            numericBlue.Location = new Point(292, 267);
            numericBlue.Name = "numericBlue";
            numericBlue.Size = new Size(190, 31);
            numericBlue.TabIndex = 4;
            // 
            // numericGreen
            // 
            numericGreen.Location = new Point(529, 267);
            numericGreen.Name = "numericGreen";
            numericGreen.Size = new Size(190, 31);
            numericGreen.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericGreen);
            Controls.Add(numericBlue);
            Controls.Add(greenBox);
            Controls.Add(blueBox);
            Controls.Add(numericRed);
            Controls.Add(redBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)redBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox redBox;
        private NumericUpDown numericRed;
        private PictureBox blueBox;
        private PictureBox greenBox;
        private NumericUpDown numericBlue;
        private NumericUpDown numericGreen;
    }
}