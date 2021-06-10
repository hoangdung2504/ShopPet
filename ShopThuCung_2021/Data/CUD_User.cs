using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Web_2021_API.Entities;
using Web_2021_API.Model;

namespace ShopThuCung_2021.Data
{
    public class CUD_User
    {
        
    
        public async Task<User_List> Create_User(string id, string pass, string email, string full_name, string Sdt, string path_img)
        {
            User_List usl = new User_List();
            User u = new User();
            u.TenDangNhap = id;
            u.MatKhau = pass;
            u.Email = email;
            u.HoTen = full_name;
            u.SDT = Sdt;
            u.Path_img = path_img;
            // string Encrypt_pass = Utils.encrypt((username + password));
            // usr.usr_password = Encrypt_pass;
            try
            {
                HttpResponseMessage res = await Startup.Send_API("User_/Create", u, "POST", "");
                if (res.IsSuccessStatusCode)
                {
                    var results = res.Content.ReadAsStringAsync().Result;
                    usl = JsonConvert.DeserializeObject<User_List>(results);
                    if (usl.res_code == "000")
                    {
                        usl.desc = "Tạo thành công!";
                        //this.Login_User = username;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usl;
        }

        public async Task<User_List> Get_User(string id)
        {
            User_List usl = new User_List();
            User u = new User();
            u.TenDangNhap = id;

            // string Encrypt_pass = Utils.encrypt((username + password));
            // usr.usr_password = Encrypt_pass;
            try
            {
                HttpResponseMessage res = await Startup.Send_API("User_/GetById", u, "POST", "");
                if (res.IsSuccessStatusCode)
                {
                    var results = res.Content.ReadAsStringAsync().Result;
                    usl = JsonConvert.DeserializeObject<User_List>(results);
                    if (usl.res_code == "000")
                    {
                        usl.desc = "Tạo thành công!";
                        //this.Login_User = username;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usl;
        }

        public async Task<User_List> Update_User(string id, string pass, string email, string full_name, string Sdt, string path_img,string ten_quyen,int solanfail,string status)
        {
            
            User_List usl = new User_List();
            User u = new User();
            u.Quyen = new Quyen();
            u.TenDangNhap = id;
            u.MatKhau = pass;
            u.Email = email;
            u.HoTen = full_name;
            u.SDT = Sdt;
            u.Path_img = path_img;
            u.Quyen.Txt_Quyen = ten_quyen;
            u.SoLanDangNhapFail = solanfail;
            u.Status = status;
            // string Encrypt_pass = Utils.encrypt((username + password));
            // usr.usr_password = Encrypt_pass;
            try
            {
                HttpResponseMessage res = await Startup.Send_API("User_/UpDate", u, "POST", "");
                if (res.IsSuccessStatusCode)
                {
                    var results = res.Content.ReadAsStringAsync().Result;
                    usl = JsonConvert.DeserializeObject<User_List>(results);
                    if (usl.res_code == "000")
                    {
                        usl.desc = "Tạo thành công!";
                        //this.Login_User = username;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usl;
        }
    }
}

