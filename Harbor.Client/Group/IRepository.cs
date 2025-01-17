﻿using Harbor.Client.Group.Model;
using Harbor.Client.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Harbor.Client.Group
{
    public interface IRepository
    {
        /// <summary>
        /// List repositories of the specified project
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<ApiResponse<List<Repositories>>> ListRepositoriesByProject(ListRepositoriesByProjectParam param);


        /// <summary>
        /// Get the repository specified by name
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<ApiResponse<Repositories>> GetRepository(GetRepositoryParam param);


        /// <summary>
        /// Delete the repository specified by name
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<ApiResponse<string>> DeleteRepository(DeleteRepositoryParam param);
    }
}
