using AutoMapper;
using FomeZero.Entidades;
using FomeZero.Models;
using System.Collections.Generic;
using System.Linq;

namespace FomeZero.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(mapper =>
            {
                #region [ Entidade => ViewModel ]
                
                mapper.CreateMap<Lanche, LancheViewModel>()
                    .ForMember(dest => dest.Ingredientes, opt => opt.MapFrom(src => src.Ingredientes.Select(s => s.Nome)))
                    .ForMember(dest => dest.Preco, opt => opt.MapFrom(src => src.Preco.ToString("N2")));

                #endregion
            });
        }
    }
}