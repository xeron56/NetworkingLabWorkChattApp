namespace Sneaky_Chat
{
    partial class Connect
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect));
               this.txb_username = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.btn_username = new System.Windows.Forms.Button();
               this.txb_ip = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // txb_username
               // 
               this.txb_username.Location = new System.Drawing.Point(66, 67);
               this.txb_username.Name = "txb_username";
               this.txb_username.Size = new System.Drawing.Size(203, 20);
               this.txb_username.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.label1.Location = new System.Drawing.Point(178, 21);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(129, 18);
               this.label1.TabIndex = 1;
               this.label1.Text = "Choose a username";
               this.label1.Click += new System.EventHandler(this.label1_Click);
               // 
               // btn_username
               // 
               this.btn_username.BackColor = System.Drawing.Color.WhiteSmoke;
               this.btn_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_username.Location = new System.Drawing.Point(181, 139);
               this.btn_username.Name = "btn_username";
               this.btn_username.Size = new System.Drawing.Size(126, 32);
               this.btn_username.TabIndex = 2;
               this.btn_username.Text = "Connect";
               this.btn_username.UseVisualStyleBackColor = false;
               this.btn_username.Click += new System.EventHandler(this.button1_Click);
               // 
               // txb_ip
               // 
               this.txb_ip.Location = new System.Drawing.Point(303, 67);
               this.txb_ip.Name = "txb_ip";
               this.txb_ip.Size = new System.Drawing.Size(127, 20);
               this.txb_ip.TabIndex = 3;
               this.txb_ip.Text = "Entrer l\'adresse IP";
               this.txb_ip.Click += new System.EventHandler(this.txb_ip_Click);
               // 
               // Connect
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.MediumSlateBlue;
               this.ClientSize = new System.Drawing.Size(562, 366);
               this.Controls.Add(this.txb_ip);
               this.Controls.Add(this.btn_username);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.txb_username);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "Connect";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Connect";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_username;
        private System.Windows.Forms.TextBox txb_ip;
    }
}