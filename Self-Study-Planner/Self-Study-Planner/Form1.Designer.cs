namespace Self_Study_Planner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.entryLst = new System.Windows.Forms.ListBox();
            this.entryAdd = new System.Windows.Forms.Button();
            this.entryDel = new System.Windows.Forms.Button();
            this.entryInput = new System.Windows.Forms.TextBox();
            this.entryMod = new System.Windows.Forms.Button();
            this.entrySav = new System.Windows.Forms.Button();
            this.entryLoad = new System.Windows.Forms.Button();
            this.bootLabel = new System.Windows.Forms.Label();
            this.labelBoot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entryLst
            // 
            this.entryLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryLst.FormattingEnabled = true;
            this.entryLst.ItemHeight = 25;
            this.entryLst.Location = new System.Drawing.Point(446, 11);
            this.entryLst.Name = "entryLst";
            this.entryLst.Size = new System.Drawing.Size(334, 354);
            this.entryLst.TabIndex = 0;
            // 
            // entryAdd
            // 
            this.entryAdd.Location = new System.Drawing.Point(49, 40);
            this.entryAdd.Name = "entryAdd";
            this.entryAdd.Size = new System.Drawing.Size(75, 53);
            this.entryAdd.TabIndex = 1;
            this.entryAdd.Text = "Add Entry";
            this.entryAdd.UseVisualStyleBackColor = true;
            this.entryAdd.Click += new System.EventHandler(this.entryAdd_Click);
            // 
            // entryDel
            // 
            this.entryDel.Location = new System.Drawing.Point(49, 99);
            this.entryDel.Name = "entryDel";
            this.entryDel.Size = new System.Drawing.Size(75, 53);
            this.entryDel.TabIndex = 2;
            this.entryDel.Text = "Delete Entry";
            this.entryDel.UseVisualStyleBackColor = true;
            this.entryDel.Click += new System.EventHandler(this.entryDel_Click);
            // 
            // entryInput
            // 
            this.entryInput.Location = new System.Drawing.Point(151, 55);
            this.entryInput.Name = "entryInput";
            this.entryInput.Size = new System.Drawing.Size(256, 22);
            this.entryInput.TabIndex = 3;
            // 
            // entryMod
            // 
            this.entryMod.Location = new System.Drawing.Point(49, 158);
            this.entryMod.Name = "entryMod";
            this.entryMod.Size = new System.Drawing.Size(75, 53);
            this.entryMod.TabIndex = 4;
            this.entryMod.Text = "Modify Entry";
            this.entryMod.UseVisualStyleBackColor = true;
            this.entryMod.Click += new System.EventHandler(this.entryMod_Click);
            // 
            // entrySav
            // 
            this.entrySav.Location = new System.Drawing.Point(151, 158);
            this.entrySav.Name = "entrySav";
            this.entrySav.Size = new System.Drawing.Size(75, 53);
            this.entrySav.TabIndex = 5;
            this.entrySav.Text = "Save to File";
            this.entrySav.UseVisualStyleBackColor = true;
            // 
            // entryLoad
            // 
            this.entryLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.entryLoad.Location = new System.Drawing.Point(332, 158);
            this.entryLoad.Name = "entryLoad";
            this.entryLoad.Size = new System.Drawing.Size(75, 53);
            this.entryLoad.TabIndex = 6;
            this.entryLoad.Text = "Load From File";
            this.entryLoad.UseVisualStyleBackColor = true;
            // 
            // bootLabel
            // 
            this.bootLabel.AutoSize = true;
            this.bootLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootLabel.ForeColor = System.Drawing.Color.Green;
            this.bootLabel.Location = new System.Drawing.Point(151, 13);
            this.bootLabel.Name = "bootLabel";
            this.bootLabel.Size = new System.Drawing.Size(179, 18);
            this.bootLabel.TabIndex = 7;
            this.bootLabel.Text = "Welcome to your SSP!";
            // 
            // labelBoot
            // 
            this.labelBoot.AutoSize = true;
            this.labelBoot.Location = new System.Drawing.Point(49, 315);
            this.labelBoot.Name = "labelBoot";
            this.labelBoot.Size = new System.Drawing.Size(0, 16);
            this.labelBoot.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(792, 377);
            this.Controls.Add(this.labelBoot);
            this.Controls.Add(this.bootLabel);
            this.Controls.Add(this.entryLoad);
            this.Controls.Add(this.entrySav);
            this.Controls.Add(this.entryMod);
            this.Controls.Add(this.entryInput);
            this.Controls.Add(this.entryDel);
            this.Controls.Add(this.entryAdd);
            this.Controls.Add(this.entryLst);
            this.Name = "Form1";
            this.Text = "Self-Study-Planner!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox entryLst;
        private System.Windows.Forms.Button entryAdd;
        private System.Windows.Forms.Button entryDel;
        private System.Windows.Forms.TextBox entryInput;
        private System.Windows.Forms.Button entryMod;
        private System.Windows.Forms.Button entrySav;
        private System.Windows.Forms.Button entryLoad;
        private System.Windows.Forms.Label bootLabel;
        private System.Windows.Forms.Label labelBoot;
    }
}

