using System;
using System.Windows.Forms;

namespace NewsParser
{
    public partial class WikiInternalLinkCategory : Form
    {
        public WikiInternalLinkCategory()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        /*
          * Ask the user of article category
          * Return to articleparser
          * */
        public string getCategory()
        {
            return textCategory.Text;
        }

        /*
          * Catch if Escape or Enter have been pressed
          * Close accordingly
          * */
        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
