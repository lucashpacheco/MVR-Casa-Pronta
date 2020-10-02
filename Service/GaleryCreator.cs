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

        public string GaleryCreatorMethod()
        {
            var images = _imagesRepository.GetAllImages();

            object imageX = "";

            var div = MountDivsPerImage(images);



            return div;
            //return div;
        }

        private string MountDivsPerImage(List<ImagesModel> images)
        {
            var imageX = "";
            var div = $"";
            foreach (var image in images)
            {


                var imageBin = image.IMG_BYTE;
                var base64 = Convert.ToBase64String(imageBin);
                var imgSrc = String.Format("data:image/jpg;base64,{0}", base64);
                
                
                
                div = $"<div class=\"img\">< a href = \"{imgSrc}\" data - lightbox = \"roadtrip\" >< img src = \"{imgSrc}\" alt = \"Fjords\" /> </ a > < div class=\"desc\">{image.IMG_DESCRIPTION}</div> </div>";
                //div = $"<div class=\"img\">< a href = \"{image.IMG_BYTE}\" data - lightbox = \"roadtrip\" >< img src = \"{image.IMG_BYTE}\" alt = \"Fjords\" /> </ a > < div class=\"desc\">{image.IMG_DESCRIPTION}</div> </div>";

                return div;
            }

            return div;
        }
    }
}