using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using na_site_api.Models;
using System.Linq;

namespace na_site_api.Controllers
{
    [Route("api/votetopics")]
    public class VoteTopicsController : Controller
    {
        private readonly TodoContext _context;

        public VoteTopicsController(TodoContext context)
        {
            _context = context;

            if (_context.VoteTopics.Count() == 0)
            {
                var votetopics = new VoteTopic[]
              {

            new VoteTopic{
                 
                Category ="construction",
                VoteTopicFullText ="This is a sample topic to be voted upon",
                Seconded =true,
                BODseconder ="tbd",
                Proposer ="khalil",
                VotingIsComplete =false,
                ProposalApproved=false },
              new VoteTopic{
                  
                Category ="revenues",
                VoteTopicFullText ="This is another sample topic to be voted upon",
                Seconded =true,
                BODseconder ="tbd",
                Proposer ="marsha",
                VotingIsComplete =false,
                ProposalApproved=false }
              };
                foreach (VoteTopic t in votetopics)
                {
                    _context.VoteTopics.Add(t);
                }
               
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<VoteTopic> GetAll()
        {
            return _context.VoteTopics.ToList();
        }
        [HttpGet("{id}", Name = "GetVoteTopic")]
        public IActionResult GetById(long id)
        {
            var item = _context.VoteTopics.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPost]
        public IActionResult Create([FromBody] VoteTopic item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.VoteTopics.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetVote", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] VoteTopic item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var VoteTopic = _context.VoteTopics.FirstOrDefault(t => t.Id == id);
            if (VoteTopic == null)
            {
                return NotFound();
            }

            VoteTopic.Category = item.Category;
            VoteTopic.VoteTopicFullText = item.VoteTopicFullText;
            VoteTopic.Seconded = item.Seconded;
            VoteTopic.BODseconder = item.BODseconder;
            VoteTopic.Proposer = item.Proposer;
            VoteTopic.VotingIsComplete = item.VotingIsComplete;
            VoteTopic.ProposalApproved = item.ProposalApproved;

            _context.VoteTopics.Update(VoteTopic);
            _context.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var proposal = _context.VoteTopics.FirstOrDefault(t => t.Id == id);
            if (proposal == null)
            {
                return NotFound();
            }

            _context.VoteTopics.Remove(proposal);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}