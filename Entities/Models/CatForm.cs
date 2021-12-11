using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class CatForm
    {
        public CatForm()
        {
            Forms = new HashSet<Form>();
        }

        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? Icone { get; set; }
        public string? Class { get; set; }

        public virtual ICollection<Form> Forms { get; set; }
    }
}
