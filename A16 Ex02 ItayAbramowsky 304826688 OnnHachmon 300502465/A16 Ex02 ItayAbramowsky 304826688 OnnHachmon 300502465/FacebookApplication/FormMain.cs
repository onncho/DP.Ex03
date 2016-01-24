using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections;

namespace FacebookApplication
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "843647649088563";
        private string m_PathOfAppDataFile = string.Format("{0}\\{1}", AppDomain.CurrentDomain.BaseDirectory, "Facebook App Config.txt");
        private User m_LoggedInUser;  
        private ApplicationConfigurationData m_AppConfig;

        IEnumerable m_PagesCollection;

        // added static factory class for the like analyzer form and the music form.
        public FormMain()
        {            
            m_AppConfig = new ApplicationConfigurationData();

            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;

            try
            {
                if (SaveLoadUtil.LoadAppData(m_PathOfAppDataFile, ref m_AppConfig))
                {
                    if (m_AppConfig.RememberMe)
                    {
                        autoLogin();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in loading configuration!");
            }
        }

        private void autoLogin()
        {
            try
            {
                LoginResult resultOfLogin = FacebookService.Connect(m_AppConfig.AccessToken);
                if (resultOfLogin != null)
                {
                    Thread loginAndFillInfo = new Thread(new ThreadStart(new Action(() =>
                    {
                        m_LoggedInUser = resultOfLogin.LoggedInUser;
                        fillUserInformation();
                    })));
                    loginAndFillInfo.IsBackground = true;
                    loginAndFillInfo.Start();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in autoLogin");
            }
        }

        private void loginAndInit()
        {
            // allready logged in
            if (m_LoggedInUser != null)
            {                
                MessageBox.Show(string.Format("Already logged in as {0} {1}", m_LoggedInUser.FirstName, m_LoggedInUser.LastName));
            }
            else
            {
                LoginResult result = FacebookService.Login(
                    k_AppId,
                    "public_profile",
                    "user_education_history",
                    "user_actions.video",
                    "user_actions.news",
                    "user_actions.music",
                    "user_actions.fitness",
                    "user_actions.books",
                    "user_about_me",
                    "user_friends",
                    "publish_actions",
                    "user_events",
                    "user_likes",
                    "user_posts",
                    "user_videos",
                    "user_website",
                    "read_custom_friendlists",
                    "publish_pages",
                    "publish_actions",
                    "rsvp_event");

                if (!string.IsNullOrEmpty(result.AccessToken))
                {
                    m_AppConfig.AccessToken = result.AccessToken;
                    m_LoggedInUser = result.LoggedInUser;
                    fillUserInformation();
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void fillUserInformation()
        {            
            // setting the images profile & cover 
            if (!string.IsNullOrEmpty(m_LoggedInUser.PictureNormalURL))
            {
                pictureProfilePhoto.LoadAsync(m_LoggedInUser.PictureNormalURL);
            }

            if (!string.IsNullOrEmpty(m_LoggedInUser.Cover.SourceURL))
            {
                pictureCoverPhoto.LoadAsync(m_LoggedInUser.Cover.SourceURL);
            }

            Thread threadEventFetch = new Thread(new ThreadStart(fetchEvent));
            threadEventFetch.IsBackground = true;
            threadEventFetch.Start();

            Thread threadSportPage = new Thread(new ThreadStart(fetchSportPages));
            threadSportPage.IsBackground = true;
            threadSportPage.Start();

            Thread threadNewsFeedFetch = new Thread(new ThreadStart(fetchNewsfeed));
            threadNewsFeedFetch.IsBackground = true;
            threadNewsFeedFetch.Start();

            if (!checkBoxRemeberMe.InvokeRequired)
            {
                checkBoxRemeberMe.Checked = m_AppConfig.RememberMe;
            }
            else
            {
                checkBoxRemeberMe.Invoke(new Action(() => checkBoxRemeberMe.Checked = m_AppConfig.RememberMe));
            }
        }


        private void fetchSportPages()
        {
            m_PagesCollection = new PagesCollectionIterator(m_LoggedInUser, "Sports Team");

            if (!listBoxSportsTeams.InvokeRequired)
            {
                pageSportBindingSource.DataSource = m_PagesCollection;
            }
            else
            {
                listBoxSportsTeams.Invoke(new Action(() => pageSportBindingSource.DataSource = m_PagesCollection));
            }
            
        }

        private void fetchEvent()
        {
            var userEvents = m_LoggedInUser.Events;
            if (!listBoxSportsTeams.InvokeRequired)
            {
                pageSportBindingSource.DataSource = userEvents;                
            }
            else
            {
                listBoxSportsTeams.Invoke(new Action(() => pageSportBindingSource.DataSource = userEvents));
            }
        }

        private void fetchNewsfeed()
        {
            var userNewsfeed = m_LoggedInUser.NewsFeed;
            if (!listBoxNewsFeed.InvokeRequired)
            {
                newsFeedBindingSource.DataSource = userNewsfeed;
            }
            else
            {
                listBoxNewsFeed.Invoke(new Action(() => newsFeedBindingSource.DataSource = userNewsfeed));
            }
        }

        private void buttonLikeAnalyzer_Click(object sender, EventArgs e)
        {          
            if (Application.OpenForms.OfType<LikeAnalyzerForm>().Count() > 0)
            {
                MessageBox.Show("Like Analyzer is already open!");
            }
            else
            {
                FormFacebookFactory.CreateFacebookForm(typeof(LikeAnalyzerForm), m_LoggedInUser).Show();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {
                SaveLoadUtil.SaveAppData(m_PathOfAppDataFile, m_AppConfig);
            }
            catch (Exception)
            {
                MessageBox.Show("Error in saving configuration!");
            }

            base.OnClosing(e);
        }

        private void checkBoxRemeberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRemeberMe.Checked)
            {
                m_AppConfig.RememberMe = true;
            }
            else
            {
                m_AppConfig.RememberMe = false;
            }
        }

        private void buttonMusicView_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormMusic>().Count() > 0)
            {
                MessageBox.Show("Music is already open!");
            }
            else
            {
                FormFacebookFactory.CreateFacebookForm(typeof(FormMusic), m_LoggedInUser).Show();
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            postStatus();
        }

        private void postStatus()
        {
            // if user hasnt logged in yet
            if (m_LoggedInUser == null)
            {
                MessageBox.Show("Please login first");
            }
            else
            {
                m_LoggedInUser.ReFetch();
                if (string.IsNullOrWhiteSpace(textBoxStatusFromUser.Text))
                {
                    MessageBox.Show("Nothing to post, please enter your status and then click 'Post'");
                }
                else
                {
                    buttonPostStatus.Enabled = false;
                    Thread postActionThread = new Thread(new ThreadStart(() =>
                        {
                            m_LoggedInUser.PostStatus(textBoxStatusFromUser.Text);
                            this.Invoke(new Action(() =>
                                {
                                    textBoxStatusFromUser.Text = string.Empty;
                                    MessageBox.Show("Your status was posted!");
                                    buttonPostStatus.Enabled = true;
                                }));
                        }));
                    postActionThread.IsBackground = true;
                    postActionThread.Start();
                }
            }
        }
    }
}
