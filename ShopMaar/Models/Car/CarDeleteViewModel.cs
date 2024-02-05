namespace ShopMaar.Models.Car
{
    public class CarDeleteViewModel
    {
        public Guid? Id { get; set; } // creates unique id
        public string Brand { get; set; } // creates car brand
        public string Model { get; set; } // creates car model
        public decimal Price { get; set; } // creates car model
        public string Description { get; set; }
        public string GearShiftType { get; set; }

        public List<FileToApiViewModel> FileToApiViewModels { get; set; } = new List<FileToApiViewModel>(); //file viewmodels

        //database only properties

        public DateTime CreatedAt { get; set; } // when entry was added to the database
        public DateTime ModifiedAt { get; set; } //when was entry modified in the database
    }
}
