using MongoDB.Driver;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamWinForm.Model;

namespace WebCamWinForm.IRepository
{
    internal class VideoRepository:IVideoRepository
    {
        private MongoClient _mongoClient= null;
        private IMongoDatabase _database = null;
        private IMongoCollection<VideoModel> _collection = null;

        public VideoRepository() 
        {
            _mongoClient = new MongoClient("mongodb://localhost:27017/");
            _database = _mongoClient.GetDatabase("Mongo_Sample");
            _collection = _database.GetCollection<VideoModel>("Videos");
        }

        public string SaveVideo(VideoWriter v)
        {
            var vi = new VideoModel { VideoData= v};
            try
            {
                _collection.InsertOne(vi);

                return vi.Id;
            }
            catch 
            {
                return "Failed";

            }   
            
        }
    }
}
