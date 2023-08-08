﻿using CodingTracker.MartinL_no.Models;

namespace CodingTracker.MartinL_no.DAL;

internal interface ICodingSessionRepository
{
    public List<CodingSession> GetCodingSessions();

    public bool InsertCodingSession(CodingSession codingSession);

    public bool DeleteCodingSession(CodingSession codingSession);

    public bool UpdateCodingSession(CodingSession codingSession);
}
