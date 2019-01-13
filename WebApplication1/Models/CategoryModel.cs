using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CategoryModel
    {
        private int cat_Id;
        private string Name;
        private string img_Dir;
        private string modified_Date;

        public int Cat_Id
        {
            get
            {
                return cat_Id;
            }

            set
            {
                cat_Id = value;
            }
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public string Img_Dir
        {
            get
            {
                return img_Dir;
            }

            set
            {
                img_Dir = value;
            }
        }

        public string Modified_Date
        {
            get
            {
                return modified_Date;
            }

            set
            {
                modified_Date = value;
            }
        }

        public CategoryModel(int cat_Id, string name, string img_Dir, string modified_Date)
        {
            this.Cat_Id = cat_Id;
            Name1 = name;
            this.Img_Dir = img_Dir;
            this.Modified_Date = modified_Date;
        }

        
    }
}