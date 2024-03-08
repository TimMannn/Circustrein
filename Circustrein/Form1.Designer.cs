namespace Circustrein
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
            labelAdd = new Label();
            checkBoxMedium = new CheckBox();
            checkBoxSmall = new CheckBox();
            checkBoxLarge = new CheckBox();
            labelSize = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            labelFood = new Label();
            panel3 = new Panel();
            checkBoxMeat = new CheckBox();
            checkBoxPlants = new CheckBox();
            panel4 = new Panel();
            buttonAdd = new Button();
            panel5 = new Panel();
            listView1 = new ListView();
            ColumnSize = new ColumnHeader();
            ColumnFood = new ColumnHeader();
            ColumnAmount = new ColumnHeader();
            numericUpDownAmount = new NumericUpDown();
            LabelAmount = new Label();
            label2 = new Label();
            buttonCalculate = new Button();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdd.Location = new Point(279, 21);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(258, 32);
            labelAdd.TabIndex = 0;
            labelAdd.Text = "Add animals to the list:";
            // 
            // checkBoxMedium
            // 
            checkBoxMedium.AutoSize = true;
            checkBoxMedium.Location = new Point(371, 96);
            checkBoxMedium.Name = "checkBoxMedium";
            checkBoxMedium.Size = new Size(71, 19);
            checkBoxMedium.TabIndex = 4;
            checkBoxMedium.Text = "Medium";
            checkBoxMedium.UseVisualStyleBackColor = true;
            checkBoxMedium.CheckedChanged += checkBoxMedium_CheckedChanged;
            // 
            // checkBoxSmall
            // 
            checkBoxSmall.AutoSize = true;
            checkBoxSmall.Location = new Point(249, 96);
            checkBoxSmall.Name = "checkBoxSmall";
            checkBoxSmall.Size = new Size(55, 19);
            checkBoxSmall.TabIndex = 5;
            checkBoxSmall.Text = "Small";
            checkBoxSmall.UseVisualStyleBackColor = true;
            checkBoxSmall.CheckedChanged += checkBoxSmall_CheckedChanged;
            // 
            // checkBoxLarge
            // 
            checkBoxLarge.AutoSize = true;
            checkBoxLarge.Location = new Point(506, 96);
            checkBoxLarge.Name = "checkBoxLarge";
            checkBoxLarge.Size = new Size(55, 19);
            checkBoxLarge.TabIndex = 6;
            checkBoxLarge.Text = "Large";
            checkBoxLarge.UseVisualStyleBackColor = true;
            checkBoxLarge.CheckedChanged += checkBoxLarge_CheckedChanged;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSize.Location = new Point(389, 59);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(38, 21);
            labelSize.TabIndex = 7;
            labelSize.Text = "Size";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(248, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 5);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(248, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 5);
            panel2.TabIndex = 9;
            // 
            // labelFood
            // 
            labelFood.AutoSize = true;
            labelFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFood.Location = new Point(387, 145);
            labelFood.Name = "labelFood";
            labelFood.Size = new Size(45, 21);
            labelFood.TabIndex = 10;
            labelFood.Text = "Food";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Location = new Point(248, 169);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 5);
            panel3.TabIndex = 11;
            // 
            // checkBoxMeat
            // 
            checkBoxMeat.AutoSize = true;
            checkBoxMeat.Location = new Point(314, 182);
            checkBoxMeat.Name = "checkBoxMeat";
            checkBoxMeat.Size = new Size(53, 19);
            checkBoxMeat.TabIndex = 12;
            checkBoxMeat.Text = "Meat";
            checkBoxMeat.UseVisualStyleBackColor = true;
            checkBoxMeat.CheckedChanged += checkBoxMeat_CheckedChanged;
            // 
            // checkBoxPlants
            // 
            checkBoxPlants.AutoSize = true;
            checkBoxPlants.Location = new Point(442, 182);
            checkBoxPlants.Name = "checkBoxPlants";
            checkBoxPlants.Size = new Size(58, 19);
            checkBoxPlants.TabIndex = 13;
            checkBoxPlants.Text = "Plants";
            checkBoxPlants.UseVisualStyleBackColor = true;
            checkBoxPlants.CheckedChanged += checkBoxPlants_CheckedChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Location = new Point(246, 210);
            panel4.Name = "panel4";
            panel4.Size = new Size(309, 5);
            panel4.TabIndex = 14;
            // 
            // buttonAdd
            // 
            buttonAdd.FlatStyle = FlatStyle.System;
            buttonAdd.Location = new Point(356, 268);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(106, 40);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveBorder;
            panel5.Location = new Point(0, 314);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 5);
            panel5.TabIndex = 17;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnSize, ColumnFood, ColumnAmount });
            listView1.Location = new Point(156, 323);
            listView1.Name = "listView1";
            listView1.Size = new Size(487, 121);
            listView1.TabIndex = 18;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnSize
            // 
            ColumnSize.Text = "Size";
            ColumnSize.Width = 191;
            // 
            // ColumnFood
            // 
            ColumnFood.Text = "Food";
            ColumnFood.Width = 191;
            // 
            // ColumnAmount
            // 
            ColumnAmount.Text = "Amount";
            ColumnAmount.Width = 100;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(376, 239);
            numericUpDownAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(68, 23);
            numericUpDownAmount.TabIndex = 19;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LabelAmount
            // 
            LabelAmount.AutoSize = true;
            LabelAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAmount.Location = new Point(378, 217);
            LabelAmount.Name = "LabelAmount";
            LabelAmount.Size = new Size(66, 21);
            LabelAmount.TabIndex = 20;
            LabelAmount.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(661, 403);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 21;
            label2.Text = "Wagons: ";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(661, 334);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 57);
            buttonCalculate.TabIndex = 23;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(628, 192);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 24;
            label8.Text = "label8";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(628, 77);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 25;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(628, 100);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 26;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(628, 122);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 27;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(628, 144);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 28;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(628, 167);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 29;
            label7.Text = "label7";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(buttonCalculate);
            Controls.Add(label2);
            Controls.Add(LabelAmount);
            Controls.Add(numericUpDownAmount);
            Controls.Add(listView1);
            Controls.Add(panel5);
            Controls.Add(buttonAdd);
            Controls.Add(panel4);
            Controls.Add(checkBoxPlants);
            Controls.Add(checkBoxMeat);
            Controls.Add(panel3);
            Controls.Add(labelFood);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelSize);
            Controls.Add(checkBoxLarge);
            Controls.Add(checkBoxSmall);
            Controls.Add(checkBoxMedium);
            Controls.Add(labelAdd);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBoxMedium;
        private CheckBox checkBoxSmall;
        private CheckBox checkBoxLarge;
        private Label labelSize;
        private Panel panel1;
        private Panel panel2;
        private Label labelFood;
        private Panel panel3;
        private CheckBox checkBoxMeat;
        private CheckBox checkBoxPlants;
        private Panel panel4;
        private Button buttonAdd;
        private Panel panel5;
        private ListView listView1;
        private ColumnHeader ColumnSize;
        private ColumnHeader ColumnFood;
        private NumericUpDown numericUpDownAmount;
        private Label LabelAmount;
        private ColumnHeader ColumnAmount;
        private Label labelAdd;
        public Label label2;
        private Button buttonCalculate;
        public Label label8;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label label7;
    }
}