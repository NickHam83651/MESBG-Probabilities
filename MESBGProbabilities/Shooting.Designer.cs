namespace MESBGProbabilities
{
    partial class Shooting
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
            this.shoot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BlackrootVale = new System.Windows.Forms.RadioButton();
            this.manualArcher = new System.Windows.Forms.RadioButton();
            this.WoodElf = new System.Windows.Forms.RadioButton();
            this.Duinhir = new System.Windows.Forms.RadioButton();
            this.chooseArcher = new System.Windows.Forms.GroupBox();
            this.ManualArcherBox = new System.Windows.Forms.GroupBox();
            this.shootValue = new System.Windows.Forms.NumericUpDown();
            this.bowStrength = new System.Windows.Forms.NumericUpDown();
            this.bowStrengthLabel = new System.Windows.Forms.Label();
            this.ModelType = new System.Windows.Forms.GroupBox();
            this.chooseWarrior = new System.Windows.Forms.RadioButton();
            this.chooseHero = new System.Windows.Forms.RadioButton();
            this.ReRollsBox = new System.Windows.Forms.GroupBox();
            this.norerolls = new System.Windows.Forms.RadioButton();
            this.rerolls = new System.Windows.Forms.RadioButton();
            this.shootValueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.reRollChoiceBox = new System.Windows.Forms.GroupBox();
            this.onesToWound = new System.Windows.Forms.CheckBox();
            this.allToWound = new System.Windows.Forms.CheckBox();
            this.onesToHit = new System.Windows.Forms.CheckBox();
            this.allToHit = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Orc = new System.Windows.Forms.RadioButton();
            this.Goblin = new System.Windows.Forms.RadioButton();
            this.Sauron = new System.Windows.Forms.RadioButton();
            this.WitchKing = new System.Windows.Forms.RadioButton();
            this.BlackrootValeTarget = new System.Windows.Forms.RadioButton();
            this.DuinhirTarget = new System.Windows.Forms.RadioButton();
            this.manualTarget = new System.Windows.Forms.RadioButton();
            this.WoodElfTarget = new System.Windows.Forms.RadioButton();
            this.manualTargetBox = new System.Windows.Forms.GroupBox();
            this.TargetDefenceLab = new System.Windows.Forms.Label();
            this.TargetNameLabel = new System.Windows.Forms.Label();
            this.targetName = new System.Windows.Forms.TextBox();
            this.moveBox = new System.Windows.Forms.GroupBox();
            this.moved = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.inWay = new System.Windows.Forms.GroupBox();
            this.inWay4 = new System.Windows.Forms.RadioButton();
            this.inWay5 = new System.Windows.Forms.RadioButton();
            this.noInWay = new System.Windows.Forms.RadioButton();
            this.inWay3 = new System.Windows.Forms.RadioButton();
            this.accuracyBox = new System.Windows.Forms.GroupBox();
            this.useAccuracy = new System.Windows.Forms.RadioButton();
            this.noAccuracy = new System.Windows.Forms.RadioButton();
            this.useMightBox = new System.Windows.Forms.GroupBox();
            this.useMight = new System.Windows.Forms.RadioButton();
            this.noMight = new System.Windows.Forms.RadioButton();
            this.numOfModelLabel = new System.Windows.Forms.Label();
            this.numOfModel = new System.Windows.Forms.NumericUpDown();
            this.targetDefence = new System.Windows.Forms.NumericUpDown();
            this.chooseArcher.SuspendLayout();
            this.ManualArcherBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shootValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowStrength)).BeginInit();
            this.ModelType.SuspendLayout();
            this.ReRollsBox.SuspendLayout();
            this.reRollChoiceBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.manualTargetBox.SuspendLayout();
            this.moveBox.SuspendLayout();
            this.inWay.SuspendLayout();
            this.accuracyBox.SuspendLayout();
            this.useMightBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetDefence)).BeginInit();
            this.SuspendLayout();
            // 
            // shoot
            // 
            this.shoot.BackColor = System.Drawing.Color.Red;
            this.shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot.Location = new System.Drawing.Point(860, 577);
            this.shoot.Name = "shoot";
            this.shoot.Size = new System.Drawing.Size(126, 74);
            this.shoot.TabIndex = 0;
            this.shoot.Text = "SHOOT";
            this.shoot.UseVisualStyleBackColor = false;
            this.shoot.Click += new System.EventHandler(this.shoot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archer Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shot Info";
            // 
            // BlackrootVale
            // 
            this.BlackrootVale.AutoSize = true;
            this.BlackrootVale.Checked = true;
            this.BlackrootVale.Location = new System.Drawing.Point(0, 19);
            this.BlackrootVale.Name = "BlackrootVale";
            this.BlackrootVale.Size = new System.Drawing.Size(133, 17);
            this.BlackrootVale.TabIndex = 5;
            this.BlackrootVale.TabStop = true;
            this.BlackrootVale.Text = "Blackroot Vale Archers";
            this.BlackrootVale.UseVisualStyleBackColor = true;
            this.BlackrootVale.CheckedChanged += new System.EventHandler(this.BRV_CheckedChanged);
            // 
            // manualArcher
            // 
            this.manualArcher.AutoSize = true;
            this.manualArcher.Location = new System.Drawing.Point(320, 19);
            this.manualArcher.Name = "manualArcher";
            this.manualArcher.Size = new System.Drawing.Size(60, 17);
            this.manualArcher.TabIndex = 6;
            this.manualArcher.TabStop = true;
            this.manualArcher.Text = "Manual";
            this.manualArcher.UseVisualStyleBackColor = true;
            this.manualArcher.CheckedChanged += new System.EventHandler(this.Manual_CheckedChanged);
            // 
            // WoodElf
            // 
            this.WoodElf.AutoSize = true;
            this.WoodElf.Location = new System.Drawing.Point(203, 19);
            this.WoodElf.Name = "WoodElf";
            this.WoodElf.Size = new System.Drawing.Size(111, 17);
            this.WoodElf.TabIndex = 7;
            this.WoodElf.TabStop = true;
            this.WoodElf.Text = "Wood Elf Warriors";
            this.WoodElf.UseVisualStyleBackColor = true;
            this.WoodElf.CheckedChanged += new System.EventHandler(this.WEW_CheckedChanged);
            // 
            // Duinhir
            // 
            this.Duinhir.AutoSize = true;
            this.Duinhir.Location = new System.Drawing.Point(139, 19);
            this.Duinhir.Name = "Duinhir";
            this.Duinhir.Size = new System.Drawing.Size(58, 17);
            this.Duinhir.TabIndex = 8;
            this.Duinhir.TabStop = true;
            this.Duinhir.Text = "Duinhir";
            this.Duinhir.UseVisualStyleBackColor = true;
            this.Duinhir.CheckedChanged += new System.EventHandler(this.Dun_CheckedChanged);
            // 
            // chooseArcher
            // 
            this.chooseArcher.BackColor = System.Drawing.Color.Transparent;
            this.chooseArcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chooseArcher.Controls.Add(this.BlackrootVale);
            this.chooseArcher.Controls.Add(this.Duinhir);
            this.chooseArcher.Controls.Add(this.manualArcher);
            this.chooseArcher.Controls.Add(this.WoodElf);
            this.chooseArcher.Location = new System.Drawing.Point(16, 36);
            this.chooseArcher.Name = "chooseArcher";
            this.chooseArcher.Size = new System.Drawing.Size(421, 44);
            this.chooseArcher.TabIndex = 9;
            this.chooseArcher.TabStop = false;
            // 
            // ManualArcherBox
            // 
            this.ManualArcherBox.Controls.Add(this.shootValue);
            this.ManualArcherBox.Controls.Add(this.bowStrength);
            this.ManualArcherBox.Controls.Add(this.bowStrengthLabel);
            this.ManualArcherBox.Controls.Add(this.ModelType);
            this.ManualArcherBox.Controls.Add(this.ReRollsBox);
            this.ManualArcherBox.Controls.Add(this.shootValueLabel);
            this.ManualArcherBox.Controls.Add(this.nameLabel);
            this.ManualArcherBox.Controls.Add(this.name);
            this.ManualArcherBox.Location = new System.Drawing.Point(16, 99);
            this.ManualArcherBox.Name = "ManualArcherBox";
            this.ManualArcherBox.Size = new System.Drawing.Size(589, 69);
            this.ManualArcherBox.TabIndex = 10;
            this.ManualArcherBox.TabStop = false;
            this.ManualArcherBox.Visible = false;
            // 
            // shootValue
            // 
            this.shootValue.Location = new System.Drawing.Point(116, 37);
            this.shootValue.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.shootValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shootValue.Name = "shootValue";
            this.shootValue.Size = new System.Drawing.Size(79, 20);
            this.shootValue.TabIndex = 28;
            this.shootValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bowStrength
            // 
            this.bowStrength.Location = new System.Drawing.Point(215, 36);
            this.bowStrength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.bowStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bowStrength.Name = "bowStrength";
            this.bowStrength.Size = new System.Drawing.Size(84, 20);
            this.bowStrength.TabIndex = 27;
            this.bowStrength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bowStrengthLabel
            // 
            this.bowStrengthLabel.AutoSize = true;
            this.bowStrengthLabel.Location = new System.Drawing.Point(215, 20);
            this.bowStrengthLabel.Name = "bowStrengthLabel";
            this.bowStrengthLabel.Size = new System.Drawing.Size(71, 13);
            this.bowStrengthLabel.TabIndex = 26;
            this.bowStrengthLabel.Text = "Bow Strength";
            // 
            // ModelType
            // 
            this.ModelType.Controls.Add(this.chooseWarrior);
            this.ModelType.Controls.Add(this.chooseHero);
            this.ModelType.Location = new System.Drawing.Point(327, 13);
            this.ModelType.Name = "ModelType";
            this.ModelType.Size = new System.Drawing.Size(135, 50);
            this.ModelType.TabIndex = 14;
            this.ModelType.TabStop = false;
            this.ModelType.Text = "Model Type";
            // 
            // chooseWarrior
            // 
            this.chooseWarrior.AutoSize = true;
            this.chooseWarrior.Checked = true;
            this.chooseWarrior.Location = new System.Drawing.Point(10, 17);
            this.chooseWarrior.Name = "chooseWarrior";
            this.chooseWarrior.Size = new System.Drawing.Size(59, 17);
            this.chooseWarrior.TabIndex = 11;
            this.chooseWarrior.TabStop = true;
            this.chooseWarrior.Text = "Warrior";
            this.chooseWarrior.UseVisualStyleBackColor = true;
            this.chooseWarrior.CheckedChanged += new System.EventHandler(this.chooseWarrior_CheckedChanged);
            // 
            // chooseHero
            // 
            this.chooseHero.AutoSize = true;
            this.chooseHero.Location = new System.Drawing.Point(75, 17);
            this.chooseHero.Name = "chooseHero";
            this.chooseHero.Size = new System.Drawing.Size(48, 17);
            this.chooseHero.TabIndex = 10;
            this.chooseHero.Text = "Hero";
            this.chooseHero.UseVisualStyleBackColor = true;
            this.chooseHero.CheckedChanged += new System.EventHandler(this.chooseHero_CheckedChanged);
            // 
            // ReRollsBox
            // 
            this.ReRollsBox.Controls.Add(this.norerolls);
            this.ReRollsBox.Controls.Add(this.rerolls);
            this.ReRollsBox.Location = new System.Drawing.Point(472, 13);
            this.ReRollsBox.Name = "ReRollsBox";
            this.ReRollsBox.Size = new System.Drawing.Size(101, 50);
            this.ReRollsBox.TabIndex = 13;
            this.ReRollsBox.TabStop = false;
            this.ReRollsBox.Text = "Rerolls?";
            // 
            // norerolls
            // 
            this.norerolls.AutoSize = true;
            this.norerolls.Checked = true;
            this.norerolls.Location = new System.Drawing.Point(49, 17);
            this.norerolls.Name = "norerolls";
            this.norerolls.Size = new System.Drawing.Size(39, 17);
            this.norerolls.TabIndex = 11;
            this.norerolls.TabStop = true;
            this.norerolls.Text = "No";
            this.norerolls.UseVisualStyleBackColor = true;
            this.norerolls.CheckedChanged += new System.EventHandler(this.norerolls_CheckedChanged);
            // 
            // rerolls
            // 
            this.rerolls.AutoSize = true;
            this.rerolls.Location = new System.Drawing.Point(4, 17);
            this.rerolls.Name = "rerolls";
            this.rerolls.Size = new System.Drawing.Size(43, 17);
            this.rerolls.TabIndex = 12;
            this.rerolls.Text = "Yes";
            this.rerolls.UseVisualStyleBackColor = true;
            this.rerolls.CheckedChanged += new System.EventHandler(this.reRolls_CheckedChanged);
            // 
            // shootValueLabel
            // 
            this.shootValueLabel.AutoSize = true;
            this.shootValueLabel.Location = new System.Drawing.Point(113, 20);
            this.shootValueLabel.Name = "shootValueLabel";
            this.shootValueLabel.Size = new System.Drawing.Size(65, 13);
            this.shootValueLabel.TabIndex = 3;
            this.shootValueLabel.Text = "Shoot Value";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(6, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 0;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(13, 519);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(74, 26);
            this.result.TabIndex = 9;
            this.result.Text = "Result";
            this.result.Visible = false;
            // 
            // reRollChoiceBox
            // 
            this.reRollChoiceBox.Controls.Add(this.onesToWound);
            this.reRollChoiceBox.Controls.Add(this.allToWound);
            this.reRollChoiceBox.Controls.Add(this.onesToHit);
            this.reRollChoiceBox.Controls.Add(this.allToHit);
            this.reRollChoiceBox.Location = new System.Drawing.Point(611, 119);
            this.reRollChoiceBox.Name = "reRollChoiceBox";
            this.reRollChoiceBox.Size = new System.Drawing.Size(399, 49);
            this.reRollChoiceBox.TabIndex = 17;
            this.reRollChoiceBox.TabStop = false;
            this.reRollChoiceBox.Text = "Reroll:";
            this.reRollChoiceBox.Visible = false;
            // 
            // onesToWound
            // 
            this.onesToWound.AutoSize = true;
            this.onesToWound.Location = new System.Drawing.Point(252, 19);
            this.onesToWound.Name = "onesToWound";
            this.onesToWound.Size = new System.Drawing.Size(91, 17);
            this.onesToWound.TabIndex = 3;
            this.onesToWound.Text = "1s To Wound";
            this.onesToWound.UseVisualStyleBackColor = true;
            // 
            // allToWound
            // 
            this.allToWound.AutoSize = true;
            this.allToWound.Location = new System.Drawing.Point(162, 19);
            this.allToWound.Name = "allToWound";
            this.allToWound.Size = new System.Drawing.Size(91, 17);
            this.allToWound.TabIndex = 2;
            this.allToWound.Text = "All To Wound";
            this.allToWound.UseVisualStyleBackColor = true;
            this.allToWound.CheckedChanged += new System.EventHandler(this.allToWound_CheckedChanged);
            // 
            // onesToHit
            // 
            this.onesToHit.AutoSize = true;
            this.onesToHit.Location = new System.Drawing.Point(90, 20);
            this.onesToHit.Name = "onesToHit";
            this.onesToHit.Size = new System.Drawing.Size(69, 17);
            this.onesToHit.TabIndex = 1;
            this.onesToHit.Text = "1s To Hit";
            this.onesToHit.UseVisualStyleBackColor = true;
            // 
            // allToHit
            // 
            this.allToHit.AutoSize = true;
            this.allToHit.Location = new System.Drawing.Point(7, 20);
            this.allToHit.Name = "allToHit";
            this.allToHit.Size = new System.Drawing.Size(74, 17);
            this.allToHit.TabIndex = 0;
            this.allToHit.Text = "All To Hits";
            this.allToHit.UseVisualStyleBackColor = true;
            this.allToHit.CheckedChanged += new System.EventHandler(this.reRollAllToHit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.Orc);
            this.groupBox1.Controls.Add(this.Goblin);
            this.groupBox1.Controls.Add(this.Sauron);
            this.groupBox1.Controls.Add(this.WitchKing);
            this.groupBox1.Controls.Add(this.BlackrootValeTarget);
            this.groupBox1.Controls.Add(this.DuinhirTarget);
            this.groupBox1.Controls.Add(this.manualTarget);
            this.groupBox1.Controls.Add(this.WoodElfTarget);
            this.groupBox1.Location = new System.Drawing.Point(16, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 44);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // Orc
            // 
            this.Orc.AutoSize = true;
            this.Orc.Checked = true;
            this.Orc.Location = new System.Drawing.Point(318, 19);
            this.Orc.Name = "Orc";
            this.Orc.Size = new System.Drawing.Size(87, 17);
            this.Orc.TabIndex = 9;
            this.Orc.TabStop = true;
            this.Orc.Text = "Moranon Orc";
            this.Orc.UseVisualStyleBackColor = true;
            this.Orc.CheckedChanged += new System.EventHandler(this.OrcTarget_CheckedChanged);
            // 
            // Goblin
            // 
            this.Goblin.AutoSize = true;
            this.Goblin.Location = new System.Drawing.Point(411, 19);
            this.Goblin.Name = "Goblin";
            this.Goblin.Size = new System.Drawing.Size(84, 17);
            this.Goblin.TabIndex = 12;
            this.Goblin.TabStop = true;
            this.Goblin.Text = "Moria Goblin";
            this.Goblin.UseVisualStyleBackColor = true;
            this.Goblin.CheckedChanged += new System.EventHandler(this.Goblin_CheckedChanged);
            // 
            // Sauron
            // 
            this.Sauron.AutoSize = true;
            this.Sauron.Location = new System.Drawing.Point(606, 19);
            this.Sauron.Name = "Sauron";
            this.Sauron.Size = new System.Drawing.Size(59, 17);
            this.Sauron.TabIndex = 10;
            this.Sauron.TabStop = true;
            this.Sauron.Text = "Sauron";
            this.Sauron.UseVisualStyleBackColor = true;
            this.Sauron.CheckedChanged += new System.EventHandler(this.Sauron_CheckedChanged);
            // 
            // WitchKing
            // 
            this.WitchKing.AutoSize = true;
            this.WitchKing.Location = new System.Drawing.Point(501, 19);
            this.WitchKing.Name = "WitchKing";
            this.WitchKing.Size = new System.Drawing.Size(99, 17);
            this.WitchKing.TabIndex = 11;
            this.WitchKing.TabStop = true;
            this.WitchKing.Text = "The Witch King";
            this.WitchKing.UseVisualStyleBackColor = true;
            this.WitchKing.CheckedChanged += new System.EventHandler(this.WitchKing_CheckedChanged);
            // 
            // BlackrootValeTarget
            // 
            this.BlackrootValeTarget.AutoSize = true;
            this.BlackrootValeTarget.Location = new System.Drawing.Point(0, 19);
            this.BlackrootValeTarget.Name = "BlackrootValeTarget";
            this.BlackrootValeTarget.Size = new System.Drawing.Size(133, 17);
            this.BlackrootValeTarget.TabIndex = 5;
            this.BlackrootValeTarget.TabStop = true;
            this.BlackrootValeTarget.Text = "Blackroot Vale Archers";
            this.BlackrootValeTarget.UseVisualStyleBackColor = true;
            this.BlackrootValeTarget.CheckedChanged += new System.EventHandler(this.BRVTarget_CheckedChanged);
            // 
            // DuinhirTarget
            // 
            this.DuinhirTarget.AutoSize = true;
            this.DuinhirTarget.Location = new System.Drawing.Point(139, 19);
            this.DuinhirTarget.Name = "DuinhirTarget";
            this.DuinhirTarget.Size = new System.Drawing.Size(58, 17);
            this.DuinhirTarget.TabIndex = 8;
            this.DuinhirTarget.TabStop = true;
            this.DuinhirTarget.Text = "Duinhir";
            this.DuinhirTarget.UseVisualStyleBackColor = true;
            this.DuinhirTarget.CheckedChanged += new System.EventHandler(this.DuinhirTarget_CheckedChanged);
            // 
            // manualTarget
            // 
            this.manualTarget.AutoSize = true;
            this.manualTarget.Location = new System.Drawing.Point(670, 19);
            this.manualTarget.Name = "manualTarget";
            this.manualTarget.Size = new System.Drawing.Size(60, 17);
            this.manualTarget.TabIndex = 6;
            this.manualTarget.TabStop = true;
            this.manualTarget.Text = "Manual";
            this.manualTarget.UseVisualStyleBackColor = true;
            this.manualTarget.CheckedChanged += new System.EventHandler(this.manualTarget_CheckedChanged);
            // 
            // WoodElfTarget
            // 
            this.WoodElfTarget.AutoSize = true;
            this.WoodElfTarget.Location = new System.Drawing.Point(203, 19);
            this.WoodElfTarget.Name = "WoodElfTarget";
            this.WoodElfTarget.Size = new System.Drawing.Size(111, 17);
            this.WoodElfTarget.TabIndex = 7;
            this.WoodElfTarget.TabStop = true;
            this.WoodElfTarget.Text = "Wood Elf Warriors";
            this.WoodElfTarget.UseVisualStyleBackColor = true;
            this.WoodElfTarget.CheckedChanged += new System.EventHandler(this.WoodElfTarget_CheckedChanged);
            // 
            // manualTargetBox
            // 
            this.manualTargetBox.Controls.Add(this.targetDefence);
            this.manualTargetBox.Controls.Add(this.TargetDefenceLab);
            this.manualTargetBox.Controls.Add(this.TargetNameLabel);
            this.manualTargetBox.Controls.Add(this.targetName);
            this.manualTargetBox.Location = new System.Drawing.Point(16, 394);
            this.manualTargetBox.Name = "manualTargetBox";
            this.manualTargetBox.Size = new System.Drawing.Size(242, 69);
            this.manualTargetBox.TabIndex = 19;
            this.manualTargetBox.TabStop = false;
            this.manualTargetBox.Visible = false;
            // 
            // TargetDefenceLab
            // 
            this.TargetDefenceLab.AutoSize = true;
            this.TargetDefenceLab.Location = new System.Drawing.Point(113, 20);
            this.TargetDefenceLab.Name = "TargetDefenceLab";
            this.TargetDefenceLab.Size = new System.Drawing.Size(82, 13);
            this.TargetDefenceLab.TabIndex = 3;
            this.TargetDefenceLab.Text = "Target Defence";
            // 
            // TargetNameLabel
            // 
            this.TargetNameLabel.AutoSize = true;
            this.TargetNameLabel.Location = new System.Drawing.Point(7, 20);
            this.TargetNameLabel.Name = "TargetNameLabel";
            this.TargetNameLabel.Size = new System.Drawing.Size(35, 13);
            this.TargetNameLabel.TabIndex = 1;
            this.TargetNameLabel.Text = "Name";
            // 
            // targetName
            // 
            this.targetName.Location = new System.Drawing.Point(6, 36);
            this.targetName.Name = "targetName";
            this.targetName.Size = new System.Drawing.Size(100, 20);
            this.targetName.TabIndex = 0;
            // 
            // moveBox
            // 
            this.moveBox.Controls.Add(this.moved);
            this.moveBox.Controls.Add(this.radioButton2);
            this.moveBox.Location = new System.Drawing.Point(16, 226);
            this.moveBox.Name = "moveBox";
            this.moveBox.Size = new System.Drawing.Size(106, 44);
            this.moveBox.TabIndex = 20;
            this.moveBox.TabStop = false;
            this.moveBox.Text = "Move?";
            // 
            // moved
            // 
            this.moved.AutoSize = true;
            this.moved.Location = new System.Drawing.Point(10, 17);
            this.moved.Name = "moved";
            this.moved.Size = new System.Drawing.Size(43, 17);
            this.moved.TabIndex = 11;
            this.moved.Text = "Yes";
            this.moved.UseVisualStyleBackColor = true;
            this.moved.CheckedChanged += new System.EventHandler(this.moved_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(57, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.notMoved_CheckedChanged);
            // 
            // inWay
            // 
            this.inWay.Controls.Add(this.inWay4);
            this.inWay.Controls.Add(this.inWay5);
            this.inWay.Controls.Add(this.noInWay);
            this.inWay.Controls.Add(this.inWay3);
            this.inWay.Location = new System.Drawing.Point(244, 226);
            this.inWay.Name = "inWay";
            this.inWay.Size = new System.Drawing.Size(186, 44);
            this.inWay.TabIndex = 21;
            this.inWay.TabStop = false;
            this.inWay.Text = "In Way?";
            // 
            // inWay4
            // 
            this.inWay4.AutoSize = true;
            this.inWay4.Location = new System.Drawing.Point(102, 17);
            this.inWay4.Name = "inWay4";
            this.inWay4.Size = new System.Drawing.Size(37, 17);
            this.inWay4.TabIndex = 13;
            this.inWay4.Text = "4+";
            this.inWay4.UseVisualStyleBackColor = true;
            this.inWay4.CheckedChanged += new System.EventHandler(this.inWay4_CheckedChanged);
            // 
            // inWay5
            // 
            this.inWay5.AutoSize = true;
            this.inWay5.Location = new System.Drawing.Point(146, 17);
            this.inWay5.Name = "inWay5";
            this.inWay5.Size = new System.Drawing.Size(37, 17);
            this.inWay5.TabIndex = 12;
            this.inWay5.Text = "5+";
            this.inWay5.UseVisualStyleBackColor = true;
            this.inWay5.CheckedChanged += new System.EventHandler(this.inWay5_CheckedChanged);
            // 
            // noInWay
            // 
            this.noInWay.AutoSize = true;
            this.noInWay.Checked = true;
            this.noInWay.Location = new System.Drawing.Point(10, 17);
            this.noInWay.Name = "noInWay";
            this.noInWay.Size = new System.Drawing.Size(51, 17);
            this.noInWay.TabIndex = 11;
            this.noInWay.TabStop = true;
            this.noInWay.Text = "None";
            this.noInWay.UseVisualStyleBackColor = true;
            this.noInWay.CheckedChanged += new System.EventHandler(this.noInWay_CheckedChanged);
            // 
            // inWay3
            // 
            this.inWay3.AutoSize = true;
            this.inWay3.Location = new System.Drawing.Point(63, 17);
            this.inWay3.Name = "inWay3";
            this.inWay3.Size = new System.Drawing.Size(37, 17);
            this.inWay3.TabIndex = 10;
            this.inWay3.Text = "3+";
            this.inWay3.UseVisualStyleBackColor = true;
            this.inWay3.CheckedChanged += new System.EventHandler(this.inWay3_CheckedChanged);
            // 
            // accuracyBox
            // 
            this.accuracyBox.Controls.Add(this.useAccuracy);
            this.accuracyBox.Controls.Add(this.noAccuracy);
            this.accuracyBox.Location = new System.Drawing.Point(436, 226);
            this.accuracyBox.Name = "accuracyBox";
            this.accuracyBox.Size = new System.Drawing.Size(106, 44);
            this.accuracyBox.TabIndex = 21;
            this.accuracyBox.TabStop = false;
            this.accuracyBox.Text = "Heroic Accuracy?";
            this.accuracyBox.Visible = false;
            // 
            // useAccuracy
            // 
            this.useAccuracy.AutoSize = true;
            this.useAccuracy.Location = new System.Drawing.Point(10, 17);
            this.useAccuracy.Name = "useAccuracy";
            this.useAccuracy.Size = new System.Drawing.Size(43, 17);
            this.useAccuracy.TabIndex = 11;
            this.useAccuracy.Text = "Yes";
            this.useAccuracy.UseVisualStyleBackColor = true;
            this.useAccuracy.CheckedChanged += new System.EventHandler(this.useAccuracy_CheckedChanged);
            // 
            // noAccuracy
            // 
            this.noAccuracy.AutoSize = true;
            this.noAccuracy.Checked = true;
            this.noAccuracy.Location = new System.Drawing.Point(57, 17);
            this.noAccuracy.Name = "noAccuracy";
            this.noAccuracy.Size = new System.Drawing.Size(39, 17);
            this.noAccuracy.TabIndex = 10;
            this.noAccuracy.TabStop = true;
            this.noAccuracy.Text = "No";
            this.noAccuracy.UseVisualStyleBackColor = true;
            this.noAccuracy.CheckedChanged += new System.EventHandler(this.noAccuracy_CheckedChanged);
            // 
            // useMightBox
            // 
            this.useMightBox.Controls.Add(this.useMight);
            this.useMightBox.Controls.Add(this.noMight);
            this.useMightBox.Location = new System.Drawing.Point(129, 226);
            this.useMightBox.Name = "useMightBox";
            this.useMightBox.Size = new System.Drawing.Size(106, 44);
            this.useMightBox.TabIndex = 22;
            this.useMightBox.TabStop = false;
            this.useMightBox.Text = "Use Might?";
            this.useMightBox.Visible = false;
            // 
            // useMight
            // 
            this.useMight.AutoSize = true;
            this.useMight.Location = new System.Drawing.Point(10, 17);
            this.useMight.Name = "useMight";
            this.useMight.Size = new System.Drawing.Size(43, 17);
            this.useMight.TabIndex = 11;
            this.useMight.Text = "Yes";
            this.useMight.UseVisualStyleBackColor = true;
            this.useMight.CheckedChanged += new System.EventHandler(this.useMight_CheckedChanged);
            // 
            // noMight
            // 
            this.noMight.AutoSize = true;
            this.noMight.Checked = true;
            this.noMight.Location = new System.Drawing.Point(57, 17);
            this.noMight.Name = "noMight";
            this.noMight.Size = new System.Drawing.Size(39, 17);
            this.noMight.TabIndex = 10;
            this.noMight.TabStop = true;
            this.noMight.Text = "No";
            this.noMight.UseVisualStyleBackColor = true;
            this.noMight.CheckedChanged += new System.EventHandler(this.noMight_CheckedChanged);
            // 
            // numOfModelLabel
            // 
            this.numOfModelLabel.AutoSize = true;
            this.numOfModelLabel.Location = new System.Drawing.Point(129, 226);
            this.numOfModelLabel.Name = "numOfModelLabel";
            this.numOfModelLabel.Size = new System.Drawing.Size(88, 13);
            this.numOfModelLabel.TabIndex = 24;
            this.numOfModelLabel.Text = "Number of Model";
            // 
            // numOfModel
            // 
            this.numOfModel.Location = new System.Drawing.Point(129, 242);
            this.numOfModel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfModel.Name = "numOfModel";
            this.numOfModel.Size = new System.Drawing.Size(106, 20);
            this.numOfModel.TabIndex = 25;
            this.numOfModel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // targetDefence
            // 
            this.targetDefence.Location = new System.Drawing.Point(113, 36);
            this.targetDefence.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.targetDefence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.targetDefence.Name = "targetDefence";
            this.targetDefence.Size = new System.Drawing.Size(106, 20);
            this.targetDefence.TabIndex = 26;
            this.targetDefence.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Shooting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 663);
            this.Controls.Add(this.accuracyBox);
            this.Controls.Add(this.inWay);
            this.Controls.Add(this.moveBox);
            this.Controls.Add(this.manualTargetBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reRollChoiceBox);
            this.Controls.Add(this.result);
            this.Controls.Add(this.ManualArcherBox);
            this.Controls.Add(this.chooseArcher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shoot);
            this.Controls.Add(this.numOfModel);
            this.Controls.Add(this.numOfModelLabel);
            this.Controls.Add(this.useMightBox);
            this.Name = "Shooting";
            this.Text = "Shooting";
            this.Load += new System.EventHandler(this.Shooting_Load);
            this.chooseArcher.ResumeLayout(false);
            this.chooseArcher.PerformLayout();
            this.ManualArcherBox.ResumeLayout(false);
            this.ManualArcherBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shootValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowStrength)).EndInit();
            this.ModelType.ResumeLayout(false);
            this.ModelType.PerformLayout();
            this.ReRollsBox.ResumeLayout(false);
            this.ReRollsBox.PerformLayout();
            this.reRollChoiceBox.ResumeLayout(false);
            this.reRollChoiceBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.manualTargetBox.ResumeLayout(false);
            this.manualTargetBox.PerformLayout();
            this.moveBox.ResumeLayout(false);
            this.moveBox.PerformLayout();
            this.inWay.ResumeLayout(false);
            this.inWay.PerformLayout();
            this.accuracyBox.ResumeLayout(false);
            this.accuracyBox.PerformLayout();
            this.useMightBox.ResumeLayout(false);
            this.useMightBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetDefence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton BlackrootVale;
        private System.Windows.Forms.RadioButton manualArcher;
        private System.Windows.Forms.RadioButton WoodElf;
        private System.Windows.Forms.RadioButton Duinhir;
        private System.Windows.Forms.GroupBox chooseArcher;
        private System.Windows.Forms.GroupBox ManualArcherBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label shootValueLabel;
        private System.Windows.Forms.RadioButton rerolls;
        private System.Windows.Forms.RadioButton norerolls;
        private System.Windows.Forms.GroupBox ReRollsBox;
        private System.Windows.Forms.GroupBox ModelType;
        private System.Windows.Forms.RadioButton chooseWarrior;
        private System.Windows.Forms.RadioButton chooseHero;
        private System.Windows.Forms.GroupBox reRollChoiceBox;
        private System.Windows.Forms.CheckBox onesToHit;
        private System.Windows.Forms.CheckBox allToHit;
        private System.Windows.Forms.CheckBox onesToWound;
        private System.Windows.Forms.CheckBox allToWound;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BlackrootValeTarget;
        private System.Windows.Forms.RadioButton DuinhirTarget;
        private System.Windows.Forms.RadioButton manualTarget;
        private System.Windows.Forms.RadioButton WoodElfTarget;
        private System.Windows.Forms.RadioButton Orc;
        private System.Windows.Forms.RadioButton Goblin;
        private System.Windows.Forms.RadioButton Sauron;
        private System.Windows.Forms.RadioButton WitchKing;
        private System.Windows.Forms.GroupBox manualTargetBox;
        private System.Windows.Forms.Label TargetDefenceLab;
        private System.Windows.Forms.Label TargetNameLabel;
        private System.Windows.Forms.TextBox targetName;
        private System.Windows.Forms.GroupBox moveBox;
        private System.Windows.Forms.RadioButton moved;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox inWay;
        private System.Windows.Forms.RadioButton noInWay;
        private System.Windows.Forms.RadioButton inWay3;
        private System.Windows.Forms.RadioButton inWay4;
        private System.Windows.Forms.RadioButton inWay5;
        private System.Windows.Forms.GroupBox accuracyBox;
        private System.Windows.Forms.RadioButton useAccuracy;
        private System.Windows.Forms.RadioButton noAccuracy;
        private System.Windows.Forms.GroupBox useMightBox;
        private System.Windows.Forms.RadioButton useMight;
        private System.Windows.Forms.RadioButton noMight;
        private System.Windows.Forms.Label numOfModelLabel;
        private System.Windows.Forms.NumericUpDown numOfModel;
        private System.Windows.Forms.NumericUpDown shootValue;
        private System.Windows.Forms.NumericUpDown bowStrength;
        private System.Windows.Forms.Label bowStrengthLabel;
        private System.Windows.Forms.NumericUpDown targetDefence;
    }
}

