using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UrbexForum.Model;
using UrbexForum.Repositories;

namespace UrbexForum.Pages
{
    public class UpdateModel : PageModel
    {
        private readonly IPlaceRepository _placeRepository;
        public UpdateModel(IPlaceRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }
        [BindProperty]
        public Place Place { get; set; }

        [BindProperty]
        public IFormFile PhotoFile { get; set; }

        public void OnGet(int Id)
        {
            Place = _placeRepository.ReadPlace(Id);
        }

        public IActionResult OnPost(int Id)
        {
            Place itemToUpdate = _placeRepository.ReadPlace(Id);
            itemToUpdate.Name = Place.Name;
            itemToUpdate.Country = Place.Country;
            itemToUpdate.Description = Place.Description;

            if (PhotoFile != null)
            {
                using MemoryStream ms = new MemoryStream();
                PhotoFile.CopyTo(ms);
                itemToUpdate.Image = ms.ToArray();
            }

            _placeRepository.UpdatePlace(itemToUpdate);
            return RedirectToPage("/Index");
        }
    }
}
