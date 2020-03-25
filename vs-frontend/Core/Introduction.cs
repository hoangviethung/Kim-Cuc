using MainProject.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace MainProject.Core
{
    public class Introduction
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public string ImageFolder { get; set; }

        //public IntroductionCollection Order { get; set; }

        public virtual Language Language { get; set; }
    }
}
