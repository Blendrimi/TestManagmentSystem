
select ClientID,
 count(case when o.Quantity in (2,3) then 1 else null  end ) as Total,
  count(case when c.InsertedDate <  DATEADD(year, -1, GETDATE())  then 1 else null  end ) as Total
from Orders o  
left join Clients c 
on o.ClientID=c.ID
group by ClientID