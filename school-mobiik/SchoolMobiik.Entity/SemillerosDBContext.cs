using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SchoolMobiik.Entity
{
    public partial class SemillerosDBContext : DbContext
    {
        public SemillerosDBContext()
        {
        }

        public SemillerosDBContext(DbContextOptions<SemillerosDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<Inscription> Inscription { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<SchoolType> SchoolType { get; set; }
        public virtual DbSet<SchoolUser> SchoolUser { get; set; }
        public virtual DbSet<Signatures> Signatures { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<WeekDay> WeekDay { get; set; }
        public virtual DbSet<Work> Work { get; set; }
        public virtual DbSet<ZipCode> ZipCode { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=semillerosdb.database.windows.net;Database=SemillerosDB;Persist Security Info=False;User ID=semilleros;Password=Password123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.Neighborhood)
                    .HasName("IX_FK_ADDRESS_ZIPCODE");

                entity.Property(e => e.ExtNum)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntNum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.NeighborhoodNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.Neighborhood)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADDRESS_ZIPCODE");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => e.StateId)
                    .HasName("IX_FK_CITY_STATE");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CITY_STATE");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasIndex(e => e.SchoolId)
                    .HasName("IX_FK_COURSE_SCHOOL");

                entity.HasIndex(e => e.SignaturesId)
                    .HasName("IX_FK_COURSE_SIGNATURES");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("IX_FK_COURSE_TEACHER");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.SchoolId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COURSE_SCHOOL");

                entity.HasOne(d => d.Signatures)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.SignaturesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COURSE_SIGNATURES");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COURSE_TEACHER");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.StudentId });

                entity.HasIndex(e => e.StudentId)
                    .HasName("IX_FK_GRADE_STUDENT");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Grade1)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Grade)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRADE_TEACHER");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Grade)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRADE_STUDENT");
            });

            modelBuilder.Entity<Inscription>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.SchoolId });

                entity.HasIndex(e => e.SchoolId)
                    .HasName("IX_FK_INSCRIPTION_SCHOOL");

                entity.Property(e => e.SchoolId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InscriptionDate).HasColumnType("datetime");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Inscription)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPTION_SCHOOL");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Inscription)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPTION_STUDENT");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .HasName("IX_FK_PERSON_ADDRESS");

                entity.HasIndex(e => e.RolId)
                    .HasName("IX_FK_PERSON_ROL");

                entity.Property(e => e.Birthday)
                    .HasColumnName("BIrthday")
                    .HasColumnType("date");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasColumnName("CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonFirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonLastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERSON_ADDRESS");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERSON_ROL");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RolId);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.RolName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.WdId });

                entity.HasIndex(e => e.WdId)
                    .HasName("IX_FK_Schedule_WeekDay");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_Course");

                entity.HasOne(d => d.Wd)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.WdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_WeekDay");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .HasName("IX_FK_SCHOOL_ADDRESS");

                entity.HasIndex(e => e.SchoolType)
                    .HasName("IX_FK_SCHOOL_SCHOOLTYPE");

                entity.Property(e => e.SchoolId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.SchoolName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.School)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCHOOL_ADDRESS");

                entity.HasOne(d => d.SchoolTypeNavigation)
                    .WithMany(p => p.School)
                    .HasForeignKey(d => d.SchoolType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCHOOL_SCHOOLTYPE");
            });

            modelBuilder.Entity<SchoolType>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SchoolUser>(entity =>
            {
                entity.HasIndex(e => e.RolId)
                    .HasName("IX_FK_PERSON_ROLES");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.SchoolUser)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERSON_ROLES");
            });

            modelBuilder.Entity<Signatures>(entity =>
            {
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.SignaturesName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.PersonId)
                    .HasName("IX_FK_STUDENT_PERSON");

                entity.Property(e => e.Account)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('true')");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENT_PERSON");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasIndex(e => e.PersonId)
                    .HasName("IX_FK_TEACHER_PERSON");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TEACHER_PERSON");
            });

            modelBuilder.Entity<WeekDay>(entity =>
            {
                entity.HasKey(e => e.WdId);

                entity.Property(e => e.Day)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Work>(entity =>
            {
                entity.HasKey(e => new { e.SchoolSchoolId, e.TeacherTeacherId });

                entity.HasIndex(e => e.TeacherTeacherId)
                    .HasName("IX_FK_Work_Teacher");

                entity.Property(e => e.SchoolSchoolId)
                    .HasColumnName("School_SchoolId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherTeacherId).HasColumnName("Teacher_TeacherId");

                entity.HasOne(d => d.SchoolSchool)
                    .WithMany(p => p.Work)
                    .HasForeignKey(d => d.SchoolSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Work_School");

                entity.HasOne(d => d.TeacherTeacher)
                    .WithMany(p => p.Work)
                    .HasForeignKey(d => d.TeacherTeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Work_Teacher");
            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.HasKey(e => e.Neighborhood);

                entity.HasIndex(e => e.CityId)
                    .HasName("IX_FK_ZIPCODE_CITY");

                entity.Property(e => e.Neighborhood).ValueGeneratedNever();

                entity.Property(e => e.Zcname)
                    .IsRequired()
                    .HasColumnName("ZCName")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ZipCode)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ZIPCODE_CITY");
            });
        }
    }
}
