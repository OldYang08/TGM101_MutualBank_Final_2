using System.ComponentModel.DataAnnotations;

namespace MutualBank.Models.ViewModels
{
    public class Update
    {
        public string? UserLname { get; set; }
        public string? UserFname { get; set; }
        public string? UserNname { get; set; }
        public string? UserSex { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public string? UserBirthday { get; set; }
        public int? UserAreaId { get; set; }
        public string? UserCv { get; set; }
        public string? UserResume { get; set; }


    }
}
