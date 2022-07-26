﻿using System;
using Lennt.Dto.Vacancy;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lennt.Dto;

namespace Lennt.Services.Interfaces.VacancyInterface
{
    public interface IVacancyAppService
    {
        Task<IResponse<bool>> Create(VacancyDto input, long userId);
        Task<IResponse<bool>> Update(VacancyDto input);
        Task<IResponse<bool>> SubmitProposal(long vacancyId);
        Task<IResponse<GetVacancyDto>> Get(long id);
        Task<IResponse<GetMyVacanciesDto>> GetMyVacanciesDetails(long id);
        Task<IResponse<List<GetVacancyDto>>> GetMyOffers(int? categoryId, string? titleContains, string? location);
        Task<IResponse<List<GetMyVacanciesListDto>>> GetMyVacancies(int? categoryId, string? titleContains, string? location);
        Task<IResponse<List<GetVacancyDto>>> GetList(int? categoryId, string? titleContains, string? location);
        Task<IResponse<bool>> Approve(long vacancyId);
        Task<IResponse<bool>> ApproveByOwner(long vacancyId, long personId);
        Task<IResponse<bool>> Finish(long vacancyId);

    }
}

