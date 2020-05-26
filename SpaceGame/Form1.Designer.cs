namespace SpaceGame
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.spaceBox = new System.Windows.Forms.GroupBox();
			this.planetListBox = new System.Windows.Forms.ListBox();
			this.explorePlanetButton = new System.Windows.Forms.Button();
			this.addPlanetNameBox = new System.Windows.Forms.GroupBox();
			this.setNameButton = new System.Windows.Forms.Button();
			this.planetNameTextBox = new System.Windows.Forms.TextBox();
			this.startButton = new System.Windows.Forms.Button();
			this.startingBox = new System.Windows.Forms.GroupBox();
			this.amountPlanetsTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.planetBox = new System.Windows.Forms.GroupBox();
			this.stoneFactories = new System.Windows.Forms.ListBox();
			this.buildFactoryButton = new System.Windows.Forms.Button();
			this.woodFactories = new System.Windows.Forms.ListBox();
			this.chooseFactoryBox = new System.Windows.Forms.GroupBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.resourceTypeListBox = new System.Windows.Forms.ListBox();
			this.storageBox = new System.Windows.Forms.GroupBox();
			this.woodInStorage = new System.Windows.Forms.Label();
			this.stoneInStorage = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timerSpace = new System.Windows.Forms.Timer(this.components);
			this.resoucesBox = new System.Windows.Forms.GroupBox();
			this.woodOnPlanetLabel = new System.Windows.Forms.Label();
			this.stoneOnPlanetLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.upgradeBox = new System.Windows.Forms.GroupBox();
			this.levelLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.upgradeButton = new System.Windows.Forms.Button();
			this.spaceBox.SuspendLayout();
			this.addPlanetNameBox.SuspendLayout();
			this.startingBox.SuspendLayout();
			this.planetBox.SuspendLayout();
			this.chooseFactoryBox.SuspendLayout();
			this.storageBox.SuspendLayout();
			this.resoucesBox.SuspendLayout();
			this.upgradeBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// spaceBox
			// 
			this.spaceBox.Controls.Add(this.planetListBox);
			this.spaceBox.Controls.Add(this.explorePlanetButton);
			this.spaceBox.Location = new System.Drawing.Point(12, 12);
			this.spaceBox.Name = "spaceBox";
			this.spaceBox.Size = new System.Drawing.Size(153, 291);
			this.spaceBox.TabIndex = 0;
			this.spaceBox.TabStop = false;
			this.spaceBox.Text = "Space";
			this.spaceBox.Visible = false;
			// 
			// planetListBox
			// 
			this.planetListBox.FormattingEnabled = true;
			this.planetListBox.Location = new System.Drawing.Point(6, 19);
			this.planetListBox.Name = "planetListBox";
			this.planetListBox.Size = new System.Drawing.Size(141, 238);
			this.planetListBox.TabIndex = 6;
			this.planetListBox.SelectedIndexChanged += new System.EventHandler(this.planetListBox_SelectedIndexChanged);
			// 
			// explorePlanetButton
			// 
			this.explorePlanetButton.Location = new System.Drawing.Point(6, 263);
			this.explorePlanetButton.Name = "explorePlanetButton";
			this.explorePlanetButton.Size = new System.Drawing.Size(141, 23);
			this.explorePlanetButton.TabIndex = 1;
			this.explorePlanetButton.Text = "Explore new planet";
			this.explorePlanetButton.UseVisualStyleBackColor = true;
			this.explorePlanetButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// addPlanetNameBox
			// 
			this.addPlanetNameBox.Controls.Add(this.setNameButton);
			this.addPlanetNameBox.Controls.Add(this.planetNameTextBox);
			this.addPlanetNameBox.Location = new System.Drawing.Point(171, 229);
			this.addPlanetNameBox.Name = "addPlanetNameBox";
			this.addPlanetNameBox.Size = new System.Drawing.Size(153, 74);
			this.addPlanetNameBox.TabIndex = 1;
			this.addPlanetNameBox.TabStop = false;
			this.addPlanetNameBox.Text = "Add name to new planet";
			this.addPlanetNameBox.Visible = false;
			// 
			// setNameButton
			// 
			this.setNameButton.Location = new System.Drawing.Point(6, 45);
			this.setNameButton.Name = "setNameButton";
			this.setNameButton.Size = new System.Drawing.Size(141, 23);
			this.setNameButton.TabIndex = 1;
			this.setNameButton.Text = "Set name";
			this.setNameButton.UseVisualStyleBackColor = true;
			this.setNameButton.Click += new System.EventHandler(this.setNameButton_Click);
			// 
			// planetNameTextBox
			// 
			this.planetNameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.planetNameTextBox.Location = new System.Drawing.Point(6, 19);
			this.planetNameTextBox.Name = "planetNameTextBox";
			this.planetNameTextBox.Size = new System.Drawing.Size(141, 20);
			this.planetNameTextBox.TabIndex = 0;
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(6, 84);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(205, 43);
			this.startButton.TabIndex = 2;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// startingBox
			// 
			this.startingBox.Controls.Add(this.amountPlanetsTextBox);
			this.startingBox.Controls.Add(this.label1);
			this.startingBox.Controls.Add(this.startButton);
			this.startingBox.Location = new System.Drawing.Point(330, 170);
			this.startingBox.Name = "startingBox";
			this.startingBox.Size = new System.Drawing.Size(217, 133);
			this.startingBox.TabIndex = 3;
			this.startingBox.TabStop = false;
			this.startingBox.Text = "Start the game";
			// 
			// amountPlanetsTextBox
			// 
			this.amountPlanetsTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.amountPlanetsTextBox.Location = new System.Drawing.Point(6, 58);
			this.amountPlanetsTextBox.Name = "amountPlanetsTextBox";
			this.amountPlanetsTextBox.Size = new System.Drawing.Size(205, 20);
			this.amountPlanetsTextBox.TabIndex = 4;
			this.amountPlanetsTextBox.TextChanged += new System.EventHandler(this.amountPlanetsTextBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 26);
			this.label1.TabIndex = 3;
			this.label1.Text = "Enter the amount of available planets and \r\n                       start the game" +
    "";
			// 
			// planetBox
			// 
			this.planetBox.Controls.Add(this.stoneFactories);
			this.planetBox.Controls.Add(this.buildFactoryButton);
			this.planetBox.Controls.Add(this.woodFactories);
			this.planetBox.Location = new System.Drawing.Point(171, 12);
			this.planetBox.Name = "planetBox";
			this.planetBox.Size = new System.Drawing.Size(153, 217);
			this.planetBox.TabIndex = 4;
			this.planetBox.TabStop = false;
			this.planetBox.Text = "Planet";
			this.planetBox.Visible = false;
			// 
			// stoneFactories
			// 
			this.stoneFactories.FormattingEnabled = true;
			this.stoneFactories.Location = new System.Drawing.Point(6, 19);
			this.stoneFactories.Name = "stoneFactories";
			this.stoneFactories.Size = new System.Drawing.Size(70, 160);
			this.stoneFactories.TabIndex = 2;
			this.stoneFactories.SelectedIndexChanged += new System.EventHandler(this.stoneFactories_SelectedIndexChanged);
			// 
			// buildFactoryButton
			// 
			this.buildFactoryButton.Location = new System.Drawing.Point(5, 188);
			this.buildFactoryButton.Name = "buildFactoryButton";
			this.buildFactoryButton.Size = new System.Drawing.Size(142, 23);
			this.buildFactoryButton.TabIndex = 1;
			this.buildFactoryButton.Text = "Build new factory";
			this.buildFactoryButton.UseVisualStyleBackColor = true;
			this.buildFactoryButton.Click += new System.EventHandler(this.buildFactoryButton_Click_1);
			// 
			// woodFactories
			// 
			this.woodFactories.FormattingEnabled = true;
			this.woodFactories.Location = new System.Drawing.Point(77, 19);
			this.woodFactories.Name = "woodFactories";
			this.woodFactories.Size = new System.Drawing.Size(70, 160);
			this.woodFactories.TabIndex = 6;
			this.woodFactories.SelectedIndexChanged += new System.EventHandler(this.woodFactories_SelectedIndexChanged);
			// 
			// chooseFactoryBox
			// 
			this.chooseFactoryBox.Controls.Add(this.cancelButton);
			this.chooseFactoryBox.Controls.Add(this.resourceTypeListBox);
			this.chooseFactoryBox.Location = new System.Drawing.Point(330, 142);
			this.chooseFactoryBox.Name = "chooseFactoryBox";
			this.chooseFactoryBox.Size = new System.Drawing.Size(112, 87);
			this.chooseFactoryBox.TabIndex = 5;
			this.chooseFactoryBox.TabStop = false;
			this.chooseFactoryBox.Text = "Choose factory type";
			this.chooseFactoryBox.Visible = false;
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(6, 58);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(100, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// resourceTypeListBox
			// 
			this.resourceTypeListBox.FormattingEnabled = true;
			this.resourceTypeListBox.Items.AddRange(new object[] {
            "Stone",
            "Wood"});
			this.resourceTypeListBox.Location = new System.Drawing.Point(6, 26);
			this.resourceTypeListBox.Name = "resourceTypeListBox";
			this.resourceTypeListBox.Size = new System.Drawing.Size(100, 30);
			this.resourceTypeListBox.TabIndex = 6;
			this.resourceTypeListBox.SelectedIndexChanged += new System.EventHandler(this.resourceTypeListBox_SelectedIndexChanged);
			// 
			// storageBox
			// 
			this.storageBox.Controls.Add(this.woodInStorage);
			this.storageBox.Controls.Add(this.stoneInStorage);
			this.storageBox.Controls.Add(this.label3);
			this.storageBox.Controls.Add(this.label2);
			this.storageBox.Location = new System.Drawing.Point(448, 12);
			this.storageBox.Name = "storageBox";
			this.storageBox.Size = new System.Drawing.Size(99, 56);
			this.storageBox.TabIndex = 5;
			this.storageBox.TabStop = false;
			this.storageBox.Text = "Storage";
			this.storageBox.Visible = false;
			// 
			// woodInStorage
			// 
			this.woodInStorage.AutoSize = true;
			this.woodInStorage.Location = new System.Drawing.Point(51, 36);
			this.woodInStorage.Name = "woodInStorage";
			this.woodInStorage.Size = new System.Drawing.Size(13, 13);
			this.woodInStorage.TabIndex = 3;
			this.woodInStorage.Text = "0";
			// 
			// stoneInStorage
			// 
			this.stoneInStorage.AutoSize = true;
			this.stoneInStorage.Location = new System.Drawing.Point(51, 19);
			this.stoneInStorage.Name = "stoneInStorage";
			this.stoneInStorage.Size = new System.Drawing.Size(13, 13);
			this.stoneInStorage.TabIndex = 2;
			this.stoneInStorage.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Wood:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Stone:";
			// 
			// timerSpace
			// 
			this.timerSpace.Interval = 1000;
			this.timerSpace.Tick += new System.EventHandler(this.timerSpace_Tick);
			// 
			// resoucesBox
			// 
			this.resoucesBox.Controls.Add(this.woodOnPlanetLabel);
			this.resoucesBox.Controls.Add(this.stoneOnPlanetLabel);
			this.resoucesBox.Controls.Add(this.label5);
			this.resoucesBox.Controls.Add(this.label4);
			this.resoucesBox.Location = new System.Drawing.Point(330, 12);
			this.resoucesBox.Name = "resoucesBox";
			this.resoucesBox.Size = new System.Drawing.Size(112, 56);
			this.resoucesBox.TabIndex = 7;
			this.resoucesBox.TabStop = false;
			this.resoucesBox.Text = "Planet resources";
			this.resoucesBox.Visible = false;
			// 
			// woodOnPlanetLabel
			// 
			this.woodOnPlanetLabel.AutoSize = true;
			this.woodOnPlanetLabel.Location = new System.Drawing.Point(50, 36);
			this.woodOnPlanetLabel.Name = "woodOnPlanetLabel";
			this.woodOnPlanetLabel.Size = new System.Drawing.Size(13, 13);
			this.woodOnPlanetLabel.TabIndex = 4;
			this.woodOnPlanetLabel.Text = "0";
			// 
			// stoneOnPlanetLabel
			// 
			this.stoneOnPlanetLabel.AutoSize = true;
			this.stoneOnPlanetLabel.Location = new System.Drawing.Point(50, 19);
			this.stoneOnPlanetLabel.Name = "stoneOnPlanetLabel";
			this.stoneOnPlanetLabel.Size = new System.Drawing.Size(13, 13);
			this.stoneOnPlanetLabel.TabIndex = 3;
			this.stoneOnPlanetLabel.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Wood:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Stone:";
			// 
			// upgradeBox
			// 
			this.upgradeBox.Controls.Add(this.levelLabel);
			this.upgradeBox.Controls.Add(this.label6);
			this.upgradeBox.Controls.Add(this.upgradeButton);
			this.upgradeBox.Location = new System.Drawing.Point(330, 74);
			this.upgradeBox.Name = "upgradeBox";
			this.upgradeBox.Size = new System.Drawing.Size(112, 62);
			this.upgradeBox.TabIndex = 8;
			this.upgradeBox.TabStop = false;
			this.upgradeBox.Text = "Upgrade selected factory?";
			this.upgradeBox.Visible = false;
			// 
			// levelLabel
			// 
			this.levelLabel.AutoSize = true;
			this.levelLabel.Location = new System.Drawing.Point(34, 38);
			this.levelLabel.Name = "levelLabel";
			this.levelLabel.Size = new System.Drawing.Size(13, 13);
			this.levelLabel.TabIndex = 4;
			this.levelLabel.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 38);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Level:";
			// 
			// upgradeButton
			// 
			this.upgradeButton.Location = new System.Drawing.Point(53, 34);
			this.upgradeButton.Name = "upgradeButton";
			this.upgradeButton.Size = new System.Drawing.Size(53, 22);
			this.upgradeButton.TabIndex = 0;
			this.upgradeButton.Text = "Upgade";
			this.upgradeButton.UseVisualStyleBackColor = true;
			this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.YellowGreen;
			this.ClientSize = new System.Drawing.Size(559, 313);
			this.Controls.Add(this.chooseFactoryBox);
			this.Controls.Add(this.upgradeBox);
			this.Controls.Add(this.resoucesBox);
			this.Controls.Add(this.storageBox);
			this.Controls.Add(this.planetBox);
			this.Controls.Add(this.startingBox);
			this.Controls.Add(this.addPlanetNameBox);
			this.Controls.Add(this.spaceBox);
			this.Name = "Form1";
			this.Text = "SpaceGame";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.spaceBox.ResumeLayout(false);
			this.addPlanetNameBox.ResumeLayout(false);
			this.addPlanetNameBox.PerformLayout();
			this.startingBox.ResumeLayout(false);
			this.startingBox.PerformLayout();
			this.planetBox.ResumeLayout(false);
			this.chooseFactoryBox.ResumeLayout(false);
			this.storageBox.ResumeLayout(false);
			this.storageBox.PerformLayout();
			this.resoucesBox.ResumeLayout(false);
			this.resoucesBox.PerformLayout();
			this.upgradeBox.ResumeLayout(false);
			this.upgradeBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox spaceBox;
		private System.Windows.Forms.Button explorePlanetButton;
		private System.Windows.Forms.GroupBox addPlanetNameBox;
		private System.Windows.Forms.TextBox planetNameTextBox;
		private System.Windows.Forms.Button setNameButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.GroupBox startingBox;
		private System.Windows.Forms.TextBox amountPlanetsTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox planetBox;
		private System.Windows.Forms.Button buildFactoryButton;
		private System.Windows.Forms.GroupBox chooseFactoryBox;
		private System.Windows.Forms.ListBox planetListBox;
		private System.Windows.Forms.ListBox stoneFactories;
		private System.Windows.Forms.ListBox resourceTypeListBox;
		private System.Windows.Forms.GroupBox storageBox;
		private System.Windows.Forms.Label woodInStorage;
		private System.Windows.Forms.Label stoneInStorage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timerSpace;
		private System.Windows.Forms.ListBox woodFactories;
		private System.Windows.Forms.GroupBox resoucesBox;
		private System.Windows.Forms.Label woodOnPlanetLabel;
		private System.Windows.Forms.Label stoneOnPlanetLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox upgradeBox;
		private System.Windows.Forms.Label levelLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button upgradeButton;
		private System.Windows.Forms.Button cancelButton;
	}
}

