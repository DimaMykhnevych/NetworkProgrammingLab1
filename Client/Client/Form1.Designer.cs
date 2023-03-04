namespace Client
{
    partial class TextConvertion
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
            this.originalText = new System.Windows.Forms.TextBox();
            this.replacedText = new System.Windows.Forms.TextBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originalText
            // 
            this.originalText.Location = new System.Drawing.Point(273, 12);
            this.originalText.Multiline = true;
            this.originalText.Name = "originalText";
            this.originalText.Size = new System.Drawing.Size(724, 222);
            this.originalText.TabIndex = 0;
            // 
            // replacedText
            // 
            this.replacedText.Location = new System.Drawing.Point(273, 344);
            this.replacedText.Multiline = true;
            this.replacedText.Name = "replacedText";
            this.replacedText.Size = new System.Drawing.Size(724, 232);
            this.replacedText.TabIndex = 1;
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(544, 272);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(198, 41);
            this.convertBtn.TabIndex = 2;
            this.convertBtn.Text = "CONVERT";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted text:";
            // 
            // TextConvertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.replacedText);
            this.Controls.Add(this.originalText);
            this.Name = "TextConvertion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Convertion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originalText;
        private System.Windows.Forms.TextBox replacedText;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

