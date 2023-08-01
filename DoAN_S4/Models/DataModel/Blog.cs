using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_S4.Models.DataModel
{
    public class Blog
    {
        [BsonId]
        [
         Display(Name = "Mã Tin"),
         Required(ErrorMessage = "không được để trống mã"),
         MinLength(4, ErrorMessage = "nội dung ngắn nhất là 4 kí tự"),
         MaxLength(20, ErrorMessage = "nội dung dài nhất là 20 kí tự")
     ]
        public string _id { get; set; }
        [
            Display(Name = "Nội dung"),
            Required(ErrorMessage = "không được để trống nội dung"),
            MinLength(20, ErrorMessage = "nội dung ngắn nhất là 20 kí tự")

        ]
        public string Content { get; set; }
        [
         Display(Name = "Ảnh")
            ]
        public string Image { get; set; }
        [Display(Name = "Trạng thái"),
         Required(ErrorMessage = "không được để trống trạng thái")
        ]
        public int Status { get; set; }
    }
}
