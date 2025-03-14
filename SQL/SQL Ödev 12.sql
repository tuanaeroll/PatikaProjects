SELECT COUNT(*) FROM film
WHERE length >
(
	SELECT AVG(length) FROM film
);

SELECT COUNT (*) FROM film
WHERE rental_rate = 
(
SELECT MAX(rental_rate) FROM film
);

SELECT * FROM film
WHERE rental_rate = 
(
SELECT MIN(rental_rate) FROM film
)
AND replacement_cost = 
(
SELECT MIN(replacement_cost) FROM film
)
ORDER BY title;

SELECT customer_id, COUNT(*) AS purchase_count
FROM payment
GROUP BY customer_id
ORDER BY purchase_count DESC;