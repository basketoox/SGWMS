﻿namespace SunEast.App
{
    partial class FrmItemEditor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDtlEdit = new System.Windows.Forms.Panel();
            this.txt_Dtl_cPosIdErp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Dtl_cAreaIdErp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Dtl_cWHIdErp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Dtl_cMatOther = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Dtl_cMatQCLevel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Dtl_cMatStyle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Dtl_cSupplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Tag_BachNo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_Out = new System.Windows.Forms.Label();
            this.txt_Dtl_cBatchNo = new System.Windows.Forms.TextBox();
            this.lbl_cBatchNo = new System.Windows.Forms.Label();
            this.txt_Dtl_cUnit = new System.Windows.Forms.TextBox();
            this.txt_Dtl_fQty = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_Dtl_cMNo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Dtl_cSpec = new System.Windows.Forms.TextBox();
            this.txt_Dtl_cMName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bdsItemList = new System.Windows.Forms.BindingSource(this.components);
            this.grdDtl = new System.Windows.Forms.DataGridView();
            this.colcMNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlDtlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDtl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(215, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(389, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(21, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 36);
            this.panel1.TabIndex = 1;
            // 
            // pnlDtlEdit
            // 
            this.pnlDtlEdit.BackColor = System.Drawing.SystemColors.Info;
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cPosIdErp);
            this.pnlDtlEdit.Controls.Add(this.label13);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cAreaIdErp);
            this.pnlDtlEdit.Controls.Add(this.label11);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cWHIdErp);
            this.pnlDtlEdit.Controls.Add(this.label10);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cMatOther);
            this.pnlDtlEdit.Controls.Add(this.label9);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cMatQCLevel);
            this.pnlDtlEdit.Controls.Add(this.label8);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cMatStyle);
            this.pnlDtlEdit.Controls.Add(this.label7);
            this.pnlDtlEdit.Controls.Add(this.button1);
            this.pnlDtlEdit.Controls.Add(this.btnSel);
            this.pnlDtlEdit.Controls.Add(this.label4);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cSupplier);
            this.pnlDtlEdit.Controls.Add(this.label3);
            this.pnlDtlEdit.Controls.Add(this.label6);
            this.pnlDtlEdit.Controls.Add(this.label5);
            this.pnlDtlEdit.Controls.Add(this.lbl_Tag_BachNo);
            this.pnlDtlEdit.Controls.Add(this.label22);
            this.pnlDtlEdit.Controls.Add(this.lbl_Out);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cBatchNo);
            this.pnlDtlEdit.Controls.Add(this.lbl_cBatchNo);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cUnit);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_fQty);
            this.pnlDtlEdit.Controls.Add(this.label25);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cMNo);
            this.pnlDtlEdit.Controls.Add(this.label19);
            this.pnlDtlEdit.Controls.Add(this.label12);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cSpec);
            this.pnlDtlEdit.Controls.Add(this.txt_Dtl_cMName);
            this.pnlDtlEdit.Controls.Add(this.label1);
            this.pnlDtlEdit.Controls.Add(this.label2);
            this.pnlDtlEdit.Location = new System.Drawing.Point(21, 21);
            this.pnlDtlEdit.Name = "pnlDtlEdit";
            this.pnlDtlEdit.Size = new System.Drawing.Size(746, 290);
            this.pnlDtlEdit.TabIndex = 0;
            this.pnlDtlEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDtlEdit_Paint);
            // 
            // txt_Dtl_cPosIdErp
            // 
            this.txt_Dtl_cPosIdErp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cPosIdErp.Location = new System.Drawing.Point(489, 41);
            this.txt_Dtl_cPosIdErp.Name = "txt_Dtl_cPosIdErp";
            this.txt_Dtl_cPosIdErp.ReadOnly = true;
            this.txt_Dtl_cPosIdErp.Size = new System.Drawing.Size(177, 21);
            this.txt_Dtl_cPosIdErp.TabIndex = 99;
            this.txt_Dtl_cPosIdErp.Tag = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(431, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 100;
            this.label13.Text = "ERP仓位号";
            // 
            // txt_Dtl_cAreaIdErp
            // 
            this.txt_Dtl_cAreaIdErp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cAreaIdErp.Location = new System.Drawing.Point(273, 42);
            this.txt_Dtl_cAreaIdErp.Name = "txt_Dtl_cAreaIdErp";
            this.txt_Dtl_cAreaIdErp.ReadOnly = true;
            this.txt_Dtl_cAreaIdErp.Size = new System.Drawing.Size(130, 21);
            this.txt_Dtl_cAreaIdErp.TabIndex = 97;
            this.txt_Dtl_cAreaIdErp.Tag = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 98;
            this.label11.Text = "ERP货区号";
            // 
            // txt_Dtl_cWHIdErp
            // 
            this.txt_Dtl_cWHIdErp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cWHIdErp.Location = new System.Drawing.Point(66, 41);
            this.txt_Dtl_cWHIdErp.Name = "txt_Dtl_cWHIdErp";
            this.txt_Dtl_cWHIdErp.ReadOnly = true;
            this.txt_Dtl_cWHIdErp.Size = new System.Drawing.Size(130, 21);
            this.txt_Dtl_cWHIdErp.TabIndex = 95;
            this.txt_Dtl_cWHIdErp.Tag = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 96;
            this.label10.Text = "ERP仓库号";
            // 
            // txt_Dtl_cMatOther
            // 
            this.txt_Dtl_cMatOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cMatOther.Location = new System.Drawing.Point(384, 138);
            this.txt_Dtl_cMatOther.Name = "txt_Dtl_cMatOther";
            this.txt_Dtl_cMatOther.ReadOnly = true;
            this.txt_Dtl_cMatOther.Size = new System.Drawing.Size(282, 21);
            this.txt_Dtl_cMatOther.TabIndex = 93;
            this.txt_Dtl_cMatOther.Tag = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 94;
            this.label9.Text = "其他属性：";
            // 
            // txt_Dtl_cMatQCLevel
            // 
            this.txt_Dtl_cMatQCLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cMatQCLevel.Location = new System.Drawing.Point(66, 133);
            this.txt_Dtl_cMatQCLevel.Name = "txt_Dtl_cMatQCLevel";
            this.txt_Dtl_cMatQCLevel.ReadOnly = true;
            this.txt_Dtl_cMatQCLevel.Size = new System.Drawing.Size(252, 21);
            this.txt_Dtl_cMatQCLevel.TabIndex = 91;
            this.txt_Dtl_cMatQCLevel.Tag = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 92;
            this.label8.Text = "质等：";
            // 
            // txt_Dtl_cMatStyle
            // 
            this.txt_Dtl_cMatStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cMatStyle.Location = new System.Drawing.Point(360, 103);
            this.txt_Dtl_cMatStyle.Name = "txt_Dtl_cMatStyle";
            this.txt_Dtl_cMatStyle.ReadOnly = true;
            this.txt_Dtl_cMatStyle.Size = new System.Drawing.Size(306, 21);
            this.txt_Dtl_cMatStyle.TabIndex = 89;
            this.txt_Dtl_cMatStyle.Tag = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 90;
            this.label7.Text = "款式：";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(631, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 87;
            this.button1.Text = "…";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSel
            // 
            this.btnSel.Location = new System.Drawing.Point(433, 16);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(20, 20);
            this.btnSel.TabIndex = 68;
            this.btnSel.Text = "…";
            this.btnSel.UseVisualStyleBackColor = true;
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(622, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 88;
            this.label4.Text = "*";
            // 
            // txt_Dtl_cSupplier
            // 
            this.txt_Dtl_cSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cSupplier.Location = new System.Drawing.Point(399, 177);
            this.txt_Dtl_cSupplier.Name = "txt_Dtl_cSupplier";
            this.txt_Dtl_cSupplier.ReadOnly = true;
            this.txt_Dtl_cSupplier.Size = new System.Drawing.Size(221, 21);
            this.txt_Dtl_cSupplier.TabIndex = 85;
            this.txt_Dtl_cSupplier.Tag = "0";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(340, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 86;
            this.label3.Text = "供应商/生产商：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(241, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 82;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(241, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 81;
            this.label5.Text = "*";
            // 
            // lbl_Tag_BachNo
            // 
            this.lbl_Tag_BachNo.AutoSize = true;
            this.lbl_Tag_BachNo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Tag_BachNo.Location = new System.Drawing.Point(241, 177);
            this.lbl_Tag_BachNo.Name = "lbl_Tag_BachNo";
            this.lbl_Tag_BachNo.Size = new System.Drawing.Size(11, 12);
            this.lbl_Tag_BachNo.TabIndex = 80;
            this.lbl_Tag_BachNo.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Location = new System.Drawing.Point(410, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(11, 12);
            this.label22.TabIndex = 78;
            this.label22.Text = "*";
            // 
            // lbl_Out
            // 
            this.lbl_Out.Location = new System.Drawing.Point(271, 214);
            this.lbl_Out.Name = "lbl_Out";
            this.lbl_Out.Size = new System.Drawing.Size(361, 12);
            this.lbl_Out.TabIndex = 73;
            // 
            // txt_Dtl_cBatchNo
            // 
            this.txt_Dtl_cBatchNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cBatchNo.Location = new System.Drawing.Point(64, 174);
            this.txt_Dtl_cBatchNo.Name = "txt_Dtl_cBatchNo";
            this.txt_Dtl_cBatchNo.Size = new System.Drawing.Size(176, 21);
            this.txt_Dtl_cBatchNo.TabIndex = 3;
            this.txt_Dtl_cBatchNo.Tag = "0";
            this.txt_Dtl_cBatchNo.Enter += new System.EventHandler(this.txt_Dtl_cBatchNo_Enter);
            this.txt_Dtl_cBatchNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Dtl_cItemName_KeyDown);
            // 
            // lbl_cBatchNo
            // 
            this.lbl_cBatchNo.AutoSize = true;
            this.lbl_cBatchNo.Location = new System.Drawing.Point(5, 174);
            this.lbl_cBatchNo.Name = "lbl_cBatchNo";
            this.lbl_cBatchNo.Size = new System.Drawing.Size(41, 12);
            this.lbl_cBatchNo.TabIndex = 72;
            this.lbl_cBatchNo.Text = "批号：";
            // 
            // txt_Dtl_cUnit
            // 
            this.txt_Dtl_cUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cUnit.Location = new System.Drawing.Point(64, 245);
            this.txt_Dtl_cUnit.Name = "txt_Dtl_cUnit";
            this.txt_Dtl_cUnit.Size = new System.Drawing.Size(176, 21);
            this.txt_Dtl_cUnit.TabIndex = 6;
            this.txt_Dtl_cUnit.Tag = "0";
            this.txt_Dtl_cUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Dtl_cUnit_KeyDown);
            // 
            // txt_Dtl_fQty
            // 
            this.txt_Dtl_fQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_fQty.Location = new System.Drawing.Point(64, 210);
            this.txt_Dtl_fQty.Name = "txt_Dtl_fQty";
            this.txt_Dtl_fQty.Size = new System.Drawing.Size(176, 21);
            this.txt_Dtl_fQty.TabIndex = 5;
            this.txt_Dtl_fQty.Tag = "0";
            this.txt_Dtl_fQty.Enter += new System.EventHandler(this.txt_Dtl_cProductBatchNo_Enter);
            this.txt_Dtl_fQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Dtl_cItemName_KeyDown);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 210);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 67;
            this.label25.Text = "数量：";
            // 
            // txt_Dtl_cMNo
            // 
            this.txt_Dtl_cMNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cMNo.Location = new System.Drawing.Point(66, 15);
            this.txt_Dtl_cMNo.Name = "txt_Dtl_cMNo";
            this.txt_Dtl_cMNo.Size = new System.Drawing.Size(337, 21);
            this.txt_Dtl_cMNo.TabIndex = 0;
            this.txt_Dtl_cMNo.Tag = "0";
            this.txt_Dtl_cMNo.Text = "9999999999999999999999999999999999999999999999999";
            this.txt_Dtl_cMNo.ReadOnlyChanged += new System.EventHandler(this.txt_Dtl_cMNo_ReadOnlyChanged);
            this.txt_Dtl_cMNo.TextChanged += new System.EventHandler(this.txt_Dtl_cItemId_TextChanged);
            this.txt_Dtl_cMNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Dtl_cItemId_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 55;
            this.label19.Text = "物料编码：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 51;
            this.label12.Text = "单位：";
            // 
            // txt_Dtl_cSpec
            // 
            this.txt_Dtl_cSpec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cSpec.Location = new System.Drawing.Point(66, 103);
            this.txt_Dtl_cSpec.Name = "txt_Dtl_cSpec";
            this.txt_Dtl_cSpec.ReadOnly = true;
            this.txt_Dtl_cSpec.Size = new System.Drawing.Size(252, 21);
            this.txt_Dtl_cSpec.TabIndex = 74;
            this.txt_Dtl_cSpec.Tag = "0";
            // 
            // txt_Dtl_cMName
            // 
            this.txt_Dtl_cMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dtl_cMName.Location = new System.Drawing.Point(66, 68);
            this.txt_Dtl_cMName.Name = "txt_Dtl_cMName";
            this.txt_Dtl_cMName.ReadOnly = true;
            this.txt_Dtl_cMName.Size = new System.Drawing.Size(600, 21);
            this.txt_Dtl_cMName.TabIndex = 76;
            this.txt_Dtl_cMName.Tag = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 75;
            this.label1.Text = "规格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 77;
            this.label2.Text = "名称：";
            // 
            // bdsItemList
            // 
            this.bdsItemList.AllowNew = false;
            // 
            // grdDtl
            // 
            this.grdDtl.AllowUserToAddRows = false;
            this.grdDtl.AllowUserToDeleteRows = false;
            this.grdDtl.AllowUserToOrderColumns = true;
            this.grdDtl.AutoGenerateColumns = false;
            this.grdDtl.ColumnHeadersHeight = 35;
            this.grdDtl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcMNo,
            this.colcName,
            this.colcSpec,
            this.colcUnit});
            this.grdDtl.DataSource = this.bdsItemList;
            this.grdDtl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDtl.Location = new System.Drawing.Point(74, 317);
            this.grdDtl.MultiSelect = false;
            this.grdDtl.Name = "grdDtl";
            this.grdDtl.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDtl.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDtl.RowHeadersVisible = false;
            this.grdDtl.RowTemplate.Height = 23;
            this.grdDtl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDtl.Size = new System.Drawing.Size(600, 338);
            this.grdDtl.TabIndex = 2;
            this.grdDtl.Tag = "8";
            this.grdDtl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDtl_CellDoubleClick);
            // 
            // colcMNo
            // 
            this.colcMNo.DataPropertyName = "cMNo";
            this.colcMNo.HeaderText = "物料编码";
            this.colcMNo.Name = "colcMNo";
            this.colcMNo.ReadOnly = true;
            this.colcMNo.ToolTipText = "物料编码";
            this.colcMNo.Width = 120;
            // 
            // colcName
            // 
            this.colcName.DataPropertyName = "cName";
            this.colcName.HeaderText = "物料名";
            this.colcName.Name = "colcName";
            this.colcName.ReadOnly = true;
            this.colcName.ToolTipText = "物料名";
            this.colcName.Width = 250;
            // 
            // colcSpec
            // 
            this.colcSpec.DataPropertyName = "cSpec";
            this.colcSpec.HeaderText = "规格型号";
            this.colcSpec.Name = "colcSpec";
            this.colcSpec.ReadOnly = true;
            this.colcSpec.ToolTipText = "规格型号";
            this.colcSpec.Width = 150;
            // 
            // colcUnit
            // 
            this.colcUnit.DataPropertyName = "cUnit";
            this.colcUnit.HeaderText = "有限期(天)";
            this.colcUnit.Name = "colcUnit";
            this.colcUnit.ReadOnly = true;
            this.colcUnit.ToolTipText = "有限期(天)";
            this.colcUnit.Width = 50;
            // 
            // FrmItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 408);
            this.Controls.Add(this.grdDtl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDtlEdit);
            this.Name = "FrmItemEditor";
            this.Text = "出库物料编辑器";
            this.Load += new System.EventHandler(this.FrmItemEditor_Load);
            this.panel1.ResumeLayout(false);
            this.pnlDtlEdit.ResumeLayout(false);
            this.pnlDtlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDtl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDtlEdit;
        private System.Windows.Forms.Button btnSel;
        private System.Windows.Forms.TextBox txt_Dtl_fQty;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_Dtl_cMNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource bdsItemList;
        private System.Windows.Forms.TextBox txt_Dtl_cUnit;
        private System.Windows.Forms.TextBox txt_Dtl_cBatchNo;
        private System.Windows.Forms.Label lbl_cBatchNo;
        private System.Windows.Forms.Label lbl_Out;
        private System.Windows.Forms.TextBox txt_Dtl_cSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Dtl_cMName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Tag_BachNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_Dtl_cSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Dtl_cMatStyle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Dtl_cMatQCLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Dtl_cMatOther;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Dtl_cPosIdErp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Dtl_cAreaIdErp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Dtl_cWHIdErp;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView grdDtl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcMNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcUnit;
    }
}