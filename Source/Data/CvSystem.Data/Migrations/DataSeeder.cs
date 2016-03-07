namespace CvSystem.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    using CvSystem.Data.Models;

    public static class DataSeeder
    {
        internal static void SeedInitialCv(CvSystemDbContext context)
        {
            var educations = new List<Education>();
            educations.Add(new Education()
            {
                School = "Foreign Language High School \"Prof.dr. Asen Zlatarov\", Veliko Tarnovo (Bulgaria)",
                From = 2008,
                To = 2012,
                Degree = Degree.HighSchool,
                FieldOfStudy = "Profile with German and English",
                Courses = new List<Course>()
                {
                    new Course() { CourseName = "German" },
                    new Course() { CourseName = "English" }
                }
            });
            educations.Add(new Education()
            {
                School = "Technical University - Sofia",
                From = 2012,
                To = 2016,
                Degree = Degree.Bachelor,
                FieldOfStudy = "Computer Science and Technology",
                Courses = new List<Course>()
                {
                    new Course() { CourseName = "Programming basics" },
                    new Course() { CourseName = "Databases" },
                    new Course() { CourseName = "Algorithms" },
                    new Course() { CourseName = "Cryptography" },
                    new Course() { CourseName = "Computer architectures" },
                    new Course() { CourseName = "Hardware components - basics" }
                }
            });
            educations.Add(new Education()
            {
                School = "Telerik Academy",
                From = 2015,
                To = 2016,
                Degree = Degree.Specialist,
                FieldOfStudy = "Software Developer",
                Courses = new List<Course>()
                {
                    new Course() { CourseName = "Programming with C# - Part One" },
                    new Course() { CourseName = "Programming with C# - Part Two" },
                    new Course() { CourseName = "Object-Oriented Programming with C#" },
                    new Course() { CourseName = "HTML Basics" },
                    new Course() { CourseName = "CSS Styling" },
                    new Course() { CourseName = "JavaScript - Fundamentals" },
                    new Course() { CourseName = "JavaScript - Object-Oriented Programming" },
                    new Course() { CourseName = "JavaScript - Applications" },
                    new Course() { CourseName = "High-Quality-Code with C#" },
                    new Course() { CourseName = "Databases" },
                    new Course() { CourseName = "Data Structures and Algorithms" },
                    new Course() { CourseName = "Web services and cloud" },
                    new Course() { CourseName = "Single page Applications with JavaScript" },
                    new Course() { CourseName = "End-to-end JavaScript Applications" },
                    new Course() { CourseName = "ASP.NET Web Forms" },
                    new Course() { CourseName = "ASP.NET MVC" }
                }
            });

            var certificates = new List<Certification>();
            certificates.Add(new Certification()
            {
                CertificateName = "Communication and analytical skills",
                Authority = "Trainer.BG",
                CertificateUrl = "http://telerikacademy.com/Certificates/View/1217/045d5eaf",
                From = new DateTime(2015, 6, 3)
            });
            certificates.Add(new Certification()
            {
                CertificateName = "Business acumen training series",
                Authority = "PwC",
                CertificateUrl = "http://telerikacademy.com/Certificates/View/1500/15b88d8a",
                From = new DateTime(2015, 11, 2)
            });
            certificates.Add(new Certification()
            {
                CertificateName = "C# Developer",
                Authority = "Telerik Academy",
                CertificateUrl = "http://telerikacademy.com/Certificates/View/1603/28af977f",
                From = new DateTime(2015, 12, 8)
            });
            certificates.Add(new Certification()
            {
                CertificateName = "JavaScript Developer",
                Authority = "Telerik Academy",
                CertificateUrl = "http://telerikacademy.com/Certificates/View/1681/27117c17",
                From = new DateTime(2016, 2, 25)
            });
            certificates.Add(new Certification()
            {
                CertificateName = "Web Developer",
                Authority = "Telerik Academy",
                CertificateUrl = "http://telerikacademy.com/Certificates/View/1939/a66648d3",
                From = new DateTime(2016, 2, 25)
            });

            var cv = new CurriculumVitae()
            {
                IsChoosen = true,
                FirstName = "Ivelina",
                LastName = "Popova",
                Address = "San Stefano 5",
                City = "Gorna Oryahovitsa",
                Country = "Bulgaria",
                Telephone = "+359 8970 17619",
                Email = "iwelina.popova@gmail.com",
                Website = "http://ivpopova.info/",
                Facebook = "https://www.facebook.com/Iwelina.Popova",
                LinkedIn = "https://www.linkedin.com/in/popovaivelina",
                GitHub = "https://github.com/iwelina-popova",
                Educations = educations,
                Certificates = certificates
            };

            context.CurriculumVitaes.AddOrUpdate(cv);
            context.SaveChanges();
        }
    }
}
