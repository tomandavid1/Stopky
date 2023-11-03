using System.Drawing;

namespace Stopky
{
	partial class StopkyWindow
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
			components = new System.ComponentModel.Container();
			watchLabel = new Label();
			Start = new Button();
			Stop = new Button();
			Reset = new Button();
			formTimer = new System.Windows.Forms.Timer(components);
			panel1 = new Panel();
			button2 = new Button();
			button1 = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// watchLabel
			// 
			watchLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			watchLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
			watchLabel.FlatStyle = FlatStyle.Flat;
			watchLabel.Font = new Font("Saira SemiBold", 60F, FontStyle.Bold, GraphicsUnit.Point);
			watchLabel.Location = new Point(42, 31);
			watchLabel.Name = "watchLabel";
			watchLabel.Size = new Size(461, 139);
			watchLabel.TabIndex = 0;
			watchLabel.Text = "00:00.00";
			watchLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// Start
			// 
			Start.BackColor = Color.FromArgb(40, 160, 44);
			Start.BackgroundImageLayout = ImageLayout.None;
			Start.Cursor = Cursors.Hand;
			Start.FlatAppearance.BorderSize = 0;
			Start.FlatStyle = FlatStyle.Flat;
			Start.Font = new Font("Saira Medium", 20F, FontStyle.Bold, GraphicsUnit.Point);
			Start.ForeColor = Color.AliceBlue;
			Start.Location = new Point(12, 173);
			Start.Name = "Start";
			Start.Size = new Size(461, 63);
			Start.TabIndex = 1;
			Start.Text = "Start";
			Start.UseVisualStyleBackColor = false;
			Start.Click += Start_Click;
			// 
			// Stop
			// 
			Stop.BackColor = Color.FromArgb(150, 20, 24);
			Stop.BackgroundImageLayout = ImageLayout.None;
			Stop.Cursor = Cursors.Hand;
			Stop.FlatAppearance.BorderSize = 0;
			Stop.FlatStyle = FlatStyle.Flat;
			Stop.Font = new Font("Saira Medium", 20F, FontStyle.Bold, GraphicsUnit.Point);
			Stop.ForeColor = Color.AliceBlue;
			Stop.Location = new Point(12, 244);
			Stop.Name = "Stop";
			Stop.Size = new Size(461, 63);
			Stop.TabIndex = 2;
			Stop.Text = "Stop";
			Stop.UseVisualStyleBackColor = false;
			Stop.Click += Stop_Click;
			// 
			// Reset
			// 
			Reset.BackColor = Color.FromArgb(60, 60, 84);
			Reset.BackgroundImageLayout = ImageLayout.None;
			Reset.Cursor = Cursors.Hand;
			Reset.FlatAppearance.BorderSize = 0;
			Reset.FlatStyle = FlatStyle.Flat;
			Reset.Font = new Font("Saira Medium", 20F, FontStyle.Bold, GraphicsUnit.Point);
			Reset.ForeColor = Color.AliceBlue;
			Reset.Location = new Point(12, 315);
			Reset.Name = "Reset";
			Reset.Size = new Size(461, 63);
			Reset.TabIndex = 3;
			Reset.Text = "Reset";
			Reset.UseVisualStyleBackColor = false;
			Reset.Click += Reset_Click;
			// 
			// formTimer
			// 
			formTimer.Interval = 10;
			formTimer.Tick += formTimer_Tick_1;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(30, 30, 40);
			panel1.BackgroundImageLayout = ImageLayout.None;
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(485, 30);
			panel1.TabIndex = 4;
			panel1.Paint += panel1_Paint;
			panel1.MouseDown += panel1_MouseDown;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(0, 255, 255, 255);
			button2.Cursor = Cursors.Hand;
			button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 255, 255, 255);
			button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 255, 255);
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point);
			button2.Location = new Point(418, -4);
			button2.Margin = new Padding(0);
			button2.Name = "button2";
			button2.Size = new Size(34, 32);
			button2.TabIndex = 1;
			button2.Text = "_";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(0, 255, 255, 255);
			button1.Cursor = Cursors.Hand;
			button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 255, 255, 255);
			button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 255, 255);
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Verdana", 20F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(456, -6);
			button1.Margin = new Padding(0);
			button1.Name = "button1";
			button1.Size = new Size(30, 39);
			button1.TabIndex = 0;
			button1.Text = "×";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// StopkyWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(20, 20, 24);
			ClientSize = new Size(485, 393);
			Controls.Add(panel1);
			Controls.Add(Reset);
			Controls.Add(Stop);
			Controls.Add(Start);
			Controls.Add(watchLabel);
			Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			ForeColor = SystemColors.Control;
			FormBorderStyle = FormBorderStyle.None;
			MaximizeBox = false;
			Name = "StopkyWindow";
			ShowIcon = false;
			SizeGripStyle = SizeGripStyle.Hide;
			Text = "Stopky";
			Load += Stopky_Load;
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label watchLabel;
		private Button Start;
		private Button Stop;
		private Button Reset;
		private System.Windows.Forms.Timer formTimer;
		private Panel panel1;
		private Button button1;
		private Button button2;
	}
}