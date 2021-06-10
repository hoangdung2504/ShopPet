using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopThuCung_2021.Service
{
  public  interface IFileUpload
    {
        Task UpLoadAsync(IFileListEntry file);
    }
}
