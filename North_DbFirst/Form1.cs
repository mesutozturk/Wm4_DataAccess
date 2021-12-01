using North_DbFirst.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using North_DbFirst.ViewModels;

namespace North_DbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NorthwindContext _dContext = new NorthwindContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            var query1 = _dContext.Categories.Select(x => new CategoryViewModel()
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                Picture = x.Picture,
                ProductCount = x.Products.Count
            }).ToList();
            dgvNorth.DataSource = query1;

            var query2 = from cat in _dContext.Categories
                         join prod in _dContext.Products on cat.CategoryId equals prod.CategoryId
                         //where prod.UnitPrice > 20
                         select new
                         {
                             cat.CategoryName,
                             prod.ProductName,
                             prod.UnitPrice
                         };
            dgvNorth.DataSource = query2
                .OrderBy(x => x.CategoryName)
                .ThenByDescending(x => x.UnitPrice)
                .ToList();

            var query3 = _dContext.Products.Select(x => new
            {
                x.Category.CategoryName,
                x.ProductName,
                x.UnitPrice
            }).OrderBy(x => x.CategoryName).ThenByDescending(x => x.UnitPrice).ToList();
            dgvNorth.DataSource = query3;

            var query4 = _dContext.Products
                .Include(x => x.Supplier)
                .Include(x => x.Category)
                .Select(x => new
                {
                    x.ProductName,
                    x.UnitPrice,
                    x.Supplier.CompanyName,
                    x.Category.CategoryName
                }).ToList();

            var query5 = _dContext.Products
                .Include(x => x.Supplier)
                .Include(x => x.Category)
                .Include(x => x.OrderDetails)
                .ThenInclude(x => x.Order)
                .ThenInclude(x => x.ShipViaNavigation);
            //.Select(x => new
            //{
            //    x.ProductName,
            //    x.Category.CategoryName,
            //    x.Supplier.CompanyName,
            //    x.OrderDetails.Count,


            //})
            //.ToList();
            var queryString = query5.ToQueryString();
            var qq = query5.ToList();

            RaporuGoster();

            var query6 = from cat in _dContext.Categories
                         join prod in _dContext.Products on cat.CategoryId equals prod.CategoryId
                         join sup in _dContext.Suppliers on prod.SupplierId equals sup.SupplierId
                         group new
                         {
                             cat,
                             prod,
                             sup
                         } by new
                         {
                             cat.CategoryName,
                             sup.CompanyName
                         } into cats
                         select new
                         {
                             CategoryName = cats.Key.CategoryName,
                             CompanyName = cats.Key.CompanyName,
                             Count = cats.Count()
                         };

            dgvNorth.DataSource = query6
                .OrderBy(x => x.CategoryName)
                .ThenByDescending(x => x.Count)
                .ToList();

            var query7 = from cat in _dContext.Categories
                         join prod in _dContext.Products on cat.CategoryId equals prod.CategoryId
                         join sup in _dContext.Suppliers on prod.SupplierId equals sup.SupplierId
                         group new
                         {
                             cat,
                             prod,
                             sup
                         } by new
                         {
                             cat.CategoryName,
                             sup.CompanyName
                         } into cats
                         select new
                         {
                             CategoryName = cats.Key.CategoryName,
                             CompanyName = cats.Key.CompanyName,
                             Cost = cats.Sum(x => x.prod.UnitPrice * x.prod.UnitsInStock)
                         };
            dgvNorth.DataSource = query7
                .OrderBy(x => x.CategoryName)
                .ThenByDescending(x => x.Cost)
                .ToList();

            var query8 = _dContext.Products
                .Include(x => x.Category)
                .Include(x => x.Supplier)
                .GroupBy(x => new { x.Category.CategoryName, x.Supplier.CompanyName })
                .Select(x => new
                {
                    x.Key.CategoryName,
                    x.Key.CompanyName,
                    Cost = x.Sum(p => p.UnitsInStock * p.UnitPrice)
                });

            dgvNorth.DataSource = query8
                .OrderBy(x => x.CategoryName)
                .ThenByDescending(x => x.Cost)
                .ToList();

            Console.WriteLine();
        }

        private int _offset = 0, _pageSize = 10, _maxPage = 0;

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (_offset + 1 == _maxPage) return;
            _offset++;
            RaporuGoster();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (_offset == 0) return;
            _offset--;
            RaporuGoster();
        }

        private void RaporuGoster()
        {
            lblSayfa.Text = $"{_offset + 1}";
            var query = _dContext.Products
                .Include(x => x.Category)
                .Include(x => x.Supplier)
                .Select(x => new
                {
                    x.Category.CategoryName,
                    x.ProductName,
                    x.UnitPrice,
                    x.Supplier.CompanyName
                });

            if (_maxPage == 0)
            {
                _maxPage = (int)Math.Ceiling(query.Count() / Convert.ToDouble(_pageSize));
            }

            query.Count(x => x.UnitPrice < 20);
            query.Sum(x => x.UnitPrice);
            query.Average(x => x.UnitPrice);
            query.Max(x => x.UnitPrice);
            query.Min(x => x.UnitPrice);

            query.Any();

            if (query.All(x => x.CategoryName != "Beverages"))
            {

            }


            var result = query
             .OrderBy(x => x.CategoryName)
             .Skip(_offset * _pageSize)
             .Take(_pageSize)
             .ToList();
            dgvNorth.DataSource = result;
            dgvNorth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
