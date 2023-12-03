using CoffeeApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.ViewModel.DalleChallengeVM
{
    public class DashboardViewModel
    {
        public ObservableCollection<Profile> Profiles { get; set; }
        public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }

        public DashboardViewModel()
        {
            
            this.LoadData();

        }

        public void LoadData() 
        {
            this.Profiles = new ObservableCollection<Profile>()
            {
                new Profile() 
                {
                    Name = "Johannes",
                    ProfileImage = "profile1.jpg",
                    NoPhotos = 12
                },
                new Profile()
                {
                    Name = "Iwan",
                    ProfileImage = "profile2.jpg",
                    NoPhotos = 5
                },
                new Profile()
                {
                    Name = "Hans",
                    ProfileImage = "profile3.jpg",
                    NoPhotos = 25
                }
            };
            this.GeneratedImages = new ObservableCollection<GeneratedImage> 
            {
                new GeneratedImage()
                {
                    ImagePath = "city1.jpg",
                    MainKeyword = "City",
                    Keywords = new List<string>() { "City", "Urban", "Buildings" }
                },
                new GeneratedImage()
                {
                    ImagePath = "city2.jpg",
                    MainKeyword = "Mordor",
                    Keywords = new List<string>() { "City", "Mountains", "Trees" }
                },
            };
        }
    }
}
