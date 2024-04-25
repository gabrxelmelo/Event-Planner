namespace Event_Planner
{
    partial class AddNewEventForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.locText = new System.Windows.Forms.TextBox();
            this.hostText = new System.Windows.Forms.TextBox();
            this.budNum = new System.Windows.Forms.NumericUpDown();
            this.addPpl = new System.Windows.Forms.Button();
            this.delPpl = new System.Windows.Forms.Button();
            this.addSave = new System.Windows.Forms.Button();
            this.addCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.budNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Budget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Host";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // locText
            // 
            this.locText.Location = new System.Drawing.Point(145, 32);
            this.locText.Name = "locText";
            this.locText.Size = new System.Drawing.Size(125, 20);
            this.locText.TabIndex = 5;
            // 
            // hostText
            // 
            this.hostText.Location = new System.Drawing.Point(145, 146);
            this.hostText.Name = "hostText";
            this.hostText.Size = new System.Drawing.Size(125, 20);
            this.hostText.TabIndex = 7;
            // 
            // budNum
            // 
            this.budNum.Location = new System.Drawing.Point(145, 88);
            this.budNum.Name = "budNum";
            this.budNum.Size = new System.Drawing.Size(120, 20);
            this.budNum.TabIndex = 10;
            // 
            // addPpl
            // 
            this.addPpl.Location = new System.Drawing.Point(500, 49);
            this.addPpl.Name = "addPpl";
            this.addPpl.Size = new System.Drawing.Size(93, 33);
            this.addPpl.TabIndex = 12;
            this.addPpl.Text = "Add Guests";
            this.addPpl.UseVisualStyleBackColor = true;
            this.addPpl.Click += new System.EventHandler(this.addPpl_Click);
            // 
            // delPpl
            // 
            this.delPpl.Location = new System.Drawing.Point(500, 112);
            this.delPpl.Name = "delPpl";
            this.delPpl.Size = new System.Drawing.Size(93, 36);
            this.delPpl.TabIndex = 13;
            this.delPpl.Text = "Delete Guests";
            this.delPpl.UseVisualStyleBackColor = true;
            // 
            // addSave
            // 
            this.addSave.Location = new System.Drawing.Point(38, 354);
            this.addSave.Name = "addSave";
            this.addSave.Size = new System.Drawing.Size(110, 54);
            this.addSave.TabIndex = 14;
            this.addSave.Text = "Save";
            this.addSave.UseVisualStyleBackColor = true;
            this.addSave.Click += new System.EventHandler(this.addSave_Click);
            // 
            // addCancel
            // 
            this.addCancel.Location = new System.Drawing.Point(212, 354);
            this.addCancel.Name = "addCancel";
            this.addCancel.Size = new System.Drawing.Size(110, 54);
            this.addCancel.TabIndex = 15;
            this.addCancel.Text = "Cancel";
            this.addCancel.UseVisualStyleBackColor = true;
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(635, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 238);
            this.textBox1.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // AddNewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.addSave);
            this.Controls.Add(this.delPpl);
            this.Controls.Add(this.addPpl);
            this.Controls.Add(this.budNum);
            this.Controls.Add(this.hostText);
            this.Controls.Add(this.locText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewEvent";
            this.Text = "AddNewEvent";
            ((System.ComponentModel.ISupportInitialize)(this.budNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox locText;
        private System.Windows.Forms.TextBox hostText;
        private System.Windows.Forms.NumericUpDown budNum;
        private System.Windows.Forms.Button addPpl;
        private System.Windows.Forms.Button delPpl;
        private System.Windows.Forms.Button addSave;
        private System.Windows.Forms.Button addCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}