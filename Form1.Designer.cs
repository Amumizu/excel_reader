namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pathtxb = new System.Windows.Forms.TextBox();
            this.tbXmlView = new System.Windows.Forms.RichTextBox();
            this.convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathtxb
            // 
            this.pathtxb.Location = new System.Drawing.Point(105, 15);
            this.pathtxb.Name = "pathtxb";
            this.pathtxb.Size = new System.Drawing.Size(277, 20);
            this.pathtxb.TabIndex = 1;
            // 
            // tbXmlView
            // 
            this.tbXmlView.Location = new System.Drawing.Point(13, 51);
            this.tbXmlView.Name = "tbXmlView";
            this.tbXmlView.Size = new System.Drawing.Size(369, 180);
            this.tbXmlView.TabIndex = 3;
            this.tbXmlView.Text = "";
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(412, 15);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 28);
            this.convert.TabIndex = 4;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 261);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.tbXmlView);
            this.Controls.Add(this.pathtxb);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pathtxb;
        private System.Windows.Forms.RichTextBox tbXmlView;
        private System.Windows.Forms.Button convert;
    }
}

