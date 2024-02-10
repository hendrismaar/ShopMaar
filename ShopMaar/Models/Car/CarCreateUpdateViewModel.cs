namespace ShopMaar.Models.Car
{
    public class CarCreateUpdateViewModel
    {
        public Guid? Id { get; set; } 
        public string Brand { get; set; } 
        public string Model { get; set; } 
        public decimal Price { get; set; } 
        public string Description { get; set; }
        public string GearShiftType { get; set; }

        public List<IFormFile> Files { get; set; } 
        public List<FileToApiViewModel> FileToApiViewModels { get; set; } = new List<FileToApiViewModel>(); 

        //database only properties

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; } 
    }
}
