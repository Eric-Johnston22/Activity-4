namespace Activity_4
{
    partial class timeConverter
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
            this.btn_convert = new System.Windows.Forms.Button();
            this.tbx_results = new System.Windows.Forms.TextBox();
            this.tbx_seconds = new System.Windows.Forms.TextBox();
            this.lbl_seconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_convert
            // 
            this.btn_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_convert.Location = new System.Drawing.Point(335, 204);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(79, 34);
            this.btn_convert.TabIndex = 0;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // tbx_results
            // 
            this.tbx_results.Location = new System.Drawing.Point(324, 280);
            this.tbx_results.Name = "tbx_results";
            this.tbx_results.Size = new System.Drawing.Size(100, 20);
            this.tbx_results.TabIndex = 1;
            // 
            // tbx_seconds
            // 
            this.tbx_seconds.Location = new System.Drawing.Point(425, 143);
            this.tbx_seconds.Name = "tbx_seconds";
            this.tbx_seconds.Size = new System.Drawing.Size(100, 20);
            this.tbx_seconds.TabIndex = 2;
            // 
            // lbl_seconds
            // 
            this.lbl_seconds.AutoSize = true;
            this.lbl_seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seconds.Location = new System.Drawing.Point(131, 137);
            this.lbl_seconds.Name = "lbl_seconds";
            this.lbl_seconds.Size = new System.Drawing.Size(254, 26);
            this.lbl_seconds.TabIndex = 3;
            this.lbl_seconds.Text = "Enter amount of seconds";
            // 
            // timeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_seconds);
            this.Controls.Add(this.tbx_seconds);
            this.Controls.Add(this.tbx_results);
            this.Controls.Add(this.btn_convert);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "timeConverter";
            this.Text = "Time Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.TextBox tbx_results;
        private System.Windows.Forms.TextBox tbx_seconds;
        private System.Windows.Forms.Label lbl_seconds;
    }
}

