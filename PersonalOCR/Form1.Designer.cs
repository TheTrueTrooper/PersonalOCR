namespace PersonalOCR
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
            this.RiTe_View = new System.Windows.Forms.RichTextBox();
            this.Bu_LoadIn = new System.Windows.Forms.Button();
            this.Bu_Prev = new System.Windows.Forms.Button();
            this.Bu_Next = new System.Windows.Forms.Button();
            this.La_PageNumber = new System.Windows.Forms.Label();
            this.Bu_FlipPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RiTe_View
            // 
            this.RiTe_View.Location = new System.Drawing.Point(14, 3);
            this.RiTe_View.Name = "RiTe_View";
            this.RiTe_View.ReadOnly = true;
            this.RiTe_View.Size = new System.Drawing.Size(1149, 572);
            this.RiTe_View.TabIndex = 1;
            this.RiTe_View.Text = "";
            // 
            // Bu_LoadIn
            // 
            this.Bu_LoadIn.Location = new System.Drawing.Point(348, 610);
            this.Bu_LoadIn.Name = "Bu_LoadIn";
            this.Bu_LoadIn.Size = new System.Drawing.Size(470, 23);
            this.Bu_LoadIn.TabIndex = 2;
            this.Bu_LoadIn.Text = "Load PDF";
            this.Bu_LoadIn.UseVisualStyleBackColor = true;
            this.Bu_LoadIn.Click += new System.EventHandler(this.BuLoadIn_Click);
            // 
            // Bu_Prev
            // 
            this.Bu_Prev.Enabled = false;
            this.Bu_Prev.Location = new System.Drawing.Point(3, 610);
            this.Bu_Prev.Name = "Bu_Prev";
            this.Bu_Prev.Size = new System.Drawing.Size(339, 23);
            this.Bu_Prev.TabIndex = 3;
            this.Bu_Prev.Text = "Prev Page";
            this.Bu_Prev.UseVisualStyleBackColor = true;
            this.Bu_Prev.Click += new System.EventHandler(this.Bu_Prev_Click);
            // 
            // Bu_Next
            // 
            this.Bu_Next.Enabled = false;
            this.Bu_Next.Location = new System.Drawing.Point(824, 610);
            this.Bu_Next.Name = "Bu_Next";
            this.Bu_Next.Size = new System.Drawing.Size(339, 23);
            this.Bu_Next.TabIndex = 4;
            this.Bu_Next.Text = "Next Page";
            this.Bu_Next.UseVisualStyleBackColor = true;
            this.Bu_Next.Click += new System.EventHandler(this.Bu_Next_Click);
            // 
            // La_PageNumber
            // 
            this.La_PageNumber.AutoSize = true;
            this.La_PageNumber.Location = new System.Drawing.Point(11, 584);
            this.La_PageNumber.Name = "La_PageNumber";
            this.La_PageNumber.Size = new System.Drawing.Size(93, 13);
            this.La_PageNumber.TabIndex = 5;
            this.La_PageNumber.Text = "Page Number Null";
            // 
            // Bu_FlipPDF
            // 
            this.Bu_FlipPDF.Location = new System.Drawing.Point(824, 581);
            this.Bu_FlipPDF.Name = "Bu_FlipPDF";
            this.Bu_FlipPDF.Size = new System.Drawing.Size(339, 23);
            this.Bu_FlipPDF.TabIndex = 6;
            this.Bu_FlipPDF.Text = "Flip PDF";
            this.Bu_FlipPDF.UseVisualStyleBackColor = true;
            this.Bu_FlipPDF.Click += new System.EventHandler(this.Bu_FlipPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 642);
            this.Controls.Add(this.Bu_FlipPDF);
            this.Controls.Add(this.RiTe_View);
            this.Controls.Add(this.Bu_LoadIn);
            this.Controls.Add(this.Bu_Prev);
            this.Controls.Add(this.Bu_Next);
            this.Controls.Add(this.La_PageNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox RiTe_View;
        private System.Windows.Forms.Button Bu_LoadIn;
        private System.Windows.Forms.Button Bu_Prev;
        private System.Windows.Forms.Button Bu_Next;
        private System.Windows.Forms.Label La_PageNumber;
        private System.Windows.Forms.Button Bu_FlipPDF;
    }
}

