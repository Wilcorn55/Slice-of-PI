->main

=== main ===

Hey man, what's up? I'm Cory. #name : Cory

    +[Hello Cory, Nice to meet you.]
    -> reply ("Oh you're the Detective!")
    
=== reply(choice) ===
{choice}

    +[That's me.]
    -> prereq ("Before we go any further, have you spoken to Charlotte yet?")
    
=== prereq(choice) ===
{choice}

    +[Yes I have.]
    -> chosen ("I'm guessing you already know that I'm Aaron's brother. Bet she also mentioned that we had been fighting recently too.")
    
    +[Not yet.]
    -> chosen ("Well I'm Aaron's brother.")
    
=== chosen(choice) ===
{choice}

    +[Please continue...]
    -> information ("Our father passed a couple months ago and he left everything to me in his will. Aaron was very angry about it as you could imagine.")

=== information(choice) ===
{choice}

    +[I can imagine. Go on...]
    -> more ("He has been pestering me ever since about how he deserves some on the inheritance. I kept telling him that this is what dad wanted which just mad him angrier.")
    
=== more(choice) ===
{choice}

    +[What else...]
    -> family ("I don't know why dad left it all to me but in the will it stated not to give anything to Aaron no matter what. I'm just trying to honor his last wishes.")

=== family(choice) ===
{choice}

    +[Anything else you want to add?]
    -> alibi ("I don't think there is anything else. As for my alibi, like many others I was sleeping at that time. Good luck Detective, please find my brothers killer.")
    
=== alibi(choice) === 
{choice}
    
    +[I will do everything in my power to find Aaron's killer. I'm sorry for your loss Cory.]
    -> final ("Thank you. Good bye.")
    
=== final(choice) ===
{choice}

->END