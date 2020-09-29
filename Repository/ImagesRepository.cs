using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using MVR_Casa_Pronta.Models;
using MVR_Casa_Pronta.Repository;

namespace MVR_Casa_Pronta.Repository
{
    public interface IImagesRepository
    {
        List<ImagesModel> GetAllImages();
    }
    public class ImagesRepository : IImagesRepository
    {
        public List<ImagesModel> GetAllImages()
        {
            var db = new PetaPoco.Database("System.Data.SqlClient");
            var allImages = db.Fetch<ImagesModel>("SELECT * FROM Images");

            return allImages;
        }
    }
     
}