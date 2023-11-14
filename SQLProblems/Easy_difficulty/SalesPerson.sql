select sp.name
from SalesPerson sp
where sp.sales_id NOT IN (
    select distinct o.sales_id
    from Orders o
    inner join Company c ON o.com_id = c.com_id
    where c.name = 'RED'
)
