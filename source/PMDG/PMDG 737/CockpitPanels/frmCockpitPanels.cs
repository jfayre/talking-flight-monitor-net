using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfm
{
    public partial class frmCockpitPanels : Form
    {
        private Dictionary<string, iPanelsPage> pages = new Dictionary<string, iPanelsPage>();
        iPanelsPage currentPage = null;

        public frmCockpitPanels()
        {
            InitializeComponent();
            loadPages();
        }

        
        private void loadPages()
        {
            pages.Add("nodElectrical", new ctlElectrical());
            pages.Add("nodFuel", new ctlFuel());
            pages.Add("nodMCP", new ctlMCP());
            pages.Add("nodIRU", new ctlInertialReferenceUnit());
            pages.Add("nodHydraulics", new ctlHydraulics());
            pages.Add("nodEngines", new ctlEngines());      
            pages.Add("nodAirSystems", new ctlAirSystems());
            pages.Add("nodAntiIce", new ctlAntiIce());
            // set the parent and hide them all
            foreach (iPanelsPage page in this.pages.Values)
            {
                page.Parent = this.pnlContent;
                page.SetDocking();
                page.Hide();
            }

        }

        private void tvPanels_AfterSelect(object sender, TreeViewEventArgs e)
        {
                                    if (this.pages.ContainsKey(e.Node.Name))
            {
                if (this.currentPage != null)
                {
                    this.currentPage.Hide();
                }
                this.currentPage = this.pages[e.Node.Name];
                this.currentPage.Show();
            }

        }
    }
}
