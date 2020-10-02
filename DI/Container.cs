using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using MVR_Casa_Pronta.Interfaces;
using MVR_Casa_Pronta.Service;
using MVR_Casa_Pronta.Repository;

namespace MVR_Casa_Pronta.DI
{
    public class Container
    {
        public static Microsoft.Practices.Unity.UnityContainer UnityContainer
        {
            get
            {
                CriarContainer();
                return _unityContainer;
            }
        }
        private static Microsoft.Practices.Unity.UnityContainer _unityContainer;

        private static void CriarContainer()
        {
            _unityContainer = new Microsoft.Practices.Unity.UnityContainer();
            _unityContainer
                .RegisterType<IGaleryCreator, GaleryCreator>
                (new HttpContextLifetimeManager<IGaleryCreator>())
                .RegisterType<IImagesRepository, ImagesRepository>
                (new HttpContextLifetimeManager<IImagesRepository>());
                
        }
    }
}