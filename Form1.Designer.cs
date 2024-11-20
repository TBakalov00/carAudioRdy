
using System.Drawing.Imaging;

namespace Car_Audio
{
    partial class lblCarAudioProject
    {
       //public static string carMake = string.Empty;
       //public static string carModel = string.Empty;
       //public static string setup = string.Empty;


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
            btnNext = new Button();
            label1 = new Label();
            marka = new Label();
            markaBox = new ComboBox();
            model = new Label();
            modelBox = new ComboBox();
            dayCheck = new CheckBox();
            advCheck = new CheckBox();
            proCheck = new CheckBox();
            lblEx = new Label();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNext.Enabled = false;
            btnNext.Location = new Point(713, 415);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(776, 150);
            label1.TabIndex = 1;
            label1.Text = "Здравейте, тази програма ще ви помогне за проектирането на вашия автомобилен аудио проект.  За да бъдем максимално полезни, моля изберете марка и модел на автомобила, и желаната от вас конфигурация.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // marka
            // 
            marka.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            marka.AutoSize = true;
            marka.Font = new Font("Segoe UI", 14F);
            marka.Location = new Point(45, 227);
            marka.Name = "marka";
            marka.Size = new Size(73, 25);
            marka.TabIndex = 2;
            marka.Text = "Марка:";
            marka.Click += marka_Click;
            // 
            // markaBox
            // 
            markaBox.AutoCompleteCustomSource.AddRange(new string[] { "Mercedes-Benz" });
            markaBox.Font = new Font("Segoe UI", 12F);
            markaBox.FormattingEnabled = true;
            markaBox.Items.AddRange(new object[] { "Mercedes-Benz" });
            markaBox.Location = new Point(124, 223);
            markaBox.Name = "markaBox";
            markaBox.Size = new Size(207, 29);
            markaBox.TabIndex = 3;
            markaBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // model
            // 
            model.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            model.AutoSize = true;
            model.Font = new Font("Segoe UI", 14F);
            model.Location = new Point(380, 227);
            model.Name = "model";
            model.Size = new Size(74, 25);
            model.TabIndex = 4;
            model.Text = "Модел:";
            model.Click += model_Click;
            // 
            // modelBox
            // 
            modelBox.AutoCompleteCustomSource.AddRange(new string[] { "W210" });
            modelBox.Font = new Font("Segoe UI", 12F);
            modelBox.FormattingEnabled = true;
            modelBox.Items.AddRange(new object[] { "W210" });
            modelBox.Location = new Point(460, 223);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(207, 29);
            modelBox.TabIndex = 5;
            modelBox.SelectedIndexChanged += modelBox_SelectedIndexChanged;
            // 
            // dayCheck
            // 
            dayCheck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dayCheck.AutoSize = true;
            dayCheck.Font = new Font("Segoe UI", 14F);
            dayCheck.Location = new Point(264, 278);
            dayCheck.Name = "dayCheck";
            dayCheck.Size = new Size(256, 29);
            dayCheck.TabIndex = 6;
            dayCheck.Text = "Ежедневна конфигурация";
            dayCheck.UseVisualStyleBackColor = false;
            dayCheck.CheckedChanged += dayCheck_CheckedChanged;
            // 
            // advCheck
            // 
            advCheck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            advCheck.AutoSize = true;
            advCheck.Font = new Font("Segoe UI", 14F);
            advCheck.Location = new Point(264, 325);
            advCheck.Name = "advCheck";
            advCheck.Size = new Size(266, 29);
            advCheck.TabIndex = 7;
            advCheck.Text = "Напреднала конфигурация";
            advCheck.UseVisualStyleBackColor = true;
            advCheck.CheckedChanged += advCheck_CheckedChanged;
            // 
            // proCheck
            // 
            proCheck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            proCheck.AutoSize = true;
            proCheck.Font = new Font("Segoe UI", 14F);
            proCheck.Location = new Point(264, 371);
            proCheck.Name = "proCheck";
            proCheck.Size = new Size(302, 29);
            proCheck.TabIndex = 8;
            proCheck.Text = "Професионална конфигурация";
            proCheck.UseVisualStyleBackColor = true;
            proCheck.CheckedChanged += proCheck_CheckedChanged;
            // 
            // lblEx
            // 
            lblEx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEx.AutoSize = true;
            lblEx.Location = new Point(454, 419);
            lblEx.Name = "lblEx";
            lblEx.Size = new Size(0, 15);
            lblEx.TabIndex = 9;
            lblEx.Click += label2_Click;
            // 
            // lblCarAudioProject
            // 
            AcceptButton = btnNext;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEx);
            Controls.Add(proCheck);
            Controls.Add(advCheck);
            Controls.Add(dayCheck);
            Controls.Add(modelBox);
            Controls.Add(model);
            Controls.Add(markaBox);
            Controls.Add(marka);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Name = "lblCarAudioProject";
            Text = "CarAudioProject";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //params
            
            int empty = 0;
            int count = 0;
            carMake = string.Empty;
            carModel = string.Empty;
            setup = string.Empty;
            
            if (markaBox.SelectedItem != null)
            {
                carMake = markaBox.Text;
                count++;
            }
            if (modelBox.SelectedItem != null)
            {
                carModel = modelBox.Text;
                count++;
            }
            
            carMake = markaBox.Text;
            carModel = modelBox.Text;
            
            if (advCheck.Checked == true)
            {
                setup = advCheck.Text;
                empty++;
            }
            if (dayCheck.Checked == true)
            {
                setup = dayCheck.Text;
                empty++;
            }
            if (proCheck.Checked == true)
            {
                setup = proCheck.Text;
                empty++;
            }

            if (empty != 1 || count != 2)
            {

                lblEx.Text = "Моля попълнете всички полета";
                throw new Exception("Моля попълнете всички полета");
            }
            Form2 f2 = new Form2();
            f2.Show ();
        }

        #endregion

        private Button btnNext;
        private Label label1;
        private Label marka;
        private ComboBox markaBox;
        private Label model;
        private ComboBox modelBox;
        private CheckBox dayCheck;
        private CheckBox advCheck;
        private CheckBox proCheck;
        private Label lblEx;
    }
}
