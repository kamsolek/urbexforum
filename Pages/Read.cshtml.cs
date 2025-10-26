using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UrbexForum.Model;
using UrbexForum.Repositories;

namespace UrbexForum.Pages
{
    public class ReadModel : PageModel
    {
        private readonly IPlaceRepository _placeRepository;
        public ReadModel(IPlaceRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }

        public Place Place { get; set; }
        public void OnGet(int Id)
        {
            Place = _placeRepository.ReadPlace(Id);
        }
    }
}
