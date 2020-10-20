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
        void InsertImage();
    }
    public class ImagesRepository : IImagesRepository
    {
        public List<ImagesModel> GetAllImages()
        {
            var db = new PetaPoco.Database("System.Data.SqlClient");
            var allImages = db.Fetch<ImagesModel>("SELECT * FROM Images");

            return allImages;
        }

        public void InsertImage()
        {
                  var db = @"INSERT INTO Images( IMG_BYTE , IMG_NAME , IMG_DESCRIPTION)
                        VALUES(

                        (SELECT
                            IMG_BYTE.BulkColumn AS IMG_BYTE

                        FROM
        
                            OPENROWSET(BULK N'C:\Users\WorkStationW10\Documents\MVR-Casa-Pronta\MVR-Casa-Pronta\images\6.jpg', SINGLE_BLOB) AS IMG_BYTE),       	                'cozinha' ,
        	                'Reforma cozinha , moveis e decoração'
                               )";
	                     
        }
    }
     
}