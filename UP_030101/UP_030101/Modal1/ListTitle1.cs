using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace UP_030101.Modal1
{
    class ListTitle1 : ObservableCollection<Service>
    {
        public ListTitle1()
        {
            DbSet<Service> servise = SpisUslug.DataEntitiesEmployee.Service;
            var services = from title in servise select title;
            foreach (Service titl in services)
            {
                this.Add(titl);
            }
        }
    }
}
