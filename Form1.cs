using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm Exit?", "Homebrew Supply", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ResetTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            Child_Class cost_of_Items = new Child_Class();
            double iTax, iSubTotal, iTotal;

            iTax = cost_of_Items.GetTax();
            iSubTotal = cost_of_Items.GetAmount();
            iTotal = iTax + iSubTotal;

            String Tax = String.Format("{0:C}", iTax);
            txtTax.Text = Tax;

            String Subtotal = String.Format("{0:C}", iSubTotal);
            txtSubtotal.Text = Subtotal;

            String Total = String.Format("{0:C}", iTotal);
            txtTotal.Text = Total;

            String Hops = String.Format("{0:C}", cost_of_Items.itemcost1);
            txtHoney.Text = Hops;

            String Honey = String.Format("{0:C}", cost_of_Items.itemcost2);
            txtHoney.Text = Honey;

            String Brewing = String.Format("{0:C}", cost_of_Items.itemcost3);
            txtBrewing_Supplies.Text = Brewing;

            cost_of_Items.Crystal = cost_of_Items.pCrystal * Double.Parse(txtCrystal.Text);
            cost_of_Items.Apollo = cost_of_Items.pApollo * Double.Parse(txtApollo.Text);
            cost_of_Items.Calypso = cost_of_Items.pCalypso * Double.Parse(txtCalypso.Text);
            cost_of_Items.Azacca = cost_of_Items.pAzacca * Double.Parse(txtAzacca.Text);
            cost_of_Items.El_Dorado = cost_of_Items.pEl_Dorado * Double.Parse(txtEl_Dorado.Text);
            cost_of_Items.Lemon_Drop = cost_of_Items.pLemon_Drop * Double.Parse(txtLemon_Drop.Text);

            cost_of_Items.Clover = cost_of_Items.pClover * Double.Parse(txtClover.Text);
            cost_of_Items.Acacia = cost_of_Items.pAcacia * Double.Parse(txtAcacia.Text);
            cost_of_Items.Hibiscus = cost_of_Items.pHibiscus * Double.Parse(txtHibiscus.Text);
            cost_of_Items.Fire_Weed = cost_of_Items.pFire_Weed * Double.Parse(txtFire_Weed.Text);
            cost_of_Items.Buck_Wheat = cost_of_Items.pBuck_Wheat * Double.Parse(txtBuck_Wheat.Text);
            cost_of_Items.Orange_Blossom = cost_of_Items.pOrange_Blossom * Double.Parse(txtOrange_Blossom.Text);

            cost_of_Items.OneGal_Carboy = cost_of_Items.pOneGal_Carboy * Double.Parse(txtOneGal.Text);
            cost_of_Items.fiveGal_Carboy = cost_of_Items.pfiveGal_Carboy * Double.Parse(txtFiveGal.Text);
            cost_of_Items.Siphone_Cane = cost_of_Items.pSiphon_Cane * Double.Parse(txtSiphon_Cane.Text);
            cost_of_Items.Air_Lock = cost_of_Items.pAir_Lock * Double.Parse(txtAir_Lock.Text);
            cost_of_Items.Cleaning_Solution = cost_of_Items.PCleaning_Solution * Double.Parse(txtClean.Text);
            cost_of_Items.Potasium_Sulfate = cost_of_Items.pPotasium_Sulfate * Double.Parse(txtPotassium.Text);
        }
    } 
    
}
