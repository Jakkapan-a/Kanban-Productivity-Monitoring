using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private float fontSizeLbHeader;
        
        private void Main_Load(object sender, EventArgs e)
        {
            this.fontSizeLbHeader = this.lbHeader.Font.Size;
            reSizeAllLabe();
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Closeing : " + this.Size.Width);
            // If size
            if (this.Size.Width > 1024 || this.Size.Height > 768)
            {
                this.lbHeader.Font = new Font(this.lbHeader.Font.FontFamily, this.fontSizeLbHeader +10);
            }
            else
            {
                this.lbHeader.Font = new Font(this.lbHeader.Font.FontFamily, this.fontSizeLbHeader);
            }
            reSizeAllLabe();
        }

        private void reSizeAllLabe()
        {
            int rows = this.tableLayoutPanelRight.RowCount;
            int comlumn = this.tableLayoutPanelRight.ColumnCount;

            int deFaultFontSize = 10;
            int fontReSize = 7;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < comlumn; j++)
                {
                    Control c = this.tableLayoutPanelRight.GetControlFromPosition(j, i);
                    if (c != null)
                    {
                        // Label
                        if (c is Label)
                        {
                            Label lb = (Label)c;
                            if (this.Size.Width > 1024 || this.Size.Height > 768)
                            {
                                lb.Font = new Font(lb.Font.FontFamily, deFaultFontSize + fontReSize);
                            }
                            else
                            {
                                lb.Font = new Font(lb.Font.FontFamily, deFaultFontSize);
                            }
                        }

                        // Textbox
                        if(c is TextBox)
                        {
                            TextBox tb = (TextBox)c;
                            if (this.Size.Width > 1024 || this.Size.Height > 768)
                            {
                                tb.Font = new Font(tb.Font.FontFamily, deFaultFontSize + fontReSize);
                            }
                            else
                            {
                                tb.Font = new Font(tb.Font.FontFamily, 10);
                            }
                        }

                        // ComboBox
                        if (c is ComboBox)
                        {
                            ComboBox cb = (ComboBox)c;
                            if (this.Size.Width > 1024 || this.Size.Height > 768)
                            {
                                cb.Font = new Font(cb.Font.FontFamily, deFaultFontSize + fontReSize);
                            }
                            else
                            {
                                cb.Font = new Font(cb.Font.FontFamily, deFaultFontSize);
                            }
                        }

                        // CheckListBox
                        if (c is CheckedListBox)
                        {
                            CheckedListBox clb = (CheckedListBox)c;
                            if (this.Size.Width > 1024 || this.Size.Height > 768)
                            {
                                clb.Font = new Font(clb.Font.FontFamily, deFaultFontSize + fontReSize);
                            }
                            else
                            {
                                clb.Font = new Font(clb.Font.FontFamily, deFaultFontSize);
                            }
                        }
                    }
                }
            }
        }
    }
}
