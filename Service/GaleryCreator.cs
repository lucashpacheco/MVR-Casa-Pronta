using Microsoft.Ajax.Utilities;
using MVR_Casa_Pronta.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI.WebControls;


namespace MVR_Casa_Pronta.Service
{

    public interface IImageSeparator
    {
        object ImageSeparatorMethod();
    }

    public interface IGaleryCreator
    {
        object GaleryCreatorMethod();
        //object ImageSeparatorMethod();
    }

    public class ImageSeparator //: IImageSeparator
    {
        //[Dependency]
        public IImagesRepository imagesRepository { get; set; }

        object imageObj = "";
        object divImageObj = "";
        public object ImageSeparatorMethod()
        {
            var images = imagesRepository.GetAllImages();
            object imageFinal = "";


            foreach (var imageElement in images)
            {

                Console.WriteLine(imageElement.IMG_NAME);
                Console.WriteLine(imageElement.IMG_DESCRIPTION);
                Console.WriteLine(imageElement.IMG_ID);
                Console.WriteLine(imageElement.IMG_BYTE);

                imageFinal = imageElement;
                return imageFinal;
            }

            return imageObj = imageFinal;

        }

        public class GaleryCreator : IGaleryCreator
        {
            public IImageSeparator imageSeparator { get; set; }

            object imageDiv = imageSeparator.ImageSeparatorMethod();
            
            //object imageDiv = imageSeparator.ImageSeparatorMethod();


            public object GaleryCreatorMethod()
            {
                var div = "";
                return null;//divImageObj = div;
            }
        }

        //return divImageObj;
    }
}