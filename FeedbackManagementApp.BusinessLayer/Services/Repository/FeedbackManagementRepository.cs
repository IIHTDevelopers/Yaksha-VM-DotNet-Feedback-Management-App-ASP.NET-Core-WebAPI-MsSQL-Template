using Microsoft.EntityFrameworkCore;
using FeedbackManagementApp.BusinessLayer.ViewModels;
using FeedbackManagementApp.DataLayer;
using FeedbackManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FeedbackManagementApp.BusinessLayer.Services.Repository
{
    public class FeedbackManagementRepository : IFeedbackManagementRepository
    {
        private readonly FeedbackManagementAppDbContext _dbContext;
        public FeedbackManagementRepository(FeedbackManagementAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Feedback> CreateFeedback(Feedback FeedbackModel)
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