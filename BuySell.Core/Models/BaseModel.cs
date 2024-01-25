using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell.Core.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate {
            get { return _createdDate; }
            set { _createdDate = value; }
        }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
