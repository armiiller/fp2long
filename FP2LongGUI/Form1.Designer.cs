namespace FP2LongGUI
{
    partial class Form1
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
            this.b_delete = new System.Windows.Forms.Button();
            this.l_Path = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.l_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_delete
            // 
            this.b_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_delete.Location = new System.Drawing.Point(197, 39);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 23);
            this.b_delete.TabIndex = 0;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // l_Path
            // 
            this.l_Path.AutoSize = true;
            this.l_Path.Location = new System.Drawing.Point(13, 13);
            this.l_Path.Name = "l_Path";
            this.l_Path.Size = new System.Drawing.Size(29, 13);
            this.l_Path.TabIndex = 1;
            this.l_Path.Text = "Path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tb_Path
            // 
            this.tb_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Path.Location = new System.Drawing.Point(48, 13);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(224, 20);
            this.tb_Path.TabIndex = 2;
            this.tb_Path.Click += new System.EventHandler(this.tb_Path_Click);
            // 
            // tb_output
            // 
            this.tb_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_output.Location = new System.Drawing.Point(16, 81);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_output.Size = new System.Drawing.Size(256, 169);
            this.tb_output.TabIndex = 3;
            // 
            // l_output
            // 
            this.l_output.AutoSize = true;
            this.l_output.Location = new System.Drawing.Point(16, 62);
            this.l_output.Name = "l_output";
            this.l_output.Size = new System.Drawing.Size(39, 13);
            this.l_output.TabIndex = 4;
            this.l_output.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.l_output);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.l_Path);
            this.Controls.Add(this.b_delete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Label l_Path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label l_output;
    }
}

