using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMaar.Core.Dto
{
    public class CarDto
    {
        public Guid? Id { get; set; }
        public string Brand { get; set; } 
        public string Model { get; set; } 
        public decimal Price { get; set; } 
        public string Description { get; set; }
        public string GearShiftType { get; set; }

        public List<IFormFile> Files { get; set; } //files 
        public IEnumerable<FileToApiDto> FileToApiDtos { get; set; } = new List<FileToApiDto>(); 

        //database only properties

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; } 
    }
}
