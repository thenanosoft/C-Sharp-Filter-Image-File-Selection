namespace Select_Image
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSlctImg = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSlctImg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 61);
            this.panel2.TabIndex = 1;
            // 
            // btnSlctImg
            // 
            this.btnSlctImg.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSlctImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSlctImg.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlctImg.ForeColor = System.Drawing.Color.White;
            this.btnSlctImg.Location = new System.Drawing.Point(0, 0);
            this.btnSlctImg.Margin = new System.Windows.Forms.Padding(10);
            this.btnSlctImg.Name = "btnSlctImg";
            this.btnSlctImg.Size = new System.Drawing.Size(800, 61);
            this.btnSlctImg.TabIndex = 0;
            this.btnSlctImg.Text = "Select Image";
            this.btnSlctImg.UseVisualStyleBackColor = false;
            this.btnSlctImg.Click += new System.EventHandler(this.btnSlctImg_Click);
            // 
            // imgBox
            // 
            this.imgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBox.Image = ((System.Drawing.Image)(resources.GetObject("imgBox.Image")));
            this.imgBox.Location = new System.Drawing.Point(0, 0);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(800, 389);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox.TabIndex = 2;
            this.imgBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Filter File Selection";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSlctImg;
        private System.Windows.Forms.PictureBox imgBox;
    }
}

