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
            this.EntryLst = new System.Windows.Forms.ListBox();
            this.EntryAdd = new System.Windows.Forms.Button();
            this.EntryDel = new System.Windows.Forms.Button();
            this.EntryInput = new System.Windows.Forms.TextBox();
            this.EntryMod = new System.Windows.Forms.Button();
            this.EntrySav = new System.Windows.Forms.Button();
            this.EntryLoad = new System.Windows.Forms.Button();
            this.bootLabel = new System.Windows.Forms.Label();
            this.labelBoot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EntryLst
            // 
            this.EntryLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryLst.FormattingEnabled = true;
            this.EntryLst.ItemHeight = 25;
            this.EntryLst.Location = new System.Drawing.Point(433, 12);
            this.EntryLst.Name = "EntryLst";
            this.EntryLst.Size = new System.Drawing.Size(613, 354);
            this.EntryLst.TabIndex = 0;
            // 
            // EntryAdd
            // 
            this.EntryAdd.Location = new System.Drawing.Point(49, 40);
            this.EntryAdd.Name = "EntryAdd";
            this.EntryAdd.Size = new System.Drawing.Size(75, 53);
            this.EntryAdd.TabIndex = 1;
            this.EntryAdd.Text = "Add Entry";
            this.EntryAdd.UseVisualStyleBackColor = true;
            this.EntryAdd.Click += new System.EventHandler(this.EntryAdd_Click);
            // 
            // EntryDel
            // 
            this.EntryDel.Location = new System.Drawing.Point(49, 99);
            this.EntryDel.Name = "EntryDel";
            this.EntryDel.Size = new System.Drawing.Size(75, 53);
            this.EntryDel.TabIndex = 2;
            this.EntryDel.Text = "Delete Entry";
            this.EntryDel.UseVisualStyleBackColor = true;
            this.EntryDel.Click += new System.EventHandler(this.EntryDel_Click);
            // 
            // EntryInput
            // 
            this.EntryInput.Location = new System.Drawing.Point(151, 55);
            this.EntryInput.Multiline = true;
            this.EntryInput.Name = "EntryInput";
            this.EntryInput.Size = new System.Drawing.Size(256, 22);
            this.EntryInput.TabIndex = 3;
            // 
            // EntryMod
            // 
            this.EntryMod.Location = new System.Drawing.Point(49, 158);
            this.EntryMod.Name = "EntryMod";
            this.EntryMod.Size = new System.Drawing.Size(75, 53);
            this.EntryMod.TabIndex = 4;
            this.EntryMod.Text = "Modify Entry";
            this.EntryMod.UseVisualStyleBackColor = true;
            this.EntryMod.Click += new System.EventHandler(this.EntryMod_Click);
            // 
            // EntrySav
            // 
            this.EntrySav.Location = new System.Drawing.Point(151, 158);
            this.EntrySav.Name = "EntrySav";
            this.EntrySav.Size = new System.Drawing.Size(75, 53);
            this.EntrySav.TabIndex = 5;
            this.EntrySav.Text = "Save to File";
            this.EntrySav.UseVisualStyleBackColor = true;
            this.EntrySav.Click += new System.EventHandler(this.EntrySav_Click);
            // 
            // EntryLoad
            // 
            this.EntryLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EntryLoad.Location = new System.Drawing.Point(332, 158);
            this.EntryLoad.Name = "EntryLoad";
            this.EntryLoad.Size = new System.Drawing.Size(75, 53);
            this.EntryLoad.TabIndex = 6;
            this.EntryLoad.Text = "Load From File";
            this.EntryLoad.UseVisualStyleBackColor = true;
            this.EntryLoad.Click += new System.EventHandler(this.EntryLoad_Click);
            // 
            // bootLabel
            // 
            this.bootLabel.AutoSize = true;
            this.bootLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootLabel.ForeColor = System.Drawing.Color.GreenYellow;
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
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1055, 378);
            this.Controls.Add(this.labelBoot);
            this.Controls.Add(this.bootLabel);
            this.Controls.Add(this.EntryLoad);
            this.Controls.Add(this.EntrySav);
            this.Controls.Add(this.EntryMod);
            this.Controls.Add(this.EntryInput);
            this.Controls.Add(this.EntryDel);
            this.Controls.Add(this.EntryAdd);
            this.Controls.Add(this.EntryLst);
            this.Name = "Form1";
            this.Text = "Self-Study-Planner!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EntryLst;
        private System.Windows.Forms.Button EntryAdd;
        private System.Windows.Forms.Button EntryDel;
        private System.Windows.Forms.TextBox EntryInput;
        private System.Windows.Forms.Button EntryMod;
        private System.Windows.Forms.Button EntrySav;
        private System.Windows.Forms.Button EntryLoad;
        private System.Windows.Forms.Label bootLabel;
        private System.Windows.Forms.Label labelBoot;
    }
}

