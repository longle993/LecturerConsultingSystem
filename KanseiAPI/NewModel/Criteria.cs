﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace KanseiAPI.NewModel
{
    public class Criteria
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string _id;

        [BsonElement("name")]
        private string _name;

        [BsonElement("kansei_list")]
        [BsonRepresentation(BsonType.ObjectId)]
        private List<ObjectId> _kanseiList;

        [BsonElement("point")]
        private double _point;

        public Criteria(string id, string name, List<ObjectId> kanseiList, double point)
        {
            _id = id;
            _name = name;
            _kanseiList = kanseiList;
            _point = point;

        }
        public Criteria() { }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public List<Kansei> ListKansei { get; set; }

        public List<ObjectId> KanseiList { get => _kanseiList; set => _kanseiList = value; }
        public double Point { get => _point; set => _point = value; }
    }
}
