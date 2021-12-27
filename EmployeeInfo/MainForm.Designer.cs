
namespace EmployeeInfo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonHireEmployee = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.buttonFireEmployee = new System.Windows.Forms.Button();
            this.checkBoxHideFiredEmployees = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersVisible = false;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(821, 464);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // buttonHireEmployee
            // 
            this.buttonHireEmployee.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonHireEmployee.Location = new System.Drawing.Point(12, 11);
            this.buttonHireEmployee.Name = "buttonHireEmployee";
            this.buttonHireEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonHireEmployee.TabIndex = 1;
            this.buttonHireEmployee.Text = "Zatrudnij";
            this.buttonHireEmployee.UseVisualStyleBackColor = false;
            this.buttonHireEmployee.Click += new System.EventHandler(this.buttonHireEmployee_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.BackColor = System.Drawing.Color.Orange;
            this.buttonEditEmployee.Location = new System.Drawing.Point(93, 11);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonEditEmployee.TabIndex = 2;
            this.buttonEditEmployee.Text = "Edytuj";
            this.buttonEditEmployee.UseVisualStyleBackColor = false;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // buttonFireEmployee
            // 
            this.buttonFireEmployee.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonFireEmployee.Location = new System.Drawing.Point(174, 12);
            this.buttonFireEmployee.Name = "buttonFireEmployee";
            this.buttonFireEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonFireEmployee.TabIndex = 3;
            this.buttonFireEmployee.Text = "Zwolnij";
            this.buttonFireEmployee.UseVisualStyleBackColor = false;
            this.buttonFireEmployee.Click += new System.EventHandler(this.buttonFireEmployee_Click);
            // 
            // checkBoxHideFiredEmployees
            // 
            this.checkBoxHideFiredEmployees.AutoSize = true;
            this.checkBoxHideFiredEmployees.Location = new System.Drawing.Point(255, 15);
            this.checkBoxHideFiredEmployees.Name = "checkBoxHideFiredEmployees";
            this.checkBoxHideFiredEmployees.Size = new System.Drawing.Size(111, 17);
            this.checkBoxHideFiredEmployees.TabIndex = 4;
            this.checkBoxHideFiredEmployees.Text = "Ukryj zwolnionych";
            this.checkBoxHideFiredEmployees.UseVisualStyleBackColor = true;
            this.checkBoxHideFiredEmployees.CheckedChanged += new System.EventHandler(this.checkBoxHideFiredEmployees_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 516);
            this.Controls.Add(this.checkBoxHideFiredEmployees);
            this.Controls.Add(this.buttonFireEmployee);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonHireEmployee);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pracownicy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonHireEmployee;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonFireEmployee;
        private System.Windows.Forms.CheckBox checkBoxHideFiredEmployees;
    }
}

