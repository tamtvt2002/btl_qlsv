
namespace BigProject.GUI
{
    partial class ThongkeForm
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
            this.label_Tongsv = new System.Windows.Forms.Label();
            this.label_TongGv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Tongsv
            // 
            this.label_Tongsv.BackColor = System.Drawing.Color.Navy;
            this.label_Tongsv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tongsv.ForeColor = System.Drawing.Color.White;
            this.label_Tongsv.Location = new System.Drawing.Point(198, 101);
            this.label_Tongsv.Name = "label_Tongsv";
            this.label_Tongsv.Size = new System.Drawing.Size(171, 158);
            this.label_Tongsv.TabIndex = 0;
            this.label_Tongsv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TongGv
            // 
            this.label_TongGv.BackColor = System.Drawing.Color.Gray;
            this.label_TongGv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TongGv.ForeColor = System.Drawing.Color.White;
            this.label_TongGv.Location = new System.Drawing.Point(557, 101);
            this.label_TongGv.Name = "label_TongGv";
            this.label_TongGv.Size = new System.Drawing.Size(171, 158);
            this.label_TongGv.TabIndex = 1;
            this.label_TongGv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThongkeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 602);
            this.Controls.Add(this.label_TongGv);
            this.Controls.Add(this.label_Tongsv);
            this.Name = "ThongkeForm";
            this.Text = "ThongkeForm";
            this.Load += new System.EventHandler(this.ThongkeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Tongsv;
        private System.Windows.Forms.Label label_TongGv;
    }
}