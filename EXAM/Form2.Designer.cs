namespace EXAM
{
    partial class Form2
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
            this.question = new System.Windows.Forms.Label();
            this.qcm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(269, 44);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(47, 13);
            this.question.TabIndex = 0;
            this.question.Text = "question";
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // qcm
            // 
            this.qcm.Location = new System.Drawing.Point(89, 114);
            this.qcm.Name = "qcm";
            this.qcm.Size = new System.Drawing.Size(75, 23);
            this.qcm.TabIndex = 1;
            this.qcm.Text = "qsm";
            this.qcm.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qcm);
            this.Controls.Add(this.question);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button qcm;
    }
}