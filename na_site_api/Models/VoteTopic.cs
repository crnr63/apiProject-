using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace na_site_api.Models
{
    public class VoteTopic
    {
        public long Id { get; set; }
        public string Category { get; set; }
        public string VoteTopicFullText { get; set; }
        public bool Seconded { get; set; }
        public string BODseconder { get; set; }
        public string Proposer { get; set; }
        public bool VotingIsComplete { get; set; }
        public bool ProposalApproved { get; set; }
    }
}
