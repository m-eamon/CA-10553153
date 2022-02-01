namespace CA_10553153
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddCom = new System.Windows.Forms.Button();
            this.btnAddRes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(129, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DBS Property Company";
            // 
            // btnAddCom
            // 
            this.btnAddCom.Location = new System.Drawing.Point(166, 75);
            this.btnAddCom.Name = "btnAddCom";
            this.btnAddCom.Size = new System.Drawing.Size(158, 23);
            this.btnAddCom.TabIndex = 1;
            this.btnAddCom.Text = "Commercial Building";
            this.btnAddCom.UseVisualStyleBackColor = true;
            this.btnAddCom.Click += new System.EventHandler(this.btnAddCom_Click);
            // 
            // btnAddRes
            // 
            this.btnAddRes.Location = new System.Drawing.Point(166, 126);
            this.btnAddRes.Name = "btnAddRes";
            this.btnAddRes.Size = new System.Drawing.Size(158, 23);
            this.btnAddRes.TabIndex = 2;
            this.btnAddRes.Text = "Residential Building";
            this.btnAddRes.UseVisualStyleBackColor = true;
            this.btnAddRes.Click += new System.EventHandler(this.btnAddRes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(166, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 328);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddRes);
            this.Controls.Add(this.btnAddCom);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddCom;
        private System.Windows.Forms.Button btnAddRes;
        private System.Windows.Forms.Button btnExit;
    }
}

