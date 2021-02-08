using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfm
{
    public class PMDGPanelUpdateEvent
    {
        public static event EventHandler<PMDGPanelUpdateEventArgs> PMDGPanelUpdate;


        // The virtual method for the event. Used as a shell and fired when needed.
        protected virtual void onPMDGPanelUpdate(PMDGPanelUpdateEventArgs e)
        {

            PMDGPanelUpdate?.Invoke(this, e);
        } // End onPMDGPanelUpdate method.

        public void fireOnPMDGPanelUpdateEvent(string tag)
        {
            PMDGPanelUpdateEventArgs args = new PMDGPanelUpdateEventArgs();
            args.ControlTag = tag;
            this.onPMDGPanelUpdate(args);
        } // End event fire method.


    }
}
