﻿
namespace MBDecompiler
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStartItemDecompiler = new System.Windows.Forms.Button();
            this.btnStartTrooperDecompiler = new System.Windows.Forms.Button();
            this.btnMBTextIDGenerator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartItemDecompiler
            // 
            this.btnStartItemDecompiler.Image = global::MBDecompiler.Properties.Resources.editor_item_icon;
            this.btnStartItemDecompiler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStartItemDecompiler.Location = new System.Drawing.Point(26, 24);
            this.btnStartItemDecompiler.Name = "btnStartItemDecompiler";
            this.btnStartItemDecompiler.Size = new System.Drawing.Size(246, 196);
            this.btnStartItemDecompiler.TabIndex = 0;
            this.btnStartItemDecompiler.Text = "Item";
            this.btnStartItemDecompiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStartItemDecompiler.UseVisualStyleBackColor = true;
            this.btnStartItemDecompiler.Click += new System.EventHandler(this.btnStartItemDecompiler_Click);
            // 
            // btnStartTrooperDecompiler
            // 
            this.btnStartTrooperDecompiler.Image = global::MBDecompiler.Properties.Resources.editor_trooper_icon;
            this.btnStartTrooperDecompiler.Location = new System.Drawing.Point(306, 24);
            this.btnStartTrooperDecompiler.Name = "btnStartTrooperDecompiler";
            this.btnStartTrooperDecompiler.Size = new System.Drawing.Size(246, 196);
            this.btnStartTrooperDecompiler.TabIndex = 1;
            this.btnStartTrooperDecompiler.Text = "Trooper";
            this.btnStartTrooperDecompiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStartTrooperDecompiler.UseVisualStyleBackColor = true;
            this.btnStartTrooperDecompiler.Click += new System.EventHandler(this.btnStartTrooperDecompiler_Click);
            // 
            // btnMBTextIDGenerator
            // 
            this.btnMBTextIDGenerator.Image = global::MBDecompiler.Properties.Resources.editor_id_generator_icon;
            this.btnMBTextIDGenerator.Location = new System.Drawing.Point(26, 253);
            this.btnMBTextIDGenerator.Name = "btnMBTextIDGenerator";
            this.btnMBTextIDGenerator.Size = new System.Drawing.Size(526, 133);
            this.btnMBTextIDGenerator.TabIndex = 2;
            this.btnMBTextIDGenerator.Text = "ID Generator";
            this.btnMBTextIDGenerator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMBTextIDGenerator.UseVisualStyleBackColor = true;
            this.btnMBTextIDGenerator.Click += new System.EventHandler(this.btnMBTextIDGenerator_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 398);
            this.Controls.Add(this.btnMBTextIDGenerator);
            this.Controls.Add(this.btnStartTrooperDecompiler);
            this.Controls.Add(this.btnStartItemDecompiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MB 1.011 Decompiler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartItemDecompiler;
        private System.Windows.Forms.Button btnStartTrooperDecompiler;
        private System.Windows.Forms.Button btnMBTextIDGenerator;
    }
}