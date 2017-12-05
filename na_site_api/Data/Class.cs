using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using na_site_api.Models;
namespace na_site_api.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            

            // Look for any students.
            if (context.TodoItems.Any())
            {
                return;   // DB has been seeded
            }

            var todoitems = new TodoItem[]
            {
    
            new TodoItem{Id=1223434,Name="Alexandra",IsComplete=true},
            new TodoItem{Id=3456789854,Name="Bob",IsComplete=false},
            };
            foreach (TodoItem t in todoitems)
            {
                context.TodoItems.Add(t);
            }
          

            // Look for any students.
            if (context.VoteTopics.Any())
            {
                return;   // DB has been seeded
            }

            var votetopics = new VoteTopic[]
            {

            new VoteTopic{
                 Id=32342381,
                Category ="construction",
                VoteTopicFullText ="This is a sample topic to be voted upon",
                Seconded =true,
                BODseconder ="tbd",
                Proposer ="khalil",
                VotingIsComplete =false,
                ProposalApproved=false },
              new VoteTopic{
                  Id=3234238,
                Category ="revenue",
                VoteTopicFullText ="This is another sample topic to be voted upon",
                Seconded =true,
                BODseconder ="tbd",
                Proposer ="marsha",
                VotingIsComplete =false,
                ProposalApproved=false }
            };
            foreach (VoteTopic t in votetopics)
            {
                context.VoteTopics.Add(t);
            }
            context.SaveChanges();



        }

    }
       
}
