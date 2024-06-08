using AplicativoAPI.DTO;
using AplicativoAPI.Models;
using AutoMapper;

namespace AplicativoAPI.Mapping
{
    public class AplicativoMapping : Profile
    {
        public AplicativoMapping(){
        CreateMap<Aluno, AlunoDTO>() .ReverseMap();
    }
    }
}
