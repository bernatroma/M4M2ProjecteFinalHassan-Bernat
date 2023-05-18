namespace M2M4
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
            label1 = new Label();
            btnLoadXML = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Bulk XML File";
            label1.Click += label1_Click;
            // 
            // btnLoadXML
            // 
            btnLoadXML.Location = new Point(46, 105);
            btnLoadXML.Name = "btnLoadXML";
            btnLoadXML.Size = new Size(75, 23);
            btnLoadXML.TabIndex = 1;
            btnLoadXML.Text = "Load";
            btnLoadXML.UseVisualStyleBackColor = true;
            btnLoadXML.Click += btnLoadXML_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 23);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnLoadXML);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLoadXML;
        private TextBox textBox1;
    }
}