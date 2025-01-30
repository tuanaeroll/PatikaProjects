DELETE FROM employee
WHERE id = 10;

DELETE FROM employee
WHERE name = 'John Doe';

DELETE FROM employee
WHERE email = 'example@email.com'
RETURNING * ;

DELETE FROM employee
WHERE birthday < '2000-01-01';

DELETE FROM employee
WHERE name LIKE 'M%';