using North_DbFirst.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace North_DbFirst
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }
        NorthwindContext _dbContext = new NorthwindContext();
        private void KategoriForm_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            lstCategory.DataSource = _dbContext.Categories.ToList();
            lstCategory.DisplayMember = "CategoryName";
        }
        Category _selectedCategory;
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategory.SelectedItem == null) return;
            _selectedCategory = (Category)lstCategory.SelectedItem;

            txtCategoryName.Text = _selectedCategory.CategoryName;
            txtDescription.Text = _selectedCategory.Description;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var yeni = new Category
                {
                    CategoryName = txtCategoryName.Text,
                    Description = txtDescription.Text
                };
                _dbContext.Categories.Add(yeni);

                int result = _dbContext.SaveChanges();
                ListeyiDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null) return;
            try
            {
                var category = _dbContext.Categories.Find(_selectedCategory.CategoryId);
                _dbContext.Categories.Remove(category);

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null) return;
            try
            {
                var category = _dbContext.Categories.Find(_selectedCategory.CategoryId);

                category.CategoryName = txtCategoryName.Text;
                category.Description = txtDescription.Text;

                //var entry = _dbContext.Entry(category);

                var updateEntry = _dbContext.Categories.Update(category);

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
