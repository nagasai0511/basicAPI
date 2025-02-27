﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BasicAPI.Services.DTO
{
    public class BookCreatedDTO
    {

        [MaxLength(60)]
        [Required(ErrorMessage = "The field (Name) is Required.")]
        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        // [Required(ErrorMessage = "Field (AuthorId) is Required.")]
        //public int AuthorId { get; set; }

        public List<int> AuthorsId { get; set; }

    }
}
