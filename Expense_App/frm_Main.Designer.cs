namespace Expense_App
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnDasboard = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCategory.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(60)))));
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(79, 89);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(156, 45);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Categories";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAddExpense.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddExpense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(60)))));
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.Location = new System.Drawing.Point(79, 146);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(156, 45);
            this.btnAddExpense.TabIndex = 3;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(60)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(79, 203);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(156, 45);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(60)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(288, 272);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 24);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "?";
            this.toolTip1.SetToolTip(this.btnHelp, "Manual");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnDasboard
            // 
            this.btnDasboard.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDasboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDasboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDasboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(60)))));
            this.btnDasboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDasboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDasboard.Location = new System.Drawing.Point(79, 31);
            this.btnDasboard.Name = "btnDasboard";
            this.btnDasboard.Size = new System.Drawing.Size(156, 45);
            this.btnDasboard.TabIndex = 1;
            this.btnDasboard.Text = "Dashboard";
            this.btnDasboard.UseVisualStyleBackColor = true;
            this.btnDasboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(314, 299);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.btnDasboard);
            this.Controls.Add(this.btnCategory);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.Text = "Expense Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnDasboard;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

