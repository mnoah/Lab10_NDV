using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_NDV
{
    public class Movie
    {
        private  string MovieTitle = "";

        private  string MovieCategory = "";

        public string getTitle()
        {
            return MovieTitle;
        }

        public string getCategory()
        {
            return MovieCategory;
        }

        public Movie (string title, string category)
        {
                MovieTitle = title;
                MovieCategory = category;
        }

            


    }
}
