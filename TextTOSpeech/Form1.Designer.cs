namespace TextTOSpeech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Speakbutton = new System.Windows.Forms.Button();
            this.SoundtrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SpeedtrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.selectcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SoundtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedtrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(363, 202);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Speakbutton
            // 
            this.Speakbutton.Location = new System.Drawing.Point(48, 215);
            this.Speakbutton.Name = "Speakbutton";
            this.Speakbutton.Size = new System.Drawing.Size(100, 32);
            this.Speakbutton.TabIndex = 1;
            this.Speakbutton.Text = "Speak";
            this.Speakbutton.UseVisualStyleBackColor = true;
            this.Speakbutton.Click += new System.EventHandler(this.Speakbutton_Click);
            // 
            // SoundtrackBar
            // 
            this.SoundtrackBar.Location = new System.Drawing.Point(241, 270);
            this.SoundtrackBar.Maximum = 100;
            this.SoundtrackBar.Name = "SoundtrackBar";
            this.SoundtrackBar.Size = new System.Drawing.Size(104, 45);
            this.SoundtrackBar.TabIndex = 2;
            this.SoundtrackBar.Value = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(188, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Volume";
            // 
            // SpeedtrackBar
            // 
            this.SpeedtrackBar.Location = new System.Drawing.Point(48, 270);
            this.SpeedtrackBar.Name = "SpeedtrackBar";
            this.SpeedtrackBar.Size = new System.Drawing.Size(104, 45);
            this.SpeedtrackBar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed";
            // 
            // selectcomboBox
            // 
            this.selectcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.selectcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectcomboBox.FormattingEnabled = true;
            this.selectcomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.selectcomboBox.Location = new System.Drawing.Point(207, 215);
            this.selectcomboBox.Name = "selectcomboBox";
            this.selectcomboBox.Size = new System.Drawing.Size(121, 21);
            this.selectcomboBox.TabIndex = 5;
            this.selectcomboBox.Text = "Male";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(369, 312);
            this.Controls.Add(this.selectcomboBox);
            this.Controls.Add(this.SpeedtrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoundtrackBar);
            this.Controls.Add(this.Speakbutton);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speech Application";
            ((System.ComponentModel.ISupportInitialize)(this.SoundtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedtrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Speakbutton;
        private System.Windows.Forms.TrackBar SoundtrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar SpeedtrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectcomboBox;
    }
}

