using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSnackPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cashbalance = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, chocolate, water, orangejuice, ticket, total;

            
            popcorn = Convert.ToInt16(txtpopcorn.Text);
            chocolate = Convert.ToInt16(txtchocolate.Text);
            water=Convert.ToInt16(txtwater.Text);
            orangejuice = Convert.ToInt16(txtorangejuice.Text);
            ticket=Convert.ToInt16(txtticket.Text);
            
            total = popcorn * 7 
                + chocolate * 5 
                + water * 2 
                + orangejuice * 7
                + ticket * 25;
            lbltotal.Text=total.ToString(); 
            cashbalance = cashbalance + total;
            lblcashbalance.Text=cashbalance.ToString(); 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpopcorn.Text = "";
            txtchocolate.Text = "";
            txtwater.Text = "";
            txtorangejuice.Text = "";
            txtticket.Text = "";
            txtpopcorn.Focus();


        }
    }
}
