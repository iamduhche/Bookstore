using BookstoreCafe.Data;
using BookstoreCafe.Data.Entities;
using BookstoreCafe.Infrastructure;
using BookstoreCafe.Services.Books;
using BookstoreCafe.Services.Orders;
using BookstoreCafe.Services.ShoppingCarts;
using BookstoreCafe.Services.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure the database connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<BookCafeDbContext>(options =>
    options.UseSqlServer(connectionString));

// Configure Identity options
builder.Services.AddDefaultIdentity<User>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<BookCafeDbContext>();

// Register application services
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
builder.Services.AddScoped<IOrderService, OrderService>();

// Add controllers with views
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
});

var app = builder.Build();

// Seed admin user
app.SeedAdmin();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error/500");
    app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "bookDetails",
    pattern: "Books/Details/{slug}-{id}",
    defaults: new { controller = "Books", action = "Details" }
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "shoppingCart",
    pattern: "{controller=ShoppingCart}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "checkout",
    pattern: "{controller=ShoppingCart}/{action=Checkout}/{id?}"
);

app.MapControllerRoute(
    name: "adminPanel",
    pattern: "{controller=Admin}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "adminPanelOrder",
    pattern: "{controller=Admin}/{action=Orders}/{id?}"
);

app.MapControllerRoute(
    name: "adminPanelOrderDetails",
    pattern: "{controller=Admin}/{action=OrderDetails}/{id?}"
);
app.MapRazorPages();

app.Run();
