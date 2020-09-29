using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVR_Casa_Pronta.Models
{
    public class ImagesModel
    {
        public int IMG_ID { get; set; }
        public string IMG_NAME { get; set; }
        public string IMG_DESCRIPTION { get; set; }
        public byte[] IMG_BYTE { get; set; }
    }
}