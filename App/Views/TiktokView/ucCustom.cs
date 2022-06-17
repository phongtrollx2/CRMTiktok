using App.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Views.TiktokView
{
    public partial class ucCustom : UserControl
    {
        public event UpdateCustomComment updateCustomComment;
        public event UpdateCustomHeart updateCustomHeart;
        public event UpdateCustomFollow updateCustomFollow;
        public ucCustom()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateCustomComment();
            UpdateCustomHeart();
            UpdateCustomFollow();
        }

        public void UpdateCustomComment()
        {
            int ratioRandomComment = int.Parse(nmRatioRandomComment.Value.ToString());
            updateCustomComment(ratioRandomComment, rdRandomComment.Checked, rdConditionComment.Checked, rdAllComment.Checked);
        }
        public void UpdateCustomHeart()
        {
            int ratioRandomHeart = int.Parse(nmRatioRandomComment.Value.ToString());
            updateCustomComment(ratioRandomHeart, rdRandomComment.Checked, rdConditionComment.Checked, rdAllComment.Checked);
        }
        public void UpdateCustomFollow()
        {
            int ratioRandomFollow = int.Parse(nmRatioRandomComment.Value.ToString());
            updateCustomComment(ratioRandomFollow, rdRandomComment.Checked, rdConditionComment.Checked, rdAllComment.Checked);
        }
    }
}
