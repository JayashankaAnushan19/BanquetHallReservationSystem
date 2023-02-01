using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanquetHallReservationSystem
{
    public partial class ucMain : UserControl
    {
        private static ucMain _instance;
        public static ucMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMain();
                return _instance;
            }

        }
        public ucMain()
        {
            InitializeComponent();
        }
    }
}
