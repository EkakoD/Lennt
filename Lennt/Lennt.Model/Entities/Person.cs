﻿using System;

namespace Lennt.Model.Entities
{
    public class Person : Base
    {
        public Person()
        {
            //Categories = new HashSet<Category>();
            //Contacts = new HashSet<Contact>();
            //PersonVacancies = new HashSet<PersonVacancy>();
        }


        public Person(
            string firstname,
            string lastname,
            string username,
            DateTime birthDate,
            string location,
            string title,
            string description,
            string skills,
            string phoneNumber,
            int reviewCount,
            string password,
            int review
            ) : this()
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            BirthDate = birthDate;
            Location = location;
            Title = title;
            Description = description;
            Skills = skills;
            PhoneNumber = phoneNumber;
            Review = review;
            ReviewCount = reviewCount;
            Password = password;
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public string PhoneNumber { get; set; }
        public int? Review { get; set; }
        public int? ReviewCount { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        //public virtual ICollection<PersonVacancy> PersonVacancies { get; private set; }


    }
}
