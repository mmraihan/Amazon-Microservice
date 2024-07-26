using Amazon.Web.Service;
using Amazon.Web.Service.IService;
using Amazon.Web.Utility;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

#region Additional Services

builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient();
builder.Services.AddHttpClient<IBaseService, BaseService>();
builder.Services.AddHttpClient<ICouponService, CouponService>();

SD.CouponAPIBase = builder.Configuration["ServiceUrls:CouponAPI"];
SD.CouponAPIBase = builder.Configuration["ServiceUrls:AuthAPI"];

builder.Services.AddScoped<IBaseService, BaseService>();

builder.Services.AddScoped<ICouponService, CouponService>();


#endregion


builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
