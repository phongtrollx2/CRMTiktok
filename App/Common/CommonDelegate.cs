using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common
{
    //CRM App
    public delegate void UpdateCustomerDelegate();
    public delegate void UpdateCustomerCategoryDelegate();

    //Top top app
    public delegate void UpdateConditionHeart(int nmHeartCondition, bool isAND);
    public delegate void UpdateConditionComment(int nmCommentCondition, bool isAND);
    public delegate void UpdateConditionShare(int nmShareCondition, bool isAND);
    public delegate void UpdateConditionKeyword(string [] keywordsCondition, bool isAND);
    public delegate void UpdateConditionHashtag(string[] hastagsCondition, bool isAND);
    public delegate void UpdateContentComment(string content, bool isRandom);
    public delegate void UpdateCustomComment(int ratio, bool random, bool condition, bool all);
    public delegate void UpdateCustomHeart(int ratio, bool random, bool condition, bool all);
    public delegate void UpdateCustomFollow(int ratio, bool random, bool condition, bool all);
}
