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
    public partial class ucContentComment : UserControl
    {
        public event UpdateContentComment updateContentComment;
        public ucContentComment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateContentComment(rtxtContentComment.Text, rdRandomEmoji.Checked);
        }
    }
}
