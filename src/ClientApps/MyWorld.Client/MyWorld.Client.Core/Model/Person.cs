﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MyWorld.Client.Core.Model
{

    public class Person
    {
        [JsonProperty("id")]
        public int Id { get; set; } = 0;

        [JsonProperty("firstname")]
        public string FirstName { get; set; } = string.Empty;

        [JsonProperty("lastname")]
        public string LastName { get; set; } = string.Empty;

        [JsonProperty("birthdate")]
        public DateTime? BirthDate { get; set; }

        string image;
        [JsonProperty("image")]
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                //if (!string.IsNullOrWhiteSpace(image))
                //{
                //    image += ":thumb";
                //}
            }
        }

        [JsonIgnore]
        public bool HasImage
        {
            get { return !string.IsNullOrWhiteSpace(image); }
        }

        //(CDLTLL - TBD)
        //ICommand imageCommand;
        //public ICommand iCommand =>
        //    imageCommand ?? (imageCommand = new Command(ExecuteImageCommand));

        //void ExecuteImageCommand()
        //{
        //    if (string.IsNullOrWhiteSpace(image))
        //        return;
        //    //(CDLTLL - TBD)
        //    //MessagingService.Current.SendMessage(MessageKeys.NavigateToImage, image);
        //}

    }
}
