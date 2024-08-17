using RunGroupApp.Data.Enum;
using RunGroupApp.Models;

namespace RunGroupApp.ViewModels
{
    public class CreateClubViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public IFormFile Image { get; set; }
        public string URL { get; set; }
        public ClubCategory ClubCategory { get; set; }
    }
}
