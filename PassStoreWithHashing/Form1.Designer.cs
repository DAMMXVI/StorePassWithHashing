namespace StorePassWithHashing
{
    partial class Form1
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPassControl = new System.Windows.Forms.Label();
            this.btnPassControl = new System.Windows.Forms.Button();
            this.txtPassControl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(164, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(131, 61);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(164, 20);
            this.txtPass.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(131, 97);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(164, 29);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(41, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(41, 68);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password";
            // 
            // lblPassControl
            // 
            this.lblPassControl.AutoSize = true;
            this.lblPassControl.Location = new System.Drawing.Point(41, 154);
            this.lblPassControl.Name = "lblPassControl";
            this.lblPassControl.Size = new System.Drawing.Size(53, 13);
            this.lblPassControl.TabIndex = 7;
            this.lblPassControl.Text = "Password";
            // 
            // btnPassControl
            // 
            this.btnPassControl.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPassControl.Location = new System.Drawing.Point(131, 183);
            this.btnPassControl.Name = "btnPassControl";
            this.btnPassControl.Size = new System.Drawing.Size(164, 29);
            this.btnPassControl.TabIndex = 6;
            this.btnPassControl.Text = "Password Control";
            this.btnPassControl.UseVisualStyleBackColor = true;
            this.btnPassControl.Click += new System.EventHandler(this.btnPassControl_Click);
            // 
            // txtPassControl
            // 
            this.txtPassControl.Location = new System.Drawing.Point(131, 147);
            this.txtPassControl.Name = "txtPassControl";
            this.txtPassControl.Size = new System.Drawing.Size(164, 20);
            this.txtPassControl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 250);
            this.Controls.Add(this.lblPassControl);
            this.Controls.Add(this.btnPassControl);
            this.Controls.Add(this.txtPassControl);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblPassControl;
        private System.Windows.Forms.Button btnPassControl;
        private System.Windows.Forms.TextBox txtPassControl;
    }
}

