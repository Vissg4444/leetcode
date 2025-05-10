# Write your MySQL query statement below
SELECT customer_id, COUNT(*) as count_no_trans from Visits
LEFT JOIN Transactions using(visit_id)
WHERE (Transactions.visit_id IS NULL)
GROUP BY customer_id