using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ClientWPF.Utilities
{
    public class UserControlSwap
    {
        public static void Add(Grid grid,UserControl user_usercontrol)
        {
            if (grid.Children.Count>0)
            {
                grid.Children.Clear();
                grid.Children.Add(user_usercontrol);
            }
            else
            {
                grid.Children.Add(user_usercontrol);
            }
        }
    }
}
