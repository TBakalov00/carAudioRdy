namespace Car_Audio
{
    partial class Form2
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
            Page1 = new TabControl();
            tabPage1 = new TabPage();
            shemaGovoriteli = new PictureBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            shemaSvurzvane = new PictureBox();
            label3 = new Label();
            tabPage3 = new TabPage();
            label1 = new Label();
            btnExit = new Button();
            Page1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shemaGovoriteli).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shemaSvurzvane).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // Page1
            // 
            Page1.Controls.Add(tabPage1);
            Page1.Controls.Add(tabPage2);
            Page1.Controls.Add(tabPage3);
            Page1.Font = new Font("Segoe UI", 10F);
            Page1.Location = new Point(-1, -1);
            Page1.Name = "Page1";
            Page1.SelectedIndex = 0;
            Page1.Size = new Size(1153, 710);
            Page1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(shemaGovoriteli);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1145, 680);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // shemaGovoriteli
            // 
            shemaGovoriteli.Location = new Point(9, 54);
            shemaGovoriteli.Name = "shemaGovoriteli";
            shemaGovoriteli.Size = new Size(1024, 715);
            shemaGovoriteli.SizeMode = PictureBoxSizeMode.StretchImage;
            shemaGovoriteli.TabIndex = 1;
            shemaGovoriteli.TabStop = false;
            shemaGovoriteli.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(306, 16);
            label2.Name = "label2";
            label2.Size = new Size(416, 35);
            label2.TabIndex = 0;
            label2.Text = "Схема на говорителите";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(shemaSvurzvane);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1145, 680);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // shemaSvurzvane
            // 
            shemaSvurzvane.Location = new Point(9, 62);
            shemaSvurzvane.Name = "shemaSvurzvane";
            shemaSvurzvane.Size = new Size(1024, 715);
            shemaSvurzvane.SizeMode = PictureBoxSizeMode.StretchImage;
            shemaSvurzvane.TabIndex = 1;
            shemaSvurzvane.TabStop = false;
            shemaSvurzvane.Click += shemaSvurzvane_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Microsoft Sans Serif", 14F);
            label3.Location = new Point(354, 3);
            label3.Name = "label3";
            label3.Size = new Size(434, 43);
            label3.TabIndex = 0;
            label3.Text = "Схема на свързване";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            tabPage3.AutoScroll = true;
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(btnExit);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1145, 680);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 1;
            label1.Text = "Свободен текст";
            label1.Click += label1_Click_1;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExit.Location = new Point(1021, 593);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1111, 653);
            Controls.Add(Page1);
            Name = "Form2";
            Text = "Form2";
            Page1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)shemaGovoriteli).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)shemaSvurzvane).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Page1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox shemaGovoriteli;
        private PictureBox shemaSvurzvane;
    }
}