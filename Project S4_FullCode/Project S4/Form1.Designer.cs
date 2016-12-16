namespace Project_S4
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
            this.l_barcode = new System.Windows.Forms.ListBox();
            this.l_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.b_sendAttendance = new System.Windows.Forms.Button();
            this.b_email = new System.Windows.Forms.Button();
            this.b_loadStudents = new System.Windows.Forms.Button();
            this.l_students = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.t_customText = new System.Windows.Forms.TextBox();
            this.b_body = new System.Windows.Forms.Button();
            this.l_customBody = new System.Windows.Forms.Label();
            this.b_useCustom = new System.Windows.Forms.Button();
            this.b_submit = new System.Windows.Forms.Button();
            this.l_timeOfDay = new System.Windows.Forms.Label();
            this.b_chooseCourse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // l_barcode
            // 
            this.l_barcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.l_barcode.FormattingEnabled = true;
            this.l_barcode.Location = new System.Drawing.Point(12, 83);
            this.l_barcode.Name = "l_barcode";
            this.l_barcode.Size = new System.Drawing.Size(274, 147);
            this.l_barcode.TabIndex = 0;
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Location = new System.Drawing.Point(118, 307);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(0, 13);
            this.l_time.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student IDs Scanned:";
            // 
            // b_sendAttendance
            // 
            this.b_sendAttendance.Location = new System.Drawing.Point(12, 265);
            this.b_sendAttendance.Name = "b_sendAttendance";
            this.b_sendAttendance.Size = new System.Drawing.Size(117, 23);
            this.b_sendAttendance.TabIndex = 4;
            this.b_sendAttendance.Text = "Check in Attendance";
            this.b_sendAttendance.UseVisualStyleBackColor = true;
            this.b_sendAttendance.Click += new System.EventHandler(this.b_sendAttendance_Click);
            // 
            // b_email
            // 
            this.b_email.Location = new System.Drawing.Point(135, 265);
            this.b_email.Name = "b_email";
            this.b_email.Size = new System.Drawing.Size(117, 23);
            this.b_email.TabIndex = 7;
            this.b_email.Text = "Send Email";
            this.b_email.UseVisualStyleBackColor = true;
            this.b_email.Click += new System.EventHandler(this.b_email_Click);
            // 
            // b_loadStudents
            // 
            this.b_loadStudents.Location = new System.Drawing.Point(420, 9);
            this.b_loadStudents.Name = "b_loadStudents";
            this.b_loadStudents.Size = new System.Drawing.Size(132, 31);
            this.b_loadStudents.TabIndex = 8;
            this.b_loadStudents.Text = "Load Students";
            this.b_loadStudents.UseVisualStyleBackColor = true;
            this.b_loadStudents.Click += new System.EventHandler(this.b_LoadStudents_Click);
            // 
            // l_students
            // 
            this.l_students.FormattingEnabled = true;
            this.l_students.Location = new System.Drawing.Point(304, 83);
            this.l_students.Name = "l_students";
            this.l_students.Size = new System.Drawing.Size(250, 147);
            this.l_students.TabIndex = 9;
            this.l_students.SelectedIndexChanged += new System.EventHandler(this.l_students_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Course:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(301, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Class:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // t_customText
            // 
            this.t_customText.Location = new System.Drawing.Point(306, 267);
            this.t_customText.Multiline = true;
            this.t_customText.Name = "t_customText";
            this.t_customText.Size = new System.Drawing.Size(250, 116);
            this.t_customText.TabIndex = 16;
            this.t_customText.Visible = false;
            this.t_customText.TextChanged += new System.EventHandler(this.t_customText_TextChanged);
            // 
            // b_body
            // 
            this.b_body.Location = new System.Drawing.Point(12, 236);
            this.b_body.Name = "b_body";
            this.b_body.Size = new System.Drawing.Size(117, 23);
            this.b_body.TabIndex = 17;
            this.b_body.Text = "Use Generic Body";
            this.b_body.UseVisualStyleBackColor = true;
            this.b_body.Click += new System.EventHandler(this.b_body_Click);
            // 
            // l_customBody
            // 
            this.l_customBody.AutoSize = true;
            this.l_customBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_customBody.Location = new System.Drawing.Point(303, 248);
            this.l_customBody.Name = "l_customBody";
            this.l_customBody.Size = new System.Drawing.Size(99, 16);
            this.l_customBody.TabIndex = 18;
            this.l_customBody.Text = "Custom Body";
            this.l_customBody.Visible = false;
            this.l_customBody.Click += new System.EventHandler(this.l_customBody_Click);
            // 
            // b_useCustom
            // 
            this.b_useCustom.Location = new System.Drawing.Point(135, 236);
            this.b_useCustom.Name = "b_useCustom";
            this.b_useCustom.Size = new System.Drawing.Size(117, 23);
            this.b_useCustom.TabIndex = 19;
            this.b_useCustom.Text = "Use Custom Body";
            this.b_useCustom.UseVisualStyleBackColor = true;
            this.b_useCustom.Click += new System.EventHandler(this.b_useCustom_Click);
            // 
            // b_submit
            // 
            this.b_submit.Location = new System.Drawing.Point(306, 389);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(250, 23);
            this.b_submit.TabIndex = 20;
            this.b_submit.Text = "Submit Custom Text";
            this.b_submit.UseVisualStyleBackColor = true;
            this.b_submit.Visible = false;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // l_timeOfDay
            // 
            this.l_timeOfDay.AutoSize = true;
            this.l_timeOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_timeOfDay.Location = new System.Drawing.Point(9, 304);
            this.l_timeOfDay.Name = "l_timeOfDay";
            this.l_timeOfDay.Size = new System.Drawing.Size(92, 16);
            this.l_timeOfDay.TabIndex = 21;
            this.l_timeOfDay.Text = "Time of Day";
            // 
            // b_chooseCourse
            // 
            this.b_chooseCourse.Location = new System.Drawing.Point(102, 17);
            this.b_chooseCourse.Name = "b_chooseCourse";
            this.b_chooseCourse.Size = new System.Drawing.Size(106, 23);
            this.b_chooseCourse.TabIndex = 22;
            this.b_chooseCourse.Text = "Choose Course";
            this.b_chooseCourse.UseVisualStyleBackColor = true;
            this.b_chooseCourse.Click += new System.EventHandler(this.b_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 429);
            this.Controls.Add(this.b_chooseCourse);
            this.Controls.Add(this.l_timeOfDay);
            this.Controls.Add(this.b_submit);
            this.Controls.Add(this.b_useCustom);
            this.Controls.Add(this.l_customBody);
            this.Controls.Add(this.b_body);
            this.Controls.Add(this.t_customText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l_students);
            this.Controls.Add(this.b_loadStudents);
            this.Controls.Add(this.b_email);
            this.Controls.Add(this.b_sendAttendance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_time);
            this.Controls.Add(this.l_barcode);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "SP4 Attendance System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox l_barcode;
        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_sendAttendance;
        private System.Windows.Forms.Button b_email;
        private System.Windows.Forms.Button b_loadStudents;
        private System.Windows.Forms.ListBox l_students;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox t_customText;
        private System.Windows.Forms.Button b_body;
        private System.Windows.Forms.Label l_customBody;
        private System.Windows.Forms.Button b_useCustom;
        private System.Windows.Forms.Button b_submit;
        private System.Windows.Forms.Label l_timeOfDay;
        private System.Windows.Forms.Button b_chooseCourse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

