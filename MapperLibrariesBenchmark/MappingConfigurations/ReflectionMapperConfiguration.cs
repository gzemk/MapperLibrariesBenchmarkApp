using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MapperLibrariesBenchmark.MappingConfigurations
{
    public static class ReflectionMapperConfiguration
    {
        public static TDestination ReflectionMapper<TSource, TDestination>(TSource source) where TDestination : new()
        {
            TDestination destination = new TDestination();
            Type sourceType = source!.GetType();
            PropertyInfo[] sourceProperties = sourceType.GetProperties();
            PropertyInfo[] destinationProperties= typeof(TDestination).GetProperties();

            foreach (var item in sourceProperties)
            {
                PropertyInfo destinationPropertyInfo = destinationProperties.FirstOrDefault(x => x.Name == item.Name && x.PropertyType == item.PropertyType)!;

                if (destinationPropertyInfo == null && !(destinationPropertyInfo!.CanWrite))
                    return destination;

                object sourceValue = item.GetValue(source,null)!;
                destinationPropertyInfo.SetValue(destination, sourceValue, null);
            }
            return destination;
        }
    }
}
