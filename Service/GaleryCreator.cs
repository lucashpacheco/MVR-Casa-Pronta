using MVR_Casa_Pronta.Interfaces;
using MVR_Casa_Pronta.Models;
using MVR_Casa_Pronta.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVR_Casa_Pronta.Service
{
    public class GaleryCreator : IGaleryCreator
    {


        private readonly IImagesRepository _imagesRepository;


        public GaleryCreator(IImagesRepository imagesRepository)
        {
            _imagesRepository = imagesRepository;
        }

        public List<ImagesModel> GaleryCreatorMethod()
        {
            var images = _imagesRepository.GetAllImages();

            var div = MountDivsPerImage(images);



            return images;
            //return div;
        }

        private IHtmlString MountDivsPerImage(List<ImagesModel> images)
        {
            int count = 0;
            IHtmlString div = new HtmlString("");
            IHtmlString divX = new HtmlString("");
            while (count < images.Count)
            {
                var image = images[count];
                var imageBin = image.IMG_BYTE;
                var base64 = Convert.ToBase64String(imageBin);
                var imgSrc = String.Format("data:image/jpg;base64,{0}", base64);



                div = new HtmlString("<div class=\"img\">" +
                                        "<a href = \"" + imgSrc + "\" data-lightbox=\"roadtrip\"><img src = \"" + imgSrc + "\" alt=\"Fjords\" /></a>" +
                                        "<div class=\"desc\">" +
                                            image.IMG_DESCRIPTION +
                                        "</div>" +
                                    "</div>");
                count++;
                return divX = div;
            }

            return div = divX;
        }
    }
}