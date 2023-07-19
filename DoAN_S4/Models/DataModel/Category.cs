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
        [BsonElement("Id_Category")]
        public int Id_Category { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Status")]
        public bool Status { get; set; }
            
    }
}
