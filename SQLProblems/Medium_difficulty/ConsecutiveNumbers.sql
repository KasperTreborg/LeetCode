select distinct 
logs1.num as 'ConsecutiveNums'
from (Logs logs1 inner join Logs logs2 on logs1.num = logs2.num and logs1.id = logs2.id-1)
inner join Logs logs3 on logs1.num = logs3.num and logs2.id = logs3.id-1

-- You can also do it like this, however I found this out later on:

select distinct
num as 'ConsecutiveNums'
from Logs
where 
  (id + 1, num) in (select * from Logs) 
  and 
  (id + 2, num) in (select * from Logs)