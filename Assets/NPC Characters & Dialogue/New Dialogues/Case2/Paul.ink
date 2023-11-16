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
    -> more ("Nope, but I am looking forward to telling you I told you so when you find Darryl guity.")
    
=== more(choice) ===
{choice}

    +[And before I go, where were you when Aaron was killed?]
    -> alibi ("I was sleeping. Although it happened close to me, I'm a very heavy sleeper. I wouldn't have woken up to anything.")

=== alibi(choice) ===
{choice}

    +[Thank you for the information.]
    -> final ("Anytime Detective!")
    
=== final(choice) ===
{choice}
    

->END