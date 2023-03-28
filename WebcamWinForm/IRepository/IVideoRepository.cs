using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamWinForm.Model;

namespace WebCamWinForm.IRepository
{
    internal interface IVideoRepository
    {
        string SaveVideo(VideoWriter v);



    }
}
