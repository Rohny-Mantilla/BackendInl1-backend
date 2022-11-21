using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BackendInl.Context;
using BackendInl.Models;
using BackendInl.Models.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendInl.Controllers
{
    [Route("api/[controller]")]
    public class CommentsController : Controller
    {
        private readonly SqlDataContext _context;

        public CommentsController(SqlDataContext context)
        {
            _context = context;
        }



        [HttpPost]
        public async Task<IActionResult> Create(CommentRequest req)
        {
            try
            {
                var commentEntity = new CommentEntity
                {
                    Comment = req.Comment,
                    Created = DateTime.Now,
                    IssueId = req.IssueId,
                    CustomerId = req.CustomerId
                };
                _context.Add(commentEntity);
                await _context.SaveChangesAsync();

                return new OkObjectResult(commentEntity);
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return new BadRequestResult();
        }
    }
}

