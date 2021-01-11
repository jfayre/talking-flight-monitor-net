using DavyKager;
using FSUIPC;
using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfm
{
            public partial class frmPMDGCDU : Form
    {
        private uint left_click = 0x20000000; // left click signal.
        private uint right_click = 0x80000000; // Right click signal.
        PMDG_NGX_CDU_Screen CDU_Screen; // The FMC display.
        HtmlDocument document; // HTML for the CDU display.
        StyleGenerator sg = null;

                public frmPMDGCDU()
        {
            InitializeComponent();
            CDU_Screen = new PMDG_NGX_CDU_Screen(0x5400);

                    }

        private void RefreshCDU()
        {
                    }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = (WebBrowser)sender;
            sg = new StyleGenerator();
            
            // Create the controls that will never refresh.
            document = browser.Document;
            HtmlElement container = document.CreateElement("SECTION");
            HtmlElement cduDisplayWrapper = document.CreateElement("MAIN");
            HtmlElement cduSections = document.CreateElement("NAV");
            HtmlElement initRefButton = document.CreateElement("BUTTON");
            HtmlElement rteButton = document.CreateElement("BUTTON");
            HtmlElement clbButton = document.CreateElement("BUTTON");
            HtmlElement crzButton = document.CreateElement("BUTTON");
            HtmlElement desButton = document.CreateElement("BUTTON");
            HtmlElement menuButton = document.CreateElement("BUTTON");
            HtmlElement legsButton = document.CreateElement("BUTTON");
            HtmlElement depArrButton = document.CreateElement("BUTTON");
            HtmlElement holdButton = document.CreateElement("BUTTON");
            HtmlElement progButton = document.CreateElement("BUTTON");
            HtmlElement execButton = document.CreateElement("BUTTON");
            HtmlElement n1Button = document.CreateElement("BUTTON");
            HtmlElement fixButton = document.CreateElement("BUTTON");
            HtmlElement prevButton = document.CreateElement("BUTTON");
            HtmlElement nextButton = document.CreateElement("BUTTON");
            HtmlElement clearButton = document.CreateElement("BUTTON");
            HtmlElement refreshButton = document.CreateElement("BUTTON");
            HtmlElement scratchPadInput = document.CreateElement("INPUT");
                        HtmlElement cduDisplay = document.CreateElement("TABLE");

            // Set styles and attributes for the fixed portion of the FMC.
            // The container for the FMC.
            container.SetAttribute("id", "737-cdu");
            container.SetAttribute("role", "document");
            container.SetAttribute("name", "737-cdu");
            container.SetAttribute("aria-label", "737-cdu");
            sg.SetStyle("font-family", "Times New Roman");
            sg.SetStyle("font-size", "14pt");
            sg.SetStyle("margin", "10px");
            sg.SetStyle("padding", "10px");
            sg.SetStyle("background-color", "white");
            sg.SetStyle("color", "black");
            sg.SetStyle("position", "relative");
            container.Style = sg.GetStyleString();
            sg.Clear();

            // CDU display (execute, clear, refresh buttons, scratchpad, and data).
            cduDisplayWrapper.SetAttribute("id", "737-cdu-display");
            cduDisplayWrapper.SetAttribute("name", "737-cdu-display");
            cduDisplayWrapper.SetAttribute("aria-label", "CDU display");
            sg.SetStyle("float", "right");
            cduDisplayWrapper.Style = sg.GetStyleString();

            
                        // Add everything to the page.
            document.Body.AppendChild(container);
            container.AppendChild(cduDisplayWrapper);
            RefreshCDU();

        }

        private void frmPMDGCDU_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("about:blank", false);        }
    }
}
