namespace CDKBuild
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.lengthText = new System.Windows.Forms.TextBox();
            this.numberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Resultpanel = new System.Windows.Forms.Panel();
            this.timeText = new System.Windows.Forms.Label();
            this.repeatText = new System.Windows.Forms.Label();
            this.successText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableName = new System.Windows.Forms.TextBox();
            this.Resultpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(337, 267);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(151, 35);
            this.skinButton1.TabIndex = 2;
            this.skinButton1.Text = "开始生成";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.build);
            // 
            // lengthText
            // 
            this.lengthText.Location = new System.Drawing.Point(389, 159);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(121, 21);
            this.lengthText.TabIndex = 3;
            // 
            // numberText
            // 
            this.numberText.Location = new System.Drawing.Point(389, 197);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(121, 21);
            this.numberText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "生成长度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "生成数量";
            // 
            // showList
            // 
            this.showList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showList.FormattingEnabled = true;
            this.showList.ItemHeight = 14;
            this.showList.Location = new System.Drawing.Point(12, 12);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(252, 424);
            this.showList.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "礼包类型";
            // 
            // typeText
            // 
            this.typeText.Location = new System.Drawing.Point(392, 83);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(118, 21);
            this.typeText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "礼包Id";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(392, 120);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(118, 21);
            this.IDText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "生成成功:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "重复:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "用时:";
            // 
            // Resultpanel
            // 
            this.Resultpanel.Controls.Add(this.timeText);
            this.Resultpanel.Controls.Add(this.repeatText);
            this.Resultpanel.Controls.Add(this.successText);
            this.Resultpanel.Controls.Add(this.label5);
            this.Resultpanel.Controls.Add(this.label6);
            this.Resultpanel.Controls.Add(this.label7);
            this.Resultpanel.Location = new System.Drawing.Point(288, 325);
            this.Resultpanel.Name = "Resultpanel";
            this.Resultpanel.Size = new System.Drawing.Size(200, 100);
            this.Resultpanel.TabIndex = 18;
            this.Resultpanel.Visible = false;
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Location = new System.Drawing.Point(77, 74);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(0, 12);
            this.timeText.TabIndex = 17;
            // 
            // repeatText
            // 
            this.repeatText.AutoSize = true;
            this.repeatText.Location = new System.Drawing.Point(77, 44);
            this.repeatText.Name = "repeatText";
            this.repeatText.Size = new System.Drawing.Size(0, 12);
            this.repeatText.TabIndex = 16;
            // 
            // successText
            // 
            this.successText.AutoSize = true;
            this.successText.Location = new System.Drawing.Point(77, 9);
            this.successText.Name = "successText";
            this.successText.Size = new System.Drawing.Size(0, 12);
            this.successText.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "导出表名";
            // 
            // tableName
            // 
            this.tableName.Location = new System.Drawing.Point(389, 232);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(121, 21);
            this.tableName.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Resultpanel);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.lengthText);
            this.Controls.Add(this.skinButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resultpanel.ResumeLayout(false);
            this.Resultpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.TextBox lengthText;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox showList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox typeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Resultpanel;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Label repeatText;
        private System.Windows.Forms.Label successText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tableName;
    }
}

