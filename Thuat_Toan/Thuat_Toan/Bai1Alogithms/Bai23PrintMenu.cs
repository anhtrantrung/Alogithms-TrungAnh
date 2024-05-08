using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuat_Toan.Bai1Alogithms
{
    internal class Bai23PrintMenu
    {
        /// <summary>
        /// Prints the menu structure recursively, including submenus, with an optional prefix for indentation.
        /// </summary>
        /// <param name="menus"></param>
        /// <param name="prefix"></param>
        public void PrintMenu(List<MenuItem> menus, string prefix = "")
        {
            foreach (var menu in menus)
            {
                Console.WriteLine($"{prefix}{menu.Name}");
                PrintMenu(menu.SubMenuItems, prefix + "--");
            }
        }
    }
}
