using EnvatoMarket;
using EnvatoMarket.Business.Hubs;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var config = builder.Configuration;
builder.Services.Registration(config);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseSession();
app.UseCors();
app.UseRouting();
StripeConfiguration.ApiKey = config.GetSection("Stripe:Secret_key").Get<string>();
//StripeConfiguration.ApiKey = "sk_test_51O8kpHJAoZSeXSjACOuWpXzXKNmWfriVblRGeLrnNqEv2iisnipsbftXv79mYT6sPIpbIOv6Pdd1tromLBg4KM4m00DKFija8g";
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "Areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}"
    );


app.MapRazorPages();
app.MapHub<ChatHub>("/chatHub");
app.Run();

