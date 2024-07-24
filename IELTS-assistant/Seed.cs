//using IELTS_assistant.Data;
//using IELTS_assistant.Models;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System;
//using System.Linq;

//namespace IELTS_assistant
//{
//    public class Seed
//    {
//        private readonly DataContext dataContext;
//        public Seed(DataContext context)
//        {
//            this.dataContext = context;
//        }
//        public void SeedDataContext()
//        {
//            if (!dataContext.Users.Any())
//            {
//                var users = new List<User>();
//                {
//                    new User()
//                    {
//                        Email = "ahmadjonovabduboriy@gmail.com",
//                        FirstName = "Abduboriy",
//                        LastName = "Ahmadjonov",    
//                        HashPassword = null,
//                        CreatedAt = DateTimeOffset.Now,
//                        UserName = "Abduboriy Ahmadjonov"
//                    };
//                    new StudyMaterial()
//                    {
//                        Content = "Reading",
//                        Title = "Article",
//                        Description = "From website",
//                        CreatedAt = DateTimeOffset.Now,
//                        MaterialId = 0
//                    };

//                    new User()
//                    {
//                        Email = "onovabduboriy@gmail.com",
//                        FirstName = "yusup",
//                        LastName = "Ahmadjsadasdonov",
//                        HashPassword = null,
//                        CreatedAt = DateTimeOffset.Now,
//                        UserName = "Abdiy Ahv"
//                    };
//                    new StudyMaterial()
//                    {
//                        Content = "Listening",
//                        Title = "book",
//                        Description = "From IELTS",
//                        CreatedAt = DateTimeOffset.Now,
//                        MaterialId = 0
//                    };
//                }

//                dataContext.Users.AddRange(users);
//                dataContext.SaveChanges();
//            }
//        }
//    }
//}







using IELTS_assistant.Data;
using IELTS_assistant.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace IELTS_assistant
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Users.Any())
            {
                var users = new List<User>
                {
                    new User
                    {
                        UserId = 1,
                        Email = "ahmadjonovabduboriy@gmail.com",
                        FirstName = "Abduboriy",
                        LastName = "Ahmadjonov",
                        HashPassword = null,
                        CreatedAt = DateTimeOffset.Now,
                        UserName = "Abduboriy Ahmadjonov"
                    },
                    new User
                    {
                        UserId = 2,
                        Email = "onovabduboriy@gmail.com",
                        FirstName = "yusup",
                        LastName = "Ahmadjsadasdonov",
                        HashPassword = null,
                        CreatedAt = DateTimeOffset.Now,
                        UserName = "Abdiy Ahv"
                    }
                };

                var studyMaterials = new List<StudyMaterial>
                {
                    new StudyMaterial
                    {
                        StudyMaterialId = 1,
                        Content = "Reading",
                        Title = "Article",
                        Description = "From website",
                        CreatedAt = DateTimeOffset.Now,
                        MaterialId = 0
                    },
                    new StudyMaterial
                    {
                        StudyMaterialId = 2,
                        Content = "Listening",
                        Title = "book",
                        Description = "From IELTS",
                        CreatedAt = DateTimeOffset.Now,
                        MaterialId = 0
                    }
                };

                dataContext.Users.AddRange(users);
                dataContext.StudyMaterials.AddRange(studyMaterials); // Add study materials to the context
                dataContext.SaveChanges();
            }
        }
    }
}
