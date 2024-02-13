namespace StudentAppMint.Data
{
    public class FacultyService
    {
        private readonly DataService _dataService;

        public FacultyService(DataService dataService)
        {
            _dataService = dataService;
        }

        public List<Faculty> GetFaculties()
        {
            var shop = _dataService.ExecReturnList<Faculty>("GetAllFaculties", null).ToList();
            return shop;
        }
    }
}
