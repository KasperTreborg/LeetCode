select
  requester_id as id,
  count(*) as num
from (
  (select requester_id from RequestAccepted)
  union all
  (select accepter_id from RequestAccepted)
) ph
group by id 
order by num desc limit 1