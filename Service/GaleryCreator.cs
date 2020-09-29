using MVR_Casa_Pronta.Models;
using MVR_Casa_Pronta.Repository;
using System;
using System.Collections.Generic;

namespace MVR_Casa_Pronta.Service
{

    public interface IImageSeparator
    {
        List<ImagesModel> ImageSeparatorMethod();
    }

    public interface IGaleryCreator
    {
        string GaleryCreatorMethod();
    }

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

            public string GaleryCreatorMethod()
            {
                var images = _imageSeparator.ImageSeparatorMethod();

                var div = MountDivsPerImage(images);

                return div;
            }

            private string MountDivsPerImage(List<ImagesModel> images)
            {
                var div = $"";
                foreach (var image in images)
                {
                    //TODO: MONTA A DIV
                }

                return div;
            }
        }
    }
}