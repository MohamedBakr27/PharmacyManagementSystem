using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.EmployeeAuth
{
    public partial class ViewMedicine : Form
    {
        public ViewMedicine()
        {
            InitializeComponent();
        }
        public object medicine;
        public void ini()
        {
            Medicine med = (Medicine)medicine;
            medNameTitle.Text = med.GenericName;
            medPriceTitle.Text = med.Price.ToString();
            medQuantityTitle.Text = med.Quantity.ToString();
            medCategoryTitle.Text = med.Category;
            medSupTitle.Text = med.SupName;
            medExpiryDateTitle.Text = med.ExpiryDate.ToShortDateString();
        }
    }
}
