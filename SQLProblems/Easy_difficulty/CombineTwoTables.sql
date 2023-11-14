SELECT firstName, lastName, city, state 
FROM Person
JOIN Address
ON Address.person_id = Person.person_id