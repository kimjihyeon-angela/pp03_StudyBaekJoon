
namespace BaekJoon5543
{
    partial class Form1
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
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSprite = new System.Windows.Forms.TextBox();
            this.tbxCoke = new System.Windows.Forms.TextBox();
            this.tbxBurger3 = new System.Windows.Forms.TextBox();
            this.tbxBurger2 = new System.Windows.Forms.TextBox();
            this.tbxBurger1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(333, 73);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(68, 23);
            this.lblResult.TabIndex = 23;
            this.lblResult.Text = "최댓값";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "사이다";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "콜라";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "하덕버거";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "중덕버거";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "상덕버거";
            // 
            // tbxSprite
            // 
            this.tbxSprite.Location = new System.Drawing.Point(78, 127);
            this.tbxSprite.Name = "tbxSprite";
            this.tbxSprite.Size = new System.Drawing.Size(100, 21);
            this.tbxSprite.TabIndex = 16;
            // 
            // tbxCoke
            // 
            this.tbxCoke.Location = new System.Drawing.Point(78, 100);
            this.tbxCoke.Name = "tbxCoke";
            this.tbxCoke.Size = new System.Drawing.Size(100, 21);
            this.tbxCoke.TabIndex = 15;
            // 
            // tbxBurger3
            // 
            this.tbxBurger3.Location = new System.Drawing.Point(78, 73);
            this.tbxBurger3.Name = "tbxBurger3";
            this.tbxBurger3.Size = new System.Drawing.Size(100, 21);
            this.tbxBurger3.TabIndex = 14;
            // 
            // tbxBurger2
            // 
            this.tbxBurger2.Location = new System.Drawing.Point(78, 46);
            this.tbxBurger2.Name = "tbxBurger2";
            this.tbxBurger2.Size = new System.Drawing.Size(100, 21);
            this.tbxBurger2.TabIndex = 13;
            // 
            // tbxBurger1
            // 
            this.tbxBurger1.Location = new System.Drawing.Point(78, 19);
            this.tbxBurger1.Name = "tbxBurger1";
            this.tbxBurger1.Size = new System.Drawing.Size(100, 21);
            this.tbxBurger1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 168);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSprite);
            this.Controls.Add(this.tbxCoke);
            this.Controls.Add(this.tbxBurger3);
            this.Controls.Add(this.tbxBurger2);
            this.Controls.Add(this.tbxBurger1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSprite;
        private System.Windows.Forms.TextBox tbxCoke;
        private System.Windows.Forms.TextBox tbxBurger3;
        private System.Windows.Forms.TextBox tbxBurger2;
        private System.Windows.Forms.TextBox tbxBurger1;
    }
}

