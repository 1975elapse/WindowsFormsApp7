using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            int[] arrya = new int[] {1,2,3 };

            foreach (var item in arrya)
            {
                Console.WriteLine(item);
                Console.WriteLine(item+2);
            }
        }
    }
}
