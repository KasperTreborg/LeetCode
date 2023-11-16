select 
    if(
        id < (select count(*) from Seat),
        if(id % 2 = 0, id - 1, id + 1),
        if(id % 2 = 0, id - 1, id)
    ) as id,
    student
from Seat
order by id asc