using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_S4.Models.DataModel
{
    public class Product
    {
        [BsonId]
        public string  _id { get; set; }

        [BsonElement("ProductName")]
        [Required(ErrorMessage ="Vui lòng nhập tên sản phẩm")]
        public string ProductName { get; set; }

        [BsonElement("Images")]
        [Required(ErrorMessage = "Vui lòng nhập ảnh sản phẩm")]
        public string Images { get; set; }

        [BsonElement("Quantity")]
        [Required(ErrorMessage = "Vui lòng nhập số lượng sản phẩm")]
        public float Quantity { get; set; }

        [BsonElement("Id_Cate")]
        public int Id_Cate { get; set; }

        [BsonElement("Price")]
        [Required(ErrorMessage = "Vui lòng nhập giá sản phẩm")]
        public float Price { get; set; }

        [BsonElement("Content")]
        [Required(ErrorMessage = "Vui lòng nhập mô tả sản phẩm")]
        public string Content { get; set; }

        public bool Status { get; set; }
    }
}
