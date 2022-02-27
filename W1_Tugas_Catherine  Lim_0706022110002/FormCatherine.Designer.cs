
namespace W1_Tugas_Catherine__Lim_0706022110002
{
    partial class FormCatherine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelCatherine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelCatherine
            // 
            this.LabelCatherine.AutoSize = true;
            this.LabelCatherine.Location = new System.Drawing.Point(119, 45);
            this.LabelCatherine.Name = "LabelCatherine";
            this.LabelCatherine.Size = new System.Drawing.Size(217, 25);
            this.LabelCatherine.TabIndex = 0;
            this.LabelCatherine.Text = "HI! My Name is Catherine.";
            // 
            // FormCatherine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 112);
            this.Controls.Add(this.LabelCatherine);
            this.Name = "FormCatherine";
            this.Text = "Catherine Lim_0706022110002";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCatherine;
    }
}

