using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using ShopThuCung_2021.Api;
using ShopThuCung_2021.Data;
using ShopThuCung_2021.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ShopThuCung_2021
{
    public class Startup
    {
        public static string api_url;
        public static HttpClient sysAPI;
        public static async Task<HttpResponseMessage> Send_API<T>(string Url, T obj, string Method, string token)
        {
            sysAPI.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            if (Method.Trim().ToUpper() == "POST")
            {
                HttpResponseMessage result = await Startup.sysAPI.PostAsync(Url, new StringContent((JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })), Encoding.UTF8, "application/json"));
                return result;
            }
            else if (Method.Trim().ToUpper() == "GET")
            {
                HttpResponseMessage result = await Startup.sysAPI.GetAsync(Url);
                return result;
            }
            else if (Method.Trim().ToUpper() == "PUT")
            {
                HttpResponseMessage result = await Startup.sysAPI.PutAsync(Url, new StringContent((JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })), Encoding.UTF8, "application/json"));
                return result;
            }
            else if (Method.Trim().ToUpper() == "DELETE")
            {
                HttpResponseMessage result = await Startup.sysAPI.DeleteAsync(Url);
                return result;
            }
            else
            {
                return new HttpResponseMessage();
            }
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddScoped<Session>();
            services.AddScoped<CUD_User>();
            services.AddScoped<_Quyen>();
            services.AddScoped<IFileUpload, FileUpload>();
            services.AddHttpClient();
            // _Api API = new _API();
            _Api APi = new _Api(); 
            api_url = Configuration["API:api_url"];
            sysAPI = APi.Initial("SYS_API");
            services.AddDistributedMemoryCache();



            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
