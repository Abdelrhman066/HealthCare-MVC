﻿using AutoMapper;
using HealthCare.BusinessLogic.ViewModels.Doctor;
using HealthCare.BusinessLogic.ViewModels.Identity;
using HealthCare.BusinessLogic.ViewModels.Patient;
using HealthCare.DataAccess.Models;

namespace HealthCare.Presentaion.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Doctor, DoctorToDisplayVM>().ForMember(d => d.FullName, opt => opt.MapFrom(x => string.Join(' ', x.FirstName, x.LastName)));
            CreateMap<RegisterUserVM, AppUser>().ForMember(u => u.PasswordHash, opt => opt.MapFrom(x => x.Password));
            CreateMap<Patient, PatientToDisplayVM>();
            CreateMap<PatientToCreateVM, Patient>();
            CreateMap<PatientToEditVM, Patient>();
            CreateMap<Patient, PatientToEditVM>();

        }


    }
}
