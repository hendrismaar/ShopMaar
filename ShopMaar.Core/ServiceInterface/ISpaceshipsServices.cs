using ShopMaar.Core.Domain.Spaceship;
using ShopMaar.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopMaar.Core.Domain.Spaceship;
using ShopMaar.Core.Dto;

namespace ShopMaar.Core.ServiceInterface
{
    public interface ISpaceshipsServices
    {
        Task<Spaceship> Add(SpaceshipDto dto);
    }
}