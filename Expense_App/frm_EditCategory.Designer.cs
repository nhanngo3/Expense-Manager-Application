namespace Expense_App
{
    partial class frm_EditCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditCategory));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveNewCate = new System.Windows.Forms.Button();
            this.txtNewCate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter category:";
            // 
            // btnSaveNewCate
            // 
            this.btnSaveNewCate.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSaveNewCate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveNewCate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(60)))));
            this.btnSaveNewCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNewCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewCate.Location = new System.Drawing.Point(176, 39);
            this.btnSaveNewCate.Name = "btnSaveNewCate";
            this.btnSaveNewCate.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewCate.TabIndex = 1;
            this.btnSaveNewCate.Text = "Save";
            this.btnSaveNewCate.UseVisualStyleBackColor = true;
            this.btnSaveNewCate.Click += new System.EventHandler(this.btnSaveNewCate_Click);
            // 
            // txtNewCate
            // 
            this.txtNewCate.Location = new System.Drawing.Point(26, 39);
            this.txtNewCate.Name = "txtNewCate";
            this.txtNewCate.Size = new System.Drawing.Size(131, 20);
            this.txtNewCate.TabIndex = 2;
            // 
            // frm_EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Expense_App.Properties.Resources.designer400_400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(263, 83);
            this.Controls.Add(this.txtNewCate);
            this.Controls.Add(this.btnSaveNewCate);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EditCategory";
            this.Text = "Edit Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveNewCate;
        private System.Windows.Forms.TextBox txtNewCate;
    }
}