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
            HtmlElement cduSections = document.CreateElement("DIV");
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
            HtmlElement delButton = document.CreateElement("BUTTON");
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
                        sg.SetStyle("background-color", "white");
            sg.SetStyle("color", "black");
            container.Style = sg.GetStyleString();
            sg.Clear();

            // CDU display (execute, clear, refresh buttons, scratchpad, and data).
            cduDisplayWrapper.SetAttribute("id", "737-cdu-display");
            cduDisplayWrapper.SetAttribute("name", "737-cdu-display");
            cduDisplayWrapper.SetAttribute("aria-label", "CDU display");
                                                sg.SetStyle("height", "100vh");
            sg.SetStyle("width", "100%");
            sg.SetStyle("padding", "5px");
            sg.SetStyle("margin-bottom", "10px");
            sg.SetStyle("border", "1px solid red");
                                    cduDisplayWrapper.Style = sg.GetStyleString();
            sg.Clear();

            // CDU sections (navigation pane).
            cduSections.SetAttribute("id", "cdu-sections");
            cduSections.SetAttribute("name", "cdu-sections");
            cduSections.SetAttribute("aria-label", "CDU sections");
            cduSections.SetAttribute("tabindex", "-1");
            cduSections.SetAttribute("role", "toolbar");
            cduSections.SetAttribute("aria-controls", "737-cdu-display");
            sg.SetStyle("overflow", "auto");
            sg.SetStyle("text-align", "center");
                        sg.SetStyle("background-color", "lightblue");
            sg.SetStyle("border", "1px solid blue");
            sg.SetStyle("padding", "5px");
                                    sg.SetStyle("width", "100%");
            sg.SetStyle("bottom", "0px");
            sg.SetStyle("position", "fixed");
                                                cduSections.Style = sg.GetStyleString();
            sg.Clear();

            // INIT-REF button.
            initRefButton.SetAttribute("accesskey", "i");
            initRefButton.SetAttribute("tabindex", "0");
            initRefButton.InnerText = "INIT-REF";
                        initRefButton.SetAttribute("aria-label", "Initial reference");
            initRefButton.SetAttribute("id", "init-ref-button");
            initRefButton.SetAttribute("aria-pressed", "false");
            sg.SetStyle("font-weight", "bold");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            sg.SetStyle("display", "inline-block");
            initRefButton.Style = sg.GetStyleString();
            sg.Clear();

            // The rte button
            rteButton.SetAttribute("id", "rte-button");
            rteButton.SetAttribute("name", "rte-button");
            rteButton.SetAttribute("tabindex", "-1");
            rteButton.SetAttribute("aria-pressed", "false");
            rteButton.SetAttribute("aria-label", "Route");
            rteButton.SetAttribute("accesskey", "t");
            rteButton.InnerText = "RTE";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            rteButton.Style = sg.GetStyleString();
            sg.Clear();

            // The clb button.
            clbButton.SetAttribute("id", "clb-button");
            clbButton.SetAttribute("name", "clb-button");
            clbButton.SetAttribute("accesskey", "c");
            clbButton.SetAttribute("tabindex", "-1");
            clbButton.SetAttribute("aria-pressed", "false");
            clbButton.SetAttribute("aria-label", "Climb");
            clbButton.InnerText = "CLB";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            clbButton.Style = sg.GetStyleString();
            sg.Clear();

            // The CRZ button.
            crzButton.SetAttribute("id", "crz-button");
            crzButton.SetAttribute("name", "crz-button");
            crzButton.SetAttribute("accesskey", "z");
            crzButton.SetAttribute("tabindex", "-1");
            crzButton.SetAttribute("aria-pressed", "false");
            crzButton.SetAttribute("aria-label", "cruise");
            crzButton.InnerText = "CRZ";
            //sg.SetStyle("float", "left");
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            sg.SetStyle("margin", "2.5px");
            crzButton.Style = sg.GetStyleString();
            sg.Clear();

            // The DES button
            desButton.SetAttribute("id", "des-button");
            desButton.SetAttribute("name", "des-button");
            desButton.SetAttribute("accesskey", "d");
            desButton.SetAttribute("tabindex", "-1");
            desButton.SetAttribute("aria-pressed", "false");
            desButton.SetAttribute("aria-label", "descent");
            desButton.InnerText = "DES";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            desButton.Style = sg.GetStyleString();
            sg.Clear();

            // The legs button.
            legsButton.SetAttribute("id", "legs-button");
            legsButton.SetAttribute("name", "legs-button");
            legsButton.SetAttribute("accesskey", "g");
            legsButton.SetAttribute("tabindex", "-1");
            legsButton.SetAttribute("aria-pressed", "false");
            legsButton.SetAttribute("aria-label", "legs");
            legsButton.InnerText = "LEGS";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            legsButton.Style = sg.GetStyleString();
            sg.Clear();

            // The dep-arr button.
            depArrButton.SetAttribute("id", "dep-arr-button");
            depArrButton.SetAttribute("name", "dep-arr-button");
            depArrButton.SetAttribute("accesskey", "a");
            depArrButton.SetAttribute("tabindex", "-1");
            depArrButton.SetAttribute("aria-pressed", "false");
            depArrButton.SetAttribute("aria-label", "departure/arrival");
            depArrButton.InnerText = "DEP-ARR";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            depArrButton.Style = sg.GetStyleString();
            sg.Clear();

            // The hold button.
            holdButton.SetAttribute("id", "hold-button");
            holdButton.SetAttribute("name", "hold-button");
            holdButton.SetAttribute("accesskey", "h");
            holdButton.SetAttribute("tabindex", "-1");
            holdButton.SetAttribute("aria-pressed", "false");
            holdButton.SetAttribute("aria-label", "hold");
            holdButton.InnerText = "HOLD";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            holdButton.Style = sg.GetStyleString();
            sg.Clear();

            // The prog button.
            progButton.SetAttribute("id", "prog-button");
            progButton.SetAttribute("name", "prog-button");
            progButton.SetAttribute("accesskey", "p");
            progButton.SetAttribute("tabindex", "-1");
            progButton.SetAttribute("aria-pressed", "false");
            progButton.SetAttribute("aria-label", "progress");
            progButton.InnerText = "PROG";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            progButton.Style = sg.GetStyleString();
            sg.Clear();

            // The N1 button.
            n1Button.SetAttribute("id", "n1-button");
            n1Button.SetAttribute("name", "n1-button");
            n1Button.SetAttribute("accesskey", "n");
            n1Button.SetAttribute("tabindex", "-1");
            n1Button.SetAttribute("aria-pressed", "false");
            n1Button.SetAttribute("aria-label", "n1 limit");
            n1Button.InnerText = "N1";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
                        n1Button.Style = sg.GetStyleString();
            sg.Clear();

            // The fix button.
            fixButton.SetAttribute("id", "fix-button");
            fixButton.SetAttribute("name", "fix-button");
            fixButton.SetAttribute("accesskey", "f");
            fixButton.SetAttribute("tabindex", "-1");
            fixButton.SetAttribute("aria-pressed", "false");
            fixButton.SetAttribute("aria-label", "fix");
            fixButton.InnerText = "FIX";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            fixButton.Style = sg.GetStyleString();
            sg.Clear();

            // The exec button.
            execButton.SetAttribute("id", "exec-button");
            execButton.SetAttribute("name", "exec-button");
            execButton.SetAttribute("accesskey", "e");
            execButton.SetAttribute("tabindex", "-1");
            execButton.SetAttribute("aria-label", "execute button");
            execButton.InnerText = "EXEC";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            execButton.Style = sg.GetStyleString();
            sg.Clear();

            // The menu button.
            menuButton.SetAttribute("id", "menu-button");
            menuButton.SetAttribute("name", "menu-button");
            menuButton.SetAttribute("accesskey", "m");
            menuButton.SetAttribute("tabindex", "-1");
            menuButton.SetAttribute("aria-label", "menu");
            menuButton.InnerText = "MENU";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            menuButton.Style = sg.GetStyleString();
            sg.Clear();

            // The previous page button.
            prevButton.SetAttribute("id", "prev-button");
            prevButton.SetAttribute("name", "prev-button");
            prevButton.SetAttribute("tabindex", "-1");
            prevButton.SetAttribute("aria-label", "previous page");
            prevButton.InnerText = "PREV";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            prevButton.Style = sg.GetStyleString();
            sg.Clear();

            // The next button.
            nextButton.SetAttribute("id", "next-button");
            nextButton.SetAttribute("name", "next-button");
            nextButton.SetAttribute("tabindex", "-1");
            nextButton.SetAttribute("aria-label", "next page");
            nextButton.InnerText = "NEXT";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            nextButton.Style = sg.GetStyleString();
            sg.Clear();

            // The delete button.
            delButton.SetAttribute("id", "del-button");
            delButton.SetAttribute("name", "del-button");
            delButton.SetAttribute("accesskey", "x");
            delButton.SetAttribute("tabindex", "-1");
            delButton.SetAttribute("aria-label", "delete");
            delButton.InnerText = "DEL";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            delButton.Style = sg.GetStyleString();
            sg.Clear();

            // The clear button.
            clearButton.SetAttribute("id", "clear-button");
            clearButton.SetAttribute("name", "clear-button");
            clearButton.SetAttribute("accesskey", "c");
            clearButton.SetAttribute("tabindex", "-1");
            clearButton.SetAttribute("aria-label", "clear scratchpad");
            clearButton.InnerText = "CLEAR";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
            clearButton.Style = sg.GetStyleString();
            sg.Clear();

            // The refresh button.
            refreshButton.SetAttribute("id", "refresh-button");
            refreshButton.SetAttribute("name", "refresh-button");
            refreshButton.SetAttribute("accesskey", "r");
            refreshButton.SetAttribute("tabindex", "-1");
            refreshButton.SetAttribute("aria-label", "refresh display");
            refreshButton.InnerText = "REFRESH";
            sg.SetStyle("font-weight", "bold");
            sg.SetStyle("display", "inline-block");
            //sg.SetStyle("float", "left");
            sg.SetStyle("margin", "2.5px");
                        refreshButton.Style = sg.GetStyleString();
            sg.Clear();


                                    // Add everything to the page.
            document.Body.AppendChild(container);
            container.AppendChild(cduDisplayWrapper);
            container.AppendChild(cduSections);
            cduSections.AppendChild(initRefButton);
            cduSections.AppendChild(rteButton);
            cduSections.AppendChild(clbButton);
            cduSections.AppendChild(crzButton);
            cduSections.AppendChild(desButton);
            cduSections.AppendChild(legsButton);
            cduSections.AppendChild(depArrButton);
            cduSections.AppendChild(holdButton);
            cduSections.AppendChild(progButton);
            cduSections.AppendChild(n1Button);
            cduSections.AppendChild(fixButton);
            cduSections.AppendChild(execButton);
            cduSections.AppendChild(menuButton);
            cduSections.AppendChild(prevButton);
            cduSections.AppendChild(nextButton);
            cduSections.AppendChild(delButton);
            cduSections.AppendChild(clearButton);
            cduSections.AppendChild(refreshButton);

            RefreshCDU();
                    }

        private void frmPMDGCDU_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("about:blank", false);        }
    }
}
