using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator5 {
    public class ScenarioThree {
        public void Add()
        {
            var thumbBits = new byte[100];
            var fullBits = new byte[2000];
            using (var context = new PhotographContext())
            {
                var photo = new Photograph {Title = "My Dog", ThumbnailBits = thumbBits};
                var fullImage = new PhotographFullImage {HighResolutionBits = fullBits};
                photo.PhotographFullImage = fullImage;
                context.PhotographSet.Add(photo);
                context.SaveChanges();
            }
        }

        public void Print()
        {
            using (var context = new PhotographContext())
            {
                foreach (var photo in context.PhotographSet)
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes",
                        photo.Title,
                        photo.ThumbnailBits
                            .Length); // explicitly load the "expensive" entity,context.Entry(photo).Reference(p => p.PhotographFullImage).Load();Console.WriteLine("Full Image Size: {0} bytes",photo.PhotographFullImage.HighResolutionBits.Length);}}
            }
        }
    }
}