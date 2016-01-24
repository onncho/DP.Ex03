using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApplication
{
    public interface IDecoratedButton
    {
        void Execute();
    }

    public class CoreButton : IDecoratedButton
    {
        public Button m_Button;

        public CoreButton(Button i_Button)
        {
            m_Button = i_Button;
        }


        public void Execute()
        {
            m_Button.Show();
            m_Button.Visible = true;
            m_Button.Enabled = true;
        }

    }

    public class DecoratedButton : IDecoratedButton
    {
        protected IDecoratedButton m_DecoratedButton;
        public Button Decorated;

        public DecoratedButton(IDecoratedButton i_Button)
        {
            if (i_Button is CoreButton)
            {
                Decorated = (i_Button as CoreButton).m_Button;
            }
            else
            {
                Decorated = (i_Button as DecoratedButton).Decorated;
            }

            m_DecoratedButton = i_Button;
            Decorated.Visible = true;
            Decorated.Enabled = true;

            
        }
        
        public virtual void Execute()
        {
            m_DecoratedButton.Execute();
        }
    }

    public class DecoratorRedBackground : DecoratedButton
    {
        Color m_Color;
        public DecoratorRedBackground (IDecoratedButton i_DecoratedButton, Color i_Color) : base(i_DecoratedButton) 
        {
            m_Color = i_Color;
        }

        public override void Execute()
        {
            m_DecoratedButton.Execute();
            Decorated.BackColor = m_Color;
        }
    }

    public class DecoratorFont : DecoratedButton
    {
        public DecoratorFont(IDecoratedButton i_DecoratedButton) : base(i_DecoratedButton) { }

        public override void Execute()
        {
            m_DecoratedButton.Execute();
            Decorated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        
    }

    public class DecoratorText : DecoratedButton
    {
        string m_text;
        public DecoratorText(IDecoratedButton i_DecoratedButton, string i_text) : base(i_DecoratedButton) 
        {
            m_text = i_text;
        }

        public override void Execute()
        {
            m_DecoratedButton.Execute();
            Decorated.Text = m_text;
        }
    }


}
