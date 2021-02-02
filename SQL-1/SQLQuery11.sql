SELECT * from C1
WHERE ID IN
(SELECT ID
FROM C1
group by ID
HAVING count(*) > 1)
