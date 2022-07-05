namespace BookManager
{
    partial class BookRemoveForm
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
            this.CommitButton = new System.Windows.Forms.Button();
            this.BookInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceText = new System.Windows.Forms.Label();
            this.BookTypeText = new System.Windows.Forms.Label();
            this.PublisherText = new System.Windows.Forms.Label();
            this.BookNameText = new System.Windows.Forms.Label();
            this.IsbnText = new System.Windows.Forms.Label();
            this.IsbnSearchButton = new System.Windows.Forms.Button();
            this.IsbnSearchTextBox = new System.Windows.Forms.TextBox();
            this.IsbnSearchText = new System.Windows.Forms.Label();
            this.MainTitleText = new System.Windows.Forms.Label();
            this.IsbnInfoText = new System.Windows.Forms.Label();
            this.BookNameInfoText = new System.Windows.Forms.Label();
            this.PublisherInfoText = new System.Windows.Forms.Label();
            this.BookTypeInfoText = new System.Windows.Forms.Label();
            this.PriceInfoText = new System.Windows.Forms.Label();
            this.BookInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommitButton
            // 
            this.CommitButton.Location = new System.Drawing.Point(359, 400);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(98, 39);
            this.CommitButton.TabIndex = 13;
            this.CommitButton.Text = "삭제";
            this.CommitButton.UseVisualStyleBackColor = true;
            // 
            // BookInfoGroupBox
            // 
            this.BookInfoGroupBox.Controls.Add(this.PriceInfoText);
            this.BookInfoGroupBox.Controls.Add(this.BookTypeInfoText);
            this.BookInfoGroupBox.Controls.Add(this.PublisherInfoText);
            this.BookInfoGroupBox.Controls.Add(this.BookNameInfoText);
            this.BookInfoGroupBox.Controls.Add(this.IsbnInfoText);
            this.BookInfoGroupBox.Controls.Add(this.PriceText);
            this.BookInfoGroupBox.Controls.Add(this.BookTypeText);
            this.BookInfoGroupBox.Controls.Add(this.PublisherText);
            this.BookInfoGroupBox.Controls.Add(this.BookNameText);
            this.BookInfoGroupBox.Controls.Add(this.IsbnText);
            this.BookInfoGroupBox.Location = new System.Drawing.Point(224, 135);
            this.BookInfoGroupBox.Name = "BookInfoGroupBox";
            this.BookInfoGroupBox.Size = new System.Drawing.Size(404, 259);
            this.BookInfoGroupBox.TabIndex = 12;
            this.BookInfoGroupBox.TabStop = false;
            // 
            // PriceText
            // 
            this.PriceText.AutoSize = true;
            this.PriceText.Font = new System.Drawing.Font("굴림", 14F);
            this.PriceText.Location = new System.Drawing.Point(103, 205);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(47, 19);
            this.PriceText.TabIndex = 20;
            this.PriceText.Text = "가격";
            // 
            // BookTypeText
            // 
            this.BookTypeText.AutoSize = true;
            this.BookTypeText.Font = new System.Drawing.Font("굴림", 14F);
            this.BookTypeText.Location = new System.Drawing.Point(103, 159);
            this.BookTypeText.Name = "BookTypeText";
            this.BookTypeText.Size = new System.Drawing.Size(47, 19);
            this.BookTypeText.TabIndex = 18;
            this.BookTypeText.Text = "분류";
            // 
            // PublisherText
            // 
            this.PublisherText.AutoSize = true;
            this.PublisherText.Font = new System.Drawing.Font("굴림", 14F);
            this.PublisherText.Location = new System.Drawing.Point(103, 117);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.Size = new System.Drawing.Size(66, 19);
            this.PublisherText.TabIndex = 16;
            this.PublisherText.Text = "출판사";
            // 
            // BookNameText
            // 
            this.BookNameText.AutoSize = true;
            this.BookNameText.Font = new System.Drawing.Font("굴림", 14F);
            this.BookNameText.Location = new System.Drawing.Point(103, 71);
            this.BookNameText.Name = "BookNameText";
            this.BookNameText.Size = new System.Drawing.Size(66, 19);
            this.BookNameText.TabIndex = 14;
            this.BookNameText.Text = "도서명";
            // 
            // IsbnText
            // 
            this.IsbnText.AutoSize = true;
            this.IsbnText.Font = new System.Drawing.Font("굴림", 14F);
            this.IsbnText.Location = new System.Drawing.Point(103, 29);
            this.IsbnText.Name = "IsbnText";
            this.IsbnText.Size = new System.Drawing.Size(46, 19);
            this.IsbnText.TabIndex = 12;
            this.IsbnText.Text = "ISBN";
            // 
            // IsbnSearchButton
            // 
            this.IsbnSearchButton.Location = new System.Drawing.Point(527, 104);
            this.IsbnSearchButton.Name = "IsbnSearchButton";
            this.IsbnSearchButton.Size = new System.Drawing.Size(75, 23);
            this.IsbnSearchButton.TabIndex = 11;
            this.IsbnSearchButton.Text = "검색";
            this.IsbnSearchButton.UseVisualStyleBackColor = true;
            // 
            // IsbnSearchTextBox
            // 
            this.IsbnSearchTextBox.Location = new System.Drawing.Point(308, 104);
            this.IsbnSearchTextBox.Name = "IsbnSearchTextBox";
            this.IsbnSearchTextBox.Size = new System.Drawing.Size(200, 21);
            this.IsbnSearchTextBox.TabIndex = 10;
            // 
            // IsbnSearchText
            // 
            this.IsbnSearchText.AutoSize = true;
            this.IsbnSearchText.Location = new System.Drawing.Point(258, 107);
            this.IsbnSearchText.Name = "IsbnSearchText";
            this.IsbnSearchText.Size = new System.Drawing.Size(33, 12);
            this.IsbnSearchText.TabIndex = 9;
            this.IsbnSearchText.Text = "ISBN";
            // 
            // MainTitleText
            // 
            this.MainTitleText.AutoSize = true;
            this.MainTitleText.Font = new System.Drawing.Font("굴림", 52F);
            this.MainTitleText.Location = new System.Drawing.Point(323, 17);
            this.MainTitleText.Name = "MainTitleText";
            this.MainTitleText.Size = new System.Drawing.Size(170, 70);
            this.MainTitleText.TabIndex = 8;
            this.MainTitleText.Text = "삭제";
            // 
            // IsbnInfoText
            // 
            this.IsbnInfoText.AutoSize = true;
            this.IsbnInfoText.Font = new System.Drawing.Font("굴림", 12F);
            this.IsbnInfoText.Location = new System.Drawing.Point(197, 28);
            this.IsbnInfoText.Name = "IsbnInfoText";
            this.IsbnInfoText.Size = new System.Drawing.Size(39, 16);
            this.IsbnInfoText.TabIndex = 14;
            this.IsbnInfoText.Text = "Text";
            // 
            // BookNameInfoText
            // 
            this.BookNameInfoText.AutoSize = true;
            this.BookNameInfoText.Font = new System.Drawing.Font("굴림", 12F);
            this.BookNameInfoText.Location = new System.Drawing.Point(197, 70);
            this.BookNameInfoText.Name = "BookNameInfoText";
            this.BookNameInfoText.Size = new System.Drawing.Size(39, 16);
            this.BookNameInfoText.TabIndex = 21;
            this.BookNameInfoText.Text = "Text";
            // 
            // PublisherInfoText
            // 
            this.PublisherInfoText.AutoSize = true;
            this.PublisherInfoText.Font = new System.Drawing.Font("굴림", 12F);
            this.PublisherInfoText.Location = new System.Drawing.Point(197, 116);
            this.PublisherInfoText.Name = "PublisherInfoText";
            this.PublisherInfoText.Size = new System.Drawing.Size(39, 16);
            this.PublisherInfoText.TabIndex = 22;
            this.PublisherInfoText.Text = "Text";
            // 
            // BookTypeInfoText
            // 
            this.BookTypeInfoText.AutoSize = true;
            this.BookTypeInfoText.Font = new System.Drawing.Font("굴림", 12F);
            this.BookTypeInfoText.Location = new System.Drawing.Point(197, 158);
            this.BookTypeInfoText.Name = "BookTypeInfoText";
            this.BookTypeInfoText.Size = new System.Drawing.Size(39, 16);
            this.BookTypeInfoText.TabIndex = 23;
            this.BookTypeInfoText.Text = "Text";
            // 
            // PriceInfoText
            // 
            this.PriceInfoText.AutoSize = true;
            this.PriceInfoText.Font = new System.Drawing.Font("굴림", 12F);
            this.PriceInfoText.Location = new System.Drawing.Point(197, 204);
            this.PriceInfoText.Name = "PriceInfoText";
            this.PriceInfoText.Size = new System.Drawing.Size(39, 16);
            this.PriceInfoText.TabIndex = 24;
            this.PriceInfoText.Text = "Text";
            // 
            // BookRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommitButton);
            this.Controls.Add(this.BookInfoGroupBox);
            this.Controls.Add(this.IsbnSearchButton);
            this.Controls.Add(this.IsbnSearchTextBox);
            this.Controls.Add(this.IsbnSearchText);
            this.Controls.Add(this.MainTitleText);
            this.Name = "BookRemoveForm";
            this.Text = "BookRemoveForm";
            this.BookInfoGroupBox.ResumeLayout(false);
            this.BookInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CommitButton;
        private System.Windows.Forms.GroupBox BookInfoGroupBox;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.Label BookTypeText;
        private System.Windows.Forms.Label PublisherText;
        private System.Windows.Forms.Label BookNameText;
        private System.Windows.Forms.Label IsbnText;
        private System.Windows.Forms.Button IsbnSearchButton;
        private System.Windows.Forms.TextBox IsbnSearchTextBox;
        private System.Windows.Forms.Label IsbnSearchText;
        private System.Windows.Forms.Label MainTitleText;
        private System.Windows.Forms.Label IsbnInfoText;
        private System.Windows.Forms.Label PriceInfoText;
        private System.Windows.Forms.Label BookTypeInfoText;
        private System.Windows.Forms.Label PublisherInfoText;
        private System.Windows.Forms.Label BookNameInfoText;
    }
}