
namespace App.Views.TiktokView
{
    partial class ucContentComment
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rtxtContentReplyComment = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdReplyCommentFollowContent = new System.Windows.Forms.RadioButton();
            this.rdReplyCommentEmoji = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtxtContentComment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdCommentFollowContent = new System.Windows.Forms.RadioButton();
            this.rdRandomEmoji = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 516);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1022, 89);
            this.flowLayoutPanel1.TabIndex = 10;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.rtxtContentReplyComment);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.rdReplyCommentFollowContent);
            this.panel5.Controls.Add(this.rdReplyCommentEmoji);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 262);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1022, 254);
            this.panel5.TabIndex = 9;
            // 
            // rtxtContentReplyComment
            // 
            this.rtxtContentReplyComment.Location = new System.Drawing.Point(146, 80);
            this.rtxtContentReplyComment.Name = "rtxtContentReplyComment";
            this.rtxtContentReplyComment.Size = new System.Drawing.Size(651, 159);
            this.rtxtContentReplyComment.TabIndex = 7;
            this.rtxtContentReplyComment.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nội dung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nội dung reply comment";
            // 
            // rdReplyCommentFollowContent
            // 
            this.rdReplyCommentFollowContent.AutoSize = true;
            this.rdReplyCommentFollowContent.Location = new System.Drawing.Point(198, 53);
            this.rdReplyCommentFollowContent.Name = "rdReplyCommentFollowContent";
            this.rdReplyCommentFollowContent.Size = new System.Drawing.Size(121, 21);
            this.rdReplyCommentFollowContent.TabIndex = 4;
            this.rdReplyCommentFollowContent.Text = "Theo nội dung";
            this.rdReplyCommentFollowContent.UseVisualStyleBackColor = true;
            // 
            // rdReplyCommentEmoji
            // 
            this.rdReplyCommentEmoji.AutoSize = true;
            this.rdReplyCommentEmoji.Checked = true;
            this.rdReplyCommentEmoji.Location = new System.Drawing.Point(62, 53);
            this.rdReplyCommentEmoji.Name = "rdReplyCommentEmoji";
            this.rdReplyCommentEmoji.Size = new System.Drawing.Size(130, 21);
            this.rdReplyCommentEmoji.TabIndex = 5;
            this.rdReplyCommentEmoji.TabStop = true;
            this.rdReplyCommentEmoji.Text = "Icon ngẫu nhiên";
            this.rdReplyCommentEmoji.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rtxtContentComment);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.rdCommentFollowContent);
            this.panel4.Controls.Add(this.rdRandomEmoji);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1022, 262);
            this.panel4.TabIndex = 8;
            // 
            // rtxtContentComment
            // 
            this.rtxtContentComment.Location = new System.Drawing.Point(146, 85);
            this.rtxtContentComment.Name = "rtxtContentComment";
            this.rtxtContentComment.Size = new System.Drawing.Size(651, 159);
            this.rtxtContentComment.TabIndex = 7;
            this.rtxtContentComment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nội dung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nội dung comment";
            // 
            // rdCommentFollowContent
            // 
            this.rdCommentFollowContent.AutoSize = true;
            this.rdCommentFollowContent.Location = new System.Drawing.Point(198, 58);
            this.rdCommentFollowContent.Name = "rdCommentFollowContent";
            this.rdCommentFollowContent.Size = new System.Drawing.Size(121, 21);
            this.rdCommentFollowContent.TabIndex = 4;
            this.rdCommentFollowContent.Text = "Theo nội dung";
            this.rdCommentFollowContent.UseVisualStyleBackColor = true;
            // 
            // rdRandomEmoji
            // 
            this.rdRandomEmoji.AutoSize = true;
            this.rdRandomEmoji.Checked = true;
            this.rdRandomEmoji.Location = new System.Drawing.Point(62, 58);
            this.rdRandomEmoji.Name = "rdRandomEmoji";
            this.rdRandomEmoji.Size = new System.Drawing.Size(130, 21);
            this.rdRandomEmoji.TabIndex = 5;
            this.rdRandomEmoji.TabStop = true;
            this.rdRandomEmoji.Text = "Icon ngẫu nhiên";
            this.rdRandomEmoji.UseVisualStyleBackColor = true;
            // 
            // ucContentComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "ucContentComment";
            this.Size = new System.Drawing.Size(1022, 605);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox rtxtContentReplyComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdReplyCommentFollowContent;
        private System.Windows.Forms.RadioButton rdReplyCommentEmoji;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rtxtContentComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdCommentFollowContent;
        private System.Windows.Forms.RadioButton rdRandomEmoji;
    }
}
