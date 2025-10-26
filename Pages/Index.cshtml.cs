using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UrbexForum.Model;
using UrbexForum.Repositories;

namespace UrbexForum.Pages;

public class IndexModel : PageModel
{
    private readonly IPlaceRepository _placeRepository;

    public IndexModel(IPlaceRepository placeRepository)
    {
        _placeRepository = placeRepository;
    }

    public List<Place> Places { get; set; } = new();

    public void OnGet()
    {
        Places = _placeRepository.ReadPlaces();
    }

    public IActionResult OnPost(int id)
    {
        var place = _placeRepository.ReadPlace(id);
        if (place != null)
        {
            _placeRepository.DeletePlace(place);
        }
        return RedirectToPage();
    }
}
