using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai7.Models
{
    public class ItemVote
    {
        private int idVote;
        private int idItem;
        private string nameVote;

        public int IdVote
        {
            get
            {
                return idVote;
            }

            set
            {
                idVote = value;
            }
        }

        public int IdItem
        {
            get
            {
                return idItem;
            }

            set
            {
                idItem = value;
            }
        }

        public string NameVote
        {
            get
            {
                return nameVote;
            }

            set
            {
                nameVote = value;
            }
        }
    }
}