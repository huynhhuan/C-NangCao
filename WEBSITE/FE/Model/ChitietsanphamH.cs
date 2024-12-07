using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FE.Model
{
    public class ChiTietSanPhamH
    {
<<<<<<< HEAD
=======
        [JsonProperty("idChitietSp")]
        public string IdChitietSp { get; set; }
>>>>>>> 974d098 (ngochuan update lần 1)
        [JsonProperty("hinhAnh")]
        public string HinhAnh { get; set; }

        [JsonProperty("soLuongTon")]
        public int SoLuongTon { get; set; }

        [JsonProperty("gia")]
        public decimal Gia { get; set; }

        [JsonProperty("tenMau")]
        public string TenMau { get; set; }
    }
}