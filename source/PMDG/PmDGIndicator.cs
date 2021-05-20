using DavyKager;
using FSUIPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfm
{
    class PmDGIndicator
    {

        private Offset<Byte> offset;
                private Byte status;
        private string name;
        private string panel;
        private string panelSection;

        public PmDGIndicator() { }
        public PmDGIndicator(Offset<byte> offset, byte status, string name, string panel, string panelSection)
        {
            this.offset = offset;
            this.name = name;
            this.status = status;
            this.panel = panel;
            this.panelSection = panelSection;
        } // End constructor.

        public byte Status { get => status; set => this.status = value; }
        public string Name { get => name; set => this.name = value; }
        public Offset<byte> Offset { get => offset; set => this.offset = value;  }
        public string Panel { get => panel; set => this.panel = value; }
        public string PanelSection { get => panelSection; set => this.panelSection = value; }
    } // End PmDGIndicator
} // End TFM namespace.
