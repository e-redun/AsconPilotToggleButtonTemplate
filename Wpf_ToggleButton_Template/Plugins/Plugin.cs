using Ascon.Pilot.SDK;
using Ascon.Pilot.SDK.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_ToggleButton_Template
{

    [Export(typeof(IMenu<ObjectsViewContext>))]
    public class Plugin : IMenu<ObjectsViewContext>
    {
        [ImportingConstructor]
        public Plugin()
        {
            MessageBox.Show("Plugin call");
        }

        public void Build(IMenuBuilder builder, ObjectsViewContext context)
        {
            //MessageBox.Show("Build call");

        }

        public void OnMenuItemClick(string name, ObjectsViewContext context)
        {
            //MessageBox.Show("OnMenuItemClick call");

        }
    }
}