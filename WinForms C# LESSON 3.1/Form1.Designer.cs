namespace WinForms_C__LESSON_3._1
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
            nameLabel = new Label();
            nameTextBox1 = new TextBox();
            surnametextBox1 = new TextBox();
            surnameLabel = new Label();
            emailTextBox1 = new TextBox();
            emailLabel = new Label();
            TelefonTextBox1 = new TextBox();
            TelefonLabel = new Label();
            dateTimeLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            elaveEtButton = new Button();
            deyisButton = new Button();
            insanlarLlabel = new Label();
            personListBox1 = new ListBox();
            insanAnketiLabel = new Label();
            LoadButton = new Button();
            SaveButton = new Button();
            fileAdilabel = new Label();
            eroreLabel = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Rockwell Extra Bold", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = SystemColors.WindowFrame;
            nameLabel.Location = new Point(60, 76);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 28);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Ad";
            nameLabel.Click += name_Click;
            // 
            // nameTextBox1
            // 
            nameTextBox1.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox1.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox1.Location = new Point(161, 71);
            nameTextBox1.MaxLength = 20;
            nameTextBox1.Name = "nameTextBox1";
            nameTextBox1.Size = new Size(270, 35);
            nameTextBox1.TabIndex = 1;
            nameTextBox1.TextChanged += nameTextBox1_TextChanged;
            // 
            // surnametextBox1
            // 
            surnametextBox1.BorderStyle = BorderStyle.FixedSingle;
            surnametextBox1.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            surnametextBox1.Location = new Point(161, 123);
            surnametextBox1.MaxLength = 20;
            surnametextBox1.Name = "surnametextBox1";
            surnametextBox1.Size = new Size(270, 35);
            surnametextBox1.TabIndex = 3;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Rockwell Extra Bold", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            surnameLabel.ForeColor = SystemColors.WindowFrame;
            surnameLabel.Location = new Point(60, 128);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(64, 28);
            surnameLabel.TabIndex = 2;
            surnameLabel.Text = "SAd";
            // 
            // emailTextBox1
            // 
            emailTextBox1.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox1.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox1.Location = new Point(161, 175);
            emailTextBox1.MaxLength = 26;
            emailTextBox1.Name = "emailTextBox1";
            emailTextBox1.Size = new Size(270, 35);
            emailTextBox1.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Rockwell Extra Bold", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.WindowFrame;
            emailLabel.Location = new Point(60, 180);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(97, 28);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email";
            // 
            // TelefonTextBox1
            // 
            TelefonTextBox1.BorderStyle = BorderStyle.FixedSingle;
            TelefonTextBox1.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            TelefonTextBox1.Location = new Point(161, 227);
            TelefonTextBox1.MaxLength = 10;
            TelefonTextBox1.Name = "TelefonTextBox1";
            TelefonTextBox1.Size = new Size(270, 35);
            TelefonTextBox1.TabIndex = 7;
            // 
            // TelefonLabel
            // 
            TelefonLabel.AutoSize = true;
            TelefonLabel.Font = new Font("Rockwell Extra Bold", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            TelefonLabel.ForeColor = SystemColors.WindowFrame;
            TelefonLabel.Location = new Point(60, 232);
            TelefonLabel.Name = "TelefonLabel";
            TelefonLabel.Size = new Size(57, 28);
            TelefonLabel.TabIndex = 6;
            TelefonLabel.Text = "Tel";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Rockwell Extra Bold", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeLabel.ForeColor = SystemColors.WindowFrame;
            dateTimeLabel.Location = new Point(60, 284);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(51, 28);
            dateTimeLabel.TabIndex = 8;
            dateTimeLabel.Text = "DT";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(161, 284);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 30);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.Value = new DateTime(2023, 10, 11, 0, 0, 0, 0);
            // 
            // elaveEtButton
            // 
            elaveEtButton.BackColor = SystemColors.ActiveBorder;
            elaveEtButton.Font = new Font("Rockwell Extra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            elaveEtButton.ForeColor = SystemColors.WindowFrame;
            elaveEtButton.Location = new Point(302, 362);
            elaveEtButton.Name = "elaveEtButton";
            elaveEtButton.Size = new Size(129, 46);
            elaveEtButton.TabIndex = 10;
            elaveEtButton.Text = "Elave Et";
            elaveEtButton.UseVisualStyleBackColor = false;
            elaveEtButton.Click += elaveEtButton_Click;
            // 
            // deyisButton
            // 
            deyisButton.BackColor = SystemColors.ActiveBorder;
            deyisButton.Font = new Font("Rockwell Extra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            deyisButton.ForeColor = SystemColors.WindowFrame;
            deyisButton.Location = new Point(161, 362);
            deyisButton.Name = "deyisButton";
            deyisButton.Size = new Size(129, 46);
            deyisButton.TabIndex = 11;
            deyisButton.Text = "Deyis";
            deyisButton.UseVisualStyleBackColor = false;
            deyisButton.Click += deyisButton_Click;
            // 
            // insanlarLlabel
            // 
            insanlarLlabel.AutoSize = true;
            insanlarLlabel.Font = new Font("Rockwell Extra Bold", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            insanlarLlabel.ForeColor = SystemColors.WindowFrame;
            insanlarLlabel.Location = new Point(564, 22);
            insanlarLlabel.Name = "insanlarLlabel";
            insanlarLlabel.Size = new Size(135, 28);
            insanlarLlabel.TabIndex = 12;
            insanlarLlabel.Text = "Insanlar";
            // 
            // personListBox1
            // 
            personListBox1.FormattingEnabled = true;
            personListBox1.ItemHeight = 23;
            personListBox1.Location = new Point(496, 71);
            personListBox1.Name = "personListBox1";
            personListBox1.Size = new Size(254, 234);
            personListBox1.TabIndex = 13;
            personListBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // insanAnketiLabel
            // 
            insanAnketiLabel.AutoSize = true;
            insanAnketiLabel.Font = new Font("Rockwell Extra Bold", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            insanAnketiLabel.ForeColor = SystemColors.WindowFrame;
            insanAnketiLabel.Location = new Point(200, 22);
            insanAnketiLabel.Name = "insanAnketiLabel";
            insanAnketiLabel.Size = new Size(193, 28);
            insanAnketiLabel.TabIndex = 14;
            insanAnketiLabel.Text = "Insan Anketi";
            // 
            // LoadButton
            // 
            LoadButton.BackColor = SystemColors.ActiveBorder;
            LoadButton.Font = new Font("Rockwell Extra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoadButton.ForeColor = SystemColors.WindowFrame;
            LoadButton.Location = new Point(496, 362);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(119, 46);
            LoadButton.TabIndex = 15;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = false;
            LoadButton.Click += LoadButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.ActiveBorder;
            SaveButton.Font = new Font("Rockwell Extra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = SystemColors.WindowFrame;
            SaveButton.Location = new Point(631, 362);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(119, 46);
            SaveButton.TabIndex = 16;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // fileAdilabel
            // 
            fileAdilabel.BackColor = SystemColors.ButtonHighlight;
            fileAdilabel.Location = new Point(496, 325);
            fileAdilabel.Name = "fileAdilabel";
            fileAdilabel.Size = new Size(254, 29);
            fileAdilabel.TabIndex = 17;
            // 
            // eroreLabel
            // 
            eroreLabel.ForeColor = Color.Red;
            eroreLabel.Location = new Point(161, 331);
            eroreLabel.Name = "eroreLabel";
            eroreLabel.Size = new Size(270, 28);
            eroreLabel.TabIndex = 18;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(eroreLabel);
            Controls.Add(fileAdilabel);
            Controls.Add(SaveButton);
            Controls.Add(LoadButton);
            Controls.Add(insanAnketiLabel);
            Controls.Add(personListBox1);
            Controls.Add(insanlarLlabel);
            Controls.Add(deyisButton);
            Controls.Add(elaveEtButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimeLabel);
            Controls.Add(TelefonTextBox1);
            Controls.Add(TelefonLabel);
            Controls.Add(emailTextBox1);
            Controls.Add(emailLabel);
            Controls.Add(surnametextBox1);
            Controls.Add(surnameLabel);
            Controls.Add(nameTextBox1);
            Controls.Add(nameLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox1;
        private TextBox surnametextBox1;
        private Label surnameLabel;
        private TextBox emailTextBox1;
        private Label emailLabel;
        private TextBox TelefonTextBox1;
        private Label TelefonLabel;
        private Label dateTimeLabel;
        private DateTimePicker dateTimePicker1;
        private Button elaveEtButton;
        private Button deyisButton;
        private Label insanlarLlabel;
        private ListBox personListBox1;
        private Label insanAnketiLabel;
        private Button LoadButton;
        private Button SaveButton;
        private Label fileAdilabel;
        private Label eroreLabel;
        private OpenFileDialog openFileDialog1;
    }
}