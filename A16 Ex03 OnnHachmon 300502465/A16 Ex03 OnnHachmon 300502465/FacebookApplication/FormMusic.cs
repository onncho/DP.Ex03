﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using YouTubeSearch;

namespace FacebookApplication
{
    public partial class FormMusic : Form
    {
        private User m_LoggedUser;
        private bool v_FormOpen;
        private YouTubeProxy m_YouTubeProxy;
        private YouTubeVideo m_CurrentVideo;
        private Page m_CurrentPage;
        private IEnumerable m_PagesCollection;
        private IDecoratedButton m_YoutubeButton;
        private IDecoratedButton m_FacbookPageButton;
        private IDecoratedButton m_ChromeButton;

        /// <param name="i_LoggedUser"> get user object from the main form</param>
        public FormMusic(User i_LoggedUser)
        {
            InitializeComponent();
            v_FormOpen = true;

            if (i_LoggedUser != null)
            {
                m_LoggedUser = i_LoggedUser;
                m_YouTubeProxy = new YouTubeProxy();
                initMusicForm();
            }
        }

        public User LoggedUser
        {
            get
            {
                return m_LoggedUser;
            }

            set
            {
                m_LoggedUser = value;
            }
        }

        // load the user profile picture and init welcome message
        private void initMusicForm()
        {
            // Startegy - implemenet using lambda expression
            m_PagesCollection = new PagesCollectionIterator(m_LoggedUser, "Musician/Band");

            profileName.Text = string.Format("Hello {0}", m_LoggedUser.Name);

            if (!string.IsNullOrEmpty(m_LoggedUser.PictureNormalURL))
            {
                profileImage.LoadAsync(m_LoggedUser.PictureNormalURL);
            }

            pageBindingSource.DataSource = m_PagesCollection;
        }
            
        private void buttonYouTubeChannel_Click(object sender, EventArgs e)
        {
            if (m_CurrentVideo == null)
            {
                MessageBox.Show("Please Choose a Musician Page First");
            }
            else
            {
                Process.Start(m_CurrentVideo.YouTubeChannelUrl);
            }
        }

        private void buttonPlayVideoOnYouTube_Click(object sender, EventArgs e)
        {
            if (m_CurrentVideo.VideoUrl == null)
            {
                MessageBox.Show("Please Choose a Video From the List");
            }
            else
            {
                Process.Start(m_CurrentVideo.VideoUrl);
            }
        }

        private void buttonLinkToPage_Click(object sender, EventArgs e)
        {
            if (m_CurrentPage == null)
            {
                MessageBox.Show("Please Choose a Music Page From The List");
            }
            else
            {
                Process.Start(m_CurrentPage.URL);
            }
        }

        private void MusicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            v_FormOpen = false;
            pageBindingSource.Dispose();
            youTubeProxyVideoListBindingSource.Dispose();
        }

        private void youTubeProxyVideoListBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ListBoxMusicans.Enabled = false;
            m_CurrentVideo = youTubeProxyVideoListBindingSource.Current as YouTubeVideo;
            ShockwaveFlashPlayerBox.Movie = m_CurrentVideo.VideoLinkForPlayer;
            ListBoxMusicans.Enabled = true;
        }

        private void pageBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            m_CurrentPage = pageBindingSource.Current as Page;

            if (v_FormOpen)
            {
                m_YouTubeProxy.Musician = m_CurrentPage.Name;
                youTubeProxyVideoListBindingSource.DataSource = m_YouTubeProxy.YouTubeVideoList;
            }
        }

        private void FormMusic_Load(object sender, EventArgs e)
        {
            // Decorator
            m_YoutubeButton = new DecoratorText(new DecoratorSetBackground(new DecoratorFont(new CoreButton(buttonYouTubeChannel)), Color.Crimson), "YouTube Channel");
            buttonYouTubeChannel.Visible = false;
            m_YoutubeButton.Execute();

            // Decorator
            m_FacbookPageButton = new DecoratorText(new DecoratorSetBackground(new DecoratorFont(new CoreButton(buttonLinkToPage)), Color.FromArgb(((int)(((byte)59))), ((int)((byte)89)), ((int)((byte)152)))), "Facebook Page");
            buttonLinkToPage.Visible = false;
            m_FacbookPageButton.Execute();

            // Decorator
            m_ChromeButton = new DecoratorText(new DecoratorSetBackground(new DecoratorFont(new CoreButton(buttonPlayVideoOnYouTube)), Color.FromArgb(((int)((byte)252)), ((int)((byte)183)), ((int)((byte)0)))), "Play on Browser");
            buttonPlayVideoOnYouTube.Visible = false;
            m_ChromeButton.Execute();
        }
    }
}