
namespace POETask2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gold_Label = new System.Windows.Forms.Label();
            this.Durability_Label = new System.Windows.Forms.Label();
            this.WeaponDamage_Label = new System.Windows.Forms.Label();
            this.WeaponRange_Label = new System.Windows.Forms.Label();
            this.Weapon_Label = new System.Windows.Forms.Label();
            this.Health_Label = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gold_Label);
            this.groupBox1.Controls.Add(this.Durability_Label);
            this.groupBox1.Controls.Add(this.WeaponDamage_Label);
            this.groupBox1.Controls.Add(this.WeaponRange_Label);
            this.groupBox1.Controls.Add(this.Weapon_Label);
            this.groupBox1.Controls.Add(this.Health_Label);
            this.groupBox1.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(453, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 250);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Stats";
            // 
            // Gold_Label
            // 
            this.Gold_Label.AutoSize = true;
            this.Gold_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gold_Label.Location = new System.Drawing.Point(9, 217);
            this.Gold_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Gold_Label.Name = "Gold_Label";
            this.Gold_Label.Size = new System.Drawing.Size(51, 19);
            this.Gold_Label.TabIndex = 5;
            this.Gold_Label.Text = "Gold";
            // 
            // Durability_Label
            // 
            this.Durability_Label.AutoSize = true;
            this.Durability_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Durability_Label.Location = new System.Drawing.Point(8, 175);
            this.Durability_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Durability_Label.Name = "Durability_Label";
            this.Durability_Label.Size = new System.Drawing.Size(104, 19);
            this.Durability_Label.TabIndex = 4;
            this.Durability_Label.Text = "Durability";
            // 
            // WeaponDamage_Label
            // 
            this.WeaponDamage_Label.AutoSize = true;
            this.WeaponDamage_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponDamage_Label.Location = new System.Drawing.Point(8, 140);
            this.WeaponDamage_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeaponDamage_Label.Name = "WeaponDamage_Label";
            this.WeaponDamage_Label.Size = new System.Drawing.Size(80, 19);
            this.WeaponDamage_Label.TabIndex = 3;
            this.WeaponDamage_Label.Text = "Damage";
            // 
            // WeaponRange_Label
            // 
            this.WeaponRange_Label.AutoSize = true;
            this.WeaponRange_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponRange_Label.Location = new System.Drawing.Point(9, 100);
            this.WeaponRange_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeaponRange_Label.Name = "WeaponRange_Label";
            this.WeaponRange_Label.Size = new System.Drawing.Size(66, 19);
            this.WeaponRange_Label.TabIndex = 2;
            this.WeaponRange_Label.Text = "Range";
            // 
            // Weapon_Label
            // 
            this.Weapon_Label.AutoSize = true;
            this.Weapon_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weapon_Label.Location = new System.Drawing.Point(8, 60);
            this.Weapon_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Weapon_Label.Name = "Weapon_Label";
            this.Weapon_Label.Size = new System.Drawing.Size(154, 19);
            this.Weapon_Label.TabIndex = 1;
            this.Weapon_Label.Text = "Current Weapon";
            // 
            // Health_Label
            // 
            this.Health_Label.AutoSize = true;
            this.Health_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health_Label.Location = new System.Drawing.Point(9, 28);
            this.Health_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Health_Label.Name = "Health_Label";
            this.Health_Label.Size = new System.Drawing.Size(74, 19);
            this.Health_Label.TabIndex = 0;
            this.Health_Label.Text = "Health";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.Location = new System.Drawing.Point(52, 52);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(46, 22);
            this.lblMap.TabIndex = 10;
            this.lblMap.Text = "MAP";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(542, 364);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 34);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(648, 364);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 34);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(434, 364);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(100, 34);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(542, 325);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 34);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Gold_Label;
        private System.Windows.Forms.Label Durability_Label;
        private System.Windows.Forms.Label WeaponDamage_Label;
        private System.Windows.Forms.Label WeaponRange_Label;
        private System.Windows.Forms.Label Weapon_Label;
        private System.Windows.Forms.Label Health_Label;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
    }
}

