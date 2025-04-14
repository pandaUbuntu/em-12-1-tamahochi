namespace tamagochi
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
            TumagochiBox = new GroupBox();
            HungryValue = new Label();
            Hungry = new Label();
            Energy = new Label();
            EnergyValue = new Label();
            Stats = new Label();
            HappyValue = new Label();
            Happy = new Label();
            Feed = new Button();
            Sleep = new Button();
            Play = new Button();
            ButtonsBox = new GroupBox();
            Functions = new Label();
            TumagochiBox.SuspendLayout();
            ButtonsBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ControlLight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(0, 36);
            label1.Name = "label1";
            label1.Size = new Size(295, 304);
            label1.TabIndex = 0;
            // 
            // TumagochiBox
            // 
            TumagochiBox.Controls.Add(HungryValue);
            TumagochiBox.Controls.Add(Hungry);
            TumagochiBox.Controls.Add(Energy);
            TumagochiBox.Controls.Add(EnergyValue);
            TumagochiBox.Controls.Add(Stats);
            TumagochiBox.Controls.Add(HappyValue);
            TumagochiBox.Controls.Add(Happy);
            TumagochiBox.Controls.Add(label1);
            TumagochiBox.Font = new Font("Segoe UI", 16.2F);
            TumagochiBox.Location = new Point(12, 12);
            TumagochiBox.Name = "TumagochiBox";
            TumagochiBox.Size = new Size(601, 343);
            TumagochiBox.TabIndex = 1;
            TumagochiBox.TabStop = false;
            TumagochiBox.Text = "Your pet";
            // 
            // HungryValue
            // 
            HungryValue.AutoSize = true;
            HungryValue.BackColor = Color.MistyRose;
            HungryValue.Font = new Font("Segoe UI", 16.2F);
            HungryValue.Location = new Point(466, 242);
            HungryValue.MinimumSize = new Size(0, 41);
            HungryValue.Name = "HungryValue";
            HungryValue.Size = new Size(32, 41);
            HungryValue.TabIndex = 5;
            HungryValue.Text = "0";
            // 
            // Hungry
            // 
            Hungry.BackColor = Color.MistyRose;
            Hungry.Font = new Font("Segoe UI", 16.2F);
            Hungry.Location = new Point(333, 242);
            Hungry.Name = "Hungry";
            Hungry.Size = new Size(127, 41);
            Hungry.TabIndex = 3;
            Hungry.Text = "Голод : ";
            // 
            // Energy
            // 
            Energy.BackColor = Color.MistyRose;
            Energy.Font = new Font("Segoe UI", 16.2F);
            Energy.Location = new Point(333, 170);
            Energy.Name = "Energy";
            Energy.Size = new Size(127, 41);
            Energy.TabIndex = 4;
            Energy.Text = "Енергія :";
            // 
            // EnergyValue
            // 
            EnergyValue.AutoSize = true;
            EnergyValue.BackColor = Color.MistyRose;
            EnergyValue.Font = new Font("Segoe UI", 16.2F);
            EnergyValue.Location = new Point(466, 170);
            EnergyValue.MinimumSize = new Size(0, 41);
            EnergyValue.Name = "EnergyValue";
            EnergyValue.Size = new Size(62, 41);
            EnergyValue.TabIndex = 2;
            EnergyValue.Text = "100";
            // 
            // Stats
            // 
            Stats.BackColor = Color.MistyRose;
            Stats.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Stats.Location = new Point(333, 23);
            Stats.Name = "Stats";
            Stats.Size = new Size(222, 41);
            Stats.TabIndex = 3;
            Stats.Text = "Статистика : ";
            // 
            // HappyValue
            // 
            HappyValue.AutoSize = true;
            HappyValue.BackColor = Color.MistyRose;
            HappyValue.Font = new Font("Segoe UI", 16.2F);
            HappyValue.Location = new Point(466, 81);
            HappyValue.MinimumSize = new Size(0, 41);
            HappyValue.Name = "HappyValue";
            HappyValue.Size = new Size(62, 41);
            HappyValue.TabIndex = 2;
            HappyValue.Text = "100";
            // 
            // Happy
            // 
            Happy.BackColor = Color.MistyRose;
            Happy.Font = new Font("Segoe UI", 16.2F);
            Happy.Location = new Point(333, 81);
            Happy.Name = "Happy";
            Happy.Size = new Size(127, 41);
            Happy.TabIndex = 1;
            Happy.Text = "Щастя : ";
            // 
            // Feed
            // 
            Feed.BackColor = Color.OliveDrab;
            Feed.Font = new Font("Segoe UI", 16.2F);
            Feed.Location = new Point(6, 106);
            Feed.Name = "Feed";
            Feed.Size = new Size(238, 61);
            Feed.TabIndex = 2;
            Feed.Text = "Годувати";
            Feed.UseVisualStyleBackColor = false;
            Feed.Click += Feed_Click;
            // 
            // Sleep
            // 
            Sleep.BackColor = Color.OliveDrab;
            Sleep.Font = new Font("Segoe UI", 16.2F);
            Sleep.Location = new Point(6, 173);
            Sleep.Name = "Sleep";
            Sleep.Size = new Size(238, 61);
            Sleep.TabIndex = 3;
            Sleep.Text = "Дати поспати";
            Sleep.UseVisualStyleBackColor = false;
            Sleep.Click += Sleep_Click;
            // 
            // Play
            // 
            Play.BackColor = Color.OliveDrab;
            Play.Font = new Font("Segoe UI", 16.2F);
            Play.Location = new Point(6, 240);
            Play.Name = "Play";
            Play.Size = new Size(238, 61);
            Play.TabIndex = 4;
            Play.Text = "Пограти";
            Play.UseVisualStyleBackColor = false;
            Play.Click += Play_Click;
            // 
            // ButtonsBox
            // 
            ButtonsBox.Controls.Add(Functions);
            ButtonsBox.Controls.Add(Play);
            ButtonsBox.Controls.Add(Feed);
            ButtonsBox.Controls.Add(Sleep);
            ButtonsBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonsBox.Location = new Point(632, 25);
            ButtonsBox.Name = "ButtonsBox";
            ButtonsBox.Size = new Size(250, 330);
            ButtonsBox.TabIndex = 5;
            ButtonsBox.TabStop = false;
            ButtonsBox.Text = "Buttons";
            // 
            // Functions
            // 
            Functions.AutoSize = true;
            Functions.BackColor = Color.OliveDrab;
            Functions.Location = new Point(6, 39);
            Functions.Name = "Functions";
            Functions.Size = new Size(158, 38);
            Functions.TabIndex = 5;
            Functions.Text = "Functions : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 505);
            Controls.Add(ButtonsBox);
            Controls.Add(TumagochiBox);
            Name = "Form1";
            Text = "Form1";
            TumagochiBox.ResumeLayout(false);
            TumagochiBox.PerformLayout();
            ButtonsBox.ResumeLayout(false);
            ButtonsBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox TumagochiBox;
        private Label Stats;
        private Label HappyValue;
        private Label Happy;
        private Label EnergyValue;
        private Label Hungry;
        private Label Energy;
        private Label HungryValue;
        private Button Feed;
        private Button Sleep;
        private Button Play;
        private GroupBox ButtonsBox;
        private Label Functions;
    }
}
