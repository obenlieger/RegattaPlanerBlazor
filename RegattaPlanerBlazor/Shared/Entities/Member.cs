using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0}, {1}", LastName, FirstName);
            }
        }
        public string FullNameClub
        {
            get
            {
                return string.Format("{0}, {1}, {2}", LastName, FirstName, ClubId);
            }
        }
        public int Birthyear { get; set; }
        public string Gender { get; set; }
        public bool isRented { get; set; }
        public int RentedToClubId { get; set; }
        public int RentYear { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
        public List<StartboatMember> StartboatMembers { get; set; }
        public List<StartboatStandby> StartboatStandbys { get; set; }
        public List<ReportedStartboatMember> ReportedStartboatMembers { get; set; }
        public List<ReportedStartboatStandby> ReportedStartboatStandbys { get; set; }
    }
}
