using netCore7api.Models.Dto;

namespace netCore7api.Data
{
    public class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>()
        {
          new VillaDto { Id=1 , Name= "Pool view" , Sqft=100 , Occupancy=4 },
          new VillaDto { Id = 2, Name = "Beach view" , Sqft=300 , Occupancy=3 }
        };
    }
}

