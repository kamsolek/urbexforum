using UrbexForum.Model;

namespace UrbexForum.Repositories
{
    public class PlaceRepository : IPlaceRepository
    {
        private readonly AppDbContext appDbContext = new AppDbContext();

        public PlaceRepository()
        {
            appDbContext.Database.EnsureCreated();
        }

        public bool CreatePlace(Place entity)
        {
            appDbContext.Places.Add(entity);
            return appDbContext.SaveChanges() == 1;
        }
        // ReadAll
        public List<Place> ReadPlaces()
        {
            return appDbContext.Places.ToList();
        }
        // Read
        public Place ReadPlace(int id)
        {
            return appDbContext.Places.Find(id) ?? new Place();
        }
        // Update
        public bool UpdatePlace(Place entity)
        {
            appDbContext.Places.Update(entity);

            return appDbContext.SaveChanges() == 1;
        }
        // Delete
        public bool DeletePlace(Place entity)
        {
            appDbContext.Places.Remove(entity);
            return appDbContext.SaveChanges() == 1;
        }
    }
}
