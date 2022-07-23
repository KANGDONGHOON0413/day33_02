
namespace day33_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.INPUT_NAME = new System.Windows.Forms.TextBox();
            this.INPUT_AGE = new System.Windows.Forms.TextBox();
            this.RBTN_MALE = new System.Windows.Forms.RadioButton();
            this.RBTN_FEMALE = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_INPUT = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.INPUT_PHONENUM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(472, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "나이: ";
            // 
            // INPUT_NAME
            // 
            this.INPUT_NAME.Location = new System.Drawing.Point(545, 35);
            this.INPUT_NAME.Name = "INPUT_NAME";
            this.INPUT_NAME.Size = new System.Drawing.Size(125, 27);
            this.INPUT_NAME.TabIndex = 3;
            // 
            // INPUT_AGE
            // 
            this.INPUT_AGE.Location = new System.Drawing.Point(545, 70);
            this.INPUT_AGE.Name = "INPUT_AGE";
            this.INPUT_AGE.Size = new System.Drawing.Size(125, 27);
            this.INPUT_AGE.TabIndex = 4;
            // 
            // RBTN_MALE
            // 
            this.RBTN_MALE.AutoSize = true;
            this.RBTN_MALE.Location = new System.Drawing.Point(6, 26);
            this.RBTN_MALE.Name = "RBTN_MALE";
            this.RBTN_MALE.Size = new System.Drawing.Size(60, 24);
            this.RBTN_MALE.TabIndex = 5;
            this.RBTN_MALE.TabStop = true;
            this.RBTN_MALE.Text = "남자";
            this.RBTN_MALE.UseVisualStyleBackColor = true;
            // 
            // RBTN_FEMALE
            // 
            this.RBTN_FEMALE.AutoSize = true;
            this.RBTN_FEMALE.Location = new System.Drawing.Point(6, 56);
            this.RBTN_FEMALE.Name = "RBTN_FEMALE";
            this.RBTN_FEMALE.Size = new System.Drawing.Size(60, 24);
            this.RBTN_FEMALE.TabIndex = 6;
            this.RBTN_FEMALE.TabStop = true;
            this.RBTN_FEMALE.Text = "여자";
            this.RBTN_FEMALE.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBTN_MALE);
            this.groupBox1.Controls.Add(this.RBTN_FEMALE);
            this.groupBox1.Location = new System.Drawing.Point(676, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 98);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성별";
            // 
            // BTN_INPUT
            // 
            this.BTN_INPUT.Location = new System.Drawing.Point(528, 149);
            this.BTN_INPUT.Name = "BTN_INPUT";
            this.BTN_INPUT.Size = new System.Drawing.Size(128, 51);
            this.BTN_INPUT.TabIndex = 8;
            this.BTN_INPUT.Text = "입력";
            this.BTN_INPUT.UseVisualStyleBackColor = true;
            this.BTN_INPUT.Click += new System.EventHandler(this.BTN_INPUT_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Location = new System.Drawing.Point(662, 149);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(128, 51);
            this.BTN_DELETE.TabIndex = 9;
            this.BTN_DELETE.Text = "삭제";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // INPUT_PHONENUM
            // 
            this.INPUT_PHONENUM.Location = new System.Drawing.Point(545, 103);
            this.INPUT_PHONENUM.Name = "INPUT_PHONENUM";
            this.INPUT_PHONENUM.Size = new System.Drawing.Size(125, 27);
            this.INPUT_PHONENUM.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "전화: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 221);
            this.Controls.Add(this.INPUT_PHONENUM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_INPUT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.INPUT_AGE);
            this.Controls.Add(this.INPUT_NAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox INPUT_NAME;
        private System.Windows.Forms.TextBox INPUT_AGE;
        private System.Windows.Forms.RadioButton RBTN_MALE;
        private System.Windows.Forms.RadioButton RBTN_FEMALE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_INPUT;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.TextBox INPUT_PHONENUM;
        private System.Windows.Forms.Label label3;
    }
}

