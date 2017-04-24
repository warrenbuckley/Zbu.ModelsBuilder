using System;
using System.Reflection;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.ModelsBuilder.Meta
{
    public static class ModelStaticInfos
    {
        public static ModelTypeInfo[] Types
        {
            get
            {
                var factory = PublishedContentModelFactoryResolver.Current.Factory;
                var pure = factory as PureLiveModelFactory;

                var infos = pure == null
                    ? Type.GetType("Umbraco.ModelsBuilder.Meta.ModelInfos")
                    : pure.ModelTypeInfosType;

                // fixme - we should extend IPublishedModelFactory to return the meta data
                // and it would avoid the costly reflection *but* change Core

                if (infos == null)
                    return new ModelTypeInfo[0];

                var prop = infos.GetField("Types", BindingFlags.Public | BindingFlags.Static);

                if (prop == null)
                    return new ModelTypeInfo[0];

                return (ModelTypeInfo[])prop.GetValue(null);
            }
        }
    }
}
