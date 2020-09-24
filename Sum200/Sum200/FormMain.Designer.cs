namespace Sum200
{
    partial class FormMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTopValue = new System.Windows.Forms.TextBox();
            this.txtHalfway = new System.Windows.Forms.TextBox();
            this.txtTotalSum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 161);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Halfway Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Sum";
            // 
            // txtTopValue
            // 
            this.txtTopValue.Location = new System.Drawing.Point(196, 40);
            this.txtTopValue.Name = "txtTopValue";
            this.txtTopValue.Size = new System.Drawing.Size(50, 22);
            this.txtTopValue.TabIndex = 4;
            this.txtTopValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHalfway
            // 
            this.txtHalfway.Location = new System.Drawing.Point(196, 79);
            this.txtHalfway.Name = "txtHalfway";
            this.txtHalfway.ReadOnly = true;
            this.txtHalfway.Size = new System.Drawing.Size(50, 22);
            this.txtHalfway.TabIndex = 5;
            this.txtHalfway.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalSum
            // 
            this.txtTotalSum.Location = new System.Drawing.Point(196, 118);
            this.txtTotalSum.Name = "txtTotalSum";
            this.txtTotalSum.ReadOnly = true;
            this.txtTotalSum.Size = new System.Drawing.Size(50, 22);
            this.txtTotalSum.TabIndex = 6;
            this.txtTotalSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 185);
            this.Controls.Add(this.txtTotalSum);
            this.Controls.Add(this.txtHalfway);
            this.Controls.Add(this.txtTopValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTopValue;
        private System.Windows.Forms.TextBox txtHalfway;
        private System.Windows.Forms.TextBox txtTotalSum;
    }
}

