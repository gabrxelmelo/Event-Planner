namespace Event_Planner
{
    partial class EventPlannerForm
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
            this.addBut = new System.Windows.Forms.Button();
            this.closeBut = new System.Windows.Forms.Button();
            this.upcomingDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upcoming Events";
            // 
            // addBut
            // 
            this.addBut.Location = new System.Drawing.Point(885, 63);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(110, 77);
            this.addBut.TabIndex = 2;
            this.addBut.Text = "Add";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // closeBut
            // 
            this.closeBut.Location = new System.Drawing.Point(885, 283);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(110, 77);
            this.closeBut.TabIndex = 4;
            this.closeBut.Text = "Close";
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // upcomingDataGridView
            // 
            this.upcomingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upcomingDataGridView.Location = new System.Drawing.Point(24, 79);
            this.upcomingDataGridView.Name = "upcomingDataGridView";
            this.upcomingDataGridView.RowHeadersWidth = 62;
            this.upcomingDataGridView.Size = new System.Drawing.Size(751, 297);
            this.upcomingDataGridView.TabIndex = 5;
            this.upcomingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Upcoming_CellContentClick);
            // 
            // EventPlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 475);
            this.Controls.Add(this.upcomingDataGridView);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.label1);
            this.Name = "EventPlannerForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.upcomingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.DataGridView upcomingDataGridView;
    }
}

