namespace PhotoGroup
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.sc_wrap = new System.Windows.Forms.SplitContainer();
            this.lb_destination = new System.Windows.Forms.Label();
            this.lb_source = new System.Windows.Forms.Label();
            this.btn_destination = new System.Windows.Forms.Button();
            this.btn_source = new System.Windows.Forms.Button();
            this.btn_configs = new System.Windows.Forms.Button();
            this.btn_deselect_all = new System.Windows.Forms.Button();
            this.btn_select_all = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.fp_options = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_preview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc_wrap)).BeginInit();
            this.sc_wrap.Panel1.SuspendLayout();
            this.sc_wrap.Panel2.SuspendLayout();
            this.sc_wrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // sc_wrap
            // 
            this.sc_wrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_wrap.Location = new System.Drawing.Point(0, 0);
            this.sc_wrap.Name = "sc_wrap";
            this.sc_wrap.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_wrap.Panel1
            // 
            this.sc_wrap.Panel1.Controls.Add(this.lb_destination);
            this.sc_wrap.Panel1.Controls.Add(this.lb_source);
            this.sc_wrap.Panel1.Controls.Add(this.btn_destination);
            this.sc_wrap.Panel1.Controls.Add(this.btn_source);
            this.sc_wrap.Panel1.Controls.Add(this.pb_preview);
            // 
            // sc_wrap.Panel2
            // 
            this.sc_wrap.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sc_wrap.Panel2.Controls.Add(this.btn_configs);
            this.sc_wrap.Panel2.Controls.Add(this.btn_deselect_all);
            this.sc_wrap.Panel2.Controls.Add(this.btn_select_all);
            this.sc_wrap.Panel2.Controls.Add(this.btn_previous);
            this.sc_wrap.Panel2.Controls.Add(this.btn_next);
            this.sc_wrap.Panel2.Controls.Add(this.fp_options);
            this.sc_wrap.Size = new System.Drawing.Size(364, 431);
            this.sc_wrap.SplitterDistance = 251;
            this.sc_wrap.TabIndex = 0;
            // 
            // lb_destination
            // 
            this.lb_destination.AutoSize = true;
            this.lb_destination.Location = new System.Drawing.Point(93, 46);
            this.lb_destination.Name = "lb_destination";
            this.lb_destination.Size = new System.Drawing.Size(0, 13);
            this.lb_destination.TabIndex = 4;
            // 
            // lb_source
            // 
            this.lb_source.AutoSize = true;
            this.lb_source.Location = new System.Drawing.Point(93, 17);
            this.lb_source.Name = "lb_source";
            this.lb_source.Size = new System.Drawing.Size(0, 13);
            this.lb_source.TabIndex = 3;
            // 
            // btn_destination
            // 
            this.btn_destination.Location = new System.Drawing.Point(12, 41);
            this.btn_destination.Name = "btn_destination";
            this.btn_destination.Size = new System.Drawing.Size(75, 23);
            this.btn_destination.TabIndex = 2;
            this.btn_destination.Text = "Destino";
            this.btn_destination.UseVisualStyleBackColor = true;
            this.btn_destination.Click += new System.EventHandler(this.btn_destination_Click);
            // 
            // btn_source
            // 
            this.btn_source.Location = new System.Drawing.Point(12, 12);
            this.btn_source.Name = "btn_source";
            this.btn_source.Size = new System.Drawing.Size(75, 23);
            this.btn_source.TabIndex = 1;
            this.btn_source.Text = "Fonte";
            this.btn_source.UseVisualStyleBackColor = true;
            this.btn_source.Click += new System.EventHandler(this.btn_source_Click);
            // 
            // btn_configs
            // 
            this.btn_configs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_configs.Location = new System.Drawing.Point(12, 141);
            this.btn_configs.Name = "btn_configs";
            this.btn_configs.Size = new System.Drawing.Size(75, 23);
            this.btn_configs.TabIndex = 4;
            this.btn_configs.Text = "Configurar";
            this.btn_configs.UseVisualStyleBackColor = true;
            this.btn_configs.Click += new System.EventHandler(this.btn_configs_Click);
            // 
            // btn_deselect_all
            // 
            this.btn_deselect_all.Location = new System.Drawing.Point(93, 12);
            this.btn_deselect_all.Name = "btn_deselect_all";
            this.btn_deselect_all.Size = new System.Drawing.Size(75, 23);
            this.btn_deselect_all.TabIndex = 0;
            this.btn_deselect_all.Text = "Nenhum";
            this.btn_deselect_all.UseVisualStyleBackColor = true;
            this.btn_deselect_all.Click += new System.EventHandler(this.btn_deselect_all_Click);
            // 
            // btn_select_all
            // 
            this.btn_select_all.Location = new System.Drawing.Point(12, 12);
            this.btn_select_all.Name = "btn_select_all";
            this.btn_select_all.Size = new System.Drawing.Size(75, 23);
            this.btn_select_all.TabIndex = 3;
            this.btn_select_all.Text = "Todos";
            this.btn_select_all.UseVisualStyleBackColor = true;
            this.btn_select_all.Click += new System.EventHandler(this.btn_select_all_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_previous.Enabled = false;
            this.btn_previous.Location = new System.Drawing.Point(196, 141);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 23);
            this.btn_previous.TabIndex = 2;
            this.btn_previous.Text = "Anterior";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.Enabled = false;
            this.btn_next.Location = new System.Drawing.Point(277, 141);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Seguinte";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // fp_options
            // 
            this.fp_options.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fp_options.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fp_options.Location = new System.Drawing.Point(3, 41);
            this.fp_options.Name = "fp_options";
            this.fp_options.Padding = new System.Windows.Forms.Padding(10);
            this.fp_options.Size = new System.Drawing.Size(358, 94);
            this.fp_options.TabIndex = 0;
            // 
            // pb_preview
            // 
            this.pb_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_preview.Image = global::PhotoGroup.Properties.Resources.picture;
            this.pb_preview.ImageLocation = "";
            this.pb_preview.Location = new System.Drawing.Point(0, 70);
            this.pb_preview.Name = "pb_preview";
            this.pb_preview.Size = new System.Drawing.Size(364, 181);
            this.pb_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_preview.TabIndex = 0;
            this.pb_preview.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 431);
            this.Controls.Add(this.sc_wrap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(380, 470);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionador de Fotos";
            this.sc_wrap.Panel1.ResumeLayout(false);
            this.sc_wrap.Panel1.PerformLayout();
            this.sc_wrap.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_wrap)).EndInit();
            this.sc_wrap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_wrap;
        private System.Windows.Forms.PictureBox pb_preview;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.FlowLayoutPanel fp_options;
        private System.Windows.Forms.Button btn_destination;
        private System.Windows.Forms.Button btn_source;
        private System.Windows.Forms.Label lb_destination;
        private System.Windows.Forms.Label lb_source;
        private System.Windows.Forms.Button btn_deselect_all;
        private System.Windows.Forms.Button btn_select_all;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_configs;
    }
}

