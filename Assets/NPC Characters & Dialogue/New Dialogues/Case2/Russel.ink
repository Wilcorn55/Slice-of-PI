->main 

=== main ===

Hey, I'm Russel #name : Russel

So you want to know about Aarons death?

    +[I do, what do you know?]
    -> information ("All I know is that Darryl and I were working in the bakery from early that morning so it wasn't either of us. There's camera footage of us arriving and leaving the bakery.")
    
=== information(choice) ===
{choice}

    +[Anything else?]
    -> more ("I saw Michael going for his daily walk. However I don't know anything about Jonothans whereabouts. He was meant to come to the bakery to get some cupcakes for Velma but he never showed.")
    
=== more(choice) ===
{choice}

    +[Thank you for this information. I will look into Jonothans whereabouts at that time of morning.]
    -> final ("Alright, see you round.")
    
=== final(choice) ===
{choice}

->END