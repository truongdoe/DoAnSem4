using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_S4.Models.DataModel
{
    public class Category
    {
        [BsonId]
        [BsonElement("_id")]
        [Required(ErrorMessage = "Id không được để trống")]
        public int _id { get; set; }

        [BsonElement("CategoryName")]
        [Required(ErrorMessage = "Tên danh mục không được để trống")]

        public string CategoryName { get; set; }

        [BsonElement("Status")]
        [Required(ErrorMessage = "Tên Status không được để trống")]
        public bool Status { get; set; }
            
    }
}
