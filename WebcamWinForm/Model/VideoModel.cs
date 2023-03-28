﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using OpenCvSharp;

namespace WebCamWinForm.Model
{
    internal class VideoModel
    {
        [BsonRepresentation(BsonType.ObjectId)] 
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        public VideoWriter VideoData { get; set; }   

    }
}
