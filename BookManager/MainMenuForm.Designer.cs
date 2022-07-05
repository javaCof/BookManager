namespace BookManager
{
    partial class MainMenuForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTitleText = new System.Windows.Forms.Label();
            this.BookAddButton = new System.Windows.Forms.Button();
            this.BookSearchButton = new System.Windows.Forms.Button();
            this.BookReviseButton = new System.Windows.Forms.Button();
            this.BookRemoveButton = new System.Windows.Forms.Button();
            this.MainNameText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainTitleText
            // 
            this.MainTitleText.AutoSize = true;
            this.MainTitleText.Font = new System.Drawing.Font("굴림", 52F);
            this.MainTitleText.Location = new System.Drawing.Point(90, 60);
            this.MainTitleText.Name = "MainTitleText";
            this.MainTitleText.Size = new System.Drawing.Size(636, 70);
            this.MainTitleText.TabIndex = 0;
            this.MainTitleText.Text = "도서 관리 프로그램";
            // 
            // BookAddButton
            // 
            this.BookAddButton.Location = new System.Drawing.Point(370, 204);
            this.BookAddButton.Name = "BookAddButton";
            this.BookAddButton.Size = new System.Drawing.Size(75, 23);
            this.BookAddButton.TabIndex = 1;
            this.BookAddButton.Text = "등록";
            this.BookAddButton.UseVisualStyleBackColor = true;
            this.BookAddButton.Click += new System.EventHandler(this.BookAddButton_Click);
            // 
            // BookSearchButton
            // 
            this.BookSearchButton.Location = new System.Drawing.Point(370, 258);
            this.BookSearchButton.Name = "BookSearchButton";
            this.BookSearchButton.Size = new System.Drawing.Size(75, 23);
            this.BookSearchButton.TabIndex = 2;
            this.BookSearchButton.Text = "검색";
            this.BookSearchButton.UseVisualStyleBackColor = true;
            this.BookSearchButton.Click += new System.EventHandler(this.BookSearchButton_Click);
            // 
            // BookReviseButton
            // 
            this.BookReviseButton.Location = new System.Drawing.Point(370, 314);
            this.BookReviseButton.Name = "BookReviseButton";
            this.BookReviseButton.Size = new System.Drawing.Size(75, 23);
            this.BookReviseButton.TabIndex = 3;
            this.BookReviseButton.Text = "수정";
            this.BookReviseButton.UseVisualStyleBackColor = true;
            this.BookReviseButton.Click += new System.EventHandler(this.BookReviseButton_Click);
            // 
            // BookRemoveButton
            // 
            this.BookRemoveButton.Location = new System.Drawing.Point(370, 372);
            this.BookRemoveButton.Name = "BookRemoveButton";
            this.BookRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.BookRemoveButton.TabIndex = 4;
            this.BookRemoveButton.Text = "삭제";
            this.BookRemoveButton.UseVisualStyleBackColor = true;
            this.BookRemoveButton.Click += new System.EventHandler(this.BookRemoveButton_Click);
            // 
            // MainNameText
            // 
            this.MainNameText.AutoSize = true;
            this.MainNameText.Location = new System.Drawing.Point(699, 429);
            this.MainNameText.Name = "MainNameText";
            this.MainNameText.Size = new System.Drawing.Size(89, 12);
            this.MainNameText.TabIndex = 5;
            this.MainNameText.Text = "만든이 : 유현우";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainNameText);
            this.Controls.Add(this.BookRemoveButton);
            this.Controls.Add(this.BookReviseButton);
            this.Controls.Add(this.BookSearchButton);
            this.Controls.Add(this.BookAddButton);
            this.Controls.Add(this.MainTitleText);
            this.Name = "MainMenuForm";
            this.Text = "Book Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleText;
        private System.Windows.Forms.Button BookAddButton;
        private System.Windows.Forms.Button BookSearchButton;
        private System.Windows.Forms.Button BookReviseButton;
        private System.Windows.Forms.Button BookRemoveButton;
        private System.Windows.Forms.Label MainNameText;
    }
}

