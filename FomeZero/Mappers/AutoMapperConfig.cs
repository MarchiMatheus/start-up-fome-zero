using AutoMapper;
using FomeZero.Entidades;
using FomeZero.Models;
using FomeZero.Negocio.Entidades.In;
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

                mapper.CreateMap<Ingrediente, IngredienteViewModel>()
                    .ForMember(dest => dest.Valor, opt => opt.MapFrom(src => src.Valor.ToString("N2")));

                #endregion

                #region [ ViewModel => Entidade ]

                 mapper.CreateMap<MontarLanchePersonalizadoViewModel, MontarLanchePersonalizadoIn>()
                    .ForMember(dest => dest.QuantidadeAlface, opt => opt.MapFrom(src => src.Alface.HasValue? src.Alface : 0))
                    .ForMember(dest => dest.QuantidadeBacon, opt => opt.MapFrom(src => src.Bacon.HasValue ? src.Bacon : 0))
                    .ForMember(dest => dest.QuantidadeHamburguerCarne, opt => opt.MapFrom(src => src.HamburguerCarne.HasValue ? src.HamburguerCarne : 0))
                    .ForMember(dest => dest.QuantidadeOvo, opt => opt.MapFrom(src => src.Ovo.HasValue ? src.Ovo : 0))
                    .ForMember(dest => dest.QuantidadeQueijo, opt => opt.MapFrom(src => src.Queijo.HasValue ? src.Queijo : 0));

                #endregion
            });
        }
    }
}