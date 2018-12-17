﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace InstantReview.Login
{
    public interface IConnectionHandler
    {
        void SaveUsagePrivileges(string token);

        bool CheckUsagePrivileges();

        void DeletePrivileges();

        Task<HttpResponseMessage> Login(string email, string password);

        bool CheckTokenValidity(string token);

        Task<HttpResponseMessage> Register(string email, string password, string name, string birthday, string gender);

        Task<bool> UploadReview();

        Task<List<Review>> DownloadReviewList();
    }
}