using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan.Bai1Alogithms
{
    public class Bai13SortByCategoryName
    {
        public static List<Product> SortByCategoryName(List<Product> listProduct, List<Category> listCategory)
        {
            for (int i = 0; i < listProduct.Count; i++)
            {
                Product product = listProduct[i];
                int j = i-1;
                while (j>=0 && string.Compare(listCategory.Find(c => c.Id==listProduct[j].CategoryId).Name, listProduct.Find(c => c.CategoryId==product.CategoryId).Name)>0) 
                {
                    listProduct[j+1]= listProduct[j];
                    j=j-1;
                }
                listProduct[j+1]=product;
            }
            return listProduct;
        }
    }
}
