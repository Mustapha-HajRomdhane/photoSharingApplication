﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace PhotoSharingApp.Model
{
    public class Photo
    {
        public Photo()
        {
           
        }
        public int PhotoID { get; set; }
        [Required]
        public string Title { get; set; }
        [DisplayName("Picture")]

        public Byte[] PhotoFile { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DisplayName("Created Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; }
        public string Owner { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public string ImageMimeType { get; set; }

    }
}