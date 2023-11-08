-- First method
select name as Customers
from Customers
left join Orders
on Orders.customerId = Customers.id
where Orders.customerId is null

-- This works so that you don't have to join the tables
select name as Customers
from Customers
where id not in (
    select customerId
    from Orders
)