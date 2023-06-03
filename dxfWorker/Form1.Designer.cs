namespace dxfWorker
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
            this.UN = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.Button();
            this.PLas = new System.Windows.Forms.Button();
            this.KL = new System.Windows.Forms.Button();
            this.set_folder_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UN
            // 
            this.UN.Location = new System.Drawing.Point(122, 145);
            this.UN.Name = "UN";
            this.UN.Size = new System.Drawing.Size(112, 34);
            this.UN.TabIndex = 3;
            this.UN.Text = "UN";
            this.UN.UseVisualStyleBackColor = true;
            this.UN.Click += new System.EventHandler(this.change_Folder);
            // 
            // U
            // 
            this.U.Location = new System.Drawing.Point(122, 185);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(112, 34);
            this.U.TabIndex = 4;
            this.U.Text = "U";
            this.U.UseVisualStyleBackColor = true;
            this.U.Click += new System.EventHandler(this.change_Folder);
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(122, 225);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(112, 34);
            this.T.TabIndex = 5;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = true;
            this.T.Click += new System.EventHandler(this.change_Folder);
            // 
            // PLas
            // 
            this.PLas.Location = new System.Drawing.Point(122, 262);
            this.PLas.Name = "PLas";
            this.PLas.Size = new System.Drawing.Size(112, 34);
            this.PLas.TabIndex = 6;
            this.PLas.Text = "PL";
            this.PLas.UseVisualStyleBackColor = true;
            this.PLas.Click += new System.EventHandler(this.change_Folder);
            // 
            // KL
            // 
            this.KL.Location = new System.Drawing.Point(122, 105);
            this.KL.Name = "KL";
            this.KL.Size = new System.Drawing.Size(112, 34);
            this.KL.TabIndex = 7;
            this.KL.Text = "KL";
            this.KL.UseVisualStyleBackColor = true;
            this.KL.Click += new System.EventHandler(this.change_Folder);
            // 
            // set_folder_button
            // 
            this.set_folder_button.Location = new System.Drawing.Point(94, 302);
            this.set_folder_button.Name = "set_folder_button";
            this.set_folder_button.Size = new System.Drawing.Size(182, 34);
            this.set_folder_button.TabIndex = 8;
            this.set_folder_button.Text = "Select folder";
            this.set_folder_button.UseVisualStyleBackColor = true;
            this.set_folder_button.Click += new System.EventHandler(this.set_Folder);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.set_folder_button);
            this.Controls.Add(this.KL);
            this.Controls.Add(this.PLas);
            this.Controls.Add(this.T);
            this.Controls.Add(this.U);
            this.Controls.Add(this.UN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button UN;
        private Button U;
        private Button T;
        private Button PLas;
        private Button KL;
        private Button set_folder_button;
        private Label label2;
    }
}