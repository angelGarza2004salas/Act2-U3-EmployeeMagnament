namespace EmployeeManagement
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPosition = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.BtnAddEmploye = new System.Windows.Forms.Button();
            this.LblEmployeeCount = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.LblSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(212, 79);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 0;
            // 
            // TxtPosition
            // 
            this.TxtPosition.Location = new System.Drawing.Point(212, 148);
            this.TxtPosition.Name = "TxtPosition";
            this.TxtPosition.Size = new System.Drawing.Size(100, 22);
            this.TxtPosition.TabIndex = 1;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(212, 212);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 22);
            this.TxtId.TabIndex = 2;
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(212, 285);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(100, 22);
            this.TxtSalary.TabIndex = 3;
            // 
            // BtnAddEmploye
            // 
            this.BtnAddEmploye.Location = new System.Drawing.Point(105, 342);
            this.BtnAddEmploye.Name = "BtnAddEmploye";
            this.BtnAddEmploye.Size = new System.Drawing.Size(116, 34);
            this.BtnAddEmploye.TabIndex = 4;
            this.BtnAddEmploye.Text = "Add Employee";
            this.BtnAddEmploye.UseVisualStyleBackColor = true;
            this.BtnAddEmploye.Click += new System.EventHandler(this.BtnAddEmploye_Click);
            // 
            // LblEmployeeCount
            // 
            this.LblEmployeeCount.AutoSize = true;
            this.LblEmployeeCount.Location = new System.Drawing.Point(114, 405);
            this.LblEmployeeCount.Name = "LblEmployeeCount";
            this.LblEmployeeCount.Size = new System.Drawing.Size(110, 16);
            this.LblEmployeeCount.TabIndex = 5;
            this.LblEmployeeCount.Text = "EmployeeAcount";
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(102, 154);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(55, 16);
            this.LblPosition.TabIndex = 6;
            this.LblPosition.Text = "Position";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(102, 85);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 16);
            this.LblName.TabIndex = 7;
            this.LblName.Text = "Name";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(102, 218);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(20, 16);
            this.LblId.TabIndex = 8;
            this.LblId.Text = "ID";
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Location = new System.Drawing.Point(102, 288);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(46, 16);
            this.LblSalary.TabIndex = 9;
            this.LblSalary.Text = "Salary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblSalary);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.LblEmployeeCount);
            this.Controls.Add(this.BtnAddEmploye);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtPosition);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPosition;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.Button BtnAddEmploye;
        private System.Windows.Forms.Label LblEmployeeCount;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblSalary;
    }
}

