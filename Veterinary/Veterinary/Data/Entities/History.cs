﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Data.Entities
{
    public class History
    {
        public int Id { get; set; }

        public ServiceType ServiceType { get; set; }

        [Display(Name = "Description*")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Description { get; set; }

        [Display(Name = "Date*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }
    }

}
