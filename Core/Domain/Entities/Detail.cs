using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Detail:EntityBase
{
    public Detail()
    {
        
    }
    public Detail(string title,string description,int categoryId)
    {
        Title = title;
        Descripton = description;
        CategoryId = categoryId;
    }
    public string Title { get; set; }
    public string Descripton { get; set; }
    public int CategoryId { get; set; }

    public Category Category { get; set; }
}
