namespace CClans_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(336, 27);
            label1.TabIndex = 0;
            label1.Text = "CClans V3";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(12, 36);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(336, 141);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 6F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(318, 307);
            label2.Name = "label2";
            label2.Size = new Size(42, 11);
            label2.TabIndex = 3;
            label2.Text = "Version 3,0";
            label2.TextAlign = ContentAlignment.BottomRight;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(60, 177);
            button1.Name = "button1";
            button1.Size = new Size(237, 28);
            button1.TabIndex = 4;
            button1.Text = "Let the almighty pufferfish clean your pc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(60, 211);
            button2.Name = "button2";
            button2.Size = new Size(237, 28);
            button2.TabIndex = 5;
            button2.Text = "Turn off hybernation (more space)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(60, 245);
            button3.Name = "button3";
            button3.Size = new Size(237, 28);
            button3.TabIndex = 6;
            button3.Text = "Turn on hybernation (less space)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(60, 279);
            button4.Name = "button4";
            button4.Size = new Size(237, 28);
            button4.TabIndex = 7;
            button4.Text = "Component cleanup (safe winSxS cleanup)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 318);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CClans v3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
