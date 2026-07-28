using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ImageGalleryCarousel
{
    public class GalleryViewModel
    {
        public ObservableCollection<TouristPlace> Places { get; set; }

        public GalleryViewModel()
        {
            Places = new ObservableCollection<TouristPlace>()
            {
                new TouristPlace()
                {
                    Image = "paris.jpg",
                    Title = "Eiffel Tower",
                    Country = "Paris, France"
                },

                new TouristPlace()
                {
                    Image = "venice.jpg",
                    Title = "Venice Canal",
                    Country = "Venice, Italy"
                },

                new TouristPlace()
                {
                    Image = "santorini.jpg",
                    Title = "Santorini",
                    Country = "Greece"
                },

                new TouristPlace()
                {
                    Image = "maldives.jpg",
                    Title = "Maldives Beach",
                    Country = "Maldives"
                },

                new TouristPlace()
                {
                    Image = "swissalps.jpg",
                    Title = "Swiss Alps",
                    Country = "Switzerland"
                }
            };
        }
    }
}
