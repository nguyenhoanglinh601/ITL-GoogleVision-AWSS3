using Microsoft.AspNetCore.Http;
using System.IO;

namespace DetectText_GoogleVision.DL.IService
{
    public interface IGoogleVisionService
    {
        string GetClientAPI();
        string JSONRequest(string base64String);
        ///////
        string ImageFromURL(string URL);
        string ImageFromFile(IFormFile file);
        //NEW
        string ImageFromStream(Stream img);
    }
}
