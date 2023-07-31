using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_S4.Models.DataModel
{
    public class Account
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("Name")]
        [Required(ErrorMessage ="Vui lòng nhập tên tài khoản")]
        public string Name { get; set; }

        [BsonElement("Password")]
        [Required(ErrorMessage = "Vui lòng nhập password tài khoản")]
        public string Password { get; set; }

        [BsonElement("Email")]
        [Required(ErrorMessage = "Vui lòng nhập email tài khoản")]
        public string Email { get; set; }

        [BsonElement("Phone")]
        public string Phone { get; set; }

        [BsonElement("Address")]
        public string Address { get; set; }

        [BsonElement("Role")]
        public int Role { get; set; }

    }
}
