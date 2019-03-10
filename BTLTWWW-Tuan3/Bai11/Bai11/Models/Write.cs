using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai11.Models
{
    public class Write
    {
        private string idBV;
        private string typeName;
        private string idWrite;
        private string title;
        private string contentSub;
        private string contentMain;

        public string IdBV
        {
            get
            {
                return idBV;
            }

            set
            {
                idBV = value;
            }
        }

        public string TypeName
        {
            get
            {
                return typeName;
            }

            set
            {
                typeName = value;
            }
        }

        public string IdWrite
        {
            get
            {
                return idWrite;
            }

            set
            {
                idWrite = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string ContentSub
        {
            get
            {
                return contentSub;
            }

            set
            {
                contentSub = value;
            }
        }

        public string ContentMain
        {
            get
            {
                return contentMain;
            }

            set
            {
                contentMain = value;
            }
        }
    }
}