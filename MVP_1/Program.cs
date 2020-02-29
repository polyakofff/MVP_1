using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_1 {
    static class Program {
        /// <summary>
        /// Эх
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            View1 view1 = new View1();
            Presenter presenter = new Presenter(view1);
            Application.Run(view1);
        }
    }
}
