namespace PhotoGroup
{
    partial class FormConfig
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
            this.lb_categories = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dgv_categories = new System.Windows.Forms.DataGridView();
            this.Categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_categories
            // 
            this.lb_categories.AutoSize = true;
            this.lb_categories.Location = new System.Drawing.Point(12, 9);
            this.lb_categories.Name = "lb_categories";
            this.lb_categories.Size = new System.Drawing.Size(39, 13);
            this.lb_categories.TabIndex = 0;
            this.lb_categories.Text = "Pastas";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(116, 226);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(197, 226);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dgv_categories
            // 
            this.dgv_categories.AllowUserToOrderColumns = true;
            this.dgv_categories.AllowUserToResizeRows = false;
            this.dgv_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categories});
            this.dgv_categories.Location = new System.Drawing.Point(15, 25);
            this.dgv_categories.Name = "dgv_categories";
            this.dgv_categories.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_categories.Size = new System.Drawing.Size(257, 195);
            this.dgv_categories.TabIndex = 4;
            // 
            // Categories
            // 
            this.Categories.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categories.HeaderText = "Nome";
            this.Categories.Name = "Categories";
            this.Categories.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgv_categories);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lb_categories);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "FormConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_categories;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dgv_categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categories;
    }
}