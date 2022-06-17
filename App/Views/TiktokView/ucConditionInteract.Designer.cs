
namespace App.Views.TiktokView
{
    partial class ucConditionInteract
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rdHeartOR = new System.Windows.Forms.RadioButton();
            this.rdHeartAND = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmHeartCondition = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmCommentCondition = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rdCommentAND = new System.Windows.Forms.RadioButton();
            this.rdCommentOR = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nmConditionShare = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rdShareAND = new System.Windows.Forms.RadioButton();
            this.rdShareOR = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtxtContentKeyword = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdContainKeyAND = new System.Windows.Forms.RadioButton();
            this.rdContainKeyOR = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rtxtHashtagKeyword = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmHeartCondition)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCommentCondition)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmConditionShare)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video có số lượng tim lớn hơn";
            // 
            // rdHeartOR
            // 
            this.rdHeartOR.AutoSize = true;
            this.rdHeartOR.Checked = true;
            this.rdHeartOR.Location = new System.Drawing.Point(146, 64);
            this.rdHeartOR.Name = "rdHeartOR";
            this.rdHeartOR.Size = new System.Drawing.Size(62, 21);
            this.rdHeartOR.TabIndex = 1;
            this.rdHeartOR.TabStop = true;
            this.rdHeartOR.Text = "Hoặc";
            this.rdHeartOR.UseVisualStyleBackColor = true;
            // 
            // rdHeartAND
            // 
            this.rdHeartAND.AutoSize = true;
            this.rdHeartAND.Location = new System.Drawing.Point(282, 64);
            this.rdHeartAND.Name = "rdHeartAND";
            this.rdHeartAND.Size = new System.Drawing.Size(46, 21);
            this.rdHeartAND.TabIndex = 1;
            this.rdHeartAND.TabStop = true;
            this.rdHeartAND.Text = "Và";
            this.rdHeartAND.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmHeartCondition);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdHeartAND);
            this.panel1.Controls.Add(this.rdHeartOR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 100);
            this.panel1.TabIndex = 2;
            // 
            // nmHeartCondition
            // 
            this.nmHeartCondition.Location = new System.Drawing.Point(481, 40);
            this.nmHeartCondition.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmHeartCondition.Name = "nmHeartCondition";
            this.nmHeartCondition.Size = new System.Drawing.Size(120, 22);
            this.nmHeartCondition.TabIndex = 2;
            this.nmHeartCondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmHeartCondition.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmCommentCondition);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rdCommentAND);
            this.panel2.Controls.Add(this.rdCommentOR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 95);
            this.panel2.TabIndex = 3;
            // 
            // nmCommentCondition
            // 
            this.nmCommentCondition.Location = new System.Drawing.Point(481, 41);
            this.nmCommentCondition.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmCommentCondition.Name = "nmCommentCondition";
            this.nmCommentCondition.Size = new System.Drawing.Size(120, 22);
            this.nmCommentCondition.TabIndex = 6;
            this.nmCommentCondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmCommentCondition.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Video có số lượng comment lớn hơn";
            // 
            // rdCommentAND
            // 
            this.rdCommentAND.AutoSize = true;
            this.rdCommentAND.Location = new System.Drawing.Point(282, 65);
            this.rdCommentAND.Name = "rdCommentAND";
            this.rdCommentAND.Size = new System.Drawing.Size(46, 21);
            this.rdCommentAND.TabIndex = 4;
            this.rdCommentAND.TabStop = true;
            this.rdCommentAND.Text = "Và";
            this.rdCommentAND.UseVisualStyleBackColor = true;
            // 
            // rdCommentOR
            // 
            this.rdCommentOR.AutoSize = true;
            this.rdCommentOR.Checked = true;
            this.rdCommentOR.Location = new System.Drawing.Point(146, 65);
            this.rdCommentOR.Name = "rdCommentOR";
            this.rdCommentOR.Size = new System.Drawing.Size(62, 21);
            this.rdCommentOR.TabIndex = 5;
            this.rdCommentOR.TabStop = true;
            this.rdCommentOR.Text = "Hoặc";
            this.rdCommentOR.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nmConditionShare);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.rdShareAND);
            this.panel3.Controls.Add(this.rdShareOR);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 95);
            this.panel3.TabIndex = 4;
            // 
            // nmConditionShare
            // 
            this.nmConditionShare.Location = new System.Drawing.Point(481, 36);
            this.nmConditionShare.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmConditionShare.Name = "nmConditionShare";
            this.nmConditionShare.Size = new System.Drawing.Size(120, 22);
            this.nmConditionShare.TabIndex = 6;
            this.nmConditionShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmConditionShare.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Video có số lượng share lớn hơn";
            // 
            // rdShareAND
            // 
            this.rdShareAND.AutoSize = true;
            this.rdShareAND.Location = new System.Drawing.Point(282, 60);
            this.rdShareAND.Name = "rdShareAND";
            this.rdShareAND.Size = new System.Drawing.Size(46, 21);
            this.rdShareAND.TabIndex = 4;
            this.rdShareAND.TabStop = true;
            this.rdShareAND.Text = "Và";
            this.rdShareAND.UseVisualStyleBackColor = true;
            // 
            // rdShareOR
            // 
            this.rdShareOR.AutoSize = true;
            this.rdShareOR.Checked = true;
            this.rdShareOR.Location = new System.Drawing.Point(146, 60);
            this.rdShareOR.Name = "rdShareOR";
            this.rdShareOR.Size = new System.Drawing.Size(62, 21);
            this.rdShareOR.TabIndex = 5;
            this.rdShareOR.TabStop = true;
            this.rdShareOR.Text = "Hoặc";
            this.rdShareOR.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rtxtContentKeyword);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.rdContainKeyAND);
            this.panel4.Controls.Add(this.rdContainKeyOR);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1022, 95);
            this.panel4.TabIndex = 5;
            // 
            // rtxtContentKeyword
            // 
            this.rtxtContentKeyword.Location = new System.Drawing.Point(397, 3);
            this.rtxtContentKeyword.Name = "rtxtContentKeyword";
            this.rtxtContentKeyword.Size = new System.Drawing.Size(400, 86);
            this.rtxtContentKeyword.TabIndex = 7;
            this.rtxtContentKeyword.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Video có chứa một trong các từ khóa";
            // 
            // rdContainKeyAND
            // 
            this.rdContainKeyAND.AutoSize = true;
            this.rdContainKeyAND.Location = new System.Drawing.Point(282, 58);
            this.rdContainKeyAND.Name = "rdContainKeyAND";
            this.rdContainKeyAND.Size = new System.Drawing.Size(46, 21);
            this.rdContainKeyAND.TabIndex = 4;
            this.rdContainKeyAND.TabStop = true;
            this.rdContainKeyAND.Text = "Và";
            this.rdContainKeyAND.UseVisualStyleBackColor = true;
            // 
            // rdContainKeyOR
            // 
            this.rdContainKeyOR.AutoSize = true;
            this.rdContainKeyOR.Checked = true;
            this.rdContainKeyOR.Location = new System.Drawing.Point(146, 58);
            this.rdContainKeyOR.Name = "rdContainKeyOR";
            this.rdContainKeyOR.Size = new System.Drawing.Size(62, 21);
            this.rdContainKeyOR.TabIndex = 5;
            this.rdContainKeyOR.TabStop = true;
            this.rdContainKeyOR.Text = "Hoặc";
            this.rdContainKeyOR.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rtxtHashtagKeyword);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1022, 95);
            this.panel5.TabIndex = 6;
            // 
            // rtxtHashtagKeyword
            // 
            this.rtxtHashtagKeyword.Location = new System.Drawing.Point(397, 6);
            this.rtxtHashtagKeyword.Name = "rtxtHashtagKeyword";
            this.rtxtHashtagKeyword.Size = new System.Drawing.Size(400, 86);
            this.rtxtHashtagKeyword.TabIndex = 7;
            this.rtxtHashtagKeyword.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Video có Hashtag chứa một trong các từ khóa";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 480);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1022, 76);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(874, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucConditionInteract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucConditionInteract";
            this.Size = new System.Drawing.Size(1022, 556);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmHeartCondition)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCommentCondition)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmConditionShare)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdHeartOR;
        private System.Windows.Forms.RadioButton rdHeartAND;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmHeartCondition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmCommentCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdCommentAND;
        private System.Windows.Forms.RadioButton rdCommentOR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nmConditionShare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdShareAND;
        private System.Windows.Forms.RadioButton rdShareOR;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rtxtContentKeyword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdContainKeyAND;
        private System.Windows.Forms.RadioButton rdContainKeyOR;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox rtxtHashtagKeyword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
    }
}
