using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileNameUpdater.App
{
    public partial class AppForm : Form
    {

        private UpdateEngine engine;

        public AppForm()
        {
            engine = new UpdateEngine();
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            engine.Stop();
            this.Close();
        }
    }
}
