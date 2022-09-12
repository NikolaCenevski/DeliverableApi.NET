﻿using AutoMapper;
using DAL.Dto.Response;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Profiles
{
    public class OpenReportPostProfile :Profile
    {
        public OpenReportPostProfile()
        {
            CreateMap<ReportPost, OpenReportPostResponse>()
                .ForMember(dest =>
                dest.id,
                opt => opt.MapFrom(src => src.Id))
                .ForMember(dest =>
                dest.postId,
                opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest =>
                dest.name,
                opt => opt.MapFrom(src => src.post.Creator.Name))
                .ForMember(dest =>
                dest.phoneNumber,
                opt => opt.MapFrom(src => src.post.Creator.PhoneNumber))
                .ForMember(dest =>
                dest.surname,
                opt => opt.MapFrom(src => src.post.Creator.Surname))
                .ForMember(dest =>
                dest.manufacturingYear,
                opt => opt.MapFrom(src => src.post.car.Manufacturer))
                .ForMember(dest =>
                dest.car,
                opt => opt.MapFrom(src => src.post.car))
                .ForMember(dest =>
                dest.price,
                opt => opt.MapFrom(src => src.post.Price))
                .ForMember(dest =>
                dest.mileage,
                opt => opt.MapFrom(src => src.post.Mileage))
                .ForMember(dest =>
                dest.color,
                opt => opt.MapFrom(src => src.post.Color))
                .ForMember(dest =>
                dest.isNew,
                opt => opt.MapFrom(src => src.post.IsNew))
                .ForMember(dest =>
                dest.horsepower,
                opt => opt.MapFrom(src => src.post.Horsepower))
                .ForMember(dest =>
                dest.date,
                opt => opt.MapFrom(src => src.post.Date))
                .ForMember(dest =>
                dest.title,
                opt => opt.MapFrom(src => src.post.Title))
                .ForMember(dest =>
                dest.description,
                opt => opt.MapFrom(src => src.post.Description));

        }
    }
}
