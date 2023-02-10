namespace Lab_1109_ADO_v1
{
    partial class Form4
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
            this.btn_enum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_enum
            // 
            this.btn_enum.Location = new System.Drawing.Point(105, 57);
            this.btn_enum.Name = "btn_enum";
            this.btn_enum.Size = new System.Drawing.Size(164, 71);
            this.btn_enum.TabIndex = 0;
            this.btn_enum.Text = "button1";
            this.btn_enum.UseVisualStyleBackColor = true;
            this.btn_enum.Click += new System.EventHandler(this.btn_enum_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 207);
            this.Controls.Add(this.btn_enum);
            this.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_enum;
    }
}