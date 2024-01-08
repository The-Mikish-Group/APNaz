using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Bmp;
using SixLabors.ImageSharp.Formats.Gif;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Processing;
using System.IO;

namespace Gallery.Helpers
{
    public static class ImageHelper
    {
        private static IWebHostEnvironment _env;

        public static void Initialize(IWebHostEnvironment env)
        {
            _env = env;
        }

        public static void CreateThumbnail(string file, string thumbnailsPath)
        {
            try
            {
                int thumbnailWidth = 800;
                int thumbnailHeight = 800;

                using (var originalImage = Image.Load(Path.Combine(_env.WebRootPath, file.TrimStart('~', '/'))))
                {
                    originalImage.Mutate(x => x
                        .Resize(new ResizeOptions
                        {
                            Size = new Size(thumbnailWidth, thumbnailHeight),
                            Mode = ResizeMode.Max
                        }));
                    
                    originalImage.Save(Path.Combine(thumbnailsPath, Path.GetFileNameWithoutExtension(file) + "_thumb.jpg"), GetImageFormat(Path.GetExtension(Path.Combine(_env.WebRootPath, file.TrimStart('~')))));
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        
        private static IImageEncoder GetImageFormat(string extension)
        {
            switch (extension.ToLower())
            {
                case ".png":
                    return new PngEncoder();
                case ".jpg":                    
                case ".jpeg":
                    return new JpegEncoder();
                case ".gif":
                    return new GifEncoder();
                case ".bmp":
                    return new BmpEncoder();
                // Add more formats as needed  
                default:
                    // Default to JPEG for unknown extensions
                    return new JpegEncoder();
            }
        }
    }
}
