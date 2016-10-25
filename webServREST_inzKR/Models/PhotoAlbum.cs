using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace webServREST_inzKR.Models
{
    public class PhotoAlbum
    {
        public int Id { get; set; }
        public OccasionType Occasion {get; set;}
        public string Title { get; set; }
        public string Description { get; set; }
        public Bitmap Photo { get; set; }
        public ObservableCollection<Person> ListOfPeopleOnPhoto = new ObservableCollection<Person>();
        public DateTime addedTime { get; set; }

        public PhotoAlbum(int Id, OccasionType Occasion, string Title, string Description, Bitmap Photo, 
            ObservableCollection<Person> ListOfPeopleOnPhoto)
        {
            this.Id = Id;
            this.Occasion = Occasion;
            this.Title = Title;
            this.Description = Description;
            this.Photo = Photo;
            this.ListOfPeopleOnPhoto = ListOfPeopleOnPhoto;
            this.addedTime = addedTime;
        }
    }

    public enum OccasionType
    {
        family,
        pets,
        holidays,
        love,
        ceremonies
    }
}