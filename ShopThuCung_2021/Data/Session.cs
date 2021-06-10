using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using ShopThuCung_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopThuCung_2021.Data
{
    public class Session

    {
        string User = "ID";
        string Quyen = "Q";
        string FullName = "FN";
        string PATH = "P";
        string Fail = "SLFAIL";
        String STATUS = "STATUS";
        protected ProtectedLocalStorage _ProtectedLocalStorage { get; set; }

        public Session(ProtectedLocalStorage protectedLocalStorage)
        {
            _ProtectedLocalStorage = protectedLocalStorage;
        }

        public async Task Set_LoginUser(string value)
        {
            await _ProtectedLocalStorage.SetAsync(User, value);
        }

        public async Task Set_Quyen(string value)
        {
            await _ProtectedLocalStorage.SetAsync(Quyen, value);
        }
        public async Task Set_SoLanFail(string value)
        {
            await _ProtectedLocalStorage.SetAsync(Fail, value);
        }
        public async Task Set_Status(string value)
        {
            await _ProtectedLocalStorage.SetAsync(STATUS, value);
        }
        public async Task Set_path_img(string value)
        {
            await _ProtectedLocalStorage.SetAsync(PATH, value);
        }
        public async Task Set_FullName(string value)
        {
            await _ProtectedLocalStorage.SetAsync(FullName, value);
        }
        public async Task Set_all(string tk,string quyen,string hoten,string path_img,string trangthai)
        {
            await Set_LoginUser(tk);
            await Set_Quyen(quyen);
            await Set_FullName(hoten);
            await Set_path_img(path_img);
            await Set_Status(trangthai);
        }
        public async Task<string> Get_LoginUser()
        {

            var name = await _ProtectedLocalStorage.GetAsync<string>(User);
            return name.Value;
        }
        public async Task<string> Get_Status()
        {

            var name = await _ProtectedLocalStorage.GetAsync<string>(STATUS);
            return name.Value;
        }
        public async Task<int> Get_SoLanFail()
        {

            var name = await _ProtectedLocalStorage.GetAsync<string>(Fail);
            return int.Parse(name.Value);
        }
        public async Task<string> Get_Path()
        {

            var name = await _ProtectedLocalStorage.GetAsync<string>(PATH);
            return name.Value;
        }
        public async Task<string> Get_FullName()
        {



            var name = await _ProtectedLocalStorage.GetAsync<string>(FullName);
            return name.Value;
        }
        public async Task<string> Get_Quyen()
        {

            var name = await _ProtectedLocalStorage.GetAsync<string>(Quyen);
            return name.Value;
        }
       public async Task<CheckRoles> Get_All()
        {
            CheckRoles cr = new CheckRoles();

            cr.TaiKhoan =   await Get_LoginUser();
            cr.Quyen = await Get_Quyen();
            cr.HoTen = await Get_FullName();
            cr.path_img = await Get_Path();
            cr.TrangThai = await Get_Status();
            return cr;
        }
        public async Task ClearSS()
        {
            await _ProtectedLocalStorage.DeleteAsync(User);
            await _ProtectedLocalStorage.DeleteAsync(FullName);
            await _ProtectedLocalStorage.DeleteAsync(Quyen);
            await _ProtectedLocalStorage.DeleteAsync(PATH);

            await _ProtectedLocalStorage.DeleteAsync(STATUS);

        }
    }
}
