namespace Bignum
{
    partial class frmMain
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
            this.txtNumberA = new System.Windows.Forms.TextBox();
            this.txtNumberB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtNumberA
            // 
            this.txtNumberA.Location = new System.Drawing.Point(12, 23);
            this.txtNumberA.Name = "txtNumberA";
            this.txtNumberA.Size = new System.Drawing.Size(353, 20);
            this.txtNumberA.TabIndex = 0;
            // 
            // txtNumberB
            // 
            this.txtNumberB.Location = new System.Drawing.Point(12, 49);
            this.txtNumberB.Name = "txtNumberB";
            this.txtNumberB.Size = new System.Drawing.Size(353, 20);
            this.txtNumberB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result:";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(265, 88);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(100, 23);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(354, 296);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberB);
            this.Controls.Add(this.txtNumberA);
            this.Name = "frmMain";
            this.Text = "MyBigNum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberA;
        private System.Windows.Forms.TextBox txtNumberB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

