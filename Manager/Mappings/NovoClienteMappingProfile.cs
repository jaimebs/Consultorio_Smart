using AutoMapper;
using Core.Domain;
using Core.ModelViews.Cliente;
using System;
using System.Text.RegularExpressions;

namespace Manager.Mappings
{
    public class NovoClienteMappingProfile : Profile
    {
        private const string REGEX_CARACTERES_ESPECIAIS = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]";
        public NovoClienteMappingProfile()
        {
            CreateMap<NovoCliente, Cliente>()
                .ForMember(dest => dest.Criacao, opt => opt.MapFrom(ori => DateTime.Now))
                .ForMember(dest => dest.Documento, opt => opt.MapFrom(ori => Regex.Replace(ori.Documento, REGEX_CARACTERES_ESPECIAIS, "")))
                .ForMember(dest => dest.DataNascimento, opt => opt.MapFrom(ori => ori.DataNascimento.Date));
        }
    }
}
