using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfm
{
    public interface iPanelsPage
    {
        void Hide();
        void Show();
        Control Parent { get; set; }
        void SetDocking();
        string Name { get; set; }
        
    }
}
