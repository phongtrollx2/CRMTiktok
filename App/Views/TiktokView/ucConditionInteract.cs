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
    public partial class ucConditionInteract : UserControl
    {
        public event UpdateConditionHeart updateConditionHeart;
        public event UpdateConditionComment updateConditionComment;
        public event UpdateConditionShare updateConditionShare;
        public event UpdateConditionKeyword updateConditionKeyword;
       
        public ucConditionInteract()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringExtensions.Convert_A_Comma_Delimited_String_To_Array(rtxtContentKeyword.Text);
            UpdateConditionHeart();
            UpdateConditionComment();
            UpdateConditionShare();
            UpdateConditionKeyword();
        }

        private void UpdateConditionComment()
        {
            int conditionComment = int.Parse(nmCommentCondition.Value.ToString());
            updateConditionComment(conditionComment, rdCommentAND.Checked);
        }

        public void UpdateConditionHeart()
        {
            int conditionHeart = int.Parse(nmHeartCondition.Value.ToString());
            updateConditionHeart(conditionHeart, rdHeartAND.Checked);
        }

        public void UpdateConditionShare()
        {
            int conditionShare = int.Parse(nmHeartCondition.Value.ToString());
            updateConditionShare(conditionShare, rdShareAND.Checked);
        }

        public void UpdateConditionKeyword()
        {
            string [] keywords = StringExtensions.Convert_A_Comma_Delimited_String_To_Array(rtxtContentKeyword.Text);
            updateConditionKeyword(keywords, rdContainKeyAND.Checked);
        }
    }
}
