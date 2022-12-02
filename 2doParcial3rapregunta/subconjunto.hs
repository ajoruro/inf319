subconjunto :: Eq x => [x] -> [x] -> Bool
subconjunto xs ys = all (`elem` ys) xs --subconjunto [1,3,2,3] [1,2,3]   subconjunto' [1,3,4,3] [1,2,3]

