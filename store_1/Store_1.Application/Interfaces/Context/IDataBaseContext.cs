using Microsoft.EntityFrameworkCore;
using Store_1.Domain.Entities.Carts;
using Store_1.Domain.Entities.Finances;
using Store_1.Domain.Entities.HomePage;
using Store_1.Domain.Entities.Orders;
using Store_1.Domain.Entities.Products;
using Store_1.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Store_1.Application.Interfaces.Context
{
    public interface IDataBaseContext
    {
         DbSet<User> users { get; set; }
         DbSet<Role> roles { get; set; }
         DbSet<UserInRole> UserInroles { get; set; }
         DbSet<Category> Categories { get; set; }
         DbSet<Product> products { get; set; }
         DbSet<ProductImages> ProductImages { get; set; }
         DbSet<ProductFeatures> ProductFeatures { get; set; }
        DbSet<Slider> Sliders { get; set; }
        DbSet<HomePageImages> HomePageImages { get; set; }
        DbSet<Cart> Carts { get; set; }
        DbSet<CartItem> CartItems { get; set; }
        DbSet<RequestPay> RequestPays { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }





        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellAtiontoken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

    }
    
}
