﻿namespace PetStore.Services.Models.Brand
{
    using System.Collections.Generic;
    using PetStore.Services.Models.Toy;

    public class BrandWithToysServiceModel
    {
        public string Name { get; set; }

        public IEnumerable<ToyListingServiceModel> Toys { get; set; }
    }
}
