﻿using BE.Models;
using Microsoft.EntityFrameworkCore;

namespace BE.Repository
{
    public class SanphamH
    {
        private readonly db_websitebanhangContext _context;

        public SanphamH(db_websitebanhangContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<object>> getAllSanphams()
        {

          
            var nhanHieus = await _context.Nhanhieus
    .Include(nh => nh.Sanphams) 
        .ThenInclude(sp => sp.Chitietsanphams)
            .ThenInclude(ct => ct.MaMauNavigation) 
    .Include(nh => nh.Sanphams) 
        .ThenInclude(sp => sp.MaKhuyenmaiNavigation)
    .Select(nh => new
    {
        TenNhanHieu = nh.TenNhan,
        Sanphams = nh.Sanphams.Select(sp => new
        {
            sp.TenSanpham,
            sp.MoTa,
            Chitietsanpham = sp.Chitietsanphams.Select(ct => new
            {
<<<<<<< HEAD
<<<<<<< HEAD
=======
                ct.IdChitietSp,
>>>>>>> 974d098 (ngochuan update lần 1)
=======
>>>>>>> d23521803f7f06053b92c698bd41c98ddb7104b0
                ct.HinhAnh,
                ct.SoLuongTon,
                ct.Gia,
                TenMau = ct.MaMauNavigation.TenMau
            }),
            PhanTramKhuyenMai = sp.MaKhuyenmaiNavigation.PhanTram 
        })
    })
    .ToListAsync();


            return nhanHieus;
        } 
    }
}
