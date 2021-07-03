namespace CollegeManagementSystem
{
    partial class SearchTeacher
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
            this.SearchTeacherButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTeacherTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTeacherDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTeacherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTeacherButton
            // 
            this.SearchTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchTeacherButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTeacherButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchTeacherButton.Location = new System.Drawing.Point(411, 158);
            this.SearchTeacherButton.Name = "SearchTeacherButton";
            this.SearchTeacherButton.Size = new System.Drawing.Size(75, 29);
            this.SearchTeacherButton.TabIndex = 48;
            this.SearchTeacherButton.Text = "Search";
            this.SearchTeacherButton.UseVisualStyleBackColor = true;
            this.SearchTeacherButton.Click += new System.EventHandler(this.SearchTeacherButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Registration No :";
            // 
            // SearchTeacherTextBox
            // 
            this.SearchTeacherTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTeacherTextBox.Location = new System.Drawing.Point(411, 113);
            this.SearchTeacherTextBox.Name = "SearchTeacherTextBox";
            this.SearchTeacherTextBox.Size = new System.Drawing.Size(165, 27);
            this.SearchTeacherTextBox.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Search Teacher ";
            // 
            // SearchTeacherDataGridView
            // 
            this.SearchTeacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchTeacherDataGridView.Location = new System.Drawing.Point(12, 210);
            this.SearchTeacherDataGridView.Name = "SearchTeacherDataGridView";
            this.SearchTeacherDataGridView.Size = new System.Drawing.Size(620, 265);
            this.SearchTeacherDataGridView.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CollegeManagementSystem.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(78, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // SearchTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 495);
            this.Controls.Add(this.SearchTeacherDataGridView);
            this.Controls.Add(this.SearchTeacherButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTeacherTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchTeacher";
            this.Text = "SearchTeacher";
            this.Load += new System.EventHandler(this.SearchTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchTeacherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchTeacherButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTeacherTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView SearchTeacherDataGridView;
    }
}