﻿using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            //Pets = new List<ResponseShortPetJson>
            //{
            //    new ResponseShortPetJson { Id = 1, Name = "Buddy", Type = PetType.Dog },
            //    new ResponseShortPetJson { Id = 2, Name = "Mittens", Type = PetType.Cat },
            //    new ResponseShortPetJson { Id = 3, Name = "Goldie", Type = PetType.Dog }
            //}
        };
    }
}