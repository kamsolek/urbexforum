using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UrbexForum.Model;
using UrbexForum.Repositories;


namespace UrbexForum.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IPlaceRepository _placeRepository;
        public CreateModel(IPlaceRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }

        [BindProperty]
        public Place Place { get; set; }

        public IFormFile Uploadfile { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Uploadfile != null)
            {
                using MemoryStream ms = new MemoryStream();
                Uploadfile.CopyTo(ms);
                Place.Image = ms.ToArray();
            }
            if (_placeRepository.CreatePlace(Place))
            {
                return RedirectToPage("/Index");
            }
            else
                return RedirectToPage("/Create");
        }
    }
}
