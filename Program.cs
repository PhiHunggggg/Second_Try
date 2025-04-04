using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Try
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /**/ while (true)
             {
                 using (loginForm lg = new loginForm())
                 {
                     DialogResult result = lg.ShowDialog();

                     if (result == DialogResult.OK)
                     {
                         using (mainForm mf = new mainForm())
                         {
                             if (mf.ShowDialog() == DialogResult.Cancel)
                             {
                                 continue; 
                             }
                         }
                     }
                     else if (result == DialogResult.Cancel)
                     {
                         break; 
                     }
                 }
             }
        //   Application.Run(new lichfrm());
        }
    }
}
