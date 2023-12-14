using FeedbackManagementApp.BusinessLayer.Interfaces;
using FeedbackManagementApp.BusinessLayer.Services.Repository;
using FeedbackManagementApp.BusinessLayer.ViewModels;
using FeedbackManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackManagementApp.BusinessLayer.Services
{
    public class FeedbackManagementService : IFeedbackManagementService
    {
        private readonly IFeedbackManagementRepository _repo;

        public FeedbackManagementService(IFeedbackManagementRepository repo)
        {
            _repo = repo;
        }

        public async Task<Feedback> CreateFeedback(Feedback employeeFeedback)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteFeedbackById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Feedback> GetAllFeedbacks()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Feedback> GetFeedbackById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Feedback> UpdateFeedback(FeedbackViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
