namespace File_Location
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
            this.path = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.open = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.Location = new System.Drawing.Point(99, 56);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(76, 16);
            this.path.TabIndex = 0;
            this.path.Text = "File Path:";
            this.path.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 38);
            this.textBox1.TabIndex = 1;
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.Location = new System.Drawing.Point(149, 125);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(123, 35);
            this.open.TabIndex = 2;
            this.open.Text = "Open File";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(358, 125);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(123, 35);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete File";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(260, 202);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(123, 35);
            this.status.TabIndex = 4;
            this.status.Text = "Check Status";
            this.status.UseVisualStyleBackColor = true;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(674, 318);
            this.Controls.Add(this.status);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.open);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label path;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button status;
    }
}

