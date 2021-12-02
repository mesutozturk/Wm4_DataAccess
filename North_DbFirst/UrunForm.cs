using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using North_DbFirst.Models;

namespace North_DbFirst
{
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        private NorthwindContext _dbContext = new NorthwindContext();
        private void UrunForm_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            lstProducts.DataSource = _dbContext.Products
                .Include(x => x.Category)
                .Include(x => x.Supplier)
                .ToList();
            //lstProducts.DisplayMember = "ProductName";

            cmbCategory.DataSource = _dbContext.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            cmbSupplier.DataSource = _dbContext.Suppliers.ToList();
            cmbSupplier.DisplayMember = "CompanyName";
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem == null) return;
            _selectedProduct = (Product)lstProducts.SelectedItem;

            txtProductName.Text = _selectedProduct.ProductName;
            nUnitPrice.Value = _selectedProduct.UnitPrice.GetValueOrDefault();
            cbDiscontinued.Checked = _selectedProduct.Discontinued;

            cmbCategory.SelectedItem = _selectedProduct.Category;
            cmbSupplier.SelectedItem = _selectedProduct.Supplier;
        }

        private Product _selectedProduct;
        private Category _selectedCategory;
        private Supplier _selectedSupplier;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem != null)
                _selectedCategory = (Category)cmbCategory.SelectedItem;
            else
                _selectedCategory = null;
            if (cmbSupplier.SelectedItem != null)
                _selectedSupplier = cmbSupplier.SelectedItem as Supplier;
            else
                _selectedSupplier = null;

            var yeni = new Product()
            {
                UnitPrice = nUnitPrice.Value,
                ProductName = txtProductName.Text,
                Discontinued = cbDiscontinued.Checked,
                CategoryId = _selectedCategory == null ? null : _selectedCategory.CategoryId,
                SupplierId = _selectedSupplier?.SupplierId //üsttekinin kısayol yazım şekli ?. operatörü
            };

            try
            {
                _dbContext.Products.Add(yeni);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new NorthwindContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var product = _dbContext.Products
                .Include(x => x.OrderDetails)
                .FirstOrDefault(x => x.ProductId == _selectedProduct.ProductId);

            if (product == null) return;

            if (product.OrderDetails.Any())
            {
                MessageBox.Show($"{product.ProductName} isimli ürün siparişlerde kullanıldığından silemezsiniz.");
                return;
            }
            var dialogResult = MessageBox.Show($"{product.ProductName} isimli ürünü silmek istiyor musunuz?", "Ürün silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    _dbContext.Products.Remove(product);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _dbContext = new NorthwindContext();
                }
                finally
                {
                    ListeyiDoldur();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null) return;

            if (cmbCategory.SelectedItem != null)
                _selectedCategory = (Category)cmbCategory.SelectedItem;
            else
                _selectedCategory = null;
            if (cmbSupplier.SelectedItem != null)
                _selectedSupplier = cmbSupplier.SelectedItem as Supplier;
            else
                _selectedSupplier = null;

            try
            {
                var product = _dbContext.Products.First(x => x.ProductId == _selectedProduct.ProductId);
                product.ProductName = txtProductName.Text;
                product.UnitPrice = nUnitPrice.Value;
                product.Discontinued = cbDiscontinued.Checked;
                product.SupplierId = _selectedSupplier?.SupplierId;
                product.CategoryId = _selectedCategory?.CategoryId;

                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new NorthwindContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }
    }
}
