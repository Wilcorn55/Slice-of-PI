->main

=== main === 

What's up? #name : Paul

I'm Paul, I'm new around here.

    +[Nice to meet you Paul]
    -> reply ("Ah you're the Detective investigating the Mayors murder right?")
    
=== reply(choice) ===
{choice}

    +[Yes I am]
    -> response ("Well you've got a tough job on your hands.")
    
=== response(choice) ===
{choice}

    +[What makes you say that?]
    -> guess ("Multiple suspects, all with motives. I personally think it was Darryl.")

=== guess(choice) ===
{choice}

    +[Oh? Why's that?]
    -> information ("I mean from what I've heard, Aaron and Darryl were completely opposite on all the political stances. So that's who I'd be looking into.")
    
=== information(choice) ===
{choice}

    +[I shall keep that in mind, anything else you can think of?]
    -> final ("Nope, but I am looking forward to telling you I told you so when you find Darryl guity. Bye Detective")
    
=== final(choice) ===
{choice}


->END