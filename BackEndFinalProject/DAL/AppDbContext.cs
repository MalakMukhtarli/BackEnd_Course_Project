using BackEndFinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BackEndFinalProject.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryCourse> CategoryCourses { get; set; }
        public DbSet<CategoryEvent> CategoryEvents { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherDetail> TeacherDetails { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<HomeVideo> HomeVideos { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Bio> Bios { get; set; }

        // # # # # # # # # # # # # # # # Data # # # # # # # # # # # # # # # # # # # //
        #region Data in the Database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Slider>().HasData(
                    new Slider
                    {
                        Id = 1,
                        Image = "slider3.jpg",
                        Subtitle = "I must explain to you how all this mistaken idea of denouncing pleasure and prsing pain was born and I will give you a complete account of the system",
                        Title = "<h3>EDUCATION MAKES </h3><h2> PROPER HUMANITY </h2>"
                    },
                    new Slider
                    {
                        Id = 2,
                        Image = "slider2.jpg",
                        Subtitle = "I must explain to you how all this mistaken idea of denouncing pleasure and prsing pain was born and I will give you a complete account of the system",
                        Title = "<h3>EDUCATION MAKES </h3><h2> PROPER HUMANITY </h2>"
                    },
                    new Slider
                    {
                        Id = 3,
                        Image = "slider1.jpg",
                        Subtitle = "I must explain to you how all this mistaken idea of denouncing pleasure and prsing pain was born and I will give you a complete account of the system",
                        Title = "<h3>EDUCATION MAKES </h3><h2> PROPER HUMANITY </h2>"
                    }
                    );

            modelBuilder.Entity<Course>().HasData(
                    new Course
                    {
                        Id = 1,
                        Image = "course1.jpg",
                        Name = "CSE ENGINEERING",
                        Description = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit," +
                        " sed quia consequuntur magni dolores eos qui",
                        IsDeleted = false
                    },
                    new Course
                    {
                        Id = 2,
                        Image = "course2.jpg",
                        Name = "political science",
                        Description = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit," +
                        " sed quia consequuntur magni dolores eos qui",
                        IsDeleted = false
                    },
                    new Course
                    {
                        Id = 3,
                        Image = "course3.jpg",
                        Name = "micro biology",
                        Description = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit," +
                        " sed quia consequuntur magni dolores eos qui",
                        IsDeleted = false
                    },
                    new Course
                    {
                        Id = 4,
                        Image = "course4.jpg",
                        Name = "English history",
                        Description = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit," +
                        " sed quia consequuntur magni dolores eos qui",
                        IsDeleted = false
                    },
                    new Course
                    {
                        Id = 5,
                        Image = "course5.jpg",
                        Name = "digital marketing",
                        Description = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit," +
                        " sed quia consequuntur magni dolores eos qui",
                        IsDeleted = false
                    },
                    new Course
                    {
                        Id = 6,
                        Image = "course6.jpg",
                        Name = "html5 &amp; css3",
                        Description = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit," +
                        " sed quia consequuntur magni dolores eos qui",
                        IsDeleted = false
                    },
                    new Course
                    {
                        Id = 7,
                        Image = "course7.jpg",
                        Name = "learn php5",
                        Description = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit," +
                        " sed quia consequuntur magni dolores eos qui",
                        IsDeleted = false
                    },
                    new Course
                    {
                         Id = 8,
                         Image = "course8.jpg",
                         Name = "social science",
                         Description = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit," +
                        " sed quia consequuntur magni dolores eos qui",
                         IsDeleted = false
                    },
                    new Course
                    {
                        Id = 9,
                        Image = "course9.jpg",
                        Name = "applied mathematics",
                        Description = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit," +
                        " sed quia consequuntur magni dolores eos qui",
                        IsDeleted = false
                    }
                    );

            modelBuilder.Entity<CourseDetail>().HasData(
                    new CourseDetail
                    {
                        Id = 1,
                        CourseAbout = "1 - I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                        HowToApply = "1 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss",
                        Certification = "<p class='margin'>1 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss</p><p> I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human </p>",
                        CourseStartDate= new DateTime(2020, 1, 25),
                        CourseDuration=6,
                        ClassDuration=3,
                        SkillLevel= "ALL LEVEL",
                        Language= "ENGLISH",
                        StudentsCount=420,
                        Assessment="self",
                        Price= 789,
                        CourseId=1
                    },
                    new CourseDetail
                    {
                        Id = 2,
                        CourseAbout = "2 - I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                        HowToApply = "2 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss",
                        Certification = "<p class='margin'>2 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss</p><p> I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human </p>",
                        CourseStartDate = new DateTime(2020, 2, 25),
                        CourseDuration = 6,
                        ClassDuration = 3,
                        SkillLevel = "ALL LEVEL",
                        Language = "ENGLISH",
                        StudentsCount = 420,
                        Assessment = "self",
                        Price = 789,
                        CourseId = 2
                    },
                    new CourseDetail
                    {
                        Id = 3,
                        CourseAbout = "3 - I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                        HowToApply = "3 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss",
                        Certification = "<p class='margin'>3 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss</p><p> I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human </p>",
                        CourseStartDate = new DateTime(2020, 3, 25),
                        CourseDuration = 6,
                        ClassDuration = 3,
                        SkillLevel = "ALL LEVEL",
                        Language = "ENGLISH",
                        StudentsCount = 420,
                        Assessment = "self",
                        Price = 789,
                        CourseId = 3
                    },
                    new CourseDetail
                    {
                        Id = 4,
                        CourseAbout = "4 - I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                        HowToApply = "4 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss",
                        Certification = "<p class='margin'>4 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss</p><p> I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human </p>",
                        CourseStartDate = new DateTime(2020, 4, 25),
                        CourseDuration = 6,
                        ClassDuration = 3,
                        SkillLevel = "ALL LEVEL",
                        Language = "ENGLISH",
                        StudentsCount = 420,
                        Assessment = "self",
                        Price = 789,
                        CourseId = 4
                    },
                    new CourseDetail
                    {
                        Id = 5,
                        CourseAbout = "5 - I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                        HowToApply = "5 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss",
                        Certification = "<p class='margin'>5 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss</p><p> I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human </p>",
                        CourseStartDate = new DateTime(2020, 5, 25),
                        CourseDuration = 6,
                        ClassDuration = 3,
                        SkillLevel = "ALL LEVEL",
                        Language = "ENGLISH",
                        StudentsCount = 420,
                        Assessment = "self",
                        Price = 789,
                        CourseId = 5
                    },
                    new CourseDetail
                    {
                        Id = 6,
                        CourseAbout = "6 - I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                        HowToApply = "6 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss",
                        Certification = "<p class='margin'>6 - I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss</p><p> I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human </p>",
                        CourseStartDate = new DateTime(2020, 6, 25),
                        CourseDuration = 6,
                        SkillLevel = "ALL LEVEL",
                        Language = "ENGLISH",
                        StudentsCount = 420,
                        Assessment = "self",
                        Price = 789,
                        CourseId = 6
                    },
                    new CourseDetail
                    {
                        Id = 7,
                        CourseAbout = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                        HowToApply = "I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss",
                        Certification = "<p class='margin'>I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss</p><p> I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human </p>",
                        CourseStartDate = new DateTime(2020, 1, 25),
                        CourseDuration = 6,
                        ClassDuration = 3,
                        SkillLevel = "ALL LEVEL",
                        Language = "ENGLISH",
                        StudentsCount = 420,
                        Assessment = "self",
                        Price = 789,
                        CourseId = 7
                    },
                    new CourseDetail
                    {
                        Id = 8,
                        CourseAbout = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                        HowToApply = "I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss",
                        Certification = "<p class='margin'>I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss</p><p> I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human </p>",
                        CourseStartDate = new DateTime(2020, 1, 25),
                        CourseDuration = 6,
                        ClassDuration = 3,
                        SkillLevel = "ALL LEVEL",
                        Language = "ENGLISH",
                        StudentsCount = 420,
                        Assessment = "self",
                        Price = 789,
                        CourseId = 8
                    },
                    new CourseDetail
                    {
                        Id = 9,
                        CourseAbout = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                        HowToApply = "I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss",
                        Certification = "<p class='margin'>I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss</p><p> I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human </p>",
                        CourseStartDate= new DateTime(2020, 1, 25),
                        CourseDuration = 6,
                        ClassDuration = 3,
                        SkillLevel = "ALL LEVEL",
                        Language = "ENGLISH",
                        StudentsCount = 420,
                        Assessment = "self",
                        Price = 789,
                        CourseId = 9
                    }
                    );

            modelBuilder.Entity<Event>().HasData(
                    new Event
                    {
                        Id = 1,
                        Image = "event5.jpg",
                        Title = "ADVANCE PHP WORKSHOP",
                        TimeStart = new DateTime(2020,7,20,9,30,0),
                        TimeEnd = new DateTime(2020,7,20,16,45,0),
                        Venue = "Cristal Centre, 254 New Yourk",
                        IsDeleted = false
                    },
                    new Event
                    {
                        Id = 2,
                        Image = "event6.jpg",
                        Title = "LEARNING ENGLISH HISTORY",
                        TimeStart = new DateTime(2020, 7, 18, 9, 30, 0),
                        TimeEnd = new DateTime(2020, 7, 18, 16, 45, 0),
                        Venue = "Cristal Centre, 254 New Yourk",
                        IsDeleted = false
                    },
                    new Event
                    {
                        Id = 3,
                        Image = "event7.jpg",
                        Title = "UI & UX DESIGNER MEETUP",
                        TimeStart = new DateTime(2020, 7, 16, 9, 30, 0),
                        TimeEnd = new DateTime(2020, 7, 16, 16, 45, 0),
                        Venue = "Cristal Centre, 254 New Yourk",
                        IsDeleted = false
                    },
                    new Event
                    {
                        Id = 4,
                        Image = "event8.jpg",
                        Title = "ADVANCE WEB DEVELOPMENT",
                        TimeStart = new DateTime(2020, 7, 14, 9, 30, 0),
                        TimeEnd = new DateTime(2020, 7, 14, 16, 45, 0),
                        Venue = "Cristal Centre, 254 New Yourk",
                        IsDeleted = false
                    },
                    new Event
                    {
                        Id = 5,
                        Image = "event9.jpg",
                        Title = "DIGITAL MARKETING ANALYSIS",
                        TimeStart = new DateTime(2020, 7, 12, 9, 30, 0),
                        TimeEnd = new DateTime(2020, 7, 12, 16, 45, 0),
                        Venue = "Cristal Centre, 254 New Yourk",
                        IsDeleted = false
                    },
                    new Event
                    {
                        Id = 6,
                        Image = "event10.jpg",
                        Title = "DEVELOPER'S MEETUP",
                        TimeStart = new DateTime(2020, 7, 10, 9, 30, 0),
                        TimeEnd = new DateTime(2020, 7, 10, 16, 45, 0),
                        Venue = "Cristal Centre, 254 New Yourk",
                        IsDeleted = false
                    },
                    new Event
                    {
                        Id = 7,
                        Image = "event11.jpg",
                        Title = "WORKSHOP ON MICRO BIOLOGY",
                        TimeStart = new DateTime(2020, 7, 8, 9, 30, 0),
                        TimeEnd = new DateTime(2020, 7, 8, 16, 45, 0),
                        Venue = "Cristal Centre, 254 New Yourk",
                        IsDeleted = false
                    },
                    new Event
                    {
                        Id = 8,
                        Image = "event12.jpg",
                        Title = "ADVANCED PHOTOSHOP 2017",
                        TimeStart = new DateTime(2020, 7, 6, 9, 30, 0),
                        TimeEnd = new DateTime(2020, 7, 6, 16, 45, 0),
                        Venue = "Cristal Centre, 254 New Yourk",
                        IsDeleted = false
                    },
                    new Event
                    {
                        Id = 9,
                        Image = "event13.jpg",
                        Title = "NEW TREND IN WEBDESIGN",
                        TimeStart = new DateTime(2020, 7, 4, 9, 30, 0),
                        TimeEnd = new DateTime(2020, 7, 4, 16, 45, 0),
                        Venue = "Cristal Centre, 254 New Yourk",
                        IsDeleted = false
                    }
                    );

            modelBuilder.Entity<EventDetail>().HasData(
                    new EventDetail
                    {
                        Id = 1,
                        Description= "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit, " +
                        "sed quia consequuntur magni dolores eos qui </p><p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.Nemo enim ipsam voluptatem </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium </p>",
                        SpeakerName= "Anthony Smith",
                        SpeakerPosition= "CEO, Hastech",
                        SpeakerImage= "speaker1.jpg",
                        EventId=1
                    },
                    new EventDetail
                    {
                        Id = 2,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit, " +
                        "sed quia consequuntur magni dolores eos qui </p><p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.Nemo enim ipsam voluptatem </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium </p>",
                        SpeakerName = "Lucy Rose",
                        SpeakerPosition = "Developer, STD",
                        SpeakerImage = "speaker2.jpg",
                        EventId=2
                    },
                    new EventDetail
                    {
                        Id = 3,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit, " +
                        "sed quia consequuntur magni dolores eos qui </p><p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.Nemo enim ipsam voluptatem </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium </p>",
                        SpeakerName = "Anthony Smith",
                        SpeakerPosition = "CEO, Hastech",
                        SpeakerImage = "speaker1.jpg",
                        EventId=3
                    },
                    new EventDetail
                    {
                        Id = 4,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit, " +
                        "sed quia consequuntur magni dolores eos qui </p><p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.Nemo enim ipsam voluptatem </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium </p>",
                        SpeakerName = "Lucy Rose",
                        SpeakerPosition = "Developer, STD",
                        SpeakerImage = "speaker2.jpg",
                        EventId=4
                    },
                    new EventDetail
                    {
                        Id = 5,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit, " +
                        "sed quia consequuntur magni dolores eos qui </p><p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.Nemo enim ipsam voluptatem </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium </p>",
                        SpeakerName = "Anthony Smith",
                        SpeakerPosition = "CEO, Hastech",
                        SpeakerImage = "speaker1.jpg",
                        EventId=5
                    },
                    new EventDetail
                    {
                        Id = 6,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit, " +
                        "sed quia consequuntur magni dolores eos qui </p><p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.Nemo enim ipsam voluptatem </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium </p>",
                        SpeakerName = "Lucy Rose",
                        SpeakerPosition = "Developer, STD",
                        SpeakerImage = "speaker2.jpg",
                        EventId=6
                    },
                    new EventDetail
                    {
                        Id = 7,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit, " +
                        "sed quia consequuntur magni dolores eos qui </p><p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.Nemo enim ipsam voluptatem </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium </p>",
                        SpeakerName = "Anthony Smith",
                        SpeakerPosition = "CEO, Hastech",
                        SpeakerImage = "speaker1.jpg",
                        EventId=7
                    },
                    new EventDetail
                    {
                        Id = 8,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit, " +
                        "sed quia consequuntur magni dolores eos qui </p><p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.Nemo enim ipsam voluptatem </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium </p>",
                        SpeakerName = "Lucy Rose",
                        SpeakerPosition = "Developer, STD",
                        SpeakerImage = "speaker2.jpg",
                        EventId=8
                    },
                    new EventDetail
                    {
                        Id = 9,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit, " +
                        "sed quia consequuntur magni dolores eos qui </p><p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.Nemo enim ipsam voluptatem </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium </p>",
                        SpeakerName = "Anthony Smith",
                        SpeakerPosition = "CEO, Hastech",
                        SpeakerImage = "speaker1.jpg",
                        EventId=9
                    }
                    );

            modelBuilder.Entity<Blog>().HasData(
                    new Blog
                    {
                        Id = 1,
                        Image = "blog1.jpg",
                        Title = "ADVANCE PHP WORKSHOP",
                        AddedTime = new DateTime(2020, 7, 20),
                        ByName = "Alex",
                        IsDeleted = false
                    },
                    new Blog
                    {
                        Id = 2,
                        Image = "blog2.jpg",
                        Title = "LEARNING ENGLISH HISTORY",
                        AddedTime = new DateTime(2020, 7, 18),
                        ByName = "Alex",
                        IsDeleted = false
                    },
                    new Blog
                    {
                        Id = 3,
                        Image = "blog3.jpg",
                        Title = "UI & UX DESIGNER MEETUP",
                        AddedTime = new DateTime(2020, 7, 16),
                        ByName = "Alex",
                        IsDeleted = false
                    },
                    new Blog
                    {
                        Id = 4,
                        Image = "blog4.jpg",
                        Title = "ADVANCE WEB DEVELOPMENT",
                        AddedTime = new DateTime(2020, 7, 14),
                        ByName = "Alex",
                        IsDeleted = false
                    },
                    new Blog
                    {
                        Id = 5,
                        Image = "blog5.jpg",
                        Title = "DIGITAL MARKETING ANALYSIS",
                        AddedTime = new DateTime(2020, 7, 12),
                        ByName = "Alex",
                        IsDeleted = false
                    },
                    new Blog
                    {
                        Id = 6,
                        Image = "blog6.jpg",
                        Title = "DEVELOPER'S MEETUP",
                        AddedTime = new DateTime(2020, 7, 10),
                        ByName = "Alex",
                        IsDeleted = false
                    },
                    new Blog
                    {
                        Id = 7,
                        Image = "blog7.jpg",
                        Title = "WORKSHOP ON MICRO BIOLOGY",
                        AddedTime = new DateTime(2020, 7, 8),
                        ByName = "Alex",
                        IsDeleted = false
                    },
                    new Blog
                    {
                        Id = 8,
                        Image = "blog8.jpg",
                        Title = "ADVANCED PHOTOSHOP 2017",
                        AddedTime = new DateTime(2020, 7, 6),
                        ByName = "Alex",
                        IsDeleted = false
                    },
                    new Blog
                    {
                        Id = 9,
                        Image = "blog9.jpg",
                        Title = "NEW TREND IN WEBDESIGN",
                        AddedTime = new DateTime(2020, 7, 4),
                        ByName = "Alex",
                        IsDeleted = false
                    }
                    );

            modelBuilder.Entity<BlogDetail>().HasData(
                    new BlogDetail
                    {
                        Id = 1,
                        Description= "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam volutatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam </p>< p class='quote'>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque la udantium, totam rem aperiam</p>" +
                        "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo emo enim ipsam</p>",
                        BlogId = 1
                    },
                    new BlogDetail
                    {
                        Id = 2,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam volutatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam </p>< p class='quote'>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque la udantium, totam rem aperiam</p>" +
                        "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo emo enim ipsam</p>",
                        BlogId =2
                    },
                    new BlogDetail
                    {
                        Id = 3,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam volutatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam </p>< p class='quote'>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque la udantium, totam rem aperiam</p>" +
                        "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo emo enim ipsam</p>",
                        BlogId =3
                    },
                    new BlogDetail
                    {
                        Id = 4,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam volutatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam </p>< p class='quote'>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque la udantium, totam rem aperiam</p>" +
                        "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo emo enim ipsam</p>",
                        BlogId =4
                    },
                    new BlogDetail
                    {
                        Id = 5,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam volutatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam </p>< p class='quote'>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque la udantium, totam rem aperiam</p>" +
                        "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo emo enim ipsam</p>",
                        BlogId =5
                    },
                    new BlogDetail
                    {
                        Id = 6,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam volutatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam </p>< p class='quote'>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque la udantium, totam rem aperiam</p>" +
                        "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo emo enim ipsam</p>",
                        BlogId =6
                    },
                    new BlogDetail
                    {
                        Id = 7,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam volutatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam </p>< p class='quote'>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque la udantium, totam rem aperiam</p>" +
                        "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo emo enim ipsam</p>",
                        BlogId =7
                    },
                    new BlogDetail
                    {
                        Id = 8,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam volutatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam </p>< p class='quote'>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque la udantium, totam rem aperiam</p>" +
                        "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo emo enim ipsam</p>",
                        BlogId =8
                    },
                    new BlogDetail
                    {
                        Id = 9,
                        Description = "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam volutatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui </p>" +
                        "<p> I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam </p>< p class='quote'>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque la udantium, totam rem aperiam</p>" +
                        "<p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo emo enim ipsam</p>",
                        BlogId =9
                    }
                    );

            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = 1,
                        Name= "CSS Engineering"
                    },
                    new Category
                    {
                        Id = 2,
                        Name= "Political Science"
                    },
                    new Category
                    {
                        Id = 3,
                        Name= "Micro Biology"
                    },
                    new Category
                    {
                        Id = 4,
                        Name = "HTML5 & CSS3"
                    },
                    new Category
                    {
                        Id = 5,
                        Name = "Web Design"
                    },
                    new Category
                    {
                        Id = 6,
                        Name = "PHP"
                    }
                    );

            modelBuilder.Entity<Teacher>().HasData(
                    new Teacher
                    {
                        Id = 1,
                        Name= "Ömür",
                        Surname= "Jabiyeva",
                        Image= "teacher4.jpg",
                        Position= "Associate Professor",
                        Facebook="#",
                        Pinterest="#",
                        Vimeo="#",
                        Twitter="#",
                        IsDeleted=false
                    },
                    new Teacher
                    {
                        Id = 2,
                        Name = "Kamran",
                        Surname = "Jabiyev",
                        Image = "forever.jpg",
                        Position = "Associate Professor",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        IsDeleted = false
                    },
                    new Teacher
                    {
                        Id = 3,
                        Name = "KEVIN",
                        Surname = "WILLIAMS",
                        Image = "teacher1.jpg",
                        Position = "Associate Professor",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        IsDeleted = false
                    },
                    new Teacher
                    {
                        Id = 4,
                        Name = "EAMILY",
                        Surname = "CRISTIAN",
                        Image = "teacher2.jpg",
                        Position = "Associate Professor",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        IsDeleted = false
                    },
                    new Teacher
                    {
                        Id = 5,
                        Name = "JASMIN",
                        Surname = "SMITH",
                        Image = "teacher5.jpg",
                        Position = "Associate Professor",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        IsDeleted = false
                    },
                    new Teacher
                    {
                        Id = 6,
                        Name = "STEPHEN",
                        Surname = "FLEMING",
                        Image = "teacher6.jpg",
                        Position = "Associate Professor",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        IsDeleted = false
                    },
                    new Teacher
                    {
                        Id = 7,
                        Name = "JULIA",
                        Surname = "WILLIAMS",
                        Image = "teacher7.jpg",
                        Position = "Associate Professor",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        IsDeleted = false
                    },
                    new Teacher
                    {
                        Id = 8,
                        Name = "NAIL",
                        Surname = "ANDERSON",
                        Image = "teacher8.jpg",
                        Position = "Associate Professor",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        IsDeleted = false
                    },
                    new Teacher
                    {
                        Id = 9,
                        Name = "STUART",
                        Surname = "KELVIN",
                        Image = "teacher9.jpg",
                        Position = "Associate Professor",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        IsDeleted = false
                    },
                    new Teacher
                    {
                        Id = 10,
                        Name = "STUART",
                        Surname = "KELVIN",
                        Image = "teacher10.jpg",
                        Position = "Associate Professor",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        IsDeleted = false
                    },
                    new Teacher
                    {
                        Id = 11,
                        Name = "KEVIN",
                        Surname = "WILLIAMS",
                        Image = "teacher11.jpg",
                        Position = "Associate Professor",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        IsDeleted = false
                    },
                    new Teacher
                    {
                        Id = 12,
                        Name = "SALINA",
                        Surname = "GOMAZE",
                        Image = "teacher12.jpg",
                        Position = "Associate Professor",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        IsDeleted = false
                    }
                    );

            modelBuilder.Entity<TeacherDetail>().HasData(
                    new TeacherDetail
                    {
                        Id = 1,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "5 years experience",
                        Hobbies = "Coding, Ballerina, music, travelling, catching fish",
                        Faculty = "Developer, Department of Micro Biology",
                        Mail = "omurjb@code.az",
                        Phone = "(+125) 5896 548 9874",
                        Skype= "stuart.k",
                        Language = 110,
                        TeamLeader = 110,
                        Development=110,
                        Design=110,
                        Innovation=110,
                        Communication=110,
                        TeacherId=1
                    },
                    new TeacherDetail
                    {
                        Id = 2,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "25 years experience",
                        Hobbies = "Eat Fish, Keep Students Sleepless:))), music, travelling, catching fish",
                        Faculty = "IT, Department of Micro Biology",
                        Mail = "kamranjb@code.az",
                        Phone = "(+125) 5896 548 9874",
                        Skype= "stuart.k",
                        Language = 50,
                        TeamLeader = 95,
                        Development = 95,
                        Design = 95,
                        Innovation = 95,
                        Communication = 95,
                        TeacherId=2
                    },
                    new TeacherDetail
                    {
                        Id = 3,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "7 years experience",
                        Hobbies = "music, travelling, catching fish",
                        Faculty = "Din, Department of Micro Biology",
                        Mail = "stuart3@eduhome.com",
                        Phone = "(+125) 5896 548 9874",
                        Skype= "stuart.k",
                        Language = 30,
                        TeamLeader = 85,
                        Development = 80,
                        Design = 75,
                        Innovation = 79,
                        Communication = 73,
                        TeacherId = 3
                    },
                    new TeacherDetail
                    {
                        Id = 4,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "7 years experience",
                        Hobbies = "music, travelling, catching fish",
                        Faculty = "Din, Department of Micro Biology",
                        Mail = "stuart4@eduhome.com",
                        Skype= "stuart.k",
                        Phone = "(+125) 5896 548 9874",
                        Language = 30,
                        TeamLeader = 85,
                        Development = 80,
                        Design = 75,
                        Innovation = 79,
                        Communication = 73,
                        TeacherId =4
                    },
                    new TeacherDetail
                    {
                        Id = 5,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "7 years experience",
                        Hobbies = "music, travelling, catching fish",
                        Faculty = "Din, Department of Micro Biology",
                        Mail = "stuart5@eduhome.com",
                        Phone = "(+125) 5896 548 9874",
                        Skype= "stuart.k",
                        Language = 30,
                        TeamLeader = 85,
                        Development = 80,
                        Design = 75,
                        Innovation = 79,
                        Communication = 73,
                        TeacherId =5
                    },
                    new TeacherDetail
                    {
                        Id = 6,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "7 years experience",
                        Hobbies = "music, travelling, catching fish",
                        Faculty = "Din, Department of Micro Biology",
                        Mail = "stuart6@eduhome.com",
                        Phone = "(+125) 5896 548 9874",
                        Skype= "stuart.k",
                        Language = 30,
                        TeamLeader = 85,
                        Development = 80,
                        Design = 75,
                        Innovation = 79,
                        Communication = 73,
                        TeacherId =6
                    },
                    new TeacherDetail
                    {
                        Id = 7,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "7 years experience",
                        Hobbies = "music, travelling, catching fish",
                        Faculty = "Din, Department of Micro Biology",
                        Mail = "stuart7@eduhome.com",
                        Phone = "(+125) 5896 548 9874",
                        Skype= "stuart.k",
                        Language = 30,
                        TeamLeader = 85,
                        Development = 80,
                        Design = 75,
                        Innovation = 79,
                        Communication = 73,
                        TeacherId =7
                    },
                    new TeacherDetail
                    {
                        Id = 8,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "7 years experience",
                        Hobbies = "music, travelling, catching fish",
                        Faculty = "Din, Department of Micro Biology",
                        Mail = "stuart8@eduhome.com",
                        Phone = "(+125) 5896 548 9874",
                        Skype= "stuart.k",
                        Language = 30,
                        TeamLeader = 85,
                        Development = 80,
                        Design = 75,
                        Innovation = 79,
                        Communication = 73,
                        TeacherId =8
                    },
                    new TeacherDetail
                    {
                        Id = 9,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "7 years experience",
                        Hobbies = "music, travelling, catching fish",
                        Faculty = "Din, Department of Micro Biology",
                        Mail = "stuart9@eduhome.com",
                        Phone = "(+125) 5896 548 9874",
                        Skype= "stuart.k",
                        Language = 30,
                        TeamLeader = 85,
                        Development = 80,
                        Design = 75,
                        Innovation = 79,
                        Communication = 73,
                        TeacherId =9
                    },
                    new TeacherDetail
                    {
                        Id = 10,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "7 years experience",
                        Hobbies = "music, travelling, catching fish",
                        Faculty = "Din, Department of Micro Biology",
                        Mail = "stuart10@eduhome.com",
                        Phone = "(+125) 5896 548 9874",
                        Skype= "stuart.k",
                        Language = 30,
                        TeamLeader = 85,
                        Development = 80,
                        Design = 75,
                        Innovation = 79,
                        Communication = 73,
                        TeacherId =10
                    },
                    new TeacherDetail
                    {
                        Id = 11,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "7 years experience",
                        Hobbies = "music, travelling, catching fish",
                        Faculty = "Din, Department of Micro Biology",
                        Mail = "stuart11@eduhome.com",
                        Phone = "(+125) 5896 548 9874",
                        Skype= "stuart.k",
                        Language = 30,
                        TeamLeader = 85,
                        Development = 80,
                        Design = 75,
                        Innovation = 79,
                        Communication = 73,
                        TeacherId =11
                    },
                    new TeacherDetail
                    {
                        Id = 12,
                        About = "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas",
                        Degree = "PHD in Micro Biology",
                        Experience = "7 years experience",
                        Hobbies = "music, travelling, catching fish",
                        Faculty = "Din, Department of Micro Biology",
                        Mail = "stuart12@eduhome.com",
                        Phone = "(+125) 5896 548 9874",
                        Skype= "stuart.k",
                        Language = 30,
                        TeamLeader = 85,
                        Development = 80,
                        Design = 75,
                        Innovation = 79,
                        Communication = 73,
                        TeacherId =12
                    }
                    );

            modelBuilder.Entity<Notice>().HasData(
                    new Notice
                    {
                        Id = 1,
                        AddedTime = new DateTime(2020, 7, 16),
                        Content = "1 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete",
                        IsDeleted = false
                    },
                    new Notice
                    {
                        Id = 2,
                        AddedTime = new DateTime(2020, 7, 15),
                        Content = "2 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete",
                        IsDeleted = false
                    },
                    new Notice
                    {
                        Id = 3,
                        AddedTime = new DateTime(2020, 7, 14),
                        Content = "3 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete",
                        IsDeleted = false
                    },
                    new Notice
                    {
                        Id = 4,
                        AddedTime = new DateTime(2020, 7, 13),
                        Content = "4 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete",
                        IsDeleted = false
                    },
                    new Notice
                    {
                        Id = 5,
                        AddedTime = new DateTime(2020, 7, 12),
                        Content = "5 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete",
                        IsDeleted = false
                    },
                    new Notice
                    {
                        Id = 6,
                        AddedTime = new DateTime(2020, 7, 11),
                        Content = "6 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete",
                        IsDeleted = false
                    }
                    );

            modelBuilder.Entity<HomeVideo>().HasData(
                    new HomeVideo
                    {
                        Id = 1,
                        VideoLink = "https://www.youtube.com/watch?v=to6Ghf8UL7o"
                    }
                    );

            modelBuilder.Entity<About>().HasData(
                    new About
                    {
                        Id = 1,
                        Image = "about.png",
                        Title= "<span>EDUHOME</span> the best education theme for you",
                        Content= "<p>I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system, and expound the actual teachings  the master-builder of humanit happiness</p>" +
                        "<p class='hidden-sm'>I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system</p>"
                    },
                    new About
                    {
                        Id = 2,
                        Image = "about.png",
                        Title = "WELCOME TO <span>EDUHOME</span>",
                        Content = "<p>I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system, and expound the actual teachings  the master-builder of humanit happiness</p>" +
                        "<p class='hidden-sm'>I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system</p>"
                    }
                    );

            modelBuilder.Entity<Testimonial>().HasData(
                    new Testimonial
                    {
                        Id = 1,
                        Image = "testimonial.jpg",
                        Description = "I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and I will give you a coete account of the system, and expound the actual",
                        FullName = "David Morgan",
                        Note= "Student, CSE"
                    },
                    new Testimonial
                    {
                        Id = 2,
                        Image = "testimonial.jpg",
                        Description = "I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and I will give you a coete account of the system, and expound the actual",
                        FullName = "David Morgan",
                        Note = "Student, CSE"
                    },
                    new Testimonial
                    {
                        Id = 3,
                        Image = "testimonial.jpg",
                        Description = "I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and I will give you a coete account of the system, and expound the actual",
                        FullName = "David Morgan",
                        Note = "Student, CSE"
                    }
                    );

            modelBuilder.Entity<Bio>().HasData(
                    new Bio
                    {
                        Id = 1,
                        SmallLogo = "logo2.png",
                        BigLogo = "footer-logo.png",
                        About = "I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and give you a coete account of the system.",
                        Facebook = "#",
                        Pinterest = "#",
                        Vimeo = "#",
                        Twitter = "#",
                        Address = "City, Roadno 785 New York",
                        Phone = "+880  548  986  898  87",
                        AdditionalPhone = "+880  659  785  658  98",
                        Email = "info@eduhome.com",
                        Webpage = "www.eduhome.com"
                    }
                    );
        }
        #endregion
    }
}
