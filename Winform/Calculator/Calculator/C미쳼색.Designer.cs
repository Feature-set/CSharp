
namespace Calculator
{
    partial class HelloLabel
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
            this.ClickLabel = new System.Windows.Forms.Label();
            this.SumNum1 = new System.Windows.Forms.TextBox();
            this.SumNum2 = new System.Windows.Forms.TextBox();
            this.SumButton = new System.Windows.Forms.Button();
            this.SumAnser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClickLabel
            // 
            this.ClickLabel.AutoSize = true;
            this.ClickLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClickLabel.Location = new System.Drawing.Point(79, 38);
            this.ClickLabel.Name = "ClickLabel";
            this.ClickLabel.Size = new System.Drawing.Size(59, 12);
            this.ClickLabel.TabIndex = 0;
            this.ClickLabel.Text = "ClickHere";
            this.ClickLabel.CursorChanged += new System.EventHandler(this.label1_Click);
            this.ClickLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SumNum1
            // 
            this.SumNum1.Location = new System.Drawing.Point(81, 112);
            this.SumNum1.Name = "SumNum1";
            this.SumNum1.Size = new System.Drawing.Size(100, 21);
            this.SumNum1.TabIndex = 1;
            // 
            // SumNum2
            // 
            this.SumNum2.Location = new System.Drawing.Point(207, 112);
            this.SumNum2.Name = "SumNum2";
            this.SumNum2.Size = new System.Drawing.Size(100, 21);
            this.SumNum2.TabIndex = 2;
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(340, 112);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(75, 23);
            this.SumButton.TabIndex = 3;
            this.SumButton.Text = "=";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // SumAnser
            // 
            this.SumAnser.Location = new System.Drawing.Point(451, 114);
            this.SumAnser.Name = "SumAnser";
            this.SumAnser.Size = new System.Drawing.Size(100, 21);
            this.SumAnser.TabIndex = 4;
            this.SumAnser.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // HelloLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumAnser);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.SumNum2);
            this.Controls.Add(this.SumNum1);
            this.Controls.Add(this.ClickLabel);
            this.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.Name = "HelloLabel";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.HelloLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClickLabel;
        private System.Windows.Forms.TextBox SumNum1;
        private System.Windows.Forms.TextBox SumNum2;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.TextBox SumAnser;
    }
}

