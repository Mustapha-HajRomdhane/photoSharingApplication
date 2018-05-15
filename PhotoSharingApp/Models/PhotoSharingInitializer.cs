using PhotoSharingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhotoSharingApp.Models
{
    public class PhotoSharingInitializer : DropCreateDatabaseAlways<PhotoSharingContext>
    {
        protected override void Seed(PhotoSharingContext context)
        {
            List<Commentaire> comments = new List<Commentaire>();
            List<Photo> photo = new List<Photo>();
            Photo ph = new Photo();
            ph.Title = "Test";
            ph.Description = "Swalallala";
            ph.Owner = "Me";
            ph.PhotoFile = System.IO.File.ReadAllBytes("\\Users\\Mustapha Haj Romdhan\\photoSharingApplication\\PhotoSharingApp\\Images\\mustapha.png");
            ph.CreatedDate = DateTime.Now;
            ph.ImageMimeType = "image/png";
                photo.Add(ph);
            foreach (Photo p in photo)
                context.Photos.Add(p);
            context.SaveChanges();
            Commentaire comm = new Commentaire();
            comm.PhotoID = 1;
            comm.User = "NaokiSato";
            comm.Subject = "Test comment";
            comm.Body = "this comment should appear in the photo";
            comments.Add(comm);
            foreach (Commentaire c in comments)
                context.Comments.Add(c);
        }
       
        


    }
}