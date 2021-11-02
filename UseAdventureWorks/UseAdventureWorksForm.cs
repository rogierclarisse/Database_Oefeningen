using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseAdventureWorks
{
    public partial class UseAdventureWorksForm : Form
    {
        AdventureWorks2016CTP3Entities db = new AdventureWorks2016CTP3Entities();
        public UseAdventureWorksForm()
        {
            InitializeComponent();
        }

       

        private void countryRegionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.countryRegionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorks2016CTP3DataSet);

        }

        private void countryRegionBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.countryRegionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorks2016CTP3DataSet);

        }

        private void UseAdventureWorks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2016CTP3DataSet.CountryRegion' table. You can move, or remove it, as needed.
            this.countryRegionTableAdapter.Fill(this.adventureWorks2016CTP3DataSet.CountryRegion);

        }

       

        private void countryRegionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

            lbMuntEenheid.Items.Clear();

            DataGridView dataSender = (DataGridView)sender;
            string CountryName = (string)dataSender.CurrentCell.Value;
            var getCurrency = db.CountryRegionCurrencies.Join(db.CountryRegions, 
                code => code.CountryRegionCode,
                regionCode => regionCode.CountryRegionCode,
                (code, regionCode) => 
                new { Code = code, CodeName = regionCode.Name, CRC = regionCode.CountryRegionCode })
                .Join(db.Currencies, code => code.Code.CurrencyCode,
                c => c.CurrencyCode,
                (code, c) => new { CCrc = code, CName = c.Name, });

            foreach(var c in getCurrency)
            {
                if(c.CCrc.CodeName.Contains(CountryName) || c.CCrc.CRC.Contains(CountryName))
                {
                    lbMuntEenheid.Items.Add(c.CName);
                }
            }
            if(lbMuntEenheid.Items.Count == 0)
            {
                lbMuntEenheid.Items.Add("no currency available");
            }

        }
    }
}
