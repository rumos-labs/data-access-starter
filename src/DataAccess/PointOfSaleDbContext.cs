using Bogus;
using DataAccess.Lib;
using Microsoft.EntityFrameworkCore;

public class PointOfSaleDbContext : DbContext
{
    private const string DatabaseName = "DataAccessDb";

    // TODO: Add DbSet properties

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder
            .UseSqlServer($"Server=(localdb)\\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True;MultipleActiveResultSets=true");
    }

    // TODO: Uncomment after adding DbSet properties
    //public void EnsureSeed()
    //{
    //    if (Sales?.Any() != true)
    //    {
    //        Seed();
    //    }
    //}

    //private void Seed()
    //{
    //    var storeFaker = new Faker<Store>()
    //        .RuleFor(s => s.Name, f => f.Company.CompanyName())
    //        .RuleFor(s => s.Address, f => f.Address.FullAddress())
    //        .RuleFor(s => s.IsClosed, f => false);

    //    var customerFaker = new Faker<Customer>()
    //        .RuleFor(c => c.Name, f => f.Name.FullName())
    //        .RuleFor(c => c.Email, f => f.Internet.Email());

    //    var productFaker = new Faker<Product>()
    //        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
    //        .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
    //        .RuleFor(p => p.Price, f => f.Finance.Amount(1, 50));

    //    var stores = storeFaker.Generate(10);

    //    var pointOfSaleFaker = new Faker<PointOfSale>()
    //        .RuleFor(p => p.Store, f => f.PickRandom(stores));

    //    var products = productFaker.Generate(50);
    //    var customers = customerFaker.Generate(100);

    //    var saleItemFaker = new Faker<SaleItem>()
    //        .RuleFor(si => si.Product, f => f.PickRandom(products))
    //        .RuleFor(si => si.Quantity, f => f.Random.Int(1, 10))
    //        .RuleFor(si => si.Price, (f, si) => si.Product.Price * si.Quantity);

    //    var pointsOfSale = pointOfSaleFaker.Generate(20);

    //    var saleFaker = new Faker<Sale>()
    //        .RuleFor(s => s.PointOfSale, f => f.PickRandom(pointsOfSale))
    //        .RuleFor(s => s.Customer, f => f.PickRandom(customers))
    //        .RuleFor(s => s.Date, f => f.Date.Past(1))
    //        .RuleFor(s => s.SaleItems, f => saleItemFaker.Generate(f.Random.Int(1, 5)));

    //    var sales = saleFaker.Generate(50);

    //    this.AddRange(stores);
    //    this.AddRange(pointsOfSale);
    //    this.AddRange(products);
    //    this.AddRange(customers);
    //    this.AddRange(sales);

    //    this.SaveChanges();
    //}   
}