using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.Extensions
{
    public static class Extension
    {
        /// <summary>
        /// check for pictures
        /// </summary>
        /// <param name="photo"></param>
        /// <returns></returns>
        public static bool IsImage(this IFormFile photo)
        {
            return photo.ContentType.Contains("image/");
        }

        /// <summary>
        /// to check the dimensions of the images
        /// </summary>
        /// <param name="photo"></param>
        /// <param name="kb"></param>
        /// <returns></returns>
        public static bool PhotoLength(this IFormFile photo, int kb)
        {
            return photo.Length / 1024 <= kb;
        }

        /// <summary>
        /// to add pictures to a folder.
        /// return Task.
        /// </summary>
        /// <param name="photo">photo IFormFile type</param>
        /// <param name="root">string root</param>
        /// <param name="folder">only one folder name</param>
        /// <returns></returns>
        public static async Task<string> AddImageAsync(this IFormFile photo, string root, string folder)
        {
            string PhotoName = Guid.NewGuid().ToString() + photo.FileName;
            string path = Path.Combine(root, folder, PhotoName);
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                await photo.CopyToAsync(fileStream);
            }
            return PhotoName;
        }
    }

    public enum Roles
    {
        Admin,
        Member
    }
}
