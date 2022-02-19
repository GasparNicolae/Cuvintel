namespace Cuvintel
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.lbText1 = new System.Windows.Forms.Label();
            this.btnDaIesire = new System.Windows.Forms.Button();
            this.btnNuIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbText1
            // 
            this.lbText1.AutoSize = true;
            this.lbText1.BackColor = System.Drawing.Color.Transparent;
            this.lbText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbText1.Location = new System.Drawing.Point(23, 21);
            this.lbText1.Name = "lbText1";
            this.lbText1.Size = new System.Drawing.Size(215, 62);
            this.lbText1.TabIndex = 0;
            this.lbText1.Text = "Ești sigur că \r\nvrei să renunți?";
            this.lbText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDaIesire
            // 
            this.btnDaIesire.BackColor = System.Drawing.Color.Transparent;
            this.btnDaIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaIesire.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDaIesire.Location = new System.Drawing.Point(29, 106);
            this.btnDaIesire.Name = "btnDaIesire";
            this.btnDaIesire.Size = new System.Drawing.Size(75, 34);
            this.btnDaIesire.TabIndex = 2;
            this.btnDaIesire.Text = "Da";
            this.btnDaIesire.UseVisualStyleBackColor = false;
            this.btnDaIesire.Click += new System.EventHandler(this.btnDaIesire_Click);
            // 
            // btnNuIesire
            // 
            this.btnNuIesire.BackColor = System.Drawing.Color.Transparent;
            this.btnNuIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuIesire.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnNuIesire.Location = new System.Drawing.Point(163, 106);
            this.btnNuIesire.Name = "btnNuIesire";
            this.btnNuIesire.Size = new System.Drawing.Size(75, 34);
            this.btnNuIesire.TabIndex = 3;
            this.btnNuIesire.Text = "Nu";
            this.btnNuIesire.UseVisualStyleBackColor = false;
            this.btnNuIesire.Click += new System.EventHandler(this.btnNuIesire_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cuvintel.Properties.Resources.BK3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(264, 157);
            this.Controls.Add(this.btnNuIesire);
            this.Controls.Add(this.btnDaIesire);
            this.Controls.Add(this.lbText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acasă";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText1;
        private System.Windows.Forms.Button btnDaIesire;
        private System.Windows.Forms.Button btnNuIesire;
    }
}