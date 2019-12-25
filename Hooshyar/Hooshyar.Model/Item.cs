using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hooshyar.Model
{
    public class Item	
    {
	    public Item()
	    {
		    
	    }
	    public Item(string name,int count,int countTypeId)
	    {
		    Name = name;
		    Count = count;
		    CountTypeId = countTypeId;
	    }
	    public int Id { get; set; }
	    public string Name { get; set; }
	    public int Count { get; set; }

	    public int? CountTypeId { get; set; }
	    public CountType CountType { get; set; }
    }
}
