
namespace Show19
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
            this.a1Control1 = new Show19.A1Control();
            this.SuspendLayout();
            // 
            // a1Control1
            // 
            this.a1Control1.BackColor = System.Drawing.Color.Blue;
            this.a1Control1.Location = new System.Drawing.Point(177, 125);
            this.a1Control1.Name = "a1Control1";
            this.a1Control1.Size = new System.Drawing.Size(458, 130);
            this.a1Control1.TabIndex = 0;
            this.a1Control1.afterGetText += new System.EventHandler(this.a1Control1_afterGetText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.a1Control1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private A1Control a1Control1;
    }
}

