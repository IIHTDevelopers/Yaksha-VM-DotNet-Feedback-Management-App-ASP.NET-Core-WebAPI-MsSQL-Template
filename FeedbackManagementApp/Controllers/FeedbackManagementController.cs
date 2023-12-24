using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FeedbackManagementApp.BusinessLayer.Interfaces;
using FeedbackManagementApp.BusinessLayer.ViewModels;
using FeedbackManagementApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementApp.Entities;

namespace FeedbackManagementApp.Controllers
{
    [ApiController]
    public class FeedbackManagementController : ControllerBase
    {
        private readonly IFeedbackManagementService  _feedbackService;
        public FeedbackManagementController(IFeedbackManagementService feedbackservice)
        {
             _feedbackService = feedbackservice;
        }

        [HttpPost]
        [Route("create-feedback")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateFeedback([FromBody] Feedback model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-feedback")]
        public async Task<IActionResult> UpdateFeedback([FromBody] FeedbackViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        [HttpDelete]
        [Route("delete-feedback")]
        public async Task<IActionResult> DeleteFeedback(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-feedback-by-id")]
        public async Task<IActionResult> GetFeedbackById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-feedbacks")]
        public async Task<IEnumerable<Feedback>> GetAllFeedbacks()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
