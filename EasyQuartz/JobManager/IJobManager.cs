﻿using System;
using System.Threading.Tasks;

namespace EasyQuartz
{
    public interface IJobManager
    {

        Task AddJobAsync(Type jobType, string cron, string id = "");

        Task RemoveJobAsync(Type jobType, string id = "");
    }
}