using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_S4.Models.DataModel
{
    public class Contact
    {
        [BsonId]
        [
            Display(Name = "Mã"),
            Required(ErrorMessage = "không được để trống mã"),
            MinLength(4, ErrorMessage = "nội dung ngắn nhất là 4 kí tự"),
            MaxLength(20, ErrorMessage = "nội dung dài nhất là 20 kí tự")
        ]
        public string _id { get; set; }
        [
            Display(Name = "Tên ngưi dùng"),
            Required(ErrorMessage = "không được để trống tên"),
            MinLength(4, ErrorMessage = "nội dung ngắn nhất là 4 kí tự"),
            MaxLength(20, ErrorMessage = "nội dung dài nhất là 20 kí tự")
        ]
        public string Name { get; set; }
        [
            Display(Name = "Gmail"),
            Required(ErrorMessage = "không được để trống Gmail"),
            MinLength(4, ErrorMessage = "nội dung ngắn nhất là 4 kí tự"),
            MaxLength(20, ErrorMessage = "nội dung dài nhất là 20 kí tự")
        ]
        public string Gmail { get; set; }
        [
            Display(Name = "Nhập số điện thoại"),
            Required(ErrorMessage = "không được để trống số điện thoại"),
            MinLength(10, ErrorMessage = "số điện thoại ngắn nhất là 10 số"),
            MaxLength(20, ErrorMessage = "số điện thoại dài nhất là 11 số")
        ]
        public string Phone { get; set; }
        public bool Status { get; set; }
    }
}
