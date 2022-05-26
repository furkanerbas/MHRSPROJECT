using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.PagingListModels
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public List<T> ItemList { get; set; }
        public bool PreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }
        public bool NextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public PaginatedList(List<T> items, int count, int pageindex, int pageSize)
        {
            PageIndex = pageindex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
            ItemList = items;
        }

        public static PaginatedList<T> Create(List<T> data, int pageindex, int pagesize)
        {
            var count = data.Count;
            //bulunduğum sayfadan bir eksiltip sayfada kaç tane data göstermek istiyorsa
            //o kadarını al
            var items = data
                //bulunduğum sayfadan bir eksiltip kaç data kapasitem varsa o kadar veriyi atla, geç
                .Skip((pageindex - 1) * pagesize)
                //sayfada kaç veri gözükmesini istiyorsam o kadar veriyi al
                .Take(pagesize)
                .ToList();

            return new PaginatedList<T>(items, count, pageindex, pagesize);

        }

    }
}
