
namespace EmployeeInfo
{
    partial class FireEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FireEmployeeForm));
            this.checkBoxFired = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFireDate = new System.Windows.Forms.DateTimePicker();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxFired
            // 
            this.checkBoxFired.AutoSize = true;
            this.checkBoxFired.Location = new System.Drawing.Point(12, 12);
            this.checkBoxFired.Name = "checkBoxFired";
            this.checkBoxFired.Size = new System.Drawing.Size(74, 17);
            this.checkBoxFired.TabIndex = 0;
            this.checkBoxFired.Text = "Zwolniony";
            this.checkBoxFired.UseVisualStyleBackColor = true;
            this.checkBoxFired.CheckedChanged += new System.EventHandler(this.checkBoxFired_CheckedChanged);
            // 
            // dateTimePickerFireDate
            // 
            this.dateTimePickerFireDate.Location = new System.Drawing.Point(12, 44);
            this.dateTimePickerFireDate.Name = "dateTimePickerFireDate";
            this.dateTimePickerFireDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFireDate.TabIndex = 1;
            this.dateTimePickerFireDate.Visible = false;
            this.dateTimePickerFireDate.ValueChanged += new System.EventHandler(this.dateTimePickerFireDate_ValueChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(11, 83);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(201, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // FireEmployeeForm
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(232, 129);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dateTimePickerFireDate);
            this.Controls.Add(this.checkBoxFired);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FireEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zwolnij pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFired;
        private System.Windows.Forms.DateTimePicker dateTimePickerFireDate;
        private System.Windows.Forms.Button buttonClose;
    }
}