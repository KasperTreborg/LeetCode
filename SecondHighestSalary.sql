select case
    when (select count(distinct salary) from Employee) < 2 then null
    else (select salary from Employee order by salary desc limit 1 offset 1)
end as SecondHighestSalary