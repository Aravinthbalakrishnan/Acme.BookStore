﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.UserTypes
{
    public class CreateUpdateUserTypeDto
    {

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string code { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }

    }
}
