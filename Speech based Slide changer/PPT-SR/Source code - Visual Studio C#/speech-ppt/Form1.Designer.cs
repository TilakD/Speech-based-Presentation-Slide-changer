namespace speech_ppt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ppt_file = new System.Windows.Forms.TextBox();
            this.pdf_file = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pdf_present = new System.Windows.Forms.Button();
            this.pdf_brouse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(538, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(28, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(626, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start presentation in Powerpoint";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Powerpoint file:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ppt_file
            // 
            this.ppt_file.Location = new System.Drawing.Point(128, 20);
            this.ppt_file.Multiline = true;
            this.ppt_file.Name = "ppt_file";
            this.ppt_file.Size = new System.Drawing.Size(404, 34);
            this.ppt_file.TabIndex = 3;
            this.ppt_file.TextChanged += new System.EventHandler(this.ppt_file_TextChanged);
            // 
            // pdf_file
            // 
            this.pdf_file.Location = new System.Drawing.Point(125, 29);
            this.pdf_file.Multiline = true;
            this.pdf_file.Name = "pdf_file";
            this.pdf_file.Size = new System.Drawing.Size(404, 34);
            this.pdf_file.TabIndex = 7;
            this.pdf_file.TextChanged += new System.EventHandler(this.pdf_file_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adobe PDF file:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pdf_present
            // 
            this.pdf_present.BackColor = System.Drawing.Color.Green;
            this.pdf_present.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdf_present.ForeColor = System.Drawing.Color.White;
            this.pdf_present.Location = new System.Drawing.Point(25, 81);
            this.pdf_present.Name = "pdf_present";
            this.pdf_present.Size = new System.Drawing.Size(626, 44);
            this.pdf_present.TabIndex = 5;
            this.pdf_present.Text = "Start presentation in Adobe reader";
            this.pdf_present.UseVisualStyleBackColor = false;
            this.pdf_present.Click += new System.EventHandler(this.pdf_present_Click);
            // 
            // pdf_brouse
            // 
            this.pdf_brouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdf_brouse.Location = new System.Drawing.Point(535, 29);
            this.pdf_brouse.Name = "pdf_brouse";
            this.pdf_brouse.Size = new System.Drawing.Size(116, 34);
            this.pdf_brouse.TabIndex = 4;
            this.pdf_brouse.Text = "Browse";
            this.pdf_brouse.UseVisualStyleBackColor = true;
            this.pdf_brouse.Click += new System.EventHandler(this.pdf_brouse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ppt_file);
            this.groupBox1.Location = new System.Drawing.Point(260, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To present in powerpoint.";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.pdf_present);
            this.groupBox2.Controls.Add(this.pdf_brouse);
            this.groupBox2.Controls.Add(this.pdf_file);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(260, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 150);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To present a PDF (LATEX).";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 733);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Speech based presentation slide changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ppt_file;
        private System.Windows.Forms.TextBox pdf_file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pdf_present;
        private System.Windows.Forms.Button pdf_brouse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

