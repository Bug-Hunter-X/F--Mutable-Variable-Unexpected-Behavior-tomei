let x = ref 10
let y = ref 20
let z = x + y
printf "%d\n" !z
x := 30
printf "%d\n" !z // z is recalculated using the updated values of x and y. Using references allows to have the correct behaviour.