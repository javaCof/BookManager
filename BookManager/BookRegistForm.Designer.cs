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
            this.IsbnText = new System.Windows.Forms.Label();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.BookNameText = new System.Windows.Forms.Label();
            this.BookTypeTextBox = new System.Windows.Forms.TextBox();
            this.BookTypeText = new System.Windows.Forms.Label();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.PublisherText = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.Label();
            this.CommitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTitleText
            // 
            this.MainTitleText.AutoSize = true;
            this.MainTitleText.Font = new System.Drawing.Font("굴림", 52F);
            this.MainTitleText.Location = new System.Drawing.Point(323, 17);
            this.MainTitleText.Name = "MainTitleText";
            this.MainTitleText.Size = new System.Drawing.Size(170, 70);
            this.MainTitleText.TabIndex = 1;
            this.MainTitleText.Text = "등록";
            // 
            // IsbnText
            // 
            this.IsbnText.AutoSize = true;
            this.IsbnText.Font = new System.Drawing.Font("굴림", 14F);
            this.IsbnText.Location = new System.Drawing.Point(316, 132);
            this.IsbnText.Name = "IsbnText";
            this.IsbnText.Size = new System.Drawing.Size(46, 19);
            this.IsbnText.TabIndex = 2;
            this.IsbnText.Text = "ISBN";
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.IsbnTextBox.Location = new System.Drawing.Point(410, 131);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.Size = new System.Drawing.Size(105, 26);
            this.IsbnTextBox.TabIndex = 3;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.BookNameTextBox.Location = new System.Drawing.Point(410, 173);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(105, 26);
            this.BookNameTextBox.TabIndex = 5;
            // 
            // BookNameText
            // 
            this.BookNameText.AutoSize = true;
            this.BookNameText.Font = new System.Drawing.Font("굴림", 14F);
            this.BookNameText.Location = new System.Drawing.Point(316, 174);
            this.BookNameText.Name = "BookNameText";
            this.BookNameText.Size = new System.Drawing.Size(66, 19);
            this.BookNameText.TabIndex = 4;
            this.BookNameText.Text = "도서명";
            // 
            // BookTypeTextBox
            // 
            this.BookTypeTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.BookTypeTextBox.Location = new System.Drawing.Point(410, 261);
            this.BookTypeTextBox.Name = "BookTypeTextBox";
            this.BookTypeTextBox.Size = new System.Drawing.Size(105, 26);
            this.BookTypeTextBox.TabIndex = 9;
            // 
            // BookTypeText
            // 
            this.BookTypeText.AutoSize = true;
            this.BookTypeText.Font = new System.Drawing.Font("굴림", 14F);
            this.BookTypeText.Location = new System.Drawing.Point(316, 262);
            this.BookTypeText.Name = "BookTypeText";
            this.BookTypeText.Size = new System.Drawing.Size(47, 19);
            this.BookTypeText.TabIndex = 8;
            this.BookTypeText.Text = "분류";
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.PublisherTextBox.Location = new System.Drawing.Point(410, 219);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(105, 26);
            this.PublisherTextBox.TabIndex = 7;
            // 
            // PublisherText
            // 
            this.PublisherText.AutoSize = true;
            this.PublisherText.Font = new System.Drawing.Font("굴림", 14F);
            this.PublisherText.Location = new System.Drawing.Point(316, 220);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.Size = new System.Drawing.Size(66, 19);
            this.PublisherText.TabIndex = 6;
            this.PublisherText.Text = "출판사";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.PriceTextBox.Location = new System.Drawing.Point(410, 307);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(105, 26);
            this.PriceTextBox.TabIndex = 11;
            // 
            // PriceText
            // 
            this.PriceText.AutoSize = true;
            this.PriceText.Font = new System.Drawing.Font("굴림", 14F);
            this.PriceText.Location = new System.Drawing.Point(316, 308);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(47, 19);
            this.PriceText.TabIndex = 10;
            this.PriceText.Text = "가격";
            // 
            // CommitButton
            // 
            this.CommitButton.Location = new System.Drawing.Point(335, 367);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(146, 50);
            this.CommitButton.TabIndex = 12;
            this.CommitButton.Text = "완료";
            this.CommitButton.UseVisualStyleBackColor = true;
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
            // 
            // BookRegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommitButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.BookTypeTextBox);
            this.Controls.Add(this.BookTypeText);
            this.Controls.Add(this.PublisherTextBox);
            this.Controls.Add(this.PublisherText);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.BookNameText);
            this.Controls.Add(this.IsbnTextBox);
            this.Controls.Add(this.IsbnText);
            this.Controls.Add(this.MainTitleText);
            this.Name = "BookRegistForm";
            this.Text = "BookRegistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleText;
        private System.Windows.Forms.Label IsbnText;
        private System.Windows.Forms.TextBox IsbnTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label BookNameText;
        private System.Windows.Forms.TextBox BookTypeTextBox;
        private System.Windows.Forms.Label BookTypeText;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.Label PublisherText;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.Button CommitButton;
    }
}