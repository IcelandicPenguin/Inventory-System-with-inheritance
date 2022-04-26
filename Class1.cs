using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Parent_Items
    {
        public double Crystal;
        public double Apollo;
        public double Azacca;
        public double Calypso;
        public double El_Dorado;
        public double Lemon_Drop;

        public double Clover;
        public double Acacia;
        public double Hibiscus;
        public double Fire_Weed;
        public double Buck_Wheat;
        public double Orange_Blossom;

        public double OneGal_Carboy;
        public double fiveGal_Carboy;
        public double Siphone_Cane;
        public double Air_Lock;
        public double Cleaning_Solution;
        public double Potasium_Sulfate;

        public double itemcost1;
        public double itemcost2;
        public double itemcost3;
        public double itemcost;

        public double pCrystal = 3.50;
        public double pApollo = 4.66;
        public double pAzacca = 10.22;
        public double pCalypso = 3.50;
        public double pEl_Dorado = 8.49;
        public double pLemon_Drop = 9.99;

        public double pClover = 29.99;
        public double pAcacia = 30.50;
        public double pHibiscus = 15.99;
        public double pFire_Weed = 18.75;
        public double pBuck_Wheat = 35.50;
        public double pOrange_Blossom = 20.99;

        public double pOneGal_Carboy = 10.99;
        public double pfiveGal_Carboy = 16.20;
        public double pSiphon_Cane = 5.99;
        public double pAir_Lock = 1.99;
        public double PCleaning_Solution = 2.50;
        public double pPotasium_Sulfate = 2.50;
        public double Taxcost;

        public double GetAmount()
        {
            itemcost1 = Crystal + Apollo + Azacca + Calypso + El_Dorado + Lemon_Drop;
            itemcost2 = Clover + Acacia + Hibiscus + Fire_Weed + Buck_Wheat + Orange_Blossom;
            itemcost3 = OneGal_Carboy + fiveGal_Carboy + Siphone_Cane + Air_Lock + Cleaning_Solution + Potasium_Sulfate;

            itemcost = itemcost1 + itemcost2 + itemcost3;
            return (itemcost);
        }

        public double mcTax_Rate = 0.15;

        public double cFindTax(double cAmount)
        {
            double FindTax = (cAmount * mcTax_Rate);
            return FindTax;
        }

        public double GetTax()
        {
            Taxcost = cFindTax(itemcost);
            return (Taxcost);
        }
    }
}
