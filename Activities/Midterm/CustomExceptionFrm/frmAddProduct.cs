using CustomExceptionFrm.CustomExceptions;
using System.Text.RegularExpressions;

namespace CustomExceptionFrm {

#pragma warning disable CA1822
#pragma warning disable IDE1006
#pragma warning disable IDE0090
#pragma warning disable SYSLIB1045

    public partial class frmAddProduct : Form {
        private string? _ProductName;
        private string? _Category;
        private string? _MfgDate;
        private string? _ExpDate;
        private string? _Description;

        private int _Quantity;
        private double _SellPrice;

        private readonly BindingSource showProductList;
        private readonly object _lock = new object();

        public frmAddProduct() {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void frmAddProduct_Load(object sender, EventArgs e) {
            string[] ListOfProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jarred Goods", 
                                               "Dairy", "Frozen Goods", "Meat", "Personal Care", 
                                               "Other" };

            foreach (string category in ListOfProductCategory)
                cbCategory.Items.Add(category);

        }

        private void btnAddProduct_Click(object sender, EventArgs e) {
            lock (_lock) {
                try {
                    _ProductName = Product_Name(txtProductName.Text);
                    _Category = cbCategory.Text;
                    _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                    _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                    _Description = richTxtDescription.Text;
                    _Quantity = Quantity(txtQuantity.Text);
                    _SellPrice = SellingPrice(txtSellPrice.Text);

                    showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                                                         _ExpDate, _SellPrice, _Quantity,
                                                         _Description));

                    gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    gridViewProductList.DataSource = showProductList;

                    // Clear controls' values.
                    txtProductName.Clear();
                    cbCategory.SelectedIndex = -1;
                    richTxtDescription.Clear();
                    txtQuantity.Clear();
                    txtSellPrice.Clear();

                } catch (NumberFormatException nfEx) {
                    MessageBox.Show(this, $"Failed to format a number.\n\nCause: {nfEx.Message}",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                } catch (StringFormatException sfEx) {
                    MessageBox.Show(this, $"Failed to format a string.\n\nCause: {sfEx.Message}",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                } catch (CurrencyFormatException cfEx) {
                    MessageBox.Show(this, $"Currency format failed.\n\nCause: {cfEx.Message}",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                } catch (OverflowException oEx) {
                    MessageBox.Show(this, $"Conversion process failed.\n\nCause: {oEx.Message}",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
            }
        }

        public string Product_Name(string name) {
            return !Regex.IsMatch(name, @"^[a-zA-Z]+$") ?
                    throw new StringFormatException("Invalid string format found.") :
                    name;
        }

        public int Quantity(string qty) {
            return !Regex.IsMatch(qty, @"^[0-9]") ?
                    throw new NumberFormatException("Converting invalid string format to an integer is not allowed.") :
                    Convert.ToInt32(qty);
        }
        public double SellingPrice(string price) {
            return !Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$") ?
                    throw new CurrencyFormatException("Converting invalid string format to a price number is not allowed.") :
                    Convert.ToDouble(price);
        }
    }
}