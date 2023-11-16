-> main 

=== main ===

Welcome back Detective. #name : Darryl

Been an interesting couple of years since you were here last...

    +[Hello Darryl, what's changed since I was here last?]
    -> update ("I've got a new bakery, and I'm also running for Mayor...")
    
=== update(choice) ===
{choice}

    +[Yes, I've heard you are running for Mayor.]
    -> alibi ("Before you ask Detective, I can tell you every morning I go to the bakery early to do the morning prep. You can even ask Russel as we work together. We were both there that morning.")
    
=== alibi(choice) ===
{choice}

    +[Was anyone acting suspicious around that time?]
    -> information ("No one was acting suspicious but, if I were you, my suspicions would be on the other 2 running for mayor. I was last in the polls by a long shot. Last I checked, Aaron was coming first with Jonothan a close second and Michael in third.")
    
=== information(choice) ===
{choice}

    +[Do you think Jonothan had more of a motive to kill Aaron?]
    -> chosen ("Jonothan")
    
    +[Do you think Michael had more of a motive to kill Aaron?]
    -> chosen ("Michael")
    
=== chosen(choice) ===
Honestly, I think {choice} was the one who did it. I don't have any supporting evidence but I have a gut feeling that it was him. 

    +[Thank you Darryl. I shall keep that in mind.]
    -> final ("I don't want to take up anymore of your time. Have a good one Detective.")
    
=== final(choice) ===
{choice}


->END