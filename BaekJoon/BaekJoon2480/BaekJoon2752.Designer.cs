
namespace BaekJoon2752
{
    partial class BaekJoon2752
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
            this.button1 = new System.Windows.Forms.Button();
            this.rtbOriginal = new System.Windows.Forms.RichTextBox();
            this.rtbSort = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbOriginal
            // 
            this.rtbOriginal.Location = new System.Drawing.Point(187, 63);
            this.rtbOriginal.Name = "rtbOriginal";
            this.rtbOriginal.ReadOnly = true;
            this.rtbOriginal.Size = new System.Drawing.Size(150, 130);
            this.rtbOriginal.TabIndex = 2;
            this.rtbOriginal.Text = "";
            // 
            // rtbSort
            // 
            this.rtbSort.Location = new System.Drawing.Point(363, 63);
            this.rtbSort.Name = "rtbSort";
            this.rtbSort.Size = new System.Drawing.Size(143, 130);
            this.rtbSort.TabIndex = 3;
            this.rtbSort.Text = "";
            // 
            // BaekJoon2752
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSort);
            this.Controls.Add(this.rtbOriginal);
            this.Controls.Add(this.button1);
            this.Name = "BaekJoon2752";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbOriginal;
        private System.Windows.Forms.RichTextBox rtbSort;
    }
}

