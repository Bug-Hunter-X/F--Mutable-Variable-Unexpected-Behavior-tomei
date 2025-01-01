let mutable x = 10
let mutable y = 20
let z = x + y
printf "%d\n" z
x <- 30
printf "%d\n" z // z will still print 30 because it's not recalculated