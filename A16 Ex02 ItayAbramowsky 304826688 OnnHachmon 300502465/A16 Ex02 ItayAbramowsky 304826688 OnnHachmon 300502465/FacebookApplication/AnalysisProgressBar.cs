using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApplication
{
    public partial class AnalysisProgressBar : Form
    {
        private int m_NumOfPosts;
        private LikeAnalyzer m_LikeAnalyzer;

        public AnalysisProgressBar(int i_NumOfPosts, LikeAnalyzer i_LikeAnalyzer)
        {
            InitializeComponent();
            m_NumOfPosts = i_NumOfPosts;
            m_LikeAnalyzer = i_LikeAnalyzer;
            m_LikeAnalyzer.ParsedPost += IncrementProgressBar;
            setProgressToStart();          
        }

        public void resetProgress(int i_NumOfPosts)
        {
            m_NumOfPosts = i_NumOfPosts;
            setProgressToStart();
        }

        private void setProgressToStart()
        {                        
            progressBarForLikeAnalysis.Value = 0;
            progressBarForLikeAnalysis.Minimum = 0;
            progressBarForLikeAnalysis.Maximum = m_NumOfPosts;
            progressBarForLikeAnalysis.Step = 1; 
        }

        private void IncrementProgressBar(object sender, EventArgs e)
        {            
                this.Invoke(new Action(() =>
                {
                    progressBarForLikeAnalysis.PerformStep();
                    if (progressBarForLikeAnalysis.Value == progressBarForLikeAnalysis.Maximum)
                    {
                        // remove 'myself' as a listener and close
                        m_LikeAnalyzer.ParsedPost -= IncrementProgressBar;
                        this.Close();
                    }
                }));
        }
    }
}
