using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApplication
{
    public partial class LikeAnalyzerForm : Form
    {
        private const string k_FormHeader = "Like Analyzer";
        private LikeAnalyzer m_LikeAnalyzer;
        private User m_LoggedUser;
        private AnalysisProgressBar m_ProgressBarForm;

        public LikeAnalyzerForm(User i_LoggedUser)
        {
            InitializeComponent();
            this.Text = k_FormHeader;

            if (i_LoggedUser != null)
            {
                m_LoggedUser = i_LoggedUser;
                initUiLikeAnaylzer();
            }
        }

        public void initUiLikeAnaylzer()
        {
            if (!string.IsNullOrEmpty(m_LoggedUser.Cover.SourceURL))
            {
                pictureBoxCoverPhoto.LoadAsync(m_LoggedUser.Cover.SourceURL);
            }

            if (!string.IsNullOrEmpty(m_LoggedUser.Name))
            {
                this.Text = string.Format("{0} - {1}", k_FormHeader, m_LoggedUser.Name);
            }

            if (!string.IsNullOrEmpty(m_LoggedUser.PictureLargeURL))
            {
                pictureBoxProfilePic.LoadAsync(m_LoggedUser.PictureLargeURL);
            }

            textBoxAmountOfPosts.Text = m_LoggedUser.Posts.Count.ToString();
        }

        private void button_RunAnalysis_Click(object sender, EventArgs e)
        {
            runLikeAnalysis();
        }  

        private void initProgressBar(int i_NumOfPosts)
        {
            m_ProgressBarForm = new AnalysisProgressBar(i_NumOfPosts, m_LikeAnalyzer);
            m_ProgressBarForm.Show();
        }

        private void runLikeAnalysis()
        {          
            if (m_LoggedUser != null)
            {
                int numOfPosts;
                if (m_LikeAnalyzer == null)
                {
                    m_LikeAnalyzer = new LikeAnalyzer(m_LoggedUser);
                }

                if (int.TryParse(textBoxAmountPostsToParse.Text, out numOfPosts))
                {
                    // see if there are any posts to parse
                    if (numOfPosts > m_LoggedUser.Posts.Count || numOfPosts < 1)
                    {
                        MessageBox.Show(string.Format("The max value is {0}, min value is 0", m_LoggedUser.Posts.Count));
                    }
                    else
                    {
                        initProgressBar(numOfPosts);
                        buttonRunAnalysis.Enabled = false;
                        Thread runAnalysisThread = new Thread(new ThreadStart(() =>
                            {
                                this.Invoke(new Action(() => buttonRunAnalysis.Enabled = false));
                                m_LikeAnalyzer.CalculateLikeToList(numOfPosts);
                                this.Invoke(new Action(() =>
                                    {
                                        userAdapterBindingSource.DataSource = m_LikeAnalyzer.DescendingListOfLikes;
                                        buttonRunAnalysis.Enabled = true;
                                    }));
                            }));
                        runAnalysisThread.IsBackground = true;
                        runAnalysisThread.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }

        private void buttonLikeBack_Click(object sender, EventArgs e)
        {
            likeBackUserChosenPost();
        }

        private void likeBackUserChosenPost()
        {
            if (m_LoggedUser != null)
            {
                if (listBoxRecentPost.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Please select a post to like back");
                }
                else
                {
                    foreach (object postToLike in listBoxRecentPost.SelectedItems)
                    {
                        Post chosenPost = postToLike as Post;
                        if (chosenPost != null)
                        {
                            Thread likeBackThread = new Thread(() =>
                            {
                                chosenPost.Like();
                                MessageBox.Show(string.Format("You liked back!"));
                            });
                            likeBackThread.IsBackground = true;
                            likeBackThread.Start();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }
    }
}
