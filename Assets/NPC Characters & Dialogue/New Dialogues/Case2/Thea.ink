-> main

=== main ===

Hi again, #name : Thea

I'm going to be honest, I hoped I would never have to see you again.
    
    +[Nice to see you too, Thea.]
    -> reply ("Sorry Detective, but you're back.")
    
    +[I hoped the same too.]
    -> reply ("Guess hoping is not enough.")
    
=== reply(choice) ===
{choice} Luckly for me this time, I don't know anything about what happened. I was asleep at that time of morning. 

    +[You sure?]
    -> final ("Sorry for wasting your time but I really don't know anything.")

=== final(choice) ===
{choice}

->END