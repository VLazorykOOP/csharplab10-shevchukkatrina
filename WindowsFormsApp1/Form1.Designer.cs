using System.Drawing;

namespace MilitaryActionsGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAttackA;
        private System.Windows.Forms.Button btnAttackB;
        private System.Windows.Forms.TextBox txtLog;

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
            this.SuspendLayout();

            // btnAttackA
            this.btnAttackA.Location = new System.Drawing.Point(30, 20);
            this.btnAttackA.Name = "btnAttackA";
            this.btnAttackA.Size = new System.Drawing.Size(150, 40);
            this.btnAttackA.TabIndex = 0;
            this.btnAttackA.Text = "Воїн A";
            this.btnAttackA.UseVisualStyleBackColor = true;
            this.btnAttackA.Click += new System.EventHandler(this.btnAttackA_Click);
            btnAttackA.Font = new Font("Consolas", 12, FontStyle.Bold);

            // btnAttackB
            this.btnAttackB.Location = new System.Drawing.Point(200, 20);
            this.btnAttackB.Name = "btnAttackB";
            this.btnAttackB.Size = new System.Drawing.Size(150, 40);
            this.btnAttackB.TabIndex = 1;
            this.btnAttackB.Text = "Воїн B";
            this.btnAttackB.UseVisualStyleBackColor = true;
            this.btnAttackB.Click += new System.EventHandler(this.btnAttackB_Click);
            btnAttackB.Font = new Font("Consolas", 12, FontStyle.Bold);

            // txtLog
            this.txtLog.Location = new System.Drawing.Point(30, 80);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(320, 200);
            this.txtLog.TabIndex = 2;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(384, 311);
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
