using MVR_Casa_Pronta.Interfaces;
using MVR_Casa_Pronta.Models;
using MVR_Casa_Pronta.Repository;
using System;
using System.Collections.Generic;

namespace MVR_Casa_Pronta.Service
{
    public class ImageSeparator : IImageSeparator
    {
        private readonly IImagesRepository _imagesRepository;

        public ImageSeparator(IImagesRepository imagesRepository)
        {
            _imagesRepository = imagesRepository;
        }

        public List<ImagesModel> ImageSeparatorMethod()
        {
            var images = _imagesRepository.GetAllImages();
            var listImages = new List<ImagesModel>();

            return images;
        }

        public class GaleryCreator : IGaleryCreator
        {
            private readonly IImageSeparator _imageSeparator;

            public GaleryCreator(IImageSeparator imageSeparator)
            {
                _imageSeparator = imageSeparator;
            }

            public object GaleryCreatorMethod()
            {
                var images = _imageSeparator.ImageSeparatorMethod();
                
                object imageX = "";

                //var div = MountDivsPerImage(images);

                foreach (var image in images)
                {
                        imageX = image;

                    return imageX;
                }

                object div = "";

                return images;
            }

            //private object MountDivsPerImage(List<ImagesModel> images)
            //{
            //    object imageX = "";
            //    var div = $"";
            //    foreach (var image in images)
            //    {
            //        imageX = image;

            //        return imageX;
            //    }

            //    return div;
            //}
        }
    }
}