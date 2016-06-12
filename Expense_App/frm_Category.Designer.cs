namespace Expense_App
{
    partial class frm_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Category));
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lstvCategory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(22, 37);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(187, 20);
            this.txtCategory.TabIndex = 2;
            // 
            // lstvCategory
            // 
            this.lstvCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.lstvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstvCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstvCategory.Location = new System.Drawing.Point(22, 86);
            this.lstvCategory.Name = "lstvCategory";
            this.lstvCategory.Size = new System.Drawing.Size(187, 129);
            this.lstvCategory.TabIndex = 3;
            this.lstvCategory.UseCompatibleStateImageBehavior = false;
            this.lstvCategory.View = System.Windows.Forms.View.Details;
            this.lstvCategory.Click += new System.EventHandler(this.lstvCategory_Click);
            this.lstvCategory.DoubleClick += new System.EventHandler(this.lstvCategory_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Categories";
            this.columnHeader1.Width = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categories:";
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSaveCategory.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(60)))));
            this.btnSaveCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(60)))));
            this.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCategory.Location = new System.Drawing.Point(22, 230);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCategory.TabIndex = 5;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Category:";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(134, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(231, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstvCategory);
            this.Controls.Add(this.txtCategory);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.frm_Category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.ListView lstvCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
    }
}