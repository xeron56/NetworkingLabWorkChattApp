namespace Sneaky_Chat
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
               this.txb_user = new System.Windows.Forms.TextBox();
               this.lbl_user = new System.Windows.Forms.Label();
               this.lbox_maindisplay = new System.Windows.Forms.ListBox();
               this.timer1 = new System.Windows.Forms.Timer(this.components);
               this.btn_deconnexion = new System.Windows.Forms.Button();
               this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
               this.SuspendLayout();
               // 
               // txb_user
               // 
               this.txb_user.BackColor = System.Drawing.SystemColors.HighlightText;
               this.txb_user.ForeColor = System.Drawing.SystemColors.MenuText;
               this.txb_user.Location = new System.Drawing.Point(13, 346);
               this.txb_user.MaxLength = 60;
               this.txb_user.Name = "txb_user";
               this.txb_user.Size = new System.Drawing.Size(415, 20);
               this.txb_user.TabIndex = 2;
               // 
               // lbl_user
               // 
               this.lbl_user.AutoSize = true;
               this.lbl_user.BackColor = System.Drawing.Color.Transparent;
               this.lbl_user.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lbl_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.lbl_user.Location = new System.Drawing.Point(10, 21);
               this.lbl_user.Name = "lbl_user";
               this.lbl_user.Size = new System.Drawing.Size(115, 15);
               this.lbl_user.TabIndex = 3;
               this.lbl_user.Text = "Welcome_message";
               // 
               // lbox_maindisplay
               // 
               this.lbox_maindisplay.BackColor = System.Drawing.Color.AliceBlue;
               this.lbox_maindisplay.ForeColor = System.Drawing.SystemColors.WindowText;
               this.lbox_maindisplay.FormattingEnabled = true;
               this.lbox_maindisplay.Location = new System.Drawing.Point(13, 100);
               this.lbox_maindisplay.Name = "lbox_maindisplay";
               this.lbox_maindisplay.Size = new System.Drawing.Size(415, 225);
               this.lbox_maindisplay.TabIndex = 4;
               // 
               // timer1
               // 
               this.timer1.Interval = 500;
               this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
               // 
               // btn_deconnexion
               // 
               this.btn_deconnexion.BackColor = System.Drawing.Color.OrangeRed;
               this.btn_deconnexion.FlatAppearance.BorderSize = 0;
               this.btn_deconnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
               this.btn_deconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btn_deconnexion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.btn_deconnexion.Location = new System.Drawing.Point(434, 383);
               this.btn_deconnexion.Name = "btn_deconnexion";
               this.btn_deconnexion.Size = new System.Drawing.Size(86, 23);
               this.btn_deconnexion.TabIndex = 12;
               this.btn_deconnexion.Text = "Log out";
               this.btn_deconnexion.UseVisualStyleBackColor = false;
               this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
               // 
               // kryptonButton1
               // 
               this.kryptonButton1.Location = new System.Drawing.Point(434, 346);
               this.kryptonButton1.Name = "kryptonButton1";
               this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
               this.kryptonButton1.TabIndex = 13;
               this.kryptonButton1.Values.Text = "Send";
               this.kryptonButton1.Click += new System.EventHandler(this.btn_send_Click);
               // 
               // MainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.Blue;
               this.ClientSize = new System.Drawing.Size(727, 437);
               this.Controls.Add(this.kryptonButton1);
               this.Controls.Add(this.btn_deconnexion);
               this.Controls.Add(this.lbox_maindisplay);
               this.Controls.Add(this.lbl_user);
               this.Controls.Add(this.txb_user);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "MainForm";
               this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "LabChat";
               this.Load += new System.EventHandler(this.MainForm_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_user;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.ListBox lbox_maindisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_deconnexion;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}

