
namespace FortuneWheel
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnMode1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMode2 = new System.Windows.Forms.Button();
            this.btnMode3 = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lbMainMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMode1
            // 
            this.btnMode1.Location = new System.Drawing.Point(12, 40);
            this.btnMode1.Name = "btnMode1";
            this.btnMode1.Size = new System.Drawing.Size(160, 23);
            this.btnMode1.TabIndex = 0;
            this.btnMode1.TabStop = false;
            this.btnMode1.Text = "Tryb \"Wisielec\"";
            this.btnMode1.UseVisualStyleBackColor = true;
            this.btnMode1.Click += new System.EventHandler(this.btnMode1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 156);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Wyjdź";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMode2
            // 
            this.btnMode2.Enabled = false;
            this.btnMode2.Location = new System.Drawing.Point(12, 69);
            this.btnMode2.Name = "btnMode2";
            this.btnMode2.Size = new System.Drawing.Size(160, 23);
            this.btnMode2.TabIndex = 2;
            this.btnMode2.TabStop = false;
            this.btnMode2.Text = "???";
            this.btnMode2.UseVisualStyleBackColor = true;
            this.btnMode2.Click += new System.EventHandler(this.btnMode2_Click);
            // 
            // btnMode3
            // 
            this.btnMode3.Enabled = false;
            this.btnMode3.Location = new System.Drawing.Point(12, 98);
            this.btnMode3.Name = "btnMode3";
            this.btnMode3.Size = new System.Drawing.Size(160, 23);
            this.btnMode3.TabIndex = 3;
            this.btnMode3.TabStop = false;
            this.btnMode3.Text = "???";
            this.btnMode3.UseVisualStyleBackColor = true;
            this.btnMode3.Click += new System.EventHandler(this.btnMode3_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 127);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(160, 23);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.TabStop = false;
            this.btnInfo.Text = "Informacje";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lbMainMenu
            // 
            this.lbMainMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMainMenu.Location = new System.Drawing.Point(9, 9);
            this.lbMainMenu.Name = "lbMainMenu";
            this.lbMainMenu.Size = new System.Drawing.Size(163, 23);
            this.lbMainMenu.TabIndex = 5;
            this.lbMainMenu.Text = "Main Menu";
            this.lbMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 190);
            this.Controls.Add(this.lbMainMenu);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnMode3);
            this.Controls.Add(this.btnMode2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMode1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(200, 229);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 229);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMode1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMode2;
        private System.Windows.Forms.Button btnMode3;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lbMainMenu;
    }
}