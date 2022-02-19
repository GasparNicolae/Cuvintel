namespace Cuvintel
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lbIntrebareIesire = new System.Windows.Forms.Label();
            this.btnDaIesire = new System.Windows.Forms.Button();
            this.btnNuIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIntrebareIesire
            // 
            this.lbIntrebareIesire.AutoSize = true;
            this.lbIntrebareIesire.BackColor = System.Drawing.Color.Transparent;
            this.lbIntrebareIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntrebareIesire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbIntrebareIesire.Location = new System.Drawing.Point(21, 25);
            this.lbIntrebareIesire.Name = "lbIntrebareIesire";
            this.lbIntrebareIesire.Size = new System.Drawing.Size(238, 62);
            this.lbIntrebareIesire.TabIndex = 0;
            this.lbIntrebareIesire.Text = "Sigur vrei să ieși \r\ndin program?";
            this.lbIntrebareIesire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDaIesire
            // 
            this.btnDaIesire.BackColor = System.Drawing.Color.Transparent;
            this.btnDaIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaIesire.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDaIesire.Location = new System.Drawing.Point(45, 103);
            this.btnDaIesire.Name = "btnDaIesire";
            this.btnDaIesire.Size = new System.Drawing.Size(75, 34);
            this.btnDaIesire.TabIndex = 1;
            this.btnDaIesire.Text = "Da";
            this.btnDaIesire.UseVisualStyleBackColor = false;
            this.btnDaIesire.Click += new System.EventHandler(this.btnDaIesire_Click);
            // 
            // btnNuIesire
            // 
            this.btnNuIesire.BackColor = System.Drawing.Color.Transparent;
            this.btnNuIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuIesire.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnNuIesire.Location = new System.Drawing.Point(154, 103);
            this.btnNuIesire.Name = "btnNuIesire";
            this.btnNuIesire.Size = new System.Drawing.Size(75, 34);
            this.btnNuIesire.TabIndex = 2;
            this.btnNuIesire.Text = "Nu";
            this.btnNuIesire.UseVisualStyleBackColor = false;
            this.btnNuIesire.Click += new System.EventHandler(this.btnNuIesire_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cuvintel.Properties.Resources.BK3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.btnNuIesire);
            this.Controls.Add(this.btnDaIesire);
            this.Controls.Add(this.lbIntrebareIesire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Închidere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIntrebareIesire;
        private System.Windows.Forms.Button btnDaIesire;
        private System.Windows.Forms.Button btnNuIesire;
    }
}