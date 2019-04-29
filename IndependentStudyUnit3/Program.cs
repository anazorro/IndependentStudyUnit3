using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndependentStudyUnit3
{
    /// <summary>
    /// Author: 21903356
    /// 
    /// This class will run the Part B windows forms (weeks 5 to 8)
    /// for the module CO453 Application Programming
    /// </summary>
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyPadScrollbar());
        }
    }
}
