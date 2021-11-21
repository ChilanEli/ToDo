using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YukselAltranToDo.Models
{
    public class ToDo
    {
        private int id;
        private string description;
        private bool isDone;
        public virtual ApplicationUser User { get; set; }

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public bool IsDone { get => isDone; set => isDone = value; }
    }
}