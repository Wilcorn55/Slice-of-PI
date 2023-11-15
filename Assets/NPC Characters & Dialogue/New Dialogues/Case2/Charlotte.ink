->main

=== main ===

Welcome back Detective, it's me Charlotte. #name : Charlotte

How have you been?

    +[I've been good]
    -> feeling ("good")
    
    +[I've been better]
    -> feeling ("no good")

=== feeling(choice) ===
Well that's {choice}! Another very sad situation has happened, hasn't it?

    +[Yes, it is sad.]
    -> response ("Aaron was a good man, he was great when Peter was killed. I'm guessing you're looking into the other candidates?")
    
=== response(choice) ===
{choice}
    
    +[Yes I am, please tell me what you know.]
    -> alibi ("I don't know anything definitive but if I were you I would be looking into Cory. He's Aarons brother and from what Aaron told me they have been fighting quite a bit.")

=== alibi(choice) ===
Oh {choice}

    +[Do you know what they had been fighting about?]
    -> information ("Mostly about the inheritance from their parents. He didn't give me any details, just that.")
    
===information(choice) ===
{choice}

    +[Well thank you for your time Charlotte and I'm sorry for your loss.]
    -> final("Have a good day Detective and thank you.")
    
===final(choice) ===
{choice}


->END
    