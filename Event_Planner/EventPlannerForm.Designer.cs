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
            this.deleteBut = new System.Windows.Forms.Button();
            this.closeBut = new System.Windows.Forms.Button();
            this.Upcoming = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Upcoming)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upcoming Events";
            // 
            // addBut
            // 
            this.addBut.Location = new System.Drawing.Point(861, 122);
            this.addBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(165, 118);
            this.addBut.TabIndex = 2;
            this.addBut.Text = "Add";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // deleteBut
            // 
            this.deleteBut.Location = new System.Drawing.Point(861, 294);
            this.deleteBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.Size = new System.Drawing.Size(165, 118);
            this.deleteBut.TabIndex = 3;
            this.deleteBut.Text = "Delete";
            this.deleteBut.UseVisualStyleBackColor = true;
            // 
            // closeBut
            // 
            this.closeBut.Location = new System.Drawing.Point(861, 460);
            this.closeBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(165, 118);
            this.closeBut.TabIndex = 4;
            this.closeBut.Text = "Close";
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // Upcoming
            // 
            this.Upcoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Upcoming.Location = new System.Drawing.Point(36, 122);
            this.Upcoming.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Upcoming.Name = "Upcoming";
            this.Upcoming.RowHeadersWidth = 62;
            this.Upcoming.Size = new System.Drawing.Size(666, 457);
            this.Upcoming.TabIndex = 5;
            this.Upcoming.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Upcoming_CellContentClick);
            // 
            // EventPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 698);
            this.Controls.Add(this.Upcoming);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.deleteBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EventPlanner";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Upcoming)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button deleteBut;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.DataGridView Upcoming;
    }
}

