using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica.DAL
{
    public class DataContextFactory
    {
        private static MusicaDataContext dataContext;

        public static MusicaDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new MusicaDataContext();

                return dataContext;
            }
        }
    }
}
