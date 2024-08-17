using RunGroupApp.Data.Enum;
using RunGroupApp.Models;

namespace RunGroupApp.ViewModels
{
    public class EditClubViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public ClubCategory ClubCategory { get; set; }
        public int? AddressId { get; internal set; }
        public string? URL { get; internal set; }
    }
}
