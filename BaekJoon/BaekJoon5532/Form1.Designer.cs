
namespace BaekJoon5532
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
            this.tbxVacation = new System.Windows.Forms.TextBox();
            this.tbxHomeWork1 = new System.Windows.Forms.TextBox();
            this.tbxMath = new System.Windows.Forms.TextBox();
            this.tbxMaxHomeWork1 = new System.Windows.Forms.TextBox();
            this.tbxMaxMath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxVacation
            // 
            this.tbxVacation.Location = new System.Drawing.Point(114, 11);
            this.tbxVacation.Name = "tbxVacation";
            this.tbxVacation.Size = new System.Drawing.Size(100, 21);
            this.tbxVacation.TabIndex = 0;
            // 
            // tbxHomeWork1
            // 
            this.tbxHomeWork1.Location = new System.Drawing.Point(114, 38);
            this.tbxHomeWork1.Name = "tbxHomeWork1";
            this.tbxHomeWork1.Size = new System.Drawing.Size(100, 21);
            this.tbxHomeWork1.TabIndex = 1;
            // 
            // tbxMath
            // 
            this.tbxMath.Location = new System.Drawing.Point(114, 65);
            this.tbxMath.Name = "tbxMath";
            this.tbxMath.Size = new System.Drawing.Size(100, 21);
            this.tbxMath.TabIndex = 2;
            // 
            // tbxMaxHomeWork1
            // 
            this.tbxMaxHomeWork1.Location = new System.Drawing.Point(114, 92);
            this.tbxMaxHomeWork1.Name = "tbxMaxHomeWork1";
            this.tbxMaxHomeWork1.Size = new System.Drawing.Size(100, 21);
            this.tbxMaxHomeWork1.TabIndex = 3;
            // 
            // tbxMaxMath
            // 
            this.tbxMaxMath.Location = new System.Drawing.Point(114, 119);
            this.tbxMaxMath.Name = "tbxMaxMath";
            this.tbxMaxMath.Size = new System.Drawing.Size(100, 21);
            this.tbxMaxMath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "방학일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "국어";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "수학";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "국어 가능 페이지";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "수학 가능 페이지";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(369, 65);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(68, 23);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "최댓값";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 157);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMaxMath);
            this.Controls.Add(this.tbxMaxHomeWork1);
            this.Controls.Add(this.tbxMath);
            this.Controls.Add(this.tbxHomeWork1);
            this.Controls.Add(this.tbxVacation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxVacation;
        private System.Windows.Forms.TextBox tbxHomeWork1;
        private System.Windows.Forms.TextBox tbxMath;
        private System.Windows.Forms.TextBox tbxMaxHomeWork1;
        private System.Windows.Forms.TextBox tbxMaxMath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
    }
}

