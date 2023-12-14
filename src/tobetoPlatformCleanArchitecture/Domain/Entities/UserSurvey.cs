﻿using Core.Persistence.Repositories;

namespace Domain.Entities;
public class UserSurvey : Entity<Guid>
{
    public int UserId { get; set; }
    public Guid SurveyId { get; set; }

    public  AppUser User { get; set; }
    public  Survey Survey { get; set; }
}
