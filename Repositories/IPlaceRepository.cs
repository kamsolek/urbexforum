using UrbexForum.Model;

namespace UrbexForum.Repositories
{
    public interface IPlaceRepository
    {
        // Create
        bool CreatePlace(Place entity);
        // ReadAll
        List<Place> ReadPlaces();
        // Read
        Place ReadPlace(int id);
        // Update
        bool UpdatePlace(Place entity);
        // Delete
        bool DeletePlace(Place entity);

    }
}
