namespace Car_Parking_Management_System_sourse
{
    partial class Manager_Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchManager = new System.Windows.Forms.TextBox();
            this.groupBoxSearchSpace = new System.Windows.Forms.GroupBox();
            this.comboBoxEmptyorHired = new System.Windows.Forms.ComboBox();
            this.txtCostInforManager = new System.Windows.Forms.TextBox();
            this.txtNumberplateInforManager = new System.Windows.Forms.TextBox();
            this.txtIDInforParkingManager = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtNameInforParkingManager = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxCreateSpace = new System.Windows.Forms.GroupBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtIDParkingSpaceManager = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridViewShowParkingSpace = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLogoutManager = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxSearchSpace.SuspendLayout();
            this.groupBoxCreateSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowParkingSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 589);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(788, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Management Center";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtSearchManager);
            this.tabPage1.Controls.Add(this.groupBoxSearchSpace);
            this.tabPage1.Controls.Add(this.groupBoxCreateSpace);
            this.tabPage1.Controls.Add(this.dataGridViewShowParkingSpace);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 560);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Car Parking Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Enter ID:";
            // 
            // txtSearchManager
            // 
            this.txtSearchManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchManager.Location = new System.Drawing.Point(560, 240);
            this.txtSearchManager.Name = "txtSearchManager";
            this.txtSearchManager.Size = new System.Drawing.Size(153, 22);
            this.txtSearchManager.TabIndex = 20;
            this.txtSearchManager.TextChanged += new System.EventHandler(this.txtSearchManager_TextChanged);
            // 
            // groupBoxSearchSpace
            // 
            this.groupBoxSearchSpace.Controls.Add(this.comboBoxEmptyorHired);
            this.groupBoxSearchSpace.Controls.Add(this.txtCostInforManager);
            this.groupBoxSearchSpace.Controls.Add(this.txtNumberplateInforManager);
            this.groupBoxSearchSpace.Controls.Add(this.txtIDInforParkingManager);
            this.groupBoxSearchSpace.Controls.Add(this.label8);
            this.groupBoxSearchSpace.Controls.Add(this.label7);
            this.groupBoxSearchSpace.Controls.Add(this.label6);
            this.groupBoxSearchSpace.Controls.Add(this.label5);
            this.groupBoxSearchSpace.Controls.Add(this.btnEdit);
            this.groupBoxSearchSpace.Controls.Add(this.txtNameInforParkingManager);
            this.groupBoxSearchSpace.Controls.Add(this.label4);
            this.groupBoxSearchSpace.Location = new System.Drawing.Point(402, 16);
            this.groupBoxSearchSpace.Name = "groupBoxSearchSpace";
            this.groupBoxSearchSpace.Size = new System.Drawing.Size(377, 205);
            this.groupBoxSearchSpace.TabIndex = 2;
            this.groupBoxSearchSpace.TabStop = false;
            this.groupBoxSearchSpace.Text = "Enter Informtion:";
            // 
            // comboBoxEmptyorHired
            // 
            this.comboBoxEmptyorHired.FormattingEnabled = true;
            this.comboBoxEmptyorHired.Items.AddRange(new object[] {
            "Empty",
            "Hired",
            "Wait..."});
            this.comboBoxEmptyorHired.Location = new System.Drawing.Point(271, 81);
            this.comboBoxEmptyorHired.Name = "comboBoxEmptyorHired";
            this.comboBoxEmptyorHired.Size = new System.Drawing.Size(88, 24);
            this.comboBoxEmptyorHired.TabIndex = 19;
            // 
            // txtCostInforManager
            // 
            this.txtCostInforManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostInforManager.Location = new System.Drawing.Point(271, 118);
            this.txtCostInforManager.Name = "txtCostInforManager";
            this.txtCostInforManager.Size = new System.Drawing.Size(88, 22);
            this.txtCostInforManager.TabIndex = 18;
            // 
            // txtNumberplateInforManager
            // 
            this.txtNumberplateInforManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberplateInforManager.Location = new System.Drawing.Point(124, 118);
            this.txtNumberplateInforManager.Name = "txtNumberplateInforManager";
            this.txtNumberplateInforManager.Size = new System.Drawing.Size(66, 22);
            this.txtNumberplateInforManager.TabIndex = 17;
            // 
            // txtIDInforParkingManager
            // 
            this.txtIDInforParkingManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDInforParkingManager.Location = new System.Drawing.Point(138, 78);
            this.txtIDInforParkingManager.Name = "txtIDInforParkingManager";
            this.txtIDInforParkingManager.Size = new System.Drawing.Size(52, 22);
            this.txtIDInforParkingManager.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(214, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Numper plate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name of car";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(132, 163);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 27);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtNameInforParkingManager
            // 
            this.txtNameInforParkingManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameInforParkingManager.Location = new System.Drawing.Point(118, 43);
            this.txtNameInforParkingManager.Name = "txtNameInforParkingManager";
            this.txtNameInforParkingManager.Size = new System.Drawing.Size(241, 22);
            this.txtNameInforParkingManager.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID parking space:";
            // 
            // groupBoxCreateSpace
            // 
            this.groupBoxCreateSpace.Controls.Add(this.comboBoxType);
            this.groupBoxCreateSpace.Controls.Add(this.txtCost);
            this.groupBoxCreateSpace.Controls.Add(this.txtIDParkingSpaceManager);
            this.groupBoxCreateSpace.Controls.Add(this.label3);
            this.groupBoxCreateSpace.Controls.Add(this.label2);
            this.groupBoxCreateSpace.Controls.Add(this.label1);
            this.groupBoxCreateSpace.Controls.Add(this.btnadd);
            this.groupBoxCreateSpace.Location = new System.Drawing.Point(6, 16);
            this.groupBoxCreateSpace.Name = "groupBoxCreateSpace";
            this.groupBoxCreateSpace.Size = new System.Drawing.Size(374, 267);
            this.groupBoxCreateSpace.TabIndex = 1;
            this.groupBoxCreateSpace.TabStop = false;
            this.groupBoxCreateSpace.Text = "Create Parking Space:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Common Zone",
            "VIP Zone"});
            this.comboBoxType.Location = new System.Drawing.Point(162, 97);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(153, 26);
            this.comboBoxType.TabIndex = 7;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(162, 136);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(105, 22);
            this.txtCost.TabIndex = 6;
            // 
            // txtIDParkingSpaceManager
            // 
            this.txtIDParkingSpaceManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDParkingSpaceManager.Location = new System.Drawing.Point(162, 62);
            this.txtIDParkingSpaceManager.Name = "txtIDParkingSpaceManager";
            this.txtIDParkingSpaceManager.Size = new System.Drawing.Size(153, 22);
            this.txtIDParkingSpaceManager.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Parking Space:";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(144, 199);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 27);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridViewShowParkingSpace
            // 
            this.dataGridViewShowParkingSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowParkingSpace.Location = new System.Drawing.Point(6, 312);
            this.dataGridViewShowParkingSpace.Name = "dataGridViewShowParkingSpace";
            this.dataGridViewShowParkingSpace.ReadOnly = true;
            this.dataGridViewShowParkingSpace.RowHeadersWidth = 51;
            this.dataGridViewShowParkingSpace.RowTemplate.Height = 24;
            this.dataGridViewShowParkingSpace.Size = new System.Drawing.Size(773, 242);
            this.dataGridViewShowParkingSpace.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(503, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 560);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLogoutManager
            // 
            this.btnLogoutManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutManager.Location = new System.Drawing.Point(731, 1);
            this.btnLogoutManager.Name = "btnLogoutManager";
            this.btnLogoutManager.Size = new System.Drawing.Size(77, 30);
            this.btnLogoutManager.TabIndex = 8;
            this.btnLogoutManager.Text = "Logout";
            this.btnLogoutManager.UseVisualStyleBackColor = true;
            this.btnLogoutManager.Click += new System.EventHandler(this.btnLogoutManager_Click);
            // 
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(820, 613);
            this.Controls.Add(this.btnLogoutManager);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxSearchSpace.ResumeLayout(false);
            this.groupBoxSearchSpace.PerformLayout();
            this.groupBoxCreateSpace.ResumeLayout(false);
            this.groupBoxCreateSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowParkingSpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxCreateSpace;
        private System.Windows.Forms.DataGridView dataGridViewShowParkingSpace;
        private System.Windows.Forms.GroupBox groupBoxSearchSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtIDParkingSpaceManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameInforParkingManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCostInforManager;
        private System.Windows.Forms.TextBox txtNumberplateInforManager;
        private System.Windows.Forms.TextBox txtIDInforParkingManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxEmptyorHired;
        private System.Windows.Forms.Button btnLogoutManager;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchManager;
    }
}