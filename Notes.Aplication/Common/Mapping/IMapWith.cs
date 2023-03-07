using AutoMapper;

namespace Notes.Aplication.Common.Mapping
{
    //это интерфейс с реализацией по умолчанию
    public interface IMapWith<T>
    {
        //этот метод будет вызываться в классе MappingProfile и создавать конфигурацию типа T 
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
