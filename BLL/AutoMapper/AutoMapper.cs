using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using AutoMapper;
using DAL;

namespace BLL.AutoMapper
{
    class AutoMapper : Profile
    {
        public void MapperConfig()
        {
            CreateMap<Entities.ChildZone, DAL.EntitiesDTO.ChildZone>(MemberList.Source).PreserveReferences();
            CreateMap<Entities.Attractions, DAL.EntitiesDTO.Attractions>(MemberList.Source).PreserveReferences();
            CreateMap<Entities.Actors, DAL.EntitiesDTO.Actors>(MemberList.Destination).PreserveReferences();
        }
    }
}
