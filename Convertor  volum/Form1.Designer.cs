namespace Convertor__volum
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
            this.textBoxLit = new System.Windows.Forms.TextBox();
            this.textBoxcub = new System.Windows.Forms.TextBox();
            this.labelLit = new System.Windows.Forms.Label();
            this.labelCub = new System.Windows.Forms.Label();
            this.buttonConvers = new System.Windows.Forms.Button();
            this.buttonsterge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(213, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convertor Litri in metri cub";
            // 
            // textBoxLit
            // 
            this.textBoxLit.Location = new System.Drawing.Point(213, 162);
            this.textBoxLit.Name = "textBoxLit";
            this.textBoxLit.Size = new System.Drawing.Size(125, 27);
            this.textBoxLit.TabIndex = 1;
            // 
            // textBoxcub
            // 
            this.textBoxcub.Location = new System.Drawing.Point(213, 231);
            this.textBoxcub.Name = "textBoxcub";
            this.textBoxcub.Size = new System.Drawing.Size(125, 27);
            this.textBoxcub.TabIndex = 2;
            // 
            // labelLit
            // 
            this.labelLit.AutoSize = true;
            this.labelLit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLit.Location = new System.Drawing.Point(403, 169);
            this.labelLit.Name = "labelLit";
            this.labelLit.Size = new System.Drawing.Size(48, 23);
            this.labelLit.TabIndex = 3;
            this.labelLit.Text = "Litru";
            // 
            // labelCub
            // 
            this.labelCub.AutoSize = true;
            this.labelCub.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCub.Location = new System.Drawing.Point(403, 236);
            this.labelCub.Name = "labelCub";
            this.labelCub.Size = new System.Drawing.Size(98, 23);
            this.labelCub.TabIndex = 4;
            this.labelCub.Text = "Metri  cubi";
            // 
            // buttonConvers
            // 
            this.buttonConvers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConvers.ForeColor = System.Drawing.Color.Blue;
            this.buttonConvers.Location = new System.Drawing.Point(218, 340);
            this.buttonConvers.Name = "buttonConvers";
            this.buttonConvers.Size = new System.Drawing.Size(108, 35);
            this.buttonConvers.TabIndex = 5;
            this.buttonConvers.Text = "Conversie";
            this.buttonConvers.UseVisualStyleBackColor = true;
            this.buttonConvers.Click += new System.EventHandler(this.buttonConvers_Click);
            // 
            // buttonsterge
            // 
            this.buttonsterge.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonsterge.ForeColor = System.Drawing.Color.Red;
            this.buttonsterge.Location = new System.Drawing.Point(413, 340);
            this.buttonsterge.Name = "buttonsterge";
            this.buttonsterge.Size = new System.Drawing.Size(94, 35);
            this.buttonsterge.TabIndex = 6;
            this.buttonsterge.Text = "Sterge";
            this.buttonsterge.UseVisualStyleBackColor = true;
            this.buttonsterge.Click += new System.EventHandler(this.buttonsterge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(943, 490);
            this.Controls.Add(this.buttonsterge);
            this.Controls.Add(this.buttonConvers);
            this.Controls.Add(this.labelCub);
            this.Controls.Add(this.labelLit);
            this.Controls.Add(this.textBoxcub);
            this.Controls.Add(this.textBoxLit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxLit;
        private TextBox textBoxcub;
        private Label labelLit;
        private Label labelCub;
        private Button buttonConvers;
        private Button buttonsterge;
    }
}