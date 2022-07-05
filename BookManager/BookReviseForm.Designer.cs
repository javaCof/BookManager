namespace BookManager
{
    partial class BookReviseForm
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
            this.IsbnSearchText = new System.Windows.Forms.Label();
            this.IsbnSearchTextBox = new System.Windows.Forms.TextBox();
            this.IsbnSearchButton = new System.Windows.Forms.Button();
            this.BookInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.Label();
            this.BookTypeTextBox = new System.Windows.Forms.TextBox();
            this.BookTypeText = new System.Windows.Forms.Label();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.PublisherText = new System.Windows.Forms.Label();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.BookNameText = new System.Windows.Forms.Label();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.IsbnText = new System.Windows.Forms.Label();
            this.CommitButton = new System.Windows.Forms.Button();
            this.BookInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTitleText
            // 
            this.MainTitleText.AutoSize = true;
            this.MainTitleText.Font = new System.Drawing.Font("굴림", 52F);
            this.MainTitleText.Location = new System.Drawing.Point(323, 17);
            this.MainTitleText.Name = "MainTitleText";
            this.MainTitleText.Size = new System.Drawing.Size(170, 70);
            this.MainTitleText.TabIndex = 2;
            this.MainTitleText.Text = "수정";
            // 
            // IsbnSearchText
            // 
            this.IsbnSearchText.AutoSize = true;
            this.IsbnSearchText.Location = new System.Drawing.Point(258, 107);
            this.IsbnSearchText.Name = "IsbnSearchText";
            this.IsbnSearchText.Size = new System.Drawing.Size(33, 12);
            this.IsbnSearchText.TabIndex = 3;
            this.IsbnSearchText.Text = "ISBN";
            // 
            // IsbnSearchTextBox
            // 
            this.IsbnSearchTextBox.Location = new System.Drawing.Point(308, 104);
            this.IsbnSearchTextBox.Name = "IsbnSearchTextBox";
            this.IsbnSearchTextBox.Size = new System.Drawing.Size(200, 21);
            this.IsbnSearchTextBox.TabIndex = 4;
            // 
            // IsbnSearchButton
            // 
            this.IsbnSearchButton.Location = new System.Drawing.Point(527, 104);
            this.IsbnSearchButton.Name = "IsbnSearchButton";
            this.IsbnSearchButton.Size = new System.Drawing.Size(75, 23);
            this.IsbnSearchButton.TabIndex = 5;
            this.IsbnSearchButton.Text = "검색";
            this.IsbnSearchButton.UseVisualStyleBackColor = true;
            // 
            // BookInfoGroupBox
            // 
            this.BookInfoGroupBox.Controls.Add(this.PriceTextBox);
            this.BookInfoGroupBox.Controls.Add(this.PriceText);
            this.BookInfoGroupBox.Controls.Add(this.BookTypeTextBox);
            this.BookInfoGroupBox.Controls.Add(this.BookTypeText);
            this.BookInfoGroupBox.Controls.Add(this.PublisherTextBox);
            this.BookInfoGroupBox.Controls.Add(this.PublisherText);
            this.BookInfoGroupBox.Controls.Add(this.BookNameTextBox);
            this.BookInfoGroupBox.Controls.Add(this.BookNameText);
            this.BookInfoGroupBox.Controls.Add(this.IsbnTextBox);
            this.BookInfoGroupBox.Controls.Add(this.IsbnText);
            this.BookInfoGroupBox.Location = new System.Drawing.Point(224, 135);
            this.BookInfoGroupBox.Name = "BookInfoGroupBox";
            this.BookInfoGroupBox.Size = new System.Drawing.Size(404, 259);
            this.BookInfoGroupBox.TabIndex = 6;
            this.BookInfoGroupBox.TabStop = false;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.PriceTextBox.Location = new System.Drawing.Point(197, 204);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(105, 26);
            this.PriceTextBox.TabIndex = 21;
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
            // BookTypeTextBox
            // 
            this.BookTypeTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.BookTypeTextBox.Location = new System.Drawing.Point(197, 158);
            this.BookTypeTextBox.Name = "BookTypeTextBox";
            this.BookTypeTextBox.Size = new System.Drawing.Size(105, 26);
            this.BookTypeTextBox.TabIndex = 19;
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
            // PublisherTextBox
            // 
            this.PublisherTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.PublisherTextBox.Location = new System.Drawing.Point(197, 116);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(105, 26);
            this.PublisherTextBox.TabIndex = 17;
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
            // BookNameTextBox
            // 
            this.BookNameTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.BookNameTextBox.Location = new System.Drawing.Point(197, 70);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(105, 26);
            this.BookNameTextBox.TabIndex = 15;
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
            // IsbnTextBox
            // 
            this.IsbnTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.IsbnTextBox.Location = new System.Drawing.Point(197, 28);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.Size = new System.Drawing.Size(105, 26);
            this.IsbnTextBox.TabIndex = 13;
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
            // CommitButton
            // 
            this.CommitButton.Location = new System.Drawing.Point(359, 400);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(98, 39);
            this.CommitButton.TabIndex = 7;
            this.CommitButton.Text = "완료";
            this.CommitButton.UseVisualStyleBackColor = true;
            // 
            // BookReviseForm
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
            this.Name = "BookReviseForm";
            this.Text = "BookReviseForm";
            this.BookInfoGroupBox.ResumeLayout(false);
            this.BookInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleText;
        private System.Windows.Forms.Label IsbnSearchText;
        private System.Windows.Forms.TextBox IsbnSearchTextBox;
        private System.Windows.Forms.Button IsbnSearchButton;
        private System.Windows.Forms.GroupBox BookInfoGroupBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.TextBox BookTypeTextBox;
        private System.Windows.Forms.Label BookTypeText;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.Label PublisherText;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label BookNameText;
        private System.Windows.Forms.TextBox IsbnTextBox;
        private System.Windows.Forms.Label IsbnText;
        private System.Windows.Forms.Button CommitButton;
    }
}