select w1.id as Id
from Weather w1
inner join Weather w2
on w1.recordDate = date_add(w2.recordDate, interval 1 day)
where w1.temperature > w2.temperature

-- This one works aswell, a bit cleaner and easier to read:
select w1.id as Id
from Weather as w1, Weather as w2
where w1.temperature > w2.temperature and datediff(w1.recordDate, w2.recordDate) = 1