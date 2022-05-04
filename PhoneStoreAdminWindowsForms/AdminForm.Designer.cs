
namespace PhoneStoreAdminWindowsForms
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonSortPhones = new System.Windows.Forms.Button();
            this.rbSortByBrand = new System.Windows.Forms.RadioButton();
            this.rbSortByModel = new System.Windows.Forms.RadioButton();
            this.rbSortByPrice = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonReplacePhone = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPrice1 = new System.Windows.Forms.TextBox();
            this.tbModel1 = new System.Windows.Forms.TextBox();
            this.tbBrand1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbByModel = new System.Windows.Forms.RadioButton();
            this.buttonRemovePhone = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRemoveBy = new System.Windows.Forms.TextBox();
            this.rbByBrand = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddPhone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPhones = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhones)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1432, 704);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridPhones);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1424, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(809, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 46);
            this.label14.TabIndex = 14;
            this.label14.Text = "Sort phones";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.buttonSortPhones);
            this.panel4.Controls.Add(this.rbSortByBrand);
            this.panel4.Controls.Add(this.rbSortByModel);
            this.panel4.Controls.Add(this.rbSortByPrice);
            this.panel4.Location = new System.Drawing.Point(782, 279);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 154);
            this.panel4.TabIndex = 10;
            // 
            // buttonSortPhones
            // 
            this.buttonSortPhones.Location = new System.Drawing.Point(80, 108);
            this.buttonSortPhones.Name = "buttonSortPhones";
            this.buttonSortPhones.Size = new System.Drawing.Size(94, 29);
            this.buttonSortPhones.TabIndex = 15;
            this.buttonSortPhones.Text = "Sort";
            this.buttonSortPhones.UseVisualStyleBackColor = true;
            this.buttonSortPhones.Click += new System.EventHandler(this.buttonSortPhones_Click);
            // 
            // rbSortByBrand
            // 
            this.rbSortByBrand.AutoSize = true;
            this.rbSortByBrand.Location = new System.Drawing.Point(81, 16);
            this.rbSortByBrand.Name = "rbSortByBrand";
            this.rbSortByBrand.Size = new System.Drawing.Size(89, 24);
            this.rbSortByBrand.TabIndex = 11;
            this.rbSortByBrand.TabStop = true;
            this.rbSortByBrand.Text = "by brand";
            this.rbSortByBrand.UseVisualStyleBackColor = true;
            // 
            // rbSortByModel
            // 
            this.rbSortByModel.AutoSize = true;
            this.rbSortByModel.Location = new System.Drawing.Point(81, 46);
            this.rbSortByModel.Name = "rbSortByModel";
            this.rbSortByModel.Size = new System.Drawing.Size(93, 24);
            this.rbSortByModel.TabIndex = 12;
            this.rbSortByModel.TabStop = true;
            this.rbSortByModel.Text = "by model";
            this.rbSortByModel.UseVisualStyleBackColor = true;
            // 
            // rbSortByPrice
            // 
            this.rbSortByPrice.AutoSize = true;
            this.rbSortByPrice.Location = new System.Drawing.Point(81, 76);
            this.rbSortByPrice.Name = "rbSortByPrice";
            this.rbSortByPrice.Size = new System.Drawing.Size(83, 24);
            this.rbSortByPrice.TabIndex = 13;
            this.rbSortByPrice.TabStop = true;
            this.rbSortByPrice.Text = "by price";
            this.rbSortByPrice.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(1080, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 46);
            this.label12.TabIndex = 9;
            this.label12.Text = "Replace phone";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.buttonReplacePhone);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tbPrice1);
            this.panel3.Controls.Add(this.tbModel1);
            this.panel3.Controls.Add(this.tbBrand1);
            this.panel3.Location = new System.Drawing.Point(1069, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 286);
            this.panel3.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Select phone you want to replace";
            // 
            // buttonReplacePhone
            // 
            this.buttonReplacePhone.Location = new System.Drawing.Point(85, 237);
            this.buttonReplacePhone.Name = "buttonReplacePhone";
            this.buttonReplacePhone.Size = new System.Drawing.Size(94, 29);
            this.buttonReplacePhone.TabIndex = 12;
            this.buttonReplacePhone.Text = "Replace";
            this.buttonReplacePhone.UseVisualStyleBackColor = true;
            this.buttonReplacePhone.Click += new System.EventHandler(this.buttonReplacePhone_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Model:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Brand:";
            // 
            // tbPrice1
            // 
            this.tbPrice1.Location = new System.Drawing.Point(26, 197);
            this.tbPrice1.Name = "tbPrice1";
            this.tbPrice1.Size = new System.Drawing.Size(207, 27);
            this.tbPrice1.TabIndex = 8;
            // 
            // tbModel1
            // 
            this.tbModel1.Location = new System.Drawing.Point(26, 134);
            this.tbModel1.Name = "tbModel1";
            this.tbModel1.Size = new System.Drawing.Size(207, 27);
            this.tbModel1.TabIndex = 7;
            // 
            // tbBrand1
            // 
            this.tbBrand1.Location = new System.Drawing.Point(26, 67);
            this.tbBrand1.Name = "tbBrand1";
            this.tbBrand1.Size = new System.Drawing.Size(207, 27);
            this.tbBrand1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(792, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 46);
            this.label8.TabIndex = 7;
            this.label8.Text = "Remove phone";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.rbByModel);
            this.panel2.Controls.Add(this.buttonRemovePhone);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbRemoveBy);
            this.panel2.Controls.Add(this.rbByBrand);
            this.panel2.Location = new System.Drawing.Point(782, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 173);
            this.panel2.TabIndex = 6;
            // 
            // rbByModel
            // 
            this.rbByModel.AutoSize = true;
            this.rbByModel.Location = new System.Drawing.Point(134, 12);
            this.rbByModel.Name = "rbByModel";
            this.rbByModel.Size = new System.Drawing.Size(93, 24);
            this.rbByModel.TabIndex = 9;
            this.rbByModel.TabStop = true;
            this.rbByModel.Text = "by model";
            this.rbByModel.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePhone
            // 
            this.buttonRemovePhone.Location = new System.Drawing.Point(76, 121);
            this.buttonRemovePhone.Name = "buttonRemovePhone";
            this.buttonRemovePhone.Size = new System.Drawing.Size(94, 29);
            this.buttonRemovePhone.TabIndex = 8;
            this.buttonRemovePhone.Text = "Remove";
            this.buttonRemovePhone.UseVisualStyleBackColor = true;
            this.buttonRemovePhone.Click += new System.EventHandler(this.buttonRemovePhone_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Enter brand/model:";
            // 
            // tbRemoveBy
            // 
            this.tbRemoveBy.Location = new System.Drawing.Point(21, 81);
            this.tbRemoveBy.Name = "tbRemoveBy";
            this.tbRemoveBy.Size = new System.Drawing.Size(207, 27);
            this.tbRemoveBy.TabIndex = 6;
            // 
            // rbByBrand
            // 
            this.rbByBrand.AutoSize = true;
            this.rbByBrand.Location = new System.Drawing.Point(23, 12);
            this.rbByBrand.Name = "rbByBrand";
            this.rbByBrand.Size = new System.Drawing.Size(89, 24);
            this.rbByBrand.TabIndex = 4;
            this.rbByBrand.TabStop = true;
            this.rbByBrand.Text = "by brand";
            this.rbByBrand.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(494, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 46);
            this.label5.TabIndex = 3;
            this.label5.Text = "Add new phone";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.nudQuantity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonAddPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.tbModel);
            this.panel1.Controls.Add(this.tbBrand);
            this.panel1.Location = new System.Drawing.Point(494, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 314);
            this.panel1.TabIndex = 2;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(27, 227);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(207, 27);
            this.nudQuantity.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quantity:";
            // 
            // buttonAddPhone
            // 
            this.buttonAddPhone.Location = new System.Drawing.Point(90, 269);
            this.buttonAddPhone.Name = "buttonAddPhone";
            this.buttonAddPhone.Size = new System.Drawing.Size(94, 29);
            this.buttonAddPhone.TabIndex = 6;
            this.buttonAddPhone.Text = "Save";
            this.buttonAddPhone.UseVisualStyleBackColor = true;
            this.buttonAddPhone.Click += new System.EventHandler(this.buttonAddPhone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(27, 162);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(207, 27);
            this.tbPrice.TabIndex = 2;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(27, 99);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(207, 27);
            this.tbModel.TabIndex = 1;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(27, 32);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(207, 27);
            this.tbBrand.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phones";
            // 
            // dataGridPhones
            // 
            this.dataGridPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPhones.Location = new System.Drawing.Point(49, 54);
            this.dataGridPhones.Name = "dataGridPhones";
            this.dataGridPhones.RowHeadersWidth = 51;
            this.dataGridPhones.RowTemplate.Height = 29;
            this.dataGridPhones.Size = new System.Drawing.Size(414, 440);
            this.dataGridPhones.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "Phone Store";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridPhones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRemoveBy;
        private System.Windows.Forms.RadioButton rbByBrand;
        private System.Windows.Forms.Button buttonRemovePhone;
        private System.Windows.Forms.RadioButton rbByModel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonReplacePhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPrice1;
        private System.Windows.Forms.TextBox tbModel1;
        private System.Windows.Forms.TextBox tbBrand1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonSortPhones;
        private System.Windows.Forms.RadioButton rbSortByBrand;
        private System.Windows.Forms.RadioButton rbSortByModel;
        private System.Windows.Forms.RadioButton rbSortByPrice;
    }
}

