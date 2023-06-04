namespace VisualGeometrySimulator
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
            btnClickThis = new Button();
            lblText = new Label();
            ResultBox = new Label();
            AnswerBox = new TextBox();
            CorrectOrIncorrectButton = new Label();
            HelpButton = new Button();
            Greeting = new Label();
            HelpText = new Label();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(85, 82);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(191, 29);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Начать тест";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += button1_Click;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.BackColor = SystemColors.ButtonFace;
            lblText.Location = new Point(253, 224);
            lblText.Name = "lblText";
            lblText.Size = new Size(0, 20);
            lblText.TabIndex = 1;
            lblText.Click += label1_Click;
            // 
            // ResultBox
            // 
            ResultBox.AutoSize = true;
            ResultBox.Location = new Point(49, 184);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(0, 20);
            ResultBox.TabIndex = 2;
            ResultBox.Click += label1_Click_1;
            // 
            // AnswerBox
            // 
            AnswerBox.Location = new Point(253, 247);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(125, 27);
            AnswerBox.TabIndex = 3;
            // 
            // CorrectOrIncorrectButton
            // 
            CorrectOrIncorrectButton.AutoSize = true;
            CorrectOrIncorrectButton.Location = new Point(262, 277);
            CorrectOrIncorrectButton.Name = "CorrectOrIncorrectButton";
            CorrectOrIncorrectButton.Size = new Size(0, 20);
            CorrectOrIncorrectButton.TabIndex = 5;
            // 
            // HelpButton
            // 
            HelpButton.BackColor = SystemColors.ControlLight;
            HelpButton.Location = new Point(694, 134);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(94, 29);
            HelpButton.TabIndex = 6;
            HelpButton.Text = "Подсказка";
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // Greeting
            // 
            Greeting.AutoSize = true;
            Greeting.Location = new Point(23, 9);
            Greeting.Name = "Greeting";
            Greeting.Size = new Size(683, 20);
            Greeting.TabIndex = 7;
            Greeting.Text = "Добро пожаловать! Сейчас вы пройдете тест на ваши знания по алгебре и немного геометрии!";
            // 
            // HelpText
            // 
            HelpText.AutoSize = true;
            HelpText.Location = new Point(483, 254);
            HelpText.Name = "HelpText";
            HelpText.Size = new Size(0, 20);
            HelpText.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(892, 379);
            Controls.Add(HelpText);
            Controls.Add(Greeting);
            Controls.Add(HelpButton);
            Controls.Add(CorrectOrIncorrectButton);
            Controls.Add(AnswerBox);
            Controls.Add(ResultBox);
            Controls.Add(lblText);
            Controls.Add(btnClickThis);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private Label lblText;
        private Label ResultBox;
        private TextBox answerBox;
        private Label CorrectOrIncorrectButton;
        private TextBox AnswerBox;
        private Button HelpButton;
        private Label Greeting;
        private Label HelpText;
    }
}