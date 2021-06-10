using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Web_2021_API.Entities;
using static System.Net.WebRequestMethods;
using  Web_2021_API.Model;

namespace ShopThuCung_2021.Data
{
    public class _Quyen
    {
        public async Task<Lst_quyen> Get_quyen()
        {
            Lst_quyen lq = new Lst_quyen();
            Quyen quyen = new Quyen();
            try
            {
                HttpResponseMessage res = await Startup.Send_API("Quyen/get_quyen",quyen, "POST", "");
                if (res.IsSuccessStatusCode)
                {
                    var results = res.Content.ReadAsStringAsync().Result;
                    lq = JsonConvert.DeserializeObject<Lst_quyen>(results);
                    return lq;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lq;
        }
    }
}
