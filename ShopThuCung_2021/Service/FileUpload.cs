using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
namespace ShopThuCung_2021.Service
{
  
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;
        public FileUpload(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
     public async Task UpLoadAsync(IFileListEntry file)
        {
            var path = Path.Combine(_environment.ContentRootPath, "wwwroot/Upload", file.Name);
            var ms = new MemoryStream();
           await  file.Data.CopyToAsync(ms);
            using (FileStream file1 =  new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file1);
            }
        }
    }
}
