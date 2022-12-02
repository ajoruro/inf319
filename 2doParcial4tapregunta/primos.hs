primos :: [Int]
primos = criba [2..] 

--Implementamos la criba recursivamente
criba :: [Int] -> [Int]
criba (p:xs) = p : criba [x | x <- xs, x `mod` p /= 0]   --take 15 primos