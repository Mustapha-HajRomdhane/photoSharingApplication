﻿using PhotoSharingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PhotoSharingApp.Models
{
    public class PhotoSharingInitializer : DropCreateDatabaseAlways<PhotoSharingContext>
    {
        protected override void Seed(PhotoSharingContext context)
        {
            Debug.WriteLine("lllllllllla");

            List<Comment> comments = new List<Comment>();
            List<Photo> photo = new List<Photo>();
            Photo ph = new Photo();
            ph.Title = "My Photo";
            ph.Description = "Swalallala";
            ph.Owner = "Me";
            ph.PhotoFile = System.IO.File.ReadAllBytes("\\Users\\mustapha.png");
            ph.CreateDate = DateTime.Now;
            ph.ImageMimeType = "image/png";
            photo.Add(ph);
            foreach (Photo p in photo)
            {
                context.Photos.Add(p);
            }
                
            context.SaveChanges();
            Comment comm = new Comment();
            comm.PhotoID = 1;
            comm.User = "NaokiSato";
            comm.Subject = "Test comment";
            comm.Body = "this comment should appear in the photo";
            comments.Add(comm);
            foreach (Comment c in comments)
            {
                context.Comments.Add(c);
            }
                
            context.SaveChanges();
            base.Seed(context);
        }




    }
}