namespace BookManager
{
    partial class BookRegistForm
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
            this.MainTitleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainTitleText
            // 
            this.MainTitleText.AutoSize = true;
            this.MainTitleText.Font = new System.Drawing.Font("굴림", 52F);
            this.MainTitleText.Location = new System.Drawing.Point(323, 60);
            this.MainTitleText.Name = "MainTitleText";
            this.MainTitleText.Size = new System.Drawing.Size(170, 70);
            this.MainTitleText.TabIndex = 1;
            this.MainTitleText.Text = "등록";
            // 
            // BookRegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTitleText);
            this.Name = "BookRegistForm";
            this.Text = "BookRegistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleText;
    }
}