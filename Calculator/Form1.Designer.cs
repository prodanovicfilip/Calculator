namespace Calculator
{
    partial class Form1
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
            TB_Field = new TextBox();
            BT_plus = new Button();
            BT_Minus = new Button();
            BT_Multi = new Button();
            BT_Division = new Button();
            BT_Result = new Button();
            TB_Result = new TextBox();
            BT_Clear = new Button();
            SuspendLayout();
            // 
            // TB_Field
            // 
            TB_Field.Location = new Point(12, 28);
            TB_Field.Name = "TB_Field";
            TB_Field.Size = new Size(140, 23);
            TB_Field.TabIndex = 0;
            // 
            // BT_plus
            // 
            BT_plus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BT_plus.Location = new Point(12, 64);
            BT_plus.Name = "BT_plus";
            BT_plus.Size = new Size(140, 30);
            BT_plus.TabIndex = 1;
            BT_plus.Text = "+";
            BT_plus.UseVisualStyleBackColor = true;
            BT_plus.Click += BT_plus_Click;
            // 
            // BT_Minus
            // 
            BT_Minus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BT_Minus.Location = new Point(12, 100);
            BT_Minus.Name = "BT_Minus";
            BT_Minus.Size = new Size(140, 30);
            BT_Minus.TabIndex = 2;
            BT_Minus.Text = "−";
            BT_Minus.UseVisualStyleBackColor = true;
            BT_Minus.Click += BT_Minus_Click;
            // 
            // BT_Multi
            // 
            BT_Multi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BT_Multi.Location = new Point(12, 136);
            BT_Multi.Name = "BT_Multi";
            BT_Multi.Size = new Size(140, 30);
            BT_Multi.TabIndex = 3;
            BT_Multi.Text = "x";
            BT_Multi.UseVisualStyleBackColor = true;
            BT_Multi.Click += BT_Multi_Click;
            // 
            // BT_Division
            // 
            BT_Division.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BT_Division.Location = new Point(12, 172);
            BT_Division.Name = "BT_Division";
            BT_Division.Size = new Size(140, 30);
            BT_Division.TabIndex = 4;
            BT_Division.Text = "/";
            BT_Division.UseVisualStyleBackColor = true;
            BT_Division.Click += BT_Division_Click;
            // 
            // BT_Result
            // 
            BT_Result.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BT_Result.Location = new Point(195, 64);
            BT_Result.Name = "BT_Result";
            BT_Result.Size = new Size(140, 30);
            BT_Result.TabIndex = 5;
            BT_Result.Text = "=";
            BT_Result.UseVisualStyleBackColor = true;
            BT_Result.Click += BT_Result_Click;
            // 
            // TB_Result
            // 
            TB_Result.Location = new Point(195, 28);
            TB_Result.Name = "TB_Result";
            TB_Result.Size = new Size(140, 23);
            TB_Result.TabIndex = 6;
            // 
            // BT_Clear
            // 
            BT_Clear.Font = new Font("Segoe UI", 12F);
            BT_Clear.Location = new Point(195, 100);
            BT_Clear.Name = "BT_Clear";
            BT_Clear.Size = new Size(140, 30);
            BT_Clear.TabIndex = 7;
            BT_Clear.Text = "Clear";
            BT_Clear.UseVisualStyleBackColor = true;
            BT_Clear.Click += BT_Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 286);
            Controls.Add(BT_Clear);
            Controls.Add(TB_Result);
            Controls.Add(BT_Result);
            Controls.Add(BT_Division);
            Controls.Add(BT_Multi);
            Controls.Add(BT_Minus);
            Controls.Add(BT_plus);
            Controls.Add(TB_Field);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Field;
        private Button BT_plus;
        private Button BT_Minus;
        private Button BT_Multi;
        private Button BT_Division;
        private Button BT_Result;
        private TextBox TB_Result;
        private Button BT_Clear;
    }
}
