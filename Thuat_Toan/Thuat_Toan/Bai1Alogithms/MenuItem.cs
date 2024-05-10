using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuat_Toan.Bai1Alogithms
{
    public class MenuItem
    {
        public string Name { get; set; }
        public List<MenuItem> SubMenuItems { get; set; }

        /// <summary>
        /// Initializes a new instance of the MenuItem class with the specified name.
        /// </summary>
        /// <param name="name"></param>
        public MenuItem(string name)
        {
            Name = name;
            SubMenuItems = new List<MenuItem>();
        }

        /// <summary>
        /// Adds a submenu item to the current menu item.
        /// </summary>
        /// <param name="menuItem"></param>
        public void AddSubMenu(MenuItem menuItem)
        {
            SubMenuItems.Add(menuItem);
        }
    }
}
