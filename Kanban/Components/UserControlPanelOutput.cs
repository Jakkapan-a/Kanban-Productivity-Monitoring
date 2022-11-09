using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban.Components
{
    public partial class UserControlPanelOutput : UserControl
    {
        public UserControlPanelOutput()
        {
            InitializeComponent();
        }
        // Set text of lbTitle
        public string lbTitleText
        {
            get { return this.lbTitle.Text; }
            set { this.lbTitle.Text = value; }
        }

        // Set size of.lbTitle
        public Font lbTitleTextFont
        {
            get { return this.lbTitle.Font; }
            set { this.lbTitle.Font = value; }
        }

        // Set color of lbTitle
        public Color lbTitleTextForeColor
        {
            get { return this.lbTitle.ForeColor; }
            set { this.lbTitle.ForeColor = value; }
        }


        // Set text of lbOutput
        public string LbOutputText
        {
            get { return this.lbOutput.Text; }
            set { this.lbOutput.Text = value; }
        }

        // Set font of lbOutput
        public Font LbOutputFontSize
        {
            get { return this.lbOutput.Font; }
            set { this.lbOutput.Font = value; }
        }

        // Set color of lbOutput
        public Color LbOutputForeColor
        {
            get { return this.lbOutput.ForeColor; }
            set { this.lbOutput.ForeColor = value; }
        }


        // Set text of lbFooter
        public string LbFooterText
        {
            get { return this.lbFooter.Text; }
            set { this.lbFooter.Text = value; }
        }

        // Set size of lbFooter
        public Font LbFooterTextFontSize
        {
            get { return this.lbFooter.Font; }
            set { this.lbFooter.Font = value; }
        }

        // Set color of lbFooter
        public Color LbFooterTextForeColor
        {
            get { return this.lbFooter.ForeColor; }
            set { this.lbFooter.ForeColor = value; }
        }
    }
}
