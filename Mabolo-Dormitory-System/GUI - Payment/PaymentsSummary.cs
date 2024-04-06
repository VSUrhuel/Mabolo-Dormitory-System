using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mabolo_Dormitory_System.Classes;

namespace Mabolo_Dormitory_System.GUI___Payment
{
    public partial class PaymentsSummary : Form
    {
        private DatabaseManager db;
        public PaymentsSummary()
        {
            this.db = new DatabaseManager();
            InitializeComponent();
            float total = db.GetSumEvents() + (db.GetSumRegularPayable() * 5);

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
