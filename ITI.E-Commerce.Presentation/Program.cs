



using ITI.E_Commerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;


public static class Program
{
    public static int Main() 
    {
        var builder = WebApplication.CreateBuilder();
        //help us to edit with runtime project
        builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

        // Creating objects from class controller #refliction
        builder.Services.AddControllersWithViews();

        //create one object from MyyContext per Request 
        builder.Services.AddDbContext<MyContext>(opttions =>
        {
            opttions.UseLazyLoadingProxies().
            UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });

        ///to Create new object from MyContext inner join my myContext 
        /// add migration and enable services ///
        builder.Services.AddIdentity<Customer, IdentityRole>().AddEntityFrameworkStores<MyContext>();

        #region To change configration of password
        builder.Services.Configure<IdentityOptions>(p =>
        {
            p.Password.RequireUppercase = false;
            p.Password.RequireLowercase = false;
            p.Password.RequireDigit = false;
            p.Password.RequireNonAlphanumeric = false;

            p.Lockout.AllowedForNewUsers = true;
            p.Lockout.MaxFailedAccessAttempts = 50;
            p.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(10);
        });
        #endregion
        ///if user not login and try to access book redirect to Sign in page
        builder.Services.ConfigureApplicationCookie(p => p.LoginPath = "/UserData/SignIn");

        builder.Services.AddControllers(options =>
        {
            //options.Filters.Add(new MyFillter());
            //options.Filters.Add(new MyLoginFillter());
        }).AddNewtonsoftJson(options => { options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; });
        var app = builder.Build();

        //allow browser to call folder content
        //app.UseStaticFiles(new StaticFileOptions()
        //{

        //    RequestPath = "/Content",
        //    FileProvider = new PhysicalFileProvider

        //    //Get current Directory of machine 
        //    (Path.Combine(Directory.GetCurrentDirectory(), "Content"))

        //});

        ///add middleware create object from user 
        app.UseAuthentication();
        app.UseAuthorization();
        // Routing Pattern to handle request
        app.MapControllerRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
        app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
        app.Run();
        return 0;    
    }

}