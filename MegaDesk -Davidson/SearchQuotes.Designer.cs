﻿namespace MegaDesk__TeamAngeles
{
    partial class SearchQuotes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sMaterial = new System.Windows.Forms.ComboBox();
            this.closeSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 331);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by Material Type:";
            // 
            // sMaterial
            // 
            this.sMaterial.FormattingEnabled = true;
            this.sMaterial.Location = new System.Drawing.Point(174, 7);
            this.sMaterial.Name = "sMaterial";
            this.sMaterial.Size = new System.Drawing.Size(121, 21);
            this.sMaterial.TabIndex = 3;
            this.sMaterial.SelectedIndexChanged += new System.EventHandler(this.sMaterial_SelectedIndexChanged);
            // 
            // closeSearch
            // 
            this.closeSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeSearch.Location = new System.Drawing.Point(680, 403);
            this.closeSearch.Name = "closeSearch";
            this.closeSearch.Size = new System.Drawing.Size(99, 35);
            this.closeSearch.TabIndex = 6;
            this.closeSearch.Text = "Close";
            this.closeSearch.UseVisualStyleBackColor = true;
            this.closeSearch.Click += new System.EventHandler(this.closeSearch_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sMaterial);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sMaterial;
        private System.Windows.Forms.Button closeSearch;
    }
}