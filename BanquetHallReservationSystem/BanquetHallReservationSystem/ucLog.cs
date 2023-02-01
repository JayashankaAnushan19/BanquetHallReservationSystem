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
    public partial class ucLog : UserControl
    {
        private static ucLog _instance;
        public static ucLog Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLog();
                return _instance;
            }
        }
        public ucLog()
        {
            InitializeComponent();
        }


        // Create link with another form
        private FrmMainWindow mainForm = null;
        public ucLog(Form callingFrom)
        {
            mainForm = callingFrom as FrmMainWindow;
            InitializeComponent();
        }
        // End of the Created link with another form


        private void btnChangePass_Click(object sender, EventArgs e)
        {
/*            //
            try
            {
                //Use link
                this.mainForm.hideLog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }*/
        }
    }
}
