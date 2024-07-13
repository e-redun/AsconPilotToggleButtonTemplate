using Ascon.Pilot.SDK;
using Ascon.Pilot.SDK.Menu;
using System.ComponentModel.Composition;
using System.Windows;
using ToggleButtonTemplate.Views;

namespace ToggleButtonTemplate
{
    [Export(typeof(IMenu<MainViewContext>))]
    public class MainMenuPlugin : IMenu<MainViewContext>
    {
        private const string TEST_MENU_ITEM = "ToggleButtonTemplateItem";
        private const string TEST_MENU_ITEM_HEADER = "ToggleButtonTemplate";

        public void Build(IMenuBuilder builder, MainViewContext context)
        {
            builder.AddItem(TEST_MENU_ITEM, builder.Count).WithHeader(TEST_MENU_ITEM_HEADER);
        }

        public void OnMenuItemClick(string name, MainViewContext context)
        {
            if (name == TEST_MENU_ITEM)
            {
                var toggleView = new ToggleView();

                toggleView.ShowDialog();
                //MessageBox.Show("name == TEST_MENU_ITEM");
            }
        }
    }
}