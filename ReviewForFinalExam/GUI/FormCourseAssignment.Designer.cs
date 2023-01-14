
namespace FinalExam.GUI
{
    partial class FormCourseAssignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxAssignedDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAssignCourse = new System.Windows.Forms.Button();
            this.buttonListCourses = new System.Windows.Forms.Button();
            this.buttonListTeacher = new System.Windows.Forms.Button();
            this.listViewTeacher = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCourse = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSaveToXML = new System.Windows.Forms.Button();
            this.btnAssignExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.comboBoxGridTeacher = new System.Windows.Forms.ComboBox();
            this.comboBoxGridCourse = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Teacher";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(50, 53);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(164, 21);
            this.comboBoxTeacher.TabIndex = 1;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(50, 132);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(188, 21);
            this.comboBoxCourse.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select the Course";
            // 
            // maskedTextBoxAssignedDate
            // 
            this.maskedTextBoxAssignedDate.Location = new System.Drawing.Point(47, 219);
            this.maskedTextBoxAssignedDate.Mask = "00/00/0000";
            this.maskedTextBoxAssignedDate.Name = "maskedTextBoxAssignedDate";
            this.maskedTextBoxAssignedDate.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBoxAssignedDate.TabIndex = 4;
            this.maskedTextBoxAssignedDate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Assigned Date(put cursor to the far left)";
            // 
            // buttonAssignCourse
            // 
            this.buttonAssignCourse.Location = new System.Drawing.Point(47, 291);
            this.buttonAssignCourse.Name = "buttonAssignCourse";
            this.buttonAssignCourse.Size = new System.Drawing.Size(112, 36);
            this.buttonAssignCourse.TabIndex = 6;
            this.buttonAssignCourse.Text = "Assign Course";
            this.buttonAssignCourse.UseVisualStyleBackColor = true;
            this.buttonAssignCourse.Click += new System.EventHandler(this.buttonAssignCourse_Click);
            // 
            // buttonListCourses
            // 
            this.buttonListCourses.Location = new System.Drawing.Point(488, 203);
            this.buttonListCourses.Name = "buttonListCourses";
            this.buttonListCourses.Size = new System.Drawing.Size(112, 36);
            this.buttonListCourses.TabIndex = 7;
            this.buttonListCourses.Text = "List Courses";
            this.buttonListCourses.UseVisualStyleBackColor = true;
            this.buttonListCourses.Click += new System.EventHandler(this.buttonListCourses_Click);
            // 
            // buttonListTeacher
            // 
            this.buttonListTeacher.Location = new System.Drawing.Point(262, 210);
            this.buttonListTeacher.Name = "buttonListTeacher";
            this.buttonListTeacher.Size = new System.Drawing.Size(112, 36);
            this.buttonListTeacher.TabIndex = 8;
            this.buttonListTeacher.Text = "List Teachers";
            this.buttonListTeacher.UseVisualStyleBackColor = true;
            this.buttonListTeacher.Click += new System.EventHandler(this.buttonListTeacher_Click);
            // 
            // listViewTeacher
            // 
            this.listViewTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTeacher.GridLines = true;
            this.listViewTeacher.HideSelection = false;
            this.listViewTeacher.Location = new System.Drawing.Point(222, 262);
            this.listViewTeacher.Name = "listViewTeacher";
            this.listViewTeacher.Size = new System.Drawing.Size(192, 119);
            this.listViewTeacher.TabIndex = 9;
            this.listViewTeacher.UseCompatibleStateImageBehavior = false;
            this.listViewTeacher.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Teacher Number";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 156;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 385;
            // 
            // listViewCourse
            // 
            this.listViewCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCourse.HideSelection = false;
            this.listViewCourse.Location = new System.Drawing.Point(439, 254);
            this.listViewCourse.Name = "listViewCourse";
            this.listViewCourse.Size = new System.Drawing.Size(302, 126);
            this.listViewCourse.TabIndex = 10;
            this.listViewCourse.UseCompatibleStateImageBehavior = false;
            this.listViewCourse.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Course Number";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Course Title";
            this.columnHeader5.Width = 252;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total Hours";
            this.columnHeader6.Width = 385;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(439, 394);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(112, 36);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSaveToXML
            // 
            this.buttonSaveToXML.Location = new System.Drawing.Point(47, 369);
            this.buttonSaveToXML.Name = "buttonSaveToXML";
            this.buttonSaveToXML.Size = new System.Drawing.Size(112, 36);
            this.buttonSaveToXML.TabIndex = 12;
            this.buttonSaveToXML.Text = "Save";
            this.buttonSaveToXML.UseVisualStyleBackColor = true;
            this.buttonSaveToXML.Click += new System.EventHandler(this.buttonSaveToXML_Click);
            // 
            // btnAssignExit
            // 
            this.btnAssignExit.Location = new System.Drawing.Point(262, 387);
            this.btnAssignExit.Name = "btnAssignExit";
            this.btnAssignExit.Size = new System.Drawing.Size(108, 51);
            this.btnAssignExit.TabIndex = 13;
            this.btnAssignExit.Text = "EXIT";
            this.btnAssignExit.UseVisualStyleBackColor = true;
            this.btnAssignExit.Click += new System.EventHandler(this.btnAssignExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "1st assign the Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "2nd save the assigned Course";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(577, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(327, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(772, 324);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 35);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // comboBoxGridTeacher
            // 
            this.comboBoxGridTeacher.FormattingEnabled = true;
            this.comboBoxGridTeacher.Items.AddRange(new object[] {
            "Tarun_1236",
            "Louis_1234",
            "Hannah_1235",
            "1111",
            "2222",
            "3333"});
            this.comboBoxGridTeacher.Location = new System.Drawing.Point(738, 210);
            this.comboBoxGridTeacher.Name = "comboBoxGridTeacher";
            this.comboBoxGridTeacher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGridTeacher.TabIndex = 18;
            // 
            // comboBoxGridCourse
            // 
            this.comboBoxGridCourse.FormattingEnabled = true;
            this.comboBoxGridCourse.Items.AddRange(new object[] {
            "COMP101,Information Sysytem,90",
            "COMP102,Computer Tools,75",
            "COMP103,Advanced Programming in C# ,75",
            "COMP104,Web Server Application,90",
            "COMP105,Java Development,90",
            "comp101",
            "comp102",
            "comp103"});
            this.comboBoxGridCourse.Location = new System.Drawing.Point(747, 274);
            this.comboBoxGridCourse.Name = "comboBoxGridCourse";
            this.comboBoxGridCourse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGridCourse.TabIndex = 19;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(262, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(284, 141);
            this.dataGridView2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(769, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Teachers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(772, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Course";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Entity Grid View Displays";
            // 
            // FormCourseAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 452);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBoxGridCourse);
            this.Controls.Add(this.comboBoxGridTeacher);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAssignExit);
            this.Controls.Add(this.buttonSaveToXML);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listViewCourse);
            this.Controls.Add(this.listViewTeacher);
            this.Controls.Add(this.buttonListTeacher);
            this.Controls.Add(this.buttonListCourses);
            this.Controls.Add(this.buttonAssignCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxAssignedDate);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.label1);
            this.Name = "FormCourseAssignment";
            this.Text = "SMTI Teacher - Course Management Form";
            this.Load += new System.EventHandler(this.FormCourseAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAssignedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAssignCourse;
        private System.Windows.Forms.Button buttonListCourses;
        private System.Windows.Forms.Button buttonListTeacher;
        private System.Windows.Forms.ListView listViewTeacher;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewCourse;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSaveToXML;
        private System.Windows.Forms.Button btnAssignExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox comboBoxGridTeacher;
        private System.Windows.Forms.ComboBox comboBoxGridCourse;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}