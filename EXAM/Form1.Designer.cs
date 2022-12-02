namespace EXAM
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ex = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Button();
            this.exam = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.afficher = new System.Windows.Forms.Button();
            this.confirmer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nbreqst = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.examDataSet = new EXAM.examDataSet();
            this.examDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ex
            // 
            this.ex.Location = new System.Drawing.Point(94, 308);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(75, 130);
            this.ex.TabIndex = 0;
            this.ex.Text = "exam";
            this.ex.UseVisualStyleBackColor = true;
            this.ex.Click += new System.EventHandler(this.ex_Click);
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(243, 308);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(75, 130);
            this.question.TabIndex = 1;
            this.question.Text = "question";
            this.question.UseVisualStyleBackColor = true;
            // 
            // exam
            // 
            this.exam.AutoSize = true;
            this.exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam.Location = new System.Drawing.Point(301, 12);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(36, 13);
            this.exam.TabIndex = 2;
            this.exam.Text = "exam";
            this.exam.Click += new System.EventHandler(this.exam_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(79, 78);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(28, 13);
            this.date.TabIndex = 3;
            this.date.Text = "date";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "numexam";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(667, 245);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "qcm";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(665, 290);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "dichotomie";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(664, 339);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "vrai/faux";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.examDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(538, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // afficher
            // 
            this.afficher.Location = new System.Drawing.Point(503, 244);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(75, 23);
            this.afficher.TabIndex = 9;
            this.afficher.Text = "afficher";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // confirmer
            // 
            this.confirmer.Location = new System.Drawing.Point(503, 308);
            this.confirmer.Name = "confirmer";
            this.confirmer.Size = new System.Drawing.Size(75, 23);
            this.confirmer.TabIndex = 10;
            this.confirmer.Text = "confirmer";
            this.confirmer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 12;
            // 
            // nbreqst
            // 
            this.nbreqst.AutoSize = true;
            this.nbreqst.Location = new System.Drawing.Point(79, 187);
            this.nbreqst.Name = "nbreqst";
            this.nbreqst.Size = new System.Drawing.Size(42, 13);
            this.nbreqst.TabIndex = 13;
            this.nbreqst.Text = "nbreqst";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // examDataSet
            // 
            this.examDataSet.DataSetName = "examDataSet";
            this.examDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examDataSetBindingSource
            // 
            this.examDataSetBindingSource.DataSource = this.examDataSet;
            this.examDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nbreqst);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.confirmer);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.exam);
            this.Controls.Add(this.question);
            this.Controls.Add(this.ex);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ex;
        private System.Windows.Forms.Button question;
        private System.Windows.Forms.Label exam;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.Button confirmer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nbreqst;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource examDataSetBindingSource;
        private examDataSet examDataSet;
    }
}

