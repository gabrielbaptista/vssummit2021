
namespace WinFormsAppNet60
{
    partial class FrSayHelloNet60
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
            this.btnSayHelloN6 = new System.Windows.Forms.Button();
            this.btnSayHelloStd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSayHelloN6
            // 
            this.btnSayHelloN6.Location = new System.Drawing.Point(118, 38);
            this.btnSayHelloN6.Name = "btnSayHelloN6";
            this.btnSayHelloN6.Size = new System.Drawing.Size(140, 23);
            this.btnSayHelloN6.TabIndex = 0;
            this.btnSayHelloN6.Text = "Say Hello - Net 6.0";
            this.btnSayHelloN6.UseVisualStyleBackColor = true;
            this.btnSayHelloN6.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHelloStd
            // 
            this.btnSayHelloStd.Location = new System.Drawing.Point(118, 84);
            this.btnSayHelloStd.Name = "btnSayHelloStd";
            this.btnSayHelloStd.Size = new System.Drawing.Size(140, 23);
            this.btnSayHelloStd.TabIndex = 1;
            this.btnSayHelloStd.Text = "Say Hello - .Net Std.";
            this.btnSayHelloStd.UseVisualStyleBackColor = true;
            this.btnSayHelloStd.Click += new System.EventHandler(this.btnSayHelloStd_Click);
            // 
            // FrSayHelloNet60
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 147);
            this.Controls.Add(this.btnSayHelloStd);
            this.Controls.Add(this.btnSayHelloN6);
            this.Name = "FrSayHelloNet60";
            this.Text = "Say Hello Net 60";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSayHelloN6;
        private System.Windows.Forms.Button btnSayHelloStd;
    }
}

