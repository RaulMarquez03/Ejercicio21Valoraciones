namespace Ejercicio21Valoraciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedHour = new System.Windows.Forms.MaskedTextBox();
            this.maskedId = new System.Windows.Forms.MaskedTextBox();
            this.maskedPhone = new System.Windows.Forms.MaskedTextBox();
            this.maskedCar = new System.Windows.Forms.MaskedTextBox();
            this.maskedValue = new System.Windows.Forms.MaskedTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxInf = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Car registration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sale value";
            // 
            // maskedDate
            // 
            this.maskedDate.Location = new System.Drawing.Point(228, 50);
            this.maskedDate.Mask = "00/00/0000";
            this.maskedDate.Name = "maskedDate";
            this.maskedDate.Size = new System.Drawing.Size(125, 27);
            this.maskedDate.TabIndex = 6;
            this.maskedDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedHour
            // 
            this.maskedHour.Location = new System.Drawing.Point(228, 94);
            this.maskedHour.Mask = "00:00";
            this.maskedHour.Name = "maskedHour";
            this.maskedHour.Size = new System.Drawing.Size(125, 27);
            this.maskedHour.TabIndex = 7;
            this.maskedHour.ValidatingType = typeof(System.DateTime);
            // 
            // maskedId
            // 
            this.maskedId.Location = new System.Drawing.Point(228, 143);
            this.maskedId.Mask = "V99999999";
            this.maskedId.Name = "maskedId";
            this.maskedId.Size = new System.Drawing.Size(125, 27);
            this.maskedId.TabIndex = 8;
            this.maskedId.ValidatingType = typeof(int);
            // 
            // maskedPhone
            // 
            this.maskedPhone.Location = new System.Drawing.Point(563, 57);
            this.maskedPhone.Mask = "000-000-000";
            this.maskedPhone.Name = "maskedPhone";
            this.maskedPhone.Size = new System.Drawing.Size(125, 27);
            this.maskedPhone.TabIndex = 9;
            // 
            // maskedCar
            // 
            this.maskedCar.Location = new System.Drawing.Point(563, 99);
            this.maskedCar.Mask = "000LLL";
            this.maskedCar.Name = "maskedCar";
            this.maskedCar.Size = new System.Drawing.Size(125, 27);
            this.maskedCar.TabIndex = 10;
            this.maskedCar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox5_MaskInputRejected);
            this.maskedCar.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // maskedValue
            // 
            this.maskedValue.Location = new System.Drawing.Point(563, 146);
            this.maskedValue.Mask = "000000,00€";
            this.maskedValue.Name = "maskedValue";
            this.maskedValue.Size = new System.Drawing.Size(125, 27);
            this.maskedValue.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(336, 212);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxInf
            // 
            this.listBoxInf.FormattingEnabled = true;
            this.listBoxInf.ItemHeight = 20;
            this.listBoxInf.Location = new System.Drawing.Point(62, 284);
            this.listBoxInf.Name = "listBoxInf";
            this.listBoxInf.Size = new System.Drawing.Size(633, 144);
            this.listBoxInf.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxInf);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.maskedValue);
            this.Controls.Add(this.maskedCar);
            this.Controls.Add(this.maskedPhone);
            this.Controls.Add(this.maskedId);
            this.Controls.Add(this.maskedHour);
            this.Controls.Add(this.maskedDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox maskedDate;
        private MaskedTextBox maskedHour;
        private MaskedTextBox maskedId;
        private MaskedTextBox maskedPhone;
        private MaskedTextBox maskedCar;
        private MaskedTextBox maskedValue;
        private Button buttonSave;
        private ListBox listBoxInf;
    }
}