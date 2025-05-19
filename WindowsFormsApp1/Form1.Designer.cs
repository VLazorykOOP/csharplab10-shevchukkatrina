using System.Drawing;

namespace MilitaryActionsGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAttackA;
        private System.Windows.Forms.Button btnAttackB;
        private System.Windows.Forms.TextBox txtLog;

        // Нові контролі:
        private System.Windows.Forms.ProgressBar progressBarA;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.Label lblHealthA;
        private System.Windows.Forms.Label lblHealthB;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAttackA = new System.Windows.Forms.Button();
            this.btnAttackB = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.lblHealthA = new System.Windows.Forms.Label();
            this.lblHealthB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAttackA
            // 
            this.btnAttackA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnAttackA.Location = new System.Drawing.Point(30, 20);
            this.btnAttackA.Name = "btnAttackA";
            this.btnAttackA.Size = new System.Drawing.Size(150, 40);
            this.btnAttackA.TabIndex = 0;
            this.btnAttackA.Text = "Воїн A";
            this.btnAttackA.UseVisualStyleBackColor = true;
            this.btnAttackA.Click += new System.EventHandler(this.btnAttackA_Click);
            // 
            // btnAttackB
            // 
            this.btnAttackB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnAttackB.Location = new System.Drawing.Point(200, 20);
            this.btnAttackB.Name = "btnAttackB";
            this.btnAttackB.Size = new System.Drawing.Size(150, 40);
            this.btnAttackB.TabIndex = 1;
            this.btnAttackB.Text = "Воїн B";
            this.btnAttackB.UseVisualStyleBackColor = true;
            this.btnAttackB.Click += new System.EventHandler(this.btnAttackB_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(30, 130);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(484, 380);
            this.txtLog.TabIndex = 2;
            // 
            // progressBarA
            // 
            this.progressBarA.Location = new System.Drawing.Point(30, 70);
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(150, 25);
            this.progressBarA.TabIndex = 3;
            this.progressBarA.Value = 100;
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(200, 70);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(150, 25);
            this.progressBarB.TabIndex = 4;
            this.progressBarB.Value = 100;
            // 
            // lblHealthA
            // 
            this.lblHealthA.AutoSize = true;
            this.lblHealthA.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblHealthA.Location = new System.Drawing.Point(30, 100);
            this.lblHealthA.Name = "lblHealthA";
            this.lblHealthA.Size = new System.Drawing.Size(314, 32);
            this.lblHealthA.TabIndex = 5;
            this.lblHealthA.Text = "Воїн A Здоров\'я: 100";
            // 
            // lblHealthB
            // 
            this.lblHealthB.AutoSize = true;
            this.lblHealthB.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblHealthB.Location = new System.Drawing.Point(200, 100);
            this.lblHealthB.Name = "lblHealthB";
            this.lblHealthB.Size = new System.Drawing.Size(314, 32);
            this.lblHealthB.TabIndex = 6;
            this.lblHealthB.Text = "Воїн B Здоров\'я: 100";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(535, 532);
            this.Controls.Add(this.lblHealthA);
            this.Controls.Add(this.lblHealthB);
            this.Controls.Add(this.progressBarA);
            this.Controls.Add(this.progressBarB);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnAttackB);
            this.Controls.Add(this.btnAttackA);
            this.Name = "Form1";
            this.Text = "Військова симуляція";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
