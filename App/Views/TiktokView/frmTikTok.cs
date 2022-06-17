using App.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace App.Views.TiktokView
{
    public partial class frmTikTok : Form
    {
        //Global variables
        private bool _isStop = false;
        private string _url = "https://www.tiktok.com/vi-VN/";
        private string _urlLogin = "https://www.tiktok.com/login";
        private string _btnLoginWithFacebookXPath = "//*[@id=\"root\"]/div/div[1]/div/div[1]/div[2]/div[3]";
        private string _firstVideoXPath = "//*[@id=\"main\"]/div[2]/div[2]/div/div[1]/span[1]/div/div/div[5]/div[1]/div[1]/div/span[2]";
        private string _videoDurationCssSelector = "#main > div.jsx-834240835.main-body.page-with-header.middle.em-follow > div.jsx-1952527567.trending-container > div > div.jsx-3131092411.video-card-big.browse-mode > div.jsx-3131092411.video-card-container > div.jsx-766879148.video-card-browse > div > div.jsx-781331802.seek-bar-time-container-browser";
        private string _heartCountXPath = "//*[@id=\"main\"]/div[2]/div[2]/div/div[2]/div[2]/div[2]/div[1]/div[1]/div[1]/strong";
        private string _commentCountXPath = "//*[@id=\"main\"]/div[2]/div[2]/div/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/strong";
        private string _btnEmojiXPath = "//*[@id=\"main\"]/div[2]/div[2]/div/div[2]/div[2]/div[4]/div/div[1]/div/div/div[3]/div/button";
        private string _btnSendCommentXPath = "//*[@id=\"main\"]/div[2]/div[2]/div/div[2]/div[2]/div[4]/div/div[2]";
        private string _inputCommentXPath = "//*[@id=\"main\"]/div[2]/div[2]/div/div[2]/div[2]/div[4]/div/div[1]/div/div/div[1]/div[2]/div/div/div/div";
        private string _btnNextVideoCssSelector = "#main > div.jsx-834240835.main-body.page-with-header.middle.em-follow > div.jsx-1952527567.trending-container > div > div.jsx-3131092411.video-card-big.browse-mode > div.jsx-3131092411.video-card-container > img.jsx-441496149.control-icon.arrow-right.up-and-down";
        private string _btnHeartXPath = "//*[@id=\"main\"]/div[2]/div[2]/div/div[2]/div[2]/div[2]/div[1]/div[1]/div[1]/span";
        private string _contentVideoXPath = "//*[@id=\"main\"]/div[2]/div[2]/div/div[2]/div[2]/div[2]/h1/strong[1]";
        private string _email = "trangbinhphongcmg@gmail.com";
        private string _password = "Troll9201";
        private string _action;
        //condition interact variables
        private int _conditionHeart;
        private bool _isConditionHeartAND = false;
        private int _conditionComment;
        private bool _isConditionCommentAND = false;
        private int _conditionShare;
        private bool _isConditionShareAND = false;
        private string[] _conditionKeywords;
        private bool _isConditionKeywordsAND = false;

        //Content comment and reply comment variables
        private bool _isRandomEmoji_contentComment = true;
        private string _contentComment;
        private string _contentReplyComment;

        //custom interact variables
        private bool _customComment_random = false;
        private bool _customComment_condition = false;
        private bool _customComment_all = false;
        private int _customComment_ratio;

        private bool _customHeart_random = false;
        private bool _customHeart_condition = false;
        private bool _customHeart_all = false;
        private int _customHeart_ratio;

        #region Events
        public frmTikTok()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            TaskOne();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _isStop = true;
        }


        private UserControl _ucActive = null;
        private void menuConditionInteractVideo_Click(object sender, EventArgs e)
        {
            if (_ucActive != null)
                _ucActive.Hide();

            ucConditionInteract ucConditionInteract = new ucConditionInteract();
            ucConditionInteract.Dock = DockStyle.Fill;

            ucConditionInteract.updateConditionComment += UcConditionInteract_updateConditionComment;
            ucConditionInteract.updateConditionHeart += UcConditionInteract_updateConditionHeart;
            ucConditionInteract.updateConditionShare += UcConditionInteract_updateConditionShare;
            ucConditionInteract.updateConditionKeyword += UcConditionInteract_updateConditionKeyword;

            _ucActive = ucConditionInteract;

            pnRightContainer.Controls.Add(ucConditionInteract);
        }

        private void UcConditionInteract_updateConditionKeyword(string[] keywordsCondition, bool isAND)
        {
            _conditionKeywords = keywordsCondition;
            _isConditionKeywordsAND = isAND;
        }

        private void UcConditionInteract_updateConditionShare(int nmShareCondition, bool isAND)
        {
            _conditionShare = nmShareCondition;
            _isConditionShareAND = isAND;
        }

        private void UcConditionInteract_updateConditionComment(int nmCommentCondition, bool isAND)
        {
            _conditionComment = nmCommentCondition;
            _isConditionCommentAND = isAND;
        }

        private void UcConditionInteract_updateConditionHeart(int nmHeartCondition, bool isAND)
        {
            _conditionHeart = nmHeartCondition;
            _isConditionHeartAND = isAND;
        }

        private void menuReplyComment_Click(object sender, EventArgs e)
        {
            if (_ucActive != null)
                _ucActive.Hide();

            ucConditionReplyComment ucConditionReplyComment = new ucConditionReplyComment();
            ucConditionReplyComment.Dock = DockStyle.Fill;

            _ucActive = ucConditionReplyComment;

            pnRightContainer.Controls.Add(ucConditionReplyComment);
        }

        private void menuCustomContent_Click(object sender, EventArgs e)
        {
            if (_ucActive != null)
                _ucActive.Hide();

            ucContentComment ucContentComment = new ucContentComment();
            ucContentComment.Dock = DockStyle.Fill;
            ucContentComment.updateContentComment += UcContentComment_updateContentComment;


            _ucActive = ucContentComment;

            pnRightContainer.Controls.Add(ucContentComment);
        }

        private void UcContentComment_updateContentComment(string content, bool isRandom)
        {
            _isRandomEmoji_contentComment = isRandom;
            if (!isRandom)
            {
                _contentComment = content;
            }
        }

        private void menuCustom_Click(object sender, EventArgs e)
        {
            if (_ucActive != null)
                _ucActive.Hide();

            ucCustom ucCustom = new ucCustom();
            ucCustom.Dock = DockStyle.Fill;

            ucCustom.updateCustomComment += UcCustom_updateCustomComment;
            ucCustom.updateCustomFollow += UcCustom_updateCustomFollow;
            ucCustom.updateCustomHeart += UcCustom_updateCustomHeart;
            _ucActive = ucCustom;

            pnRightContainer.Controls.Add(ucCustom);
        }

        private void UcCustom_updateCustomHeart(int ratio, bool random, bool condition, bool all)
        {
            throw new NotImplementedException();
        }

        private void UcCustom_updateCustomFollow(int ratio, bool random, bool condition, bool all)
        {
            throw new NotImplementedException();
        }

        private void UcCustom_updateCustomComment(int ratio, bool random, bool condition, bool all)
        {
            _customComment_ratio = ratio;
            _customComment_random = random;
            _customComment_condition = condition;
            _customComment_all = all;
        }

        #endregion

        #region Methods

        private void TaskOne()
        {
            Task t = new Task(() =>
            {
                RunWebDriver();
            });
            t.Start();
        }

        public void RunWebDriver()
        {
            while (true)
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                chromeOptions.AddExcludedArgument("enable-automation");
                chromeOptions.AddArgument("--start-maximized");
                //chromeOptions.AddArgument("--incognito");

                var chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;

                ChromeDriver chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions);
                chromeDriver.Url = _urlLogin;
                chromeDriver.Navigate();

                Thread.Sleep(3000);
                var btnLoginWithFacebook = chromeDriver.FindElement(By.XPath(_btnLoginWithFacebookXPath));
                btnLoginWithFacebook.Click();

                Actions action = new Actions(chromeDriver);

                Login(chromeDriver);

                Thread.Sleep(5000);
                action.SendKeys(Keys.Enter);
                action.Perform();

                Thread.Sleep(5000);
                chromeDriver.SwitchTo().Window(chromeDriver.WindowHandles[0]);

                //Click video when app run 1st
                WatchVideo(chromeDriver);

                while (_isStop == false)
                {
                    InteractVideo(chromeDriver);
                }

                CloseWebDriver(chromeDriver);
                break;
            }

        }

        private void InteractVideo(ChromeDriver chromeDriver)
        {
            Thread.Sleep(10000);
            string commentCountElement = chromeDriver.FindElement(By.XPath(_commentCountXPath)).Text;
            string heartCountElement = chromeDriver.FindElement(By.XPath(_heartCountXPath)).Text;
            string contentVideo;
            try
            {
                contentVideo = chromeDriver.FindElement(By.XPath(_contentVideoXPath)).Text;
            }
            catch
            {
                contentVideo = "";
            }
            //var videoDuration = chromeDriver.FindElement(By.CssSelector(_videoDurationCssSelector)).Text;

            var heartCount = StringExtensions.ConvertWordToNumber(heartCountElement);
            var commentCount = StringExtensions.ConvertWordToNumber(commentCountElement);

            if (_action =="Tùy chọn")
            {

                if (_customComment_random)
                {
                    CommentRandom(chromeDriver);
                }
                else
                {
                    if (commentCount > _conditionComment)
                    {
                        if (_isRandomEmoji_contentComment)
                        {
                            Comment_RandomEmoji(chromeDriver);
                        }
                        else
                        {
                            Comment_FollowContent(chromeDriver);
                        }
                    }
                }

                if (_customHeart_random)
                {
                    LikeRandom(chromeDriver);
                }
                else
                {
                    if (heartCount > _conditionHeart)
                    {
                        LikeVideo(chromeDriver);
                    }
                }

            }
            else
            {
                if (_isConditionHeartAND && _isConditionCommentAND && _isConditionKeywordsAND)
                {
                    if (heartCount >= _conditionHeart && commentCount >= _conditionComment && CheckKeyword(contentVideo))
                    {
                        Thread.Sleep(10000);
                        LikeVideo(chromeDriver);

                        Thread.Sleep(5000);
                        Comment(chromeDriver);
                    }
                }
                else if (_isConditionHeartAND && _isConditionCommentAND && !_isConditionKeywordsAND)
                {
                    if (heartCount >= _conditionHeart && commentCount >= _conditionComment || CheckKeyword(contentVideo))
                    {
                        Thread.Sleep(10000);
                        LikeVideo(chromeDriver);

                        Thread.Sleep(5000);
                        Comment(chromeDriver);
                    }

                }
                else if (_isConditionHeartAND && !_isConditionCommentAND && _isConditionKeywordsAND)
                {
                    if (heartCount >= _conditionHeart || commentCount >= _conditionComment && CheckKeyword(contentVideo))
                    {
                        Thread.Sleep(10000);
                        LikeVideo(chromeDriver);

                        Thread.Sleep(5000);
                        Comment(chromeDriver);
                    }
                }
                else if (_isConditionHeartAND && !_isConditionCommentAND && !_isConditionKeywordsAND)
                {
                    if (heartCount >= _conditionHeart || commentCount >= _conditionComment || CheckKeyword(contentVideo))
                    {
                        Thread.Sleep(10000);
                        LikeVideo(chromeDriver);

                        Thread.Sleep(5000);
                        Comment(chromeDriver);
                    }
                }
                else if (!_isConditionHeartAND && _isConditionCommentAND && _isConditionKeywordsAND)
                {
                    if (heartCount >= _conditionHeart || commentCount >= _conditionComment && CheckKeyword(contentVideo))
                    {
                        Thread.Sleep(10000);
                        LikeVideo(chromeDriver);

                        Thread.Sleep(5000);
                        Comment(chromeDriver);
                    }
                }
                else if (!_isConditionHeartAND && _isConditionCommentAND && !_isConditionKeywordsAND)
                {
                    if (heartCount >= _conditionHeart || commentCount >= _conditionComment || CheckKeyword(contentVideo))
                    {
                        Thread.Sleep(10000);
                        LikeVideo(chromeDriver);

                        Thread.Sleep(5000);
                        Comment(chromeDriver);
                    }
                }
                else if (!_isConditionHeartAND && !_isConditionCommentAND && !_isConditionKeywordsAND)
                {
                    if (heartCount >= _conditionHeart || commentCount >= _conditionComment || CheckKeyword(contentVideo))
                    {
                        Thread.Sleep(10000);
                        LikeVideo(chromeDriver);

                        Thread.Sleep(5000);
                        Comment(chromeDriver);
                    }
                }
                else
                {
                    if (heartCount >= _conditionHeart || commentCount >= _conditionComment)
                    {
                        Thread.Sleep(10000);
                        LikeVideo(chromeDriver);

                        Thread.Sleep(5000);
                        Comment(chromeDriver);
                    }
                }
            }


            Thread.Sleep(2000);

            NextVideo(chromeDriver);
        }

        private bool CheckKeyword(string contentVideo)
        {
            foreach (string keyword in _conditionKeywords)
            {
                if (contentVideo.ToLower().Contains(keyword.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }

        private void LikeRandom(ChromeDriver chromeDriver)
        {
            Random rd = new Random();
            int value = rd.Next(0, _customComment_ratio);
            if (value == 1)
            {
                LikeVideo(chromeDriver);
            }
        }

        private void CommentRandom(ChromeDriver chromeDriver)
        {

            Random rd = new Random();
            int value = rd.Next(0, _customComment_ratio);
            if (value == 1)
            {
                if (_isRandomEmoji_contentComment)
                {
                    Comment_RandomEmoji(chromeDriver);
                }
                else
                {
                    Comment_FollowContent(chromeDriver);
                }
            }
        }

        private void WatchVideo(ChromeDriver chromeDriver)
        {
            Thread.Sleep(10000);
            var firstVideo = chromeDriver.FindElement(By.XPath(_firstVideoXPath));

            firstVideo.Click();
        }

        private void LikeVideo(ChromeDriver chromeDriver)
        {
            IWebElement btnHeart = chromeDriver.FindElement(By.XPath(_btnHeartXPath));
            int x = btnHeart.Location.X;
            int y = btnHeart.Location.Y;

            //Actions action = new Actions(chromeDriver);
            //action.MoveByOffset(x, y).Click().Perform();
            btnHeart.Click();
        }

        private void Comment_RandomEmoji(ChromeDriver chromeDriver)
        {
            Random rd = new Random();
            int emojiIndex = rd.Next(1, 93);
            var btnEmoji = chromeDriver.FindElement(By.XPath(_btnEmojiXPath));
            btnEmoji.Click();

            Thread.Sleep(3000);

            var emojiRandom = chromeDriver.FindElement(By.XPath($"//*[@id=\"main\"]/div[2]/div[2]/div/div[2]/div[2]/div[4]/div/div[1]/div/div/div[3]/div/div/div/div/div[1]/section/ul/li[{emojiIndex}]"));
            emojiRandom.Click();

            Thread.Sleep(3000);

            var btnSendComment = chromeDriver.FindElement(By.XPath(_btnSendCommentXPath));
            btnSendComment.Click();
        }

        private void Comment_FollowContent(ChromeDriver chromeDriver)
        {
            var inputComment = chromeDriver.FindElement(By.XPath(_inputCommentXPath));
            inputComment.Click();
            Thread.Sleep(3000);

            inputComment.SendKeys(_contentComment);
            Thread.Sleep(5000);

            var btnSendComment = chromeDriver.FindElement(By.XPath(_btnSendCommentXPath));
            btnSendComment.Click();
        }

        private void Comment(ChromeDriver chromeDriver)
        {
            if (_customComment_random)
            {
                CommentFollowEmojiContent(chromeDriver);
            }
            else if (_customComment_condition)
            {
                CommentFollowEmojiContent(chromeDriver);
            }
            else
            {
                CommentFollowEmojiContent(chromeDriver);
            }

        }

        public void CommentFollowEmojiContent(ChromeDriver chromeDriver)
        {
            if (_isRandomEmoji_contentComment)
            {
                Comment_RandomEmoji(chromeDriver);
            }
            else
            {
                Comment_FollowContent(chromeDriver);
            }
        }

        private void NextVideo(ChromeDriver chromeDriver)
        {
            var btnNextVideo = chromeDriver.FindElement(By.CssSelector(_btnNextVideoCssSelector));
            btnNextVideo.Click();
        }

        private void Login(ChromeDriver chromeDriver)
        {
            chromeDriver.SwitchTo().Window(chromeDriver.WindowHandles[1]);

            Thread.Sleep(5000);

            //login with facebook
            //type username
            var usernameElement = chromeDriver.FindElement(By.XPath($"//*[@id=\"email\"]"));
            usernameElement.Click();
            usernameElement.SendKeys(_email);
            //type password
            var passwordElement = chromeDriver.FindElement(By.XPath($"//*[@id=\"pass\"]"));
            passwordElement.Click();
            passwordElement.SendKeys(_password);
        }

        private void CloseWebDriver(ChromeDriver chromeDriver)
        {
            chromeDriver.Close();
            chromeDriver.Quit();
        }

        #endregion

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            _action = cbAction.Text.ToString();
        }
    }
}
