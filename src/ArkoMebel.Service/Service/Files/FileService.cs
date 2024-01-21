using ArkoMebel.Service.Abstraction.File;
using ArkoMebel.Service.Common.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ArkoMebel.Service.Service.Files
{
    public class FileService : IFileService
    {
        private readonly string MEDIA = "media";
        private readonly string IMAGES = "images";
       
        private readonly string ROOTPATH;
        public FileService(IWebHostEnvironment env)
        {
            ROOTPATH = env.WebRootPath;
        }

        public async ValueTask<bool> DeleteImageAsync(string file)
        {
            string path = Path.Combine(ROOTPATH, file);

            if (File.Exists(path))
            {
                await Task.Run(() =>
                {
                    File.Delete(path);
                });
                return true;
            }
            return false;
        }

        public async ValueTask<byte[]> GetImageAsync(string fileName)
        {
            string path = Path.Combine(ROOTPATH, fileName);
            byte[] imageBytes = await File.ReadAllBytesAsync(path);
            return imageBytes;
        }

        public async ValueTask<string> UploadImageAsync(IFormFile file)
        {
            string newImageName = MediaHelper.MakeImageName(file.FileName.ToLower());
            string subPath = Path.Combine(MEDIA, IMAGES, newImageName);
            string path = Path.Combine(ROOTPATH, subPath);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
                return subPath;
            }
        }
    }
}
