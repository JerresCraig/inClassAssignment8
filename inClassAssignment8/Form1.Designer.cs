namespace inClassAssignment8
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
            this.txtCarb = new System.Windows.Forms.TextBox();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblCarb = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCarb
            // 
            this.txtCarb.Location = new System.Drawing.Point(388, 230);
            this.txtCarb.Name = "txtCarb";
            this.txtCarb.Size = new System.Drawing.Size(177, 22);
            this.txtCarb.TabIndex = 1;
            // 
            // txtFat
            // 
            this.txtFat.Location = new System.Drawing.Point(388, 169);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(177, 22);
            this.txtFat.TabIndex = 2;
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(261, 172);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(112, 17);
            this.lblFat.TabIndex = 3;
            this.lblFat.Text = "Enter Fat Grams";
            // 
            // lblCarb
            // 
            this.lblCarb.AutoSize = true;
            this.lblCarb.Location = new System.Drawing.Point(251, 233);
            this.lblCarb.Name = "lblCarb";
            this.lblCarb.Size = new System.Drawing.Size(122, 17);
            this.lblCarb.TabIndex = 4;
            this.lblCarb.Text = "Enter Carb Grams";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(373, 22);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 17);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label1";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(373, 96);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(46, 17);
            this.lblResult2.TabIndex = 6;
            this.lblResult2.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCarb);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.txtFat);
            this.Controls.Add(this.txtCarb);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCarb;
        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblCarb;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResult2;
    }
}

