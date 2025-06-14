﻿using Microsoft.AspNetCore.Http;
using Resume.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Core.IServices
{
    public interface IAIService
    {
        Task<AIResponse> GetAIResponseById(int aiId);
        Task AddAiResponseAsync(IFormFile resumeFile,string extention,int userId);
        Task<IEnumerable<AIResponse>> GetAllAIResponsesAsync();
    }
}
