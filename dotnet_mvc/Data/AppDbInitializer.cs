using dotnet_mvc.Models;

namespace dotnet_mvc.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context?.Database.EnsureCreated();

                if(context != null && !context.tblT_Ages.Any())
                {
                    for (int i = 18; i <= 40; i++)
                    {
                        context.tblT_Ages.Add(new tblT_Age() { Age = i });
                    };
                    context.SaveChanges();
                }

                if(context != null && !context.tblM_Hobbies.Any())
                {
                    context.tblM_Hobbies.AddRange(new List<tblM_Hobby>() 
                    {
                        new tblM_Hobby() 
                        {
                            Id = 'A',
                            Name = "Sepak Bola",
                        },
                        new tblM_Hobby() 
                        {
                            Id = 'B',
                            Name = "Badminton",
                        },
                        new tblM_Hobby() 
                        {
                            Id = 'C',
                            Name = "Tenis",
                        },
                        new tblM_Hobby() 
                        {
                            Id = 'D',
                            Name = "Renang",
                        },
                        new tblM_Hobby() 
                        {
                            Id = 'E',
                            Name = "Bersepeda",
                        }
                    });
                    context.SaveChanges();
                }

                if(context != null && !context.tblM_Genders.Any())
                {
                    context.tblM_Genders.AddRange(new List<tblM_Gender>() 
                    {
                        new tblM_Gender() 
                        {
                            Id = 1,
                            Name = "Pria",
                        },
                        new tblM_Gender() 
                        {
                            Id = 2,
                            Name = "Wanita",
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}