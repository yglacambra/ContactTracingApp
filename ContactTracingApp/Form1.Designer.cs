namespace ContactTracingApp
{
    partial class ContactTracingAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracingAppForm));
            this.LblName = new System.Windows.Forms.Label();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LblHomeAddress = new System.Windows.Forms.Label();
            this.TxtBoxHomeAddress = new System.Windows.Forms.TextBox();
            this.LblContactNum = new System.Windows.Forms.Label();
            this.TxtBoxContactNum = new System.Windows.Forms.TextBox();
            this.LblTimeEntered = new System.Windows.Forms.Label();
            this.LbllTEColon = new System.Windows.Forms.Label();
            this.BtnHourTimeEntered = new System.Windows.Forms.Button();
            this.BtnMinuteTimeEntered = new System.Windows.Forms.Button();
            this.LblTimeLeft = new System.Windows.Forms.Label();
            this.BtnMinuteTimeLeft = new System.Windows.Forms.Button();
            this.BtnHourTimeLeft = new System.Windows.Forms.Button();
            this.LblTLColon = new System.Windows.Forms.Label();
            this.LblDateVisited = new System.Windows.Forms.Label();
            this.BtnMonthVisited = new System.Windows.Forms.Button();
            this.LblComma = new System.Windows.Forms.Label();
            this.BtnDayVisited = new System.Windows.Forms.Button();
            this.TxtBoxYearVisited = new System.Windows.Forms.TextBox();
            this.LblGender = new System.Windows.Forms.Label();
            this.RdioBtnMale = new System.Windows.Forms.RadioButton();
            this.RdioBtnFemale = new System.Windows.Forms.RadioButton();
            this.RdioBttonOtherGenders = new System.Windows.Forms.RadioButton();
            this.TxtBoxOtherGenders = new System.Windows.Forms.TextBox();
            this.LblSpecify = new System.Windows.Forms.Label();
            this.RdioButtonQ1Yes = new System.Windows.Forms.RadioButton();
            this.RdioButtonQ1No = new System.Windows.Forms.RadioButton();
            this.LblQuestion1 = new System.Windows.Forms.Label();
            this.LblQuestion2 = new System.Windows.Forms.Label();
            this.RdioButtonQ2Yes = new System.Windows.Forms.RadioButton();
            this.RdioButtonQ2No = new System.Windows.Forms.RadioButton();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.SystemColors.Control;
            this.LblName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblName.Location = new System.Drawing.Point(12, 24);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(72, 23);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name:";
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxName.Location = new System.Drawing.Point(23, 50);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(283, 27);
            this.TxtBoxName.TabIndex = 1;
            // 
            // LblHomeAddress
            // 
            this.LblHomeAddress.AutoSize = true;
            this.LblHomeAddress.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHomeAddress.Location = new System.Drawing.Point(12, 88);
            this.LblHomeAddress.Name = "LblHomeAddress";
            this.LblHomeAddress.Size = new System.Drawing.Size(155, 23);
            this.LblHomeAddress.TabIndex = 2;
            this.LblHomeAddress.Text = "Home Address:";
            // 
            // TxtBoxHomeAddress
            // 
            this.TxtBoxHomeAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxHomeAddress.Location = new System.Drawing.Point(23, 114);
            this.TxtBoxHomeAddress.Name = "TxtBoxHomeAddress";
            this.TxtBoxHomeAddress.Size = new System.Drawing.Size(283, 27);
            this.TxtBoxHomeAddress.TabIndex = 3;
            // 
            // LblContactNum
            // 
            this.LblContactNum.AutoSize = true;
            this.LblContactNum.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblContactNum.Location = new System.Drawing.Point(12, 149);
            this.LblContactNum.Name = "LblContactNum";
            this.LblContactNum.Size = new System.Drawing.Size(173, 23);
            this.LblContactNum.TabIndex = 4;
            this.LblContactNum.Text = "Contact Number:";
            // 
            // TxtBoxContactNum
            // 
            this.TxtBoxContactNum.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxContactNum.Location = new System.Drawing.Point(23, 175);
            this.TxtBoxContactNum.Name = "TxtBoxContactNum";
            this.TxtBoxContactNum.Size = new System.Drawing.Size(283, 27);
            this.TxtBoxContactNum.TabIndex = 5;
            // 
            // LblTimeEntered
            // 
            this.LblTimeEntered.AutoSize = true;
            this.LblTimeEntered.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTimeEntered.Location = new System.Drawing.Point(417, 88);
            this.LblTimeEntered.Name = "LblTimeEntered";
            this.LblTimeEntered.Size = new System.Drawing.Size(144, 23);
            this.LblTimeEntered.TabIndex = 6;
            this.LblTimeEntered.Text = "Time Entered:";
            // 
            // LbllTEColon
            // 
            this.LbllTEColon.AutoSize = true;
            this.LbllTEColon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbllTEColon.Location = new System.Drawing.Point(491, 118);
            this.LbllTEColon.Name = "LbllTEColon";
            this.LbllTEColon.Size = new System.Drawing.Size(15, 23);
            this.LbllTEColon.TabIndex = 9;
            this.LbllTEColon.Text = ":";
            // 
            // BtnHourTimeEntered
            // 
            this.BtnHourTimeEntered.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnHourTimeEntered.Location = new System.Drawing.Point(449, 116);
            this.BtnHourTimeEntered.Name = "BtnHourTimeEntered";
            this.BtnHourTimeEntered.Size = new System.Drawing.Size(36, 29);
            this.BtnHourTimeEntered.TabIndex = 10;
            this.BtnHourTimeEntered.Text = "00";
            this.BtnHourTimeEntered.UseVisualStyleBackColor = true;
            // 
            // BtnMinuteTimeEntered
            // 
            this.BtnMinuteTimeEntered.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMinuteTimeEntered.Location = new System.Drawing.Point(512, 116);
            this.BtnMinuteTimeEntered.Name = "BtnMinuteTimeEntered";
            this.BtnMinuteTimeEntered.Size = new System.Drawing.Size(36, 29);
            this.BtnMinuteTimeEntered.TabIndex = 11;
            this.BtnMinuteTimeEntered.Text = "00";
            this.BtnMinuteTimeEntered.UseVisualStyleBackColor = true;
            // 
            // LblTimeLeft
            // 
            this.LblTimeLeft.AutoSize = true;
            this.LblTimeLeft.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTimeLeft.Location = new System.Drawing.Point(417, 152);
            this.LblTimeLeft.Name = "LblTimeLeft";
            this.LblTimeLeft.Size = new System.Drawing.Size(107, 23);
            this.LblTimeLeft.TabIndex = 12;
            this.LblTimeLeft.Text = "Time Left:";
            // 
            // BtnMinuteTimeLeft
            // 
            this.BtnMinuteTimeLeft.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMinuteTimeLeft.Location = new System.Drawing.Point(512, 182);
            this.BtnMinuteTimeLeft.Name = "BtnMinuteTimeLeft";
            this.BtnMinuteTimeLeft.Size = new System.Drawing.Size(36, 29);
            this.BtnMinuteTimeLeft.TabIndex = 15;
            this.BtnMinuteTimeLeft.Text = "00";
            this.BtnMinuteTimeLeft.UseVisualStyleBackColor = true;
            // 
            // BtnHourTimeLeft
            // 
            this.BtnHourTimeLeft.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnHourTimeLeft.Location = new System.Drawing.Point(449, 180);
            this.BtnHourTimeLeft.Name = "BtnHourTimeLeft";
            this.BtnHourTimeLeft.Size = new System.Drawing.Size(36, 29);
            this.BtnHourTimeLeft.TabIndex = 14;
            this.BtnHourTimeLeft.Text = "00";
            this.BtnHourTimeLeft.UseVisualStyleBackColor = true;
            // 
            // LblTLColon
            // 
            this.LblTLColon.AutoSize = true;
            this.LblTLColon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTLColon.Location = new System.Drawing.Point(491, 182);
            this.LblTLColon.Name = "LblTLColon";
            this.LblTLColon.Size = new System.Drawing.Size(15, 23);
            this.LblTLColon.TabIndex = 13;
            this.LblTLColon.Text = ":";
            // 
            // LblDateVisited
            // 
            this.LblDateVisited.AutoSize = true;
            this.LblDateVisited.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDateVisited.Location = new System.Drawing.Point(417, 24);
            this.LblDateVisited.Name = "LblDateVisited";
            this.LblDateVisited.Size = new System.Drawing.Size(133, 23);
            this.LblDateVisited.TabIndex = 16;
            this.LblDateVisited.Text = "Date Visited:";
            // 
            // BtnMonthVisited
            // 
            this.BtnMonthVisited.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMonthVisited.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMonthVisited.Location = new System.Drawing.Point(449, 50);
            this.BtnMonthVisited.Name = "BtnMonthVisited";
            this.BtnMonthVisited.Size = new System.Drawing.Size(101, 29);
            this.BtnMonthVisited.TabIndex = 17;
            this.BtnMonthVisited.Text = "January";
            this.BtnMonthVisited.UseVisualStyleBackColor = true;
            this.BtnMonthVisited.Click += new System.EventHandler(this.BtnMonthVisited_Click);
            // 
            // LblComma
            // 
            this.LblComma.AutoSize = true;
            this.LblComma.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblComma.Location = new System.Drawing.Point(586, 56);
            this.LblComma.Name = "LblComma";
            this.LblComma.Size = new System.Drawing.Size(15, 23);
            this.LblComma.TabIndex = 18;
            this.LblComma.Text = ",";
            // 
            // BtnDayVisited
            // 
            this.BtnDayVisited.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDayVisited.Location = new System.Drawing.Point(556, 50);
            this.BtnDayVisited.Name = "BtnDayVisited";
            this.BtnDayVisited.Size = new System.Drawing.Size(36, 29);
            this.BtnDayVisited.TabIndex = 19;
            this.BtnDayVisited.Text = "00";
            this.BtnDayVisited.UseVisualStyleBackColor = true;
            // 
            // TxtBoxYearVisited
            // 
            this.TxtBoxYearVisited.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxYearVisited.Location = new System.Drawing.Point(606, 50);
            this.TxtBoxYearVisited.Name = "TxtBoxYearVisited";
            this.TxtBoxYearVisited.Size = new System.Drawing.Size(59, 27);
            this.TxtBoxYearVisited.TabIndex = 20;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblGender.Location = new System.Drawing.Point(12, 227);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(85, 23);
            this.LblGender.TabIndex = 23;
            this.LblGender.Text = "Gender:";
            // 
            // RdioBtnMale
            // 
            this.RdioBtnMale.AutoSize = true;
            this.RdioBtnMale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnMale.Location = new System.Drawing.Point(23, 253);
            this.RdioBtnMale.Name = "RdioBtnMale";
            this.RdioBtnMale.Size = new System.Drawing.Size(60, 23);
            this.RdioBtnMale.TabIndex = 24;
            this.RdioBtnMale.TabStop = true;
            this.RdioBtnMale.Text = "Male";
            this.RdioBtnMale.UseVisualStyleBackColor = true;
            // 
            // RdioBtnFemale
            // 
            this.RdioBtnFemale.AutoSize = true;
            this.RdioBtnFemale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBtnFemale.Location = new System.Drawing.Point(23, 282);
            this.RdioBtnFemale.Name = "RdioBtnFemale";
            this.RdioBtnFemale.Size = new System.Drawing.Size(74, 23);
            this.RdioBtnFemale.TabIndex = 25;
            this.RdioBtnFemale.TabStop = true;
            this.RdioBtnFemale.Text = "Female";
            this.RdioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // RdioBttonOtherGenders
            // 
            this.RdioBttonOtherGenders.AutoSize = true;
            this.RdioBttonOtherGenders.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioBttonOtherGenders.Location = new System.Drawing.Point(23, 311);
            this.RdioBttonOtherGenders.Name = "RdioBttonOtherGenders";
            this.RdioBttonOtherGenders.Size = new System.Drawing.Size(75, 23);
            this.RdioBttonOtherGenders.TabIndex = 28;
            this.RdioBttonOtherGenders.TabStop = true;
            this.RdioBttonOtherGenders.Text = "Others,";
            this.RdioBttonOtherGenders.UseVisualStyleBackColor = true;
            // 
            // TxtBoxOtherGenders
            // 
            this.TxtBoxOtherGenders.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxOtherGenders.Location = new System.Drawing.Point(195, 311);
            this.TxtBoxOtherGenders.Name = "TxtBoxOtherGenders";
            this.TxtBoxOtherGenders.Size = new System.Drawing.Size(89, 27);
            this.TxtBoxOtherGenders.TabIndex = 29;
            // 
            // LblSpecify
            // 
            this.LblSpecify.AutoSize = true;
            this.LblSpecify.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSpecify.Location = new System.Drawing.Point(92, 313);
            this.LblSpecify.Name = "LblSpecify";
            this.LblSpecify.Size = new System.Drawing.Size(106, 19);
            this.LblSpecify.TabIndex = 30;
            this.LblSpecify.Text = "Please Specify:";
            // 
            // RdioButtonQ1Yes
            // 
            this.RdioButtonQ1Yes.AutoSize = true;
            this.RdioButtonQ1Yes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioButtonQ1Yes.Location = new System.Drawing.Point(425, 253);
            this.RdioButtonQ1Yes.Name = "RdioButtonQ1Yes";
            this.RdioButtonQ1Yes.Size = new System.Drawing.Size(49, 23);
            this.RdioButtonQ1Yes.TabIndex = 31;
            this.RdioButtonQ1Yes.TabStop = true;
            this.RdioButtonQ1Yes.Text = "Yes";
            this.RdioButtonQ1Yes.UseVisualStyleBackColor = true;
            // 
            // RdioButtonQ1No
            // 
            this.RdioButtonQ1No.AutoSize = true;
            this.RdioButtonQ1No.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioButtonQ1No.Location = new System.Drawing.Point(425, 282);
            this.RdioButtonQ1No.Name = "RdioButtonQ1No";
            this.RdioButtonQ1No.Size = new System.Drawing.Size(45, 23);
            this.RdioButtonQ1No.TabIndex = 32;
            this.RdioButtonQ1No.TabStop = true;
            this.RdioButtonQ1No.Text = "No";
            this.RdioButtonQ1No.UseVisualStyleBackColor = true;
            // 
            // LblQuestion1
            // 
            this.LblQuestion1.AutoSize = true;
            this.LblQuestion1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblQuestion1.Location = new System.Drawing.Point(417, 227);
            this.LblQuestion1.Name = "LblQuestion1";
            this.LblQuestion1.Size = new System.Drawing.Size(449, 19);
            this.LblQuestion1.TabIndex = 33;
            this.LblQuestion1.Text = "Are you experiencing COVID-like symptoms for the past 13 days?";
            // 
            // LblQuestion2
            // 
            this.LblQuestion2.AutoSize = true;
            this.LblQuestion2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblQuestion2.Location = new System.Drawing.Point(417, 319);
            this.LblQuestion2.Name = "LblQuestion2";
            this.LblQuestion2.Size = new System.Drawing.Size(449, 19);
            this.LblQuestion2.TabIndex = 34;
            this.LblQuestion2.Text = "Are you experiencing COVID-like symptoms for the past 13 days?";
            // 
            // RdioButtonQ2Yes
            // 
            this.RdioButtonQ2Yes.AutoSize = true;
            this.RdioButtonQ2Yes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioButtonQ2Yes.Location = new System.Drawing.Point(425, 341);
            this.RdioButtonQ2Yes.Name = "RdioButtonQ2Yes";
            this.RdioButtonQ2Yes.Size = new System.Drawing.Size(49, 23);
            this.RdioButtonQ2Yes.TabIndex = 35;
            this.RdioButtonQ2Yes.TabStop = true;
            this.RdioButtonQ2Yes.Text = "Yes";
            this.RdioButtonQ2Yes.UseVisualStyleBackColor = true;
            // 
            // RdioButtonQ2No
            // 
            this.RdioButtonQ2No.AutoSize = true;
            this.RdioButtonQ2No.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdioButtonQ2No.Location = new System.Drawing.Point(425, 370);
            this.RdioButtonQ2No.Name = "RdioButtonQ2No";
            this.RdioButtonQ2No.Size = new System.Drawing.Size(45, 23);
            this.RdioButtonQ2No.TabIndex = 36;
            this.RdioButtonQ2No.TabStop = true;
            this.RdioButtonQ2No.Text = "No";
            this.RdioButtonQ2No.UseVisualStyleBackColor = true;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSubmit.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.Location = new System.Drawing.Point(363, 415);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(113, 36);
            this.BtnSubmit.TabIndex = 37;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            // 
            // ContactTracingAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 459);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.RdioButtonQ2No);
            this.Controls.Add(this.RdioButtonQ2Yes);
            this.Controls.Add(this.LblQuestion2);
            this.Controls.Add(this.LblQuestion1);
            this.Controls.Add(this.RdioButtonQ1No);
            this.Controls.Add(this.RdioButtonQ1Yes);
            this.Controls.Add(this.LblSpecify);
            this.Controls.Add(this.TxtBoxOtherGenders);
            this.Controls.Add(this.RdioBttonOtherGenders);
            this.Controls.Add(this.RdioBtnFemale);
            this.Controls.Add(this.RdioBtnMale);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.TxtBoxYearVisited);
            this.Controls.Add(this.BtnDayVisited);
            this.Controls.Add(this.LblComma);
            this.Controls.Add(this.BtnMonthVisited);
            this.Controls.Add(this.LblDateVisited);
            this.Controls.Add(this.BtnMinuteTimeLeft);
            this.Controls.Add(this.BtnHourTimeLeft);
            this.Controls.Add(this.LblTLColon);
            this.Controls.Add(this.LblTimeLeft);
            this.Controls.Add(this.BtnMinuteTimeEntered);
            this.Controls.Add(this.BtnHourTimeEntered);
            this.Controls.Add(this.LbllTEColon);
            this.Controls.Add(this.LblTimeEntered);
            this.Controls.Add(this.TxtBoxContactNum);
            this.Controls.Add(this.LblContactNum);
            this.Controls.Add(this.TxtBoxHomeAddress);
            this.Controls.Add(this.LblHomeAddress);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.LblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContactTracingAppForm";
            this.Text = "YGL Mall Contact Tracing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblName;
        private TextBox TxtBoxName;
        private Label LblHomeAddress;
        private TextBox TxtBoxHomeAddress;
        private Label LblContactNum;
        private TextBox TxtBoxContactNum;
        private Label LblTimeEntered;
        private Label LbllTEColon;
        private Button BtnHourTimeEntered;
        private Button BtnMinuteTimeEntered;
        private Label LblTimeLeft;
        private Button BtnMinuteTimeLeft;
        private Button BtnHourTimeLeft;
        private Label LblTLColon;
        private Label LblDateVisited;
        private Button BtnMonthVisited;
        private Label LblComma;
        private Button BtnDayVisited;
        private TextBox TxtBoxYearVisited;
        private Label LblGender;
        private RadioButton RdioBtnMale;
        private RadioButton RdioBtnFemale;
        private RadioButton RdioBttonOtherGenders;
        private TextBox TxtBoxOtherGenders;
        private Label LblSpecify;
        private RadioButton RdioButtonQ1Yes;
        private RadioButton RdioButtonQ1No;
        private Label LblQuestion1;
        private Label LblQuestion2;
        private RadioButton RdioButtonQ2Yes;
        private RadioButton RdioButtonQ2No;
        private Button BtnSubmit;
    }
}