using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDTOs, Announcement>();
            CreateMap<Announcement, AnnouncementAddDTOs>();

            CreateMap<AnnouncementListDTOs, Announcement>();
            CreateMap<Announcement, AnnouncementListDTOs>();
        }
    }
}
