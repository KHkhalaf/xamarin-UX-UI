using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin_UX.Models;

namespace Xamarin_UX.ViewModels
{
    public class ProfileViewModel
    {
        public ObservableCollection<Friend> friends { get; set; }
        public ObservableCollection<PrincipalComents> principalComments { get; set; }
        public ObservableCollection<PersonalInformation> personalInformation { get; set; }
        public ObservableCollection<PhotoRoll> photoRoll { get; set; }
        public ProfileViewModel()
        {

            photoRoll = new ObservableCollection<PhotoRoll>
            {
                new PhotoRoll {  Picture = "ProfileImage.jpg"   },
                new PhotoRoll {  Picture = "SunflowersTL.jpg"   },
                new PhotoRoll {  Picture = "TimeLineImage.jpg"  },
                new PhotoRoll {  Picture = "Girasol.jpg"        },
                new PhotoRoll {  Picture = "Agriculture.jpg"    },
                new PhotoRoll {  Picture = "Water.jpg"          },
            };


            personalInformation = new ObservableCollection<PersonalInformation>
            {
                new PersonalInformation
                {
                    Picture = "HomeIcon.png",
                    Description = "Live in Damascus , Syria"
                },
                new PersonalInformation
                {
                    Picture = "FromIcon.png",
                    Description = "From Syria"
                },
                new PersonalInformation
                {
                    Picture = "CivilStatusIcon.png",
                    Description = "Single"
                },
                 new PersonalInformation
                {
                    Picture = "LinkIcon.png",
                    Description = "KHkhalil12345@outlook.com"
                }
            };

            friends = new ObservableCollection<Friend>
            {
                new Friend
                {
                    Picture = "Friend1.jpg",
                    Name = "Vanessa Weiss"
                },
                new Friend
                {
                    Picture = "Friend2.jpg",
                    Name = "Paola Willys"
                },
                new Friend
                {
                    Picture = "Friend3.jpg",
                    Name = "Katty Prince"
                },
                new Friend
                {
                    Picture = "Friend4.jpg",
                    Name = "Amanda Scott"
                },
                new Friend
                {
                    Picture = "Friend5.jpg",
                    Name = "Keily Red"
                },
                new Friend
                {
                    Picture = "Friend6.jpg",
                    Name = "Josefa Perez"
                }
            };

            principalComments = new ObservableCollection<PrincipalComents>
            {
                 new PrincipalComents
                {
                    UserIcon = "ProfileImage",
                    PictureComment = "SunflowersTL.jpg",
                    Name="Leomaris Reyes",
                    Date="20 Junio 2019",
                    Comment="Hello people!!!",
                    Funny=true,
                    Like=true,
                    Love=false,
                    TotalComents="50 comments"
                },
                  new PrincipalComents
                {
                    UserIcon = "ProfileImage",
                    PictureComment = "Girasol.jpg",
                    Name="Leomaris Reyes",
                    Date="8 Junio 2019",
                    Comment="what do you think about this picture..? 😉",
                    Funny=true,
                    Like=false,
                    Love=true,
                    TotalComents="10 comments"
                },
                  new PrincipalComents
                {
                    UserIcon = "ProfileImage",
                    PictureComment = "Agriculture.jpg",
                    Name="Leomaris Reyes",
                    Date="8 Junio 2019",
                    Comment="Good morning",
                    Funny=true,
                    Like=false,
                    Love=true,
                    TotalComents="17 comments"
                },
                  new PrincipalComents
                {
                    UserIcon = "ProfileImage",
                    PictureComment = "Water.jpg",
                    Name="Leomaris Reyes",
                    Date="8 Junio 2019",
                    Comment="good afternoon",
                    Funny=true,
                    Like=false,
                    Love=true,
                    TotalComents="1 comments"
                }
            };

        }
    }
}
