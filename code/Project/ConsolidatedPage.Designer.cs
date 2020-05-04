namespace Project
{
    partial class ConsolidatedPage
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
            this.Name_Department = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_Department
            // 
            this.Name_Department.AccessibleDescription = "NameDepartment";
            this.Name_Department.AccessibleName = "NameDepartment";
            this.Name_Department.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Name_Department.AutoSize = true;
            this.Name_Department.Location = new System.Drawing.Point(82, 31);
            this.Name_Department.Name = "Name_Department";
            this.Name_Department.Size = new System.Drawing.Size(93, 13);
            this.Name_Department.TabIndex = 0;
            this.Name_Department.Text = "Name Department";
            // 
            // ConsolidatedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Name_Department);
            this.Name = "ConsolidatedPage";
            this.Text = "ConsolidatedPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Department;
    }
}